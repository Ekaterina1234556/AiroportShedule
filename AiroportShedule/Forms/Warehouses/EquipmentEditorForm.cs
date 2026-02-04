using AiroportShedule.Services;
using System;
using System.Windows.Forms;

namespace AiroportShedule.Forms
{
    public partial class EquipmentEditorForm : Form
    {
        private readonly AirportService _airportService;
        private readonly bool _isEditMode;
        private readonly int? _equipmentId;

        public EquipmentEditorForm(AirportService airportService)
        {
            InitializeComponent();
            _airportService = airportService ?? throw new ArgumentNullException(nameof(airportService));
            _isEditMode = false;
            _equipmentId = null;
            InitializeFormForAdd();
        }

        public EquipmentEditorForm(AirportService airportService, AirportService.EquipmentViewModel equipment)
        {
            InitializeComponent();
            _airportService = airportService ?? throw new ArgumentNullException(nameof(airportService));
            _isEditMode = true;
            _equipmentId = equipment?.Id ?? throw new ArgumentNullException(nameof(equipment));
            InitializeFormForEdit(equipment);
        }

        private void InitializeFormForAdd()
        {
            Text = "Добавление оборудования — Аэропорт";
            lblTitle.Text = "Добавление оборудования";
            btnAction.Text = "Добавить оборудование";
            chkIsWorking.Checked = true;
        }

        private void InitializeFormForEdit(AirportService.EquipmentViewModel equipment)
        {
            Text = "Редактирование оборудования — Аэропорт";
            lblTitle.Text = "Редактирование оборудования";
            btnAction.Text = "Сохранить изменения";
            LoadEquipmentData(equipment);
        }

        private void EquipmentEditorForm_Load(object sender, EventArgs e)
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
                if (cmbHangar.Items.Count > 0) cmbHangar.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка загрузки ангаров: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadEquipmentData(AirportService.EquipmentViewModel equipment)
        {
            txtName.Text = equipment.Name;
            txtDescription.Text = equipment.Description ?? string.Empty;
            chkIsWorking.Checked = equipment.IsWorking;

            for (int i = 0; i < cmbHangar.Items.Count; i++)
            {
                if (((ComboBoxItem)cmbHangar.Items[i]).Id == equipment.HangarId)
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

                if (_isEditMode && _equipmentId.HasValue)
                {
                    success = _airportService.UpdateEquipment(
                        _equipmentId.Value,
                        txtName.Text.Trim(),
                        txtDescription.Text.Trim(),
                        hangarItem.Id,
                        chkIsWorking.Checked
                    );
                    successMessage = "Оборудование успешно обновлено";
                }
                else
                {
                    success = _airportService.AddEquipment(
                        txtName.Text.Trim(),
                        txtDescription.Text.Trim(),
                        hangarItem.Id,
                        chkIsWorking.Checked
                    );
                    successMessage = "Оборудование успешно добавлено";
                }

                if (success)
                {
                    MessageBox.Show(successMessage, "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DialogResult = DialogResult.OK;
                    Close();
                }
                else
                {
                    MessageBox.Show("Не удалось сохранить оборудование. Проверьте данные и повторите попытку.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                ShowValidationError("Введите название оборудования");
                txtName.Focus();
                return false;
            }

            if (cmbHangar.SelectedIndex == -1)
            {
                ShowValidationError("Выберите ангар");
                cmbHangar.Focus();
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
            EquipmentEditorForm_Load(this, EventArgs.Empty);
        }

        private class ComboBoxItem
        {
            public int Id { get; set; }
            public string Name { get; set; }

            public override string ToString() => Name;
        }
    }
}