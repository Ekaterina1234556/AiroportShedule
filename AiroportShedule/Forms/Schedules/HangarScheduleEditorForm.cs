using AiroportShedule.Services;
using System;
using System.Windows.Forms;

namespace AiroportShedule.Forms
{
    public partial class HangarScheduleEditorForm : Form
    {
        private readonly AirportService _airportService;
        private readonly bool _isEditMode;
        private readonly int? _scheduleId;

        public HangarScheduleEditorForm(AirportService airportService)
        {
            InitializeComponent();
            _airportService = airportService ?? throw new ArgumentNullException(nameof(airportService));
            _isEditMode = false;
            _scheduleId = null;
            InitializeFormForAdd();
        }

        public HangarScheduleEditorForm(AirportService airportService, AirportService.HangarScheduleViewModel schedule)
        {
            InitializeComponent();
            _airportService = airportService ?? throw new ArgumentNullException(nameof(airportService));
            _isEditMode = true;
            _scheduleId = schedule?.Id ?? throw new ArgumentNullException(nameof(schedule));
            InitializeFormForEdit(schedule);
        }

        private void InitializeFormForAdd()
        {
            Text = "Добавление записи в ангар — Аэропорт";
            lblTitle.Text = "Добавление записи в ангар";
            btnAction.Text = "Добавить запись";
            txtTimeInterval.Text = "09:00 - 12:00";
        }

        private void InitializeFormForEdit(AirportService.HangarScheduleViewModel schedule)
        {
            Text = "Редактирование записи в ангаре — Аэропорт";
            lblTitle.Text = "Редактирование записи в ангаре";
            btnAction.Text = "Сохранить изменения";
            LoadScheduleData(schedule);
        }

        private void LoadScheduleData(AirportService.HangarScheduleViewModel schedule)
        {
            txtTimeInterval.Text = schedule.TimeInterval;
            txtDescription.Text = schedule.Description;

            for (int i = 0; i < cmbHangar.Items.Count; i++)
            {
                if (((ComboBoxItem)cmbHangar.Items[i]).Name == schedule.Hangar.Split(' ')[0])
                {
                    cmbHangar.SelectedIndex = i;
                    break;
                }
            }

            for (int i = 0; i < cmbAircraft.Items.Count; i++)
            {
                if (((ComboBoxItem)cmbAircraft.Items[i]).Name == schedule.Aircraft)
                {
                    cmbAircraft.SelectedIndex = i;
                    break;
                }
            }

            for (int i = 0; i < cmbPersonnel.Items.Count; i++)
            {
                if (((ComboBoxItem)cmbPersonnel.Items[i]).Name == schedule.Personnel)
                {
                    cmbPersonnel.SelectedIndex = i;
                    break;
                }
            }
        }

        private void HangarScheduleEditorForm_Load(object sender, EventArgs e)
        {
            LoadReferenceData();
        }

        private void LoadReferenceData()
        {
            try
            {
                var hangars = _airportService.GetHangars();
                cmbHangar.Items.Clear();
                foreach (var hangar in hangars)
                {
                    cmbHangar.Items.Add(new ComboBoxItem { Id = hangar.Id, Name = hangar.Name });
                }
                if (cmbHangar.Items.Count > 0) cmbHangar.SelectedIndex = 0;

                var aircrafts = _airportService.GetAvailableAircraft();
                cmbAircraft.Items.Clear();
                foreach (var aircraft in aircrafts)
                {
                    cmbAircraft.Items.Add(new ComboBoxItem { Id = aircraft.Id, Name = aircraft.Model });
                }
                if (cmbAircraft.Items.Count > 0) cmbAircraft.SelectedIndex = 0;

                var personnel = _airportService.GetCrewMembers();
                cmbPersonnel.Items.Clear();
                foreach (var person in personnel)
                {
                    cmbPersonnel.Items.Add(new ComboBoxItem { Id = person.Id, Name = person.FullName });
                }
                if (cmbPersonnel.Items.Count > 0) cmbPersonnel.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка загрузки справочников: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAction_Click(object sender, EventArgs e)
        {
            if (!ValidateInput())
                return;

            try
            {
                var hangarItem = (ComboBoxItem)cmbHangar.SelectedItem;
                var aircraftItem = (ComboBoxItem)cmbAircraft.SelectedItem;
                var personnelItem = (ComboBoxItem)cmbPersonnel.SelectedItem;

                bool success;
                string successMessage;

                if (_isEditMode && _scheduleId.HasValue)
                {
                    success = _airportService.UpdateHangarSchedule(
                        _scheduleId.Value,
                        txtTimeInterval.Text.Trim(),
                        hangarItem.Id,
                        aircraftItem.Id,
                        personnelItem.Id,
                        txtDescription.Text.Trim()
                    );
                    successMessage = "Запись успешно обновлена";
                }
                else
                {
                    success = _airportService.AddHangarSchedule(
                        txtTimeInterval.Text.Trim(),
                        hangarItem.Id,
                        aircraftItem.Id,
                        personnelItem.Id,
                        txtDescription.Text.Trim()
                    );
                    successMessage = "Запись успешно добавлена";
                }

                if (success)
                {
                    MessageBox.Show(successMessage, "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DialogResult = DialogResult.OK;
                    Close();
                }
                else
                {
                    MessageBox.Show("Не удалось сохранить запись. Проверьте данные и повторите попытку.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при сохранении: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ValidateInput()
        {
            if (string.IsNullOrWhiteSpace(txtTimeInterval.Text) || !txtTimeInterval.Text.Contains(" - "))
            {
                ShowValidationError("Введите время в формате \"09:00 - 12:00\"");
                txtTimeInterval.Focus();
                return false;
            }

            if (cmbHangar.SelectedIndex == -1)
            {
                ShowValidationError("Выберите ангар");
                cmbHangar.Focus();
                return false;
            }

            if (cmbAircraft.SelectedIndex == -1)
            {
                ShowValidationError("Выберите воздушное судно");
                cmbAircraft.Focus();
                return false;
            }

            if (cmbPersonnel.SelectedIndex == -1)
            {
                ShowValidationError("Выберите персонал");
                cmbPersonnel.Focus();
                return false;
            }

            return true;
        }

        private void ShowValidationError(string message)
        {
            MessageBox.Show(message, "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private class ComboBoxItem
        {
            public int Id { get; set; }
            public string Name { get; set; }

            public override string ToString() => Name;
        }
    }
}