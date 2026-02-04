using AiroportShedule.Services;
using System;
using System.Windows.Forms;

namespace AiroportShedule.Forms
{
    public partial class RouteEditorForm : Form
    {
        private readonly AirportService _airportService;
        private readonly bool _isEditMode;
        private readonly int? _routeId;

        public RouteEditorForm(AirportService airportService)
        {
            InitializeComponent();
            _airportService = airportService ?? throw new ArgumentNullException(nameof(airportService));
            _isEditMode = false;
            _routeId = null;
            InitializeFormForAdd();
        }

        public RouteEditorForm(AirportService airportService, AirportService.RouteViewModel route)
        {
            InitializeComponent();
            _airportService = airportService ?? throw new ArgumentNullException(nameof(airportService));
            _isEditMode = true;
            _routeId = route?.Id ?? throw new ArgumentNullException(nameof(route));
            InitializeFormForEdit(route);
        }

        private void InitializeFormForAdd()
        {
            Text = "Добавление маршрута — Аэропорт";
            lblTitle.Text = "Добавление маршрута";
            btnAction.Text = "Добавить маршрут";
        }

        private void InitializeFormForEdit(AirportService.RouteViewModel route)
        {
            Text = "Редактирование маршрута — Аэропорт";
            lblTitle.Text = "Редактирование маршрута";
            btnAction.Text = "Сохранить изменения";
            LoadRouteData(route);
        }

        private void LoadRouteData(AirportService.RouteViewModel route)
        {
            txtRouteName.Text = route.Name;
        }

        private void btnAction_Click(object sender, EventArgs e)
        {
            if (!ValidateInput())
                return;

            try
            {
                bool success;
                string successMessage;

                if (_isEditMode && _routeId.HasValue)
                {
                    success = _airportService.UpdateRoute(
                        _routeId.Value,
                        txtRouteName.Text.Trim()
                    );
                    successMessage = "Маршрут успешно обновлён";
                }
                else
                {
                    success = _airportService.AddRoute(
                        txtRouteName.Text.Trim()
                    );
                    successMessage = "Маршрут успешно добавлен";
                }

                if (success)
                {
                    MessageBox.Show(successMessage, "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DialogResult = DialogResult.OK;
                    Close();
                }
                else
                {
                    MessageBox.Show("Не удалось сохранить маршрут. Проверьте данные и повторите попытку.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при сохранении: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ValidateInput()
        {
            if (string.IsNullOrWhiteSpace(txtRouteName.Text))
            {
                ShowValidationError("Введите название маршрута");
                txtRouteName.Focus();
                return false;
            }

            if (!txtRouteName.Text.Contains(" - "))
            {
                var result = MessageBox.Show("Название маршрута должно содержать разделитель \" - \" (например: Москва - Санкт-Петербург).\nПродолжить?", "Предупреждение", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);

                if (result == DialogResult.No)
                {
                    txtRouteName.Focus();
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
    }
}