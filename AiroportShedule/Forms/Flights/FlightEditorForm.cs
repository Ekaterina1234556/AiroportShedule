using AiroportShedule.Services;
using System;
using System.Linq;
using System.Windows.Forms;

namespace AiroportShedule.Forms
{
    public partial class FlightEditorForm : Form
    {
        private readonly AirportService _airportService;
        private readonly bool _isEditMode;
        private readonly int? _flightId;

        public FlightEditorForm(AirportService airportService)
        {
            InitializeComponent();
            _airportService = airportService ?? throw new ArgumentNullException(nameof(airportService));
            _isEditMode = false;
            _flightId = null;
            InitializeFormForAdd();
        }

        public FlightEditorForm(AirportService airportService, AirportService.FlightScheduleViewModel flight)
        {
            InitializeComponent();
            _airportService = airportService ?? throw new ArgumentNullException(nameof(airportService));
            _isEditMode = true;
            _flightId = flight?.Id ?? throw new ArgumentNullException(nameof(flight));
            InitializeFormForEdit(flight);
        }

        private void InitializeFormForAdd()
        {
            Text = "Добавление нового рейса — Аэропорт";
            lblTitle.Text = "Добавление нового рейса";
            btnAction.Text = "Добавить рейс";
            dtpDate.Value = DateTime.Today;
            numPassengers.Enabled = false;
            numBaggage.Enabled = false;
        }

        private void InitializeFormForEdit(AirportService.FlightScheduleViewModel flight)
        {
            Text = "Редактирование рейса — Аэропорт";
            lblTitle.Text = "Редактирование рейса";
            btnAction.Text = "Сохранить изменения";
            LoadFlightData(flight);
            numPassengers.Enabled = false;
            numBaggage.Enabled = false;
        }

        private void FlightEditorForm_Load(object sender, EventArgs e)
        {
            LoadReferenceData();
        }

        private void LoadReferenceData()
        {
            try
            {
                var routes = _airportService.GetRoutes();
                cmbRoute.Items.Clear();
                foreach (var route in routes)
                {
                    cmbRoute.Items.Add(new ComboBoxItem { Id = route.Id, Name = route.Name });
                }
                if (cmbRoute.Items.Count > 0) cmbRoute.SelectedIndex = 0;

                var aircrafts = _airportService.GetAvailableAircraft();
                cmbAircraft.Items.Clear();
                foreach (var aircraft in aircrafts)
                {
                    cmbAircraft.Items.Add(new ComboBoxItem { Id = aircraft.Id, Name = aircraft.Model });
                }
                if (cmbAircraft.Items.Count > 0) cmbAircraft.SelectedIndex = 0;

                var pilots = _airportService.GetCrewMembers("Пилот");
                cmbPilot.Items.Clear();
                foreach (var pilot in pilots)
                {
                    cmbPilot.Items.Add(new ComboBoxItem { Id = pilot.Id, Name = pilot.FullName });
                }
                if (cmbPilot.Items.Count > 0) cmbPilot.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка загрузки справочников: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadFlightData(AirportService.FlightScheduleViewModel flight)
        {
            if (flight == null) return;

            for (int i = 0; i < cmbRoute.Items.Count; i++)
            {
                if (((ComboBoxItem)cmbRoute.Items[i]).Name == flight.Route)
                {
                    cmbRoute.SelectedIndex = i;
                    break;
                }
            }

            for (int i = 0; i < cmbAircraft.Items.Count; i++)
            {
                if (((ComboBoxItem)cmbAircraft.Items[i]).Name == flight.Aircraft)
                {
                    cmbAircraft.SelectedIndex = i;
                    break;
                }
            }

            if (DateTime.TryParse(flight.DepartureTime, out var depTime))
            {
                dtpDate.Value = depTime.Date;
                numDepartureHour.Value = depTime.Hour;
                numDepartureMinute.Value = depTime.Minute;
            }

            if (DateTime.TryParse(flight.ArrivalTime, out var arrTime))
            {
                numArrivalHour.Value = arrTime.Hour;
                numArrivalMinute.Value = arrTime.Minute;
            }

            numPassengers.Value = flight.Passengers;
            if (int.TryParse(flight.Baggage.Replace(" kg", ""), out int baggage))
            {
                numBaggage.Value = baggage;
            }
        }

        private void btnAction_Click(object sender, EventArgs e)
        {
            if (!ValidateInput())
                return;

            try
            {
                var routeItem = (ComboBoxItem)cmbRoute.SelectedItem;
                var aircraftItem = (ComboBoxItem)cmbAircraft.SelectedItem;
                var pilotItem = (ComboBoxItem)cmbPilot.SelectedItem;

                var departure = new DateTime(
                    dtpDate.Value.Year,
                    dtpDate.Value.Month,
                    dtpDate.Value.Day,
                    (int)numDepartureHour.Value,
                    (int)numDepartureMinute.Value,
                    0
                );

                var arrival = new DateTime(
                    dtpDate.Value.Year,
                    dtpDate.Value.Month,
                    dtpDate.Value.Day,
                    (int)numArrivalHour.Value,
                    (int)numArrivalMinute.Value,
                    0
                );

                if (arrival <= departure)
                {
                    arrival = arrival.AddDays(1);
                }

                bool success;
                string successMessage;

                if (_isEditMode && _flightId.HasValue)
                {
                    success = _airportService.UpdateFlight(
                        _flightId.Value,
                        routeItem.Id,
                        aircraftItem.Id,
                        pilotItem.Id,
                        departure,
                        arrival
                    );
                    successMessage = "Рейс успешно обновлён";
                }
                else
                {
                    success = _airportService.AddFlight(
                        routeItem.Id,
                        aircraftItem.Id,
                        pilotItem.Id,
                        departure,
                        arrival
                    );
                    successMessage = "Рейс успешно добавлен";
                }

                if (success)
                {
                    MessageBox.Show(successMessage, "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DialogResult = DialogResult.OK;
                    Close();
                }
                else
                {
                    MessageBox.Show("Не удалось сохранить рейс. Проверьте данные и повторите попытку.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при сохранении рейса: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ValidateInput()
        {
            if (cmbRoute.SelectedIndex == -1)
            {
                ShowValidationError("Выберите маршрут");
                cmbRoute.Focus();
                return false;
            }

            if (cmbAircraft.SelectedIndex == -1)
            {
                ShowValidationError("Выберите воздушное судно");
                cmbAircraft.Focus();
                return false;
            }

            if (cmbPilot.SelectedIndex == -1)
            {
                ShowValidationError("Выберите пилота");
                cmbPilot.Focus();
                return false;
            }

            var depTime = new TimeSpan((int)numDepartureHour.Value, (int)numDepartureMinute.Value, 0);
            var arrTime = new TimeSpan((int)numArrivalHour.Value, (int)numArrivalMinute.Value, 0);

            if (arrTime <= depTime)
            {
                var result = MessageBox.Show("Время прилёта не может быть раньше или равно времени вылета.\nСистема автоматически установит прилёт на следующий день.\n\nПродолжить?", "Проверка времени", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);

                if (result == DialogResult.No)
                {
                    numArrivalHour.Focus();
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

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            FlightEditorForm_Load(this, EventArgs.Empty);
        }

        private class ComboBoxItem
        {
            public int Id { get; set; }
            public string Name { get; set; }

            public override string ToString() => Name;
        }
    }
}