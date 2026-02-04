using AiroportShedule.Services;
using System;
using System.Windows.Forms;

namespace AiroportShedule.Forms
{
    public partial class SupplyEditorForm : Form
    {
        private readonly AirportService _airportService;
        private readonly bool _isEditMode;
        private readonly int? _supplyId;

        public SupplyEditorForm(AirportService airportService)
        {
            InitializeComponent();
            _airportService = airportService ?? throw new ArgumentNullException(nameof(airportService));
            _isEditMode = false;
            _supplyId = null;
            InitializeFormForAdd();
        }

        public SupplyEditorForm(AirportService airportService, AirportService.SupplyViewModel supply)
        {
            InitializeComponent();
            _airportService = airportService ?? throw new ArgumentNullException(nameof(airportService));
            _isEditMode = true;
            _supplyId = supply?.Id ?? throw new ArgumentNullException(nameof(supply));
            InitializeFormForEdit(supply);
        }

        private void InitializeFormForAdd()
        {
            Text = "Добавление припаса — Аэропорт";
            lblTitle.Text = "Добавление припаса";
            btnAction.Text = "Добавить припас";
            numQuantity.Value = 1;
            txtUnit.Text = "шт.";
            if (cmbCategory.Items.Count > 0) cmbCategory.SelectedIndex = 0;
        }

        private void InitializeFormForEdit(AirportService.SupplyViewModel supply)
        {
            Text = "Редактирование припаса — Аэропорт";
            lblTitle.Text = "Редактирование припаса";
            btnAction.Text = "Сохранить изменения";
            LoadSupplyData(supply);
        }

        private void SupplyEditorForm_Load(object sender, EventArgs e)
        {
            LoadHangars();
        }

        private void LoadHangars()
        {
            try
            {
                var hangars = _airportService.GetHangars();
                cmbHangar.Items.Clear();
                foreach (var hangar in hangars)
                {
                    cmbHangar.Items.Add(new ComboBoxItem { Id = hangar.Id, Name = hangar.Name });
                }
                if (cmbHangar.Items.Count > 0 && cmbHangar.SelectedIndex == -1)
                    cmbHangar.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка загрузки ангаров: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadSupplyData(AirportService.SupplyViewModel supply)
        {
            txtName.Text = supply.Name;
            txtDescription.Text = supply.Description ?? string.Empty;
            numQuantity.Value = supply.Quantity;
            txtUnit.Text = supply.Unit ?? "шт.";

            if (!string.IsNullOrEmpty(supply.Category))
            {
                cmbCategory.Text = supply.Category;
            }

            for (int i = 0; i < cmbHangar.Items.Count; i++)
            {
                if (((ComboBoxItem)cmbHangar.Items[i]).Id == supply.HangarId)
                {
                    cmbHangar.SelectedIndex = i;
                    break;
                }
            }
        }

        private void btnAction_Click(object sender, EventArgs e)
        {
            if (!ValidateInput())
                return;

            try
            {
                var hangarItem = (ComboBoxItem)cmbHangar.SelectedItem;

                bool success;
                string successMessage;

                if (_isEditMode && _supplyId.HasValue)
                {
                    success = _airportService.UpdateSupply(
                        _supplyId.Value,
                        txtName.Text.Trim(),
                        cmbCategory.Text.Trim(),
                        (int)numQuantity.Value,
                        txtUnit.Text.Trim(),
                        hangarItem.Id,
                        txtDescription.Text.Trim()
                    );
                    successMessage = "Припас успешно обновлён";
                }
                else
                {
                    success = _airportService.AddSupply(
                        txtName.Text.Trim(),
                        cmbCategory.Text.Trim(),
                        (int)numQuantity.Value,
                        txtUnit.Text.Trim(),
                        hangarItem.Id,
                        txtDescription.Text.Trim()
                    );
                    successMessage = "Припас успешно добавлен";
                }

                if (success)
                {
                    MessageBox.Show(successMessage, "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DialogResult = DialogResult.OK;
                    Close();
                }
                else
                {
                    MessageBox.Show("Не удалось сохранить припас. Проверьте данные и повторите попытку.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                ShowValidationError("Введите название припаса");
                txtName.Focus();
                return false;
            }

            if (cmbHangar.SelectedIndex == -1)
            {
                ShowValidationError("Выберите ангар");
                cmbHangar.Focus();
                return false;
            }

            if (numQuantity.Value <= 0)
            {
                ShowValidationError("Количество должно быть больше 0");
                numQuantity.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtUnit.Text))
            {
                ShowValidationError("Укажите единицу измерения");
                txtUnit.Focus();
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

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            SupplyEditorForm_Load(this, EventArgs.Empty);
        }

        private class ComboBoxItem
        {
            public int Id { get; set; }
            public string Name { get; set; }

            public override string ToString() => Name;
        }
    }
}