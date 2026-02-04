using AiroportShedule.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AiroportShedule.Forms
{
    public partial class RouteScheduleForm : Form
    {
        private readonly AirportService _airportService;
        private List<AirportService.FlightScheduleViewModel> _allFlights;

        public RouteScheduleForm(AirportService airportService)
        {
            InitializeComponent();
            _airportService = airportService ?? throw new ArgumentNullException(nameof(airportService));
            InitializeDataGridView();
            dtpFilterDate.Value = DateTime.Today;
            dtpFilterDate.ValueChanged += DtpFilterDate_ValueChanged;
            LoadData();
        }

        private void InitializeDataGridView()
        {
            dgvSchedule.AutoGenerateColumns = false;
            dgvSchedule.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Id", HeaderText = "ID", Width = 60, Visible = false });
            dgvSchedule.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "FlightNumber", HeaderText = "Рейс", Width = 100 });
            dgvSchedule.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Route", HeaderText = "Маршрут", Width = 250 });
            dgvSchedule.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Aircraft", HeaderText = "ВС", Width = 150 });
            dgvSchedule.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "DepartureTime", HeaderText = "Вылет", Width = 100 });
            dgvSchedule.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "ArrivalTime", HeaderText = "Прилёт", Width = 100 });
            dgvSchedule.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Status", HeaderText = "Статус", Width = 120 });
            dgvSchedule.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Passengers", HeaderText = "Пасс.", Width = 80, DefaultCellStyle = { Alignment = DataGridViewContentAlignment.MiddleCenter } });
            dgvSchedule.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Baggage", HeaderText = "Багаж", Width = 100 });
        }

        private  void LoadData()
        {
            try
            {
                _allFlights = _airportService.GetFlightSchedule();
                ApplyDateFilter();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка загрузки расписания: {ex.Message}",
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ApplyDateFilter()
        {
            var filtered = _allFlights
                .Where(f => DateTime.TryParse(f.DepartureTime, out var depTime) && depTime.Date == dtpFilterDate.Value.Date)
                .ToList();

            dgvSchedule.DataSource = filtered;

            // Обновление цвета строк в зависимости от статуса
            foreach (DataGridViewRow row in dgvSchedule.Rows)
            {
                var status = row.Cells["Status"].Value?.ToString() ?? "";
                switch (status)
                {
                    case "Ожидание":
                        row.DefaultCellStyle.BackColor = Color.FromArgb(255, 250, 240);
                        break;
                    case "Посадка пассажиров":
                        row.DefaultCellStyle.BackColor = Color.FromArgb(255, 243, 205);
                        break;
                    case "В полёте":
                        row.DefaultCellStyle.BackColor = Color.FromArgb(236, 242, 255);
                        break;
                    case "Прибыл":
                        row.DefaultCellStyle.BackColor = Color.FromArgb(236, 253, 245);
                        break;
                }
            }
        }

        private void DtpFilterDate_ValueChanged(object sender, EventArgs e)
        {
            ApplyDateFilter();
        }

        private  void btnAdd_Click(object sender, EventArgs e)
        {
            using var editor = new FlightEditorForm(_airportService);
            if (editor.ShowDialog() == DialogResult.OK)
            {
                LoadData();
                MessageBox.Show("Рейс успешно добавлен", "Успех",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private  void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvSchedule.SelectedRows.Count == 0)
            {
                MessageBox.Show("Выберите рейс для редактирования",
                    "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var flightId = (int)dgvSchedule.SelectedRows[0].Cells["Id"].Value;
            var flight =  _airportService.GetFlightById(flightId);

            if (flight == null)
            {
                MessageBox.Show("Рейс не найден", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using var editor = new FlightEditorForm(_airportService, flight);
            if (editor.ShowDialog() == DialogResult.OK)
            {
                 LoadData();
                MessageBox.Show("Рейс успешно обновлён", "Успех",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private  void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvSchedule.SelectedRows.Count == 0)
            {
                MessageBox.Show("Выберите рейс для удаления",
                    "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var result = MessageBox.Show(
                "Вы уверены, что хотите удалить выбранный рейс?\nЭто действие нельзя отменить.",
                "Подтверждение удаления",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning,
                MessageBoxDefaultButton.Button2);

            if (result == DialogResult.Yes)
            {
                var flightId = (int)dgvSchedule.SelectedRows[0].Cells["Id"].Value;

                try
                {
                    if ( _airportService.DeleteFlight(flightId))
                    {
                         LoadData();
                        MessageBox.Show("Рейс успешно удалён", "Успех",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Не удалось удалить рейс", "Ошибка",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка при удалении: {ex.Message}", "Ошибка",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private  void btnAllowTakeoff_Click(object sender, EventArgs e)
        {
            if (dgvSchedule.SelectedRows.Count == 0)
            {
                MessageBox.Show("Выберите рейс для разрешения взлёта",
                    "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var flightId = (int)dgvSchedule.SelectedRows[0].Cells["Id"].Value;
            var status = dgvSchedule.SelectedRows[0].Cells["Status"].Value?.ToString() ?? "";

            if (status == "В полёте" || status == "Прибыл")
            {
                MessageBox.Show("Для этого рейса взлёт уже разрешён",
                    "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var result = MessageBox.Show(
                "Разрешить взлёт для выбранного рейса?",
                "Подтверждение",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                if ( _airportService.AllowTakeoff(flightId))
                {
                     LoadData();
                    MessageBox.Show("Взлёт разрешён", "Успех",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Не удалось разрешить взлёт", "Ошибка",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private  void btnAllowLanding_Click(object sender, EventArgs e)
        {
            if (dgvSchedule.SelectedRows.Count == 0)
            {
                MessageBox.Show("Выберите рейс для разрешения посадки",
                    "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var flightId = (int)dgvSchedule.SelectedRows[0].Cells["Id"].Value;
            var status = dgvSchedule.SelectedRows[0].Cells["Status"].Value?.ToString() ?? "";

            if (status != "В полёте")
            {
                MessageBox.Show("Посадку можно разрешить только для рейсов в полёте",
                    "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var result = MessageBox.Show(
                "Разрешить посадку для выбранного рейса?",
                "Подтверждение",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                if ( _airportService.AllowLanding(flightId))
                {
                     LoadData();
                    MessageBox.Show("Посадка разрешена", "Успех",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Не удалось разрешить посадку", "Ошибка",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}