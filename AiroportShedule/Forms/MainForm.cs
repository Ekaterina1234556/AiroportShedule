using AiroportShedule.Forms;
using AiroportShedule.Models;
using AiroportShedule.Services;
using System;
using System.Windows.Forms;

namespace AiroportShedule.Forms
{
    public partial class MainForm : Form
    {
        private readonly AirportService _airportService;
        private readonly User _currentUser;
        private System.Windows.Forms.Timer _clockTimer;

        public MainForm()
        {
            InitializeComponent();
            _currentUser = AppManager.Instance.CurrentUser;
            _airportService = new AirportService();
            ApplyRolePermissions();
        }

        private void ApplyRolePermissions()
        {
            switch (_currentUser.Role)
            {
                case Role.Guest:
                    menuMain.Visible = false;
                    btnAddFlight.Visible = false;
                    btnEditFlight.Visible = false;
                    btnDeleteFlight.Visible = false;
                    btnAllowTakeoff.Visible = false;
                    btnAllowLanding.Visible = false;
                    btnMaintenance.Visible = false;
                    btnSuppliesManagement.Visible = false;
                    stsUser.Text = "Пользователь: Гость";
                    break;

                case Role.Pilot:
                    menuMain.Visible = true;
                    mnuSchedule.Visible = true;
                    mnuRoutes.Visible = true;
                    mnuHangars.Visible = true;
                    mnuCrews.Visible = false;
                    mnuReferences.Visible = false;
                    mnuWarehouses.Visible = false;
                    btnAddFlight.Visible = false;
                    btnEditFlight.Visible = false;
                    btnDeleteFlight.Visible = false;
                    btnAllowTakeoff.Visible = false;
                    btnAllowLanding.Visible = false;
                    btnMaintenance.Visible = false;
                    btnSuppliesManagement.Visible = false;
                    stsUser.Text = $"Пилот: {_currentUser.FullName}";
                    break;

                case Role.Coordinator:
                    menuMain.Visible = true;
                    mnuSchedule.Visible = true;
                    mnuRoutes.Visible = true;
                    mnuHangars.Visible = true;
                    mnuCrews.Visible = true;
                    mnuReferences.Visible = true;
                    mnuWarehouses.Visible = true;
                    btnAddFlight.Visible = true;
                    btnEditFlight.Visible = true;
                    btnDeleteFlight.Visible = true;
                    btnAllowTakeoff.Visible = true;
                    btnAllowLanding.Visible = true;
                    btnMaintenance.Visible = true;
                    btnSuppliesManagement.Visible = true;
                    stsUser.Text = $"Координатор: {_currentUser.FullName}";
                    break;

                case Role.Repair:
                    menuMain.Visible = true;
                    mnuSchedule.Visible = true;
                    mnuRoutes.Visible = false;
                    mnuHangars.Visible = true;
                    mnuCrews.Visible = false;
                    mnuReferences.Visible = true;
                    mnuCrewReference.Visible = false;
                    mnuHangarReference.Visible = true;
                    mnuRouteReference.Visible = false;
                    mnuWarehouses.Visible = true;
                    mnuEquipment.Visible = true;
                    mnuSupplies.Visible = false;
                    btnAddFlight.Visible = false;
                    btnEditFlight.Visible = false;
                    btnDeleteFlight.Visible = false;
                    btnAllowTakeoff.Visible = false;
                    btnAllowLanding.Visible = false;
                    btnMaintenance.Visible = true;
                    btnSuppliesManagement.Visible = false;
                    stsUser.Text = $"Техник: {_currentUser.FullName}";
                    break;

                case Role.Personal:
                    menuMain.Visible = true;
                    mnuSchedule.Visible = true;
                    mnuRoutes.Visible = false;
                    mnuHangars.Visible = true;
                    mnuCrews.Visible = false;
                    mnuReferences.Visible = true;
                    mnuCrewReference.Visible = false;
                    mnuHangarReference.Visible = false;
                    mnuRouteReference.Visible = false;
                    mnuWarehouses.Visible = true;
                    mnuEquipment.Visible = false;
                    mnuSupplies.Visible = true;
                    btnAddFlight.Visible = false;
                    btnEditFlight.Visible = false;
                    btnDeleteFlight.Visible = false;
                    btnAllowTakeoff.Visible = false;
                    btnAllowLanding.Visible = false;
                    btnMaintenance.Visible = false;
                    btnSuppliesManagement.Visible = true;
                    stsUser.Text = $"Персонал: {_currentUser.FullName}";
                    break;
            }
            stsAirport.Text = $"Аэропорт: {AppManager.Instance.CurrentAirport}";
        }

     
        private void MainForm_Load(object sender, EventArgs e)
        {
            LoadData();
            StartClock();
        }

        private void LoadData()
        {
            try
            {
                var schedule = _airportService.GetFlightSchedule();
                dgvFlightsSchedule.DataSource = schedule;
                FormatDataGridView();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка загрузки данных: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormatDataGridView()
        {
            dgvFlightsSchedule.Columns["Id"].Visible = false;
            dgvFlightsSchedule.Columns["FlightNumber"].HeaderText = "Рейс";
            dgvFlightsSchedule.Columns["FlightNumber"].Width = 80;
            dgvFlightsSchedule.Columns["Route"].HeaderText = "Маршрут";
            dgvFlightsSchedule.Columns["Route"].Width = 200;
            dgvFlightsSchedule.Columns["Aircraft"].HeaderText = "ВС";
            dgvFlightsSchedule.Columns["Aircraft"].Width = 120;
            dgvFlightsSchedule.Columns["DepartureTime"].HeaderText = "Вылет";
            dgvFlightsSchedule.Columns["DepartureTime"].Width = 80;
            dgvFlightsSchedule.Columns["ArrivalTime"].HeaderText = "Прилёт";
            dgvFlightsSchedule.Columns["ArrivalTime"].Width = 80;
            dgvFlightsSchedule.Columns["Status"].HeaderText = "Статус";
            dgvFlightsSchedule.Columns["Status"].Width = 100;
            dgvFlightsSchedule.Columns["Passengers"].HeaderText = "Пасс.";
            dgvFlightsSchedule.Columns["Passengers"].Width = 70;
            dgvFlightsSchedule.Columns["Baggage"].HeaderText = "Багаж";
            dgvFlightsSchedule.Columns["Baggage"].Width = 90;
            dgvFlightsSchedule.Columns["Passengers"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvFlightsSchedule.Columns["DepartureTime"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvFlightsSchedule.Columns["ArrivalTime"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        private void btnAddFlight_Click(object sender, EventArgs e)
        {
            if (_currentUser.Role != Role.Coordinator)
            {
                MessageBox.Show("У вас недостаточно прав для добавления рейса", "Доступ запрещён", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using var editor = new FlightEditorForm(_airportService);
            if (editor.ShowDialog() == DialogResult.OK)
            {
                LoadData();
                MessageBox.Show("Рейс успешно добавлен", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnEditFlight_Click(object sender, EventArgs e)
        {
            if (_currentUser.Role != Role.Coordinator)
            {
                MessageBox.Show("У вас недостаточно прав для редактирования рейса", "Доступ запрещён", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (dgvFlightsSchedule.SelectedRows.Count == 0)
            {
                MessageBox.Show("Выберите рейс для редактирования", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var flightId = (int)dgvFlightsSchedule.SelectedRows[0].Cells["Id"].Value;
            var flight = _airportService.GetFlightById(flightId);

            if (flight == null)
            {
                MessageBox.Show("Рейс не найден", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using var editor = new FlightEditorForm(_airportService, flight);
            if (editor.ShowDialog() == DialogResult.OK)
            {
                LoadData();
                MessageBox.Show("Рейс успешно обновлён", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnDeleteFlight_Click(object sender, EventArgs e)
        {
            if (_currentUser.Role != Role.Coordinator)
            {
                MessageBox.Show("У вас недостаточно прав для удаления рейса", "Доступ запрещён", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (dgvFlightsSchedule.SelectedRows.Count == 0)
            {
                MessageBox.Show("Выберите рейс для удаления", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var result = MessageBox.Show("Вы уверены, что хотите удалить выбранный рейс?\nЭто действие нельзя отменить.", "Подтверждение удаления", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);

            if (result == DialogResult.Yes)
            {
                var flightId = (int)dgvFlightsSchedule.SelectedRows[0].Cells["Id"].Value;

                try
                {
                    if (_airportService.DeleteFlight(flightId))
                    {
                        LoadData();
                        MessageBox.Show("Рейс успешно удалён", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Не удалось удалить рейс", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка при удалении: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnAllowTakeoff_Click(object sender, EventArgs e)
        {
            if (_currentUser.Role != Role.Coordinator)
            {
                MessageBox.Show("У вас недостаточно прав для разрешения взлёта", "Доступ запрещён", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (dgvFlightsSchedule.SelectedRows.Count == 0)
            {
                MessageBox.Show("Выберите рейс для разрешения взлёта", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var flightId = (int)dgvFlightsSchedule.SelectedRows[0].Cells["Id"].Value;
            var status = dgvFlightsSchedule.SelectedRows[0].Cells["Status"].Value?.ToString() ?? "";

            if (status == "В полёте" || status == "Прибыл")
            {
                MessageBox.Show("Для этого рейса взлёт уже разрешён", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var result = MessageBox.Show("Разрешить взлёт для выбранного рейса?", "Подтверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                if (_airportService.AllowTakeoff(flightId))
                {
                    LoadData();
                    MessageBox.Show("Взлёт разрешён", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Не удалось разрешить взлёт", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnAllowLanding_Click(object sender, EventArgs e)
        {
            if (_currentUser.Role != Role.Coordinator)
            {
                MessageBox.Show("У вас недостаточно прав для разрешения посадки", "Доступ запрещён", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (dgvFlightsSchedule.SelectedRows.Count == 0)
            {
                MessageBox.Show("Выберите рейс для разрешения посадки", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var flightId = (int)dgvFlightsSchedule.SelectedRows[0].Cells["Id"].Value;
            var status = dgvFlightsSchedule.SelectedRows[0].Cells["Status"].Value?.ToString() ?? "";

            if (status != "В полёте")
            {
                MessageBox.Show("Посадку можно разрешить только для рейсов в полёте", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var result = MessageBox.Show("Разрешить посадку для выбранного рейса?", "Подтверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                if (_airportService.AllowLanding(flightId))
                {
                    LoadData();
                    MessageBox.Show("Посадка разрешена", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Не удалось разрешить посадку", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnMaintenance_Click(object sender, EventArgs e)
        {
            if (_currentUser.Role != Role.Coordinator && _currentUser.Role != Role.Repair)
            {
                MessageBox.Show("У вас недостаточно прав для доступа к управлению оборудованием", "Доступ запрещён", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using var form = new WarehouseManagementForm(_airportService);
            form.ShowDialog();
        }

        private void btnSuppliesManagement_Click(object sender, EventArgs e)
        {
            if (_currentUser.Role != Role.Coordinator && _currentUser.Role != Role.Personal)
            {
                MessageBox.Show("У вас недостаточно прав для доступа к управлению припасами", "Доступ запрещён", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using var form = new WarehouseManagementForm(_airportService);
            form.ShowDialog();
        }

        private void menuRoutes_Click(object sender, EventArgs e)
        {
            if (_currentUser.Role == Role.Guest || _currentUser.Role == Role.Personal || _currentUser.Role == Role.Repair)
            {
                MessageBox.Show("У вас недостаточно прав для просмотра расписания воздушных путей", "Доступ запрещён", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using var form = new RouteScheduleForm(_airportService);
            form.ShowDialog();
        }

        private void menuHangars_Click(object sender, EventArgs e)
        {
            if (_currentUser.Role == Role.Guest)
            {
                MessageBox.Show("У вас недостаточно прав для просмотра расписания ангаров", "Доступ запрещён", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using var form = new HangarScheduleForm(_airportService);
            form.ShowDialog();
        }

        private void menuCrews_Click(object sender, EventArgs e)
        {
            if (_currentUser.Role != Role.Coordinator)
            {
                MessageBox.Show("У вас недостаточно прав для управления экипажами", "Доступ запрещён", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using var form = new ReferenceManagementForm(_airportService, ReferenceManagementForm.ReferenceType.Crews);
            form.ShowDialog();
        }

        private void menuHangarReference_Click(object sender, EventArgs e)
        {
            if (_currentUser.Role != Role.Coordinator && _currentUser.Role != Role.Repair)
            {
                MessageBox.Show("У вас недостаточно прав для управления справочником ангаров", "Доступ запрещён", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using var form = new ReferenceManagementForm(_airportService, ReferenceManagementForm.ReferenceType.Hangars);
            form.ShowDialog();
        }

        private void menuRouteReference_Click(object sender, EventArgs e)
        {
            if (_currentUser.Role != Role.Coordinator)
            {
                MessageBox.Show("У вас недостаточно прав для управления справочником путей", "Доступ запрещён", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using var form = new ReferenceManagementForm(_airportService, ReferenceManagementForm.ReferenceType.Routes);
            form.ShowDialog();
        }

        private void menuEquipment_Click(object sender, EventArgs e)
        {
            if (_currentUser.Role != Role.Coordinator && _currentUser.Role != Role.Repair)
            {
                MessageBox.Show("У вас недостаточно прав для управления оборудованием", "Доступ запрещён", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using var form = new WarehouseManagementForm(_airportService);
            form.ShowDialog();
        }

        private void menuSupplies_Click(object sender, EventArgs e)
        {
            if (_currentUser.Role != Role.Coordinator && _currentUser.Role != Role.Personal)
            {
                MessageBox.Show("У вас недостаточно прав для управления припасами", "Доступ запрещён", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using var form = new WarehouseManagementForm(_airportService);
            form.ShowDialog();
        }

        private void StartClock()
        {
            _clockTimer = new System.Windows.Forms.Timer { Interval = 1000 };
            _clockTimer.Tick += (s, e) => stsTime.Text = DateTime.Now.ToString("HH:mm:ss");
            _clockTimer.Start();
            stsTime.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            _clockTimer?.Stop();
            _clockTimer?.Dispose();
            _airportService.Dispose();
        }
    }
}