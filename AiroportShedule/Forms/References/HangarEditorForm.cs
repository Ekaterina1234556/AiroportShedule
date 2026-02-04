using AiroportShedule.Services;
using System;
using System.Windows.Forms;

namespace AiroportShedule.Forms
{
    public partial class HangarEditorForm : Form
    {
        private readonly AirportService _airportService;
        private readonly bool _isEditMode;
        private readonly int? _hangarId;

        public HangarEditorForm(AirportService airportService)
        {
            InitializeComponent();
            _airportService = airportService ?? throw new ArgumentNullException(nameof(airportService));
            _isEditMode = false;
            _hangarId = null;
            InitializeFormForAdd();
        }

        public HangarEditorForm(AirportService airportService, AirportService.HangarViewModel hangar)
        {
            InitializeComponent();
            _airportService = airportService ?? throw new ArgumentNullException(nameof(airportService));
            _isEditMode = true;
            _hangarId = hangar?.Id ?? throw new ArgumentNullException(nameof(hangar));
            InitializeFormForEdit(hangar);
        }

        private void InitializeFormForAdd()
        {
            Text = "Добавление ангара — Аэропорт";
            lblTitle.Text = "Добавление ангара";
            btnAction.Text = "Добавить ангар";

            if (cmbType.Items.Count > 0)
                cmbType.SelectedIndex = 0;
        }

        private void InitializeFormForEdit(AirportService.HangarViewModel hangar)
        {
            Text = "Редактирование ангара — Аэропорт";
            lblTitle.Text = "Редактирование ангара";
            btnAction.Text = "Сохранить изменения";
            LoadHangarData(hangar);
        }

        private void LoadHangarData(AirportService.HangarViewModel hangar)
        {
            txtName.Text = hangar.Name;
            txtSize.Text = hangar.Size ?? string.Empty;
            cmbType.Text = hangar.Type;
        }

        private void btnAction_Click(object sender, EventArgs e)
        {
            if (!ValidateInput())
                return;

            try
            {
                bool success;
                string successMessage;

                if (_isEditMode && _hangarId.HasValue)
                {
                    success = _airportService.UpdateHangar(
                        _hangarId.Value,
                        txtName.Text.Trim(),
                        cmbType.Text.Trim(),
                        txtSize.Text.Trim()
                    );
                    successMessage = "Ангар успешно обновлён";
                }
                else
                {
                    success = _airportService.AddHangar(
                        txtName.Text.Trim(),
                        cmbType.Text.Trim(),
                        txtSize.Text.Trim()
                    );
                    successMessage = "Ангар успешно добавлен";
                }

                if (success)
                {
                    MessageBox.Show(successMessage, "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DialogResult = DialogResult.OK;
                    Close();
                }
                else
                {
                    MessageBox.Show("Не удалось сохранить ангар. Проверьте данные и повторите попытку.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при сохранении: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ValidateInput()
        {
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                ShowValidationError("Введите название ангара");
                txtName.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(cmbType.Text))
            {
                ShowValidationError("Выберите тип ангара");
                cmbType.Focus();
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
    }
}