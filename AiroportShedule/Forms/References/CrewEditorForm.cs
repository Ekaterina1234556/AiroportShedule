using AiroportShedule.Services;
using System;
using System.Windows.Forms;

namespace AiroportShedule.Forms
{
    public partial class CrewEditorForm : Form
    {
        private readonly AirportService _airportService;
        private readonly CrewType _crewType;
        private readonly bool _isEditMode;
        private readonly int? _crewId;

        public enum CrewType
        {
            Flight,
            Support
        }

        public CrewEditorForm(AirportService airportService, CrewType crewType)
        {
            InitializeComponent();
            _airportService = airportService ?? throw new ArgumentNullException(nameof(airportService));
            _crewType = crewType;
            _isEditMode = false;
            _crewId = null;
            InitializeFormForAdd();
        }

        public CrewEditorForm(AirportService airportService, CrewType crewType, AirportService.CrewMemberViewModel crew)
        {
            InitializeComponent();
            _airportService = airportService ?? throw new ArgumentNullException(nameof(airportService));
            _crewType = crewType;
            _isEditMode = true;
            _crewId = crew?.Id ?? throw new ArgumentNullException(nameof(crew));
            InitializeFormForEdit(crew);
        }

        private void InitializeFormForAdd()
        {
            switch (_crewType)
            {
                case CrewType.Flight:
                    Text = "Добавление пилота — Аэропорт";
                    lblTitle.Text = "Добавление пилота";
                    cmbRole.Items.Clear();
                    cmbRole.Items.Add("Пилот");
                    cmbRole.SelectedIndex = 0;
                    cmbRole.Enabled = false;
                    break;
                case CrewType.Support:
                    Text = "Добавление обслуживающего персонала — Аэропорт";
                    lblTitle.Text = "Добавление персонала";
                    cmbRole.Items.Clear();
                    cmbRole.Items.Add("Техник");
                    cmbRole.Items.Add("Обслуживающий персонал");
                    cmbRole.SelectedIndex = 0;
                    cmbRole.Enabled = true;
                    break;
            }
            btnAction.Text = "Добавить сотрудника";
        }

        private void InitializeFormForEdit(AirportService.CrewMemberViewModel crew)
        {
            switch (_crewType)
            {
                case CrewType.Flight:
                    Text = "Редактирование пилота — Аэропорт";
                    lblTitle.Text = "Редактирование пилота";
                    break;
                case CrewType.Support:
                    Text = "Редактирование персонала — Аэропорт";
                    lblTitle.Text = "Редактирование персонала";
                    break;
            }
            btnAction.Text = "Сохранить изменения";
            LoadCrewData(crew);
        }

        private void LoadCrewData(AirportService.CrewMemberViewModel crew)
        {
            txtFullName.Text = crew.FullName;
            numFlightHours.Value = crew.FlightHours;
            numExperience.Value = crew.ExperienceYears;
            cmbRole.Text = crew.Role;
        }

        private void btnAction_Click(object sender, EventArgs e)
        {
            if (!ValidateInput())
                return;

            try
            {
                bool success;
                string successMessage;

                if (_isEditMode && _crewId.HasValue)
                {
                    success = _airportService.UpdateCrewMember(
                        _crewId.Value,
                        txtFullName.Text.Trim(),
                        cmbRole.Text.Trim(),
                        (int)numFlightHours.Value,
                        (int)numExperience.Value,
                        txtLogin.Text.Trim(),
                        txtPassword.Text.Trim()
                    );
                    successMessage = "Сотрудник успешно обновлён";
                }
                else
                {
                    success = _airportService.AddCrewMember(
                        txtFullName.Text.Trim(),
                        cmbRole.Text.Trim(),
                        (int)numFlightHours.Value,
                        (int)numExperience.Value,
                        txtLogin.Text.Trim(),
                        txtPassword.Text.Trim()
                    );
                    successMessage = "Сотрудник успешно добавлен";
                }

                if (success)
                {
                    MessageBox.Show(successMessage, "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DialogResult = DialogResult.OK;
                    Close();
                }
                else
                {
                    MessageBox.Show("Не удалось сохранить сотрудника. Проверьте данные и повторите попытку.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при сохранении: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ValidateInput()
        {
            if (string.IsNullOrWhiteSpace(txtFullName.Text))
            {
                ShowValidationError("Введите ФИО сотрудника");
                txtFullName.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(cmbRole.Text))
            {
                ShowValidationError("Выберите должность");
                cmbRole.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtLogin.Text))
            {
                ShowValidationError("Введите логин");
                txtLogin.Focus();
                return false;
            }

            if (_isEditMode && string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                var result = MessageBox.Show("Вы не ввели новый пароль. Оставить текущий пароль без изменений?", "Подтверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.No)
                {
                    txtPassword.Focus();
                    return false;
                }
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

        private void CrewEditorForm_Load(object sender, EventArgs e)
        {
            if (!_isEditMode && string.IsNullOrWhiteSpace(txtLogin.Text))
            {
                txtLogin.Text = GenerateLoginFromName(txtFullName.Text);
            }
        }

        private string GenerateLoginFromName(string fullName)
        {
            if (string.IsNullOrWhiteSpace(fullName)) return "user" + DateTime.Now.Ticks.ToString().Substring(0, 6);

            var parts = fullName.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            if (parts.Length >= 2)
            {
                return (parts[0].Substring(0, 1) + parts[1]).ToLower();
            }
            return parts[0].ToLower();
        }
    }
}