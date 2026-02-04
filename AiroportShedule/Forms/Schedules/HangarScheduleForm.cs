using AiroportShedule.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace AiroportShedule.Forms
{
    public partial class HangarScheduleForm : Form
    {
        private readonly AirportService _airportService;
        private List<AirportService.HangarScheduleViewModel> _allSchedules;
        private List<AirportService.HangarViewModel> _hangars;

        public HangarScheduleForm(AirportService airportService)
        {
            InitializeComponent();
            _airportService = airportService ?? throw new ArgumentNullException(nameof(airportService));
            InitializeDataGridView();
            cmbHangarFilter.SelectedIndexChanged += cmbHangarFilter_SelectedIndexChanged;
            LoadData();
        }

        private void InitializeDataGridView()
        {
            dgvSchedule.AutoGenerateColumns = false;
            dgvSchedule.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Id", HeaderText = "ID", Width = 60, Visible = false });
            dgvSchedule.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "TimeInterval", HeaderText = "Время", Width = 150 });
            dgvSchedule.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Hangar", HeaderText = "Ангар", Width = 200 });
            dgvSchedule.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Aircraft", HeaderText = "ВС", Width = 150 });
            dgvSchedule.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Personnel", HeaderText = "Персонал", Width = 250 });
            dgvSchedule.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Description", HeaderText = "Описание", Width = 300 });
            dgvSchedule.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Status", HeaderText = "Статус", Width = 120 });
        }

        private void LoadData()
        {
            try
            {
                _allSchedules = _airportService.GetHangarSchedule();
                _hangars = _airportService.GetHangars();

                cmbHangarFilter.Items.Clear();
                cmbHangarFilter.Items.Add("Все ангары");
                foreach (var hangar in _hangars)
                {
                    cmbHangarFilter.Items.Add(hangar.Name);
                }
                cmbHangarFilter.SelectedIndex = 0;

                ApplyFilter();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка загрузки расписания: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ApplyFilter()
        {
            var selectedHangar = cmbHangarFilter.SelectedItem?.ToString();
            var filtered = selectedHangar == "Все ангары" || string.IsNullOrEmpty(selectedHangar)
                ? _allSchedules
                : _allSchedules.Where(s => s.Hangar.Contains(selectedHangar)).ToList();

            dgvSchedule.DataSource = filtered;

            foreach (DataGridViewRow row in dgvSchedule.Rows)
            {
                var status = row.Cells["Status"].Value?.ToString() ?? "";
                switch (status)
                {
                    case "Запланировано":
                        row.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(255, 250, 240);
                        break;
                    case "В работе":
                        row.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(255, 243, 205);
                        break;
                    case "Выполнено":
                        row.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(236, 253, 245);
                        break;
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            using var editor = new HangarScheduleEditorForm(_airportService);
            if (editor.ShowDialog() == DialogResult.OK)
            {
                LoadData();
                MessageBox.Show("Запись успешно добавлена", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvSchedule.SelectedRows.Count == 0)
            {
                MessageBox.Show("Выберите запись для редактирования", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var scheduleId = (int)dgvSchedule.SelectedRows[0].Cells["Id"].Value;
            var schedule = _airportService.GetHangarScheduleById(scheduleId);

            if (schedule == null)
            {
                MessageBox.Show("Запись не найдена", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using var editor = new HangarScheduleEditorForm(_airportService, schedule);
            if (editor.ShowDialog() == DialogResult.OK)
            {
                LoadData();
                MessageBox.Show("Запись успешно обновлена", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvSchedule.SelectedRows.Count == 0)
            {
                MessageBox.Show("Выберите запись для удаления", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var result = MessageBox.Show("Вы уверены, что хотите удалить выбранную запись?\nЭто действие нельзя отменить.", "Подтверждение удаления", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);

            if (result == DialogResult.Yes)
            {
                var scheduleId = (int)dgvSchedule.SelectedRows[0].Cells["Id"].Value;

                try
                {
                    if (_airportService.DeleteHangarSchedule(scheduleId))
                    {
                        LoadData();
                        MessageBox.Show("Запись успешно удалена", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Не удалось удалить запись", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка при удалении: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnMarkComplete_Click(object sender, EventArgs e)
        {
            if (dgvSchedule.SelectedRows.Count == 0)
            {
                MessageBox.Show("Выберите запись для отметки о выполнении", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var scheduleId = (int)dgvSchedule.SelectedRows[0].Cells["Id"].Value;
            var status = dgvSchedule.SelectedRows[0].Cells["Status"].Value?.ToString() ?? "";

            if (status == "Выполнено")
            {
                MessageBox.Show("Работа уже отмечена как выполненная", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var result = MessageBox.Show("Отметить работу как выполненную?", "Подтверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                if (_airportService.MarkHangarScheduleComplete(scheduleId))
                {
                    LoadData();
                    MessageBox.Show("Работа отмечена как выполненная", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Не удалось отметить работу", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void cmbHangarFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            ApplyFilter();
        }
    }
}