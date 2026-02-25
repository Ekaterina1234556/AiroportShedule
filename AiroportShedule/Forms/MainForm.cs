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
            // Сброс: по умолчанию скрываем меню и кнопки управления
            menuMain.Visible = true;

            // Скрываем все пункты меню по умолчанию
            SetMenuItemsVisible(false, false, false, false, false, false, false, false, false, false, false);

            // Скрываем все кнопки операций по умолчанию
            SetOperationButtonsVisible(false, false, false, false, false, false, false);

            switch (_currentUser.Role)
            {
                case Role.Guest:
                    // Гость видит только расписание рейсов
                    menuMain.Visible = false;
                    // Кнопки уже скрыты по умолчанию
                    stsUser.Text = "Пользователь: Гость";
                    break;

                case Role.Pilot:
                    // Пилот: Расписание (маршруты, ангары, экипажи)
                    SetMenuItemsVisible(
                        mnuSchedule: true, mnuRoutes: true, mnuHangars: true, mnuCrews: false,
                        mnuReferences: false, mnuCrewReference: false, mnuHangarReference: false,
                        mnuRouteReference: false, mnuWarehouses: false, mnuEquipment: false, mnuSupplies: false);
                    // Кнопки операций скрыты
                    stsUser.Text = $"Пилот: {_currentUser.FullName}";
                    break;

                case Role.Coordinator:
                    // Координатор: Полный доступ
                    SetMenuItemsVisible(
                        mnuSchedule: true, mnuRoutes: true, mnuHangars: true, mnuCrews: true,
                        mnuReferences: true, mnuCrewReference: true, mnuHangarReference: true,
                        mnuRouteReference: true, mnuWarehouses: true, mnuEquipment: true, mnuSupplies: true);
                    SetOperationButtonsVisible(
                        add: true, edit: true, delete: true, takeoff: true, landing: true,
                        maintenance: true, supplies: true);
                    stsUser.Text = $"Координатор: {_currentUser.FullName}";
                    break;

                case Role.Repair:
                    // Техник: Расписание (ангары), Справочники (ангары), Склады (оборудование)
                    SetMenuItemsVisible(
                        mnuSchedule: true, mnuRoutes: false, mnuHangars: true, mnuCrews: false,
                        mnuReferences: true, mnuCrewReference: false, mnuHangarReference: true,
                        mnuRouteReference: false, mnuWarehouses: true, mnuEquipment: true, mnuSupplies: false);
                    // Подпункты справочника экипажей скрыты
                    SafeSetVisible(mnuSupportStaff, false);
                    SafeSetVisible(mnuFlightStaff, false);

                    SetOperationButtonsVisible(
                        add: false, edit: false, delete: false, takeoff: false, landing: false,
                        maintenance: true, supplies: false);
                    stsUser.Text = $"Техник: {_currentUser.FullName}";
                    break;

                case Role.Personal:
                    // Персонал: Расписание (ангары), Справочники (ограничено), Склады (припасы)
                    SetMenuItemsVisible(
                        mnuSchedule: true, mnuRoutes: false, mnuHangars: true, mnuCrews: false,
                        mnuReferences: true, mnuCrewReference: false, mnuHangarReference: false,
                        mnuRouteReference: false, mnuWarehouses: true, mnuEquipment: false, mnuSupplies: true);
                    // Подпункты справочников скрыты
                    SafeSetVisible(mnuSupportStaff, false);
                    SafeSetVisible(mnuFlightStaff, false);

                    SetOperationButtonsVisible(
                        add: false, edit: false, delete: false, takeoff: false, landing: false,
                        maintenance: false, supplies: true);
                    stsUser.Text = $"Персонал: {_currentUser.FullName}";
                    break;
            }

            stsAirport.Text = $"Аэропорт: {AppManager.Instance.CurrentAirport}";
        }

        private void SetMenuItemsVisible(
            bool mnuSchedule, bool mnuRoutes, bool mnuHangars, bool mnuCrews,
            bool mnuReferences, bool mnuCrewReference, bool mnuHangarReference,
            bool mnuRouteReference, bool mnuWarehouses, bool mnuEquipment, bool mnuSupplies)
        {
            SafeSetVisible(this.mnuSchedule, mnuSchedule);
            SafeSetVisible(this.mnuRoutes, mnuRoutes);
            SafeSetVisible(this.mnuHangars, mnuHangars);
            SafeSetVisible(this.mnuCrews, mnuCrews);
            SafeSetVisible(this.mnuReferences, mnuReferences);
            SafeSetVisible(this.mnuCrewReference, mnuCrewReference);
            SafeSetVisible(this.mnuHangarReference, mnuHangarReference);
            SafeSetVisible(this.mnuRouteReference, mnuRouteReference);
            SafeSetVisible(this.mnuWarehouses, mnuWarehouses);
            SafeSetVisible(this.mnuEquipment, mnuEquipment);
            SafeSetVisible(this.mnuSupplies, mnuSupplies);
        }

        private void SetOperationButtonsVisible(bool add, bool edit, bool delete, bool takeoff, bool landing, bool maintenance, bool supplies)
        {
            SafeSetVisible(btnAddFlight, add);
            SafeSetVisible(btnEditFlight, edit);
            SafeSetVisible(btnDeleteFlight, delete);
            SafeSetVisible(btnAllowTakeoff, takeoff);
            SafeSetVisible(btnAllowLanding, landing);
            SafeSetVisible(btnMaintenance, maintenance);
            SafeSetVisible(btnSuppliesManagement, supplies);
        }

        private void SafeSetVisible(Control control, bool visible)
        {
            if (control != null)
                control.Visible = visible;
        }
        private void SafeSetVisible(ToolStripMenuItem control, bool visible)
        {
            if (control != null)
                control.Visible = visible;
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
            if (dgvFlightsSchedule.Columns.Contains("Id"))
                dgvFlightsSchedule.Columns["Id"].Visible = false;

            SetColumnHeader("FlightNumber", "Рейс", 80);
            SetColumnHeader("Route", "Маршрут", 200);
            SetColumnHeader("Aircraft", "ВС", 120);
            SetColumnHeader("DepartureTime", "Вылет", 80);
            SetColumnHeader("ArrivalTime", "Прилёт", 80);
            SetColumnHeader("Status", "Статус", 100);
            SetColumnHeader("Passengers", "Пасс.", 70);
            SetColumnHeader("Baggage", "Багаж", 90);

            AlignColumnCenter("Passengers");
            AlignColumnCenter("DepartureTime");
            AlignColumnCenter("ArrivalTime");
        }

        private void SetColumnHeader(string name, string text, int width)
        {
            if (dgvFlightsSchedule.Columns.Contains(name))
            {
                dgvFlightsSchedule.Columns[name].HeaderText = text;
                dgvFlightsSchedule.Columns[name].Width = width;
            }
        }

        private void AlignColumnCenter(string name)
        {
            if (dgvFlightsSchedule.Columns.Contains(name))
                dgvFlightsSchedule.Columns[name].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        #region Flight Operations (Coordinator Only)

        private void btnAddFlight_Click(object sender, EventArgs e)
        {
            if (_currentUser.Role != Role.Coordinator)
            {
                MessageBox.Show("У вас недостаточно прав для добавления рейса", "Доступ запрещён",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                MessageBox.Show("У вас недостаточно прав для редактирования рейса", "Доступ запрещён",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!TryGetSelectedFlightId(out int flightId)) return;

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
                MessageBox.Show("У вас недостаточно прав для удаления рейса", "Доступ запрещён",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!TryGetSelectedFlightId(out int flightId)) return;

            var result = MessageBox.Show(
                "Вы уверены, что хотите удалить выбранный рейс?\nЭто действие нельзя отменить.",
                "Подтверждение удаления",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning,
                MessageBoxDefaultButton.Button2);

            if (result == DialogResult.Yes)
            {
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
                MessageBox.Show("У вас недостаточно прав для разрешения взлёта", "Доступ запрещён",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!TryGetSelectedFlight(out int flightId, out string status)) return;

            if (status == "В полёте" || status == "Прибыл")
            {
                MessageBox.Show("Для этого рейса взлёт уже разрешён", "Информация",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var result = MessageBox.Show("Разрешить взлёт для выбранного рейса?", "Подтверждение",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

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
                MessageBox.Show("У вас недостаточно прав для разрешения посадки", "Доступ запрещён",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!TryGetSelectedFlight(out int flightId, out string status)) return;

            if (status != "В полёте")
            {
                MessageBox.Show("Посадку можно разрешить только для рейсов в полёте", "Внимание",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var result = MessageBox.Show("Разрешить посадку для выбранного рейса?", "Подтверждение",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

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

        private bool TryGetSelectedFlightId(out int flightId)
        {
            flightId = 0;
            if (dgvFlightsSchedule.SelectedRows.Count == 0)
            {
                MessageBox.Show("Выберите рейс для выполнения операции", "Внимание",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            var cellValue = dgvFlightsSchedule.SelectedRows[0].Cells["Id"].Value;
            if (cellValue == null || !int.TryParse(cellValue.ToString(), out flightId))
            {
                MessageBox.Show("Ошибка получения данных рейса", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private bool TryGetSelectedFlight(out int flightId, out string status)
        {
            flightId = 0;
            status = string.Empty;

            if (!TryGetSelectedFlightId(out flightId)) return false;

            var statusCell = dgvFlightsSchedule.SelectedRows[0].Cells["Status"].Value;
            status = statusCell?.ToString() ?? string.Empty;
            return true;
        }

        #endregion

        #region Maintenance & Supplies

        private void btnMaintenance_Click(object sender, EventArgs e)
        {
            if (_currentUser.Role != Role.Coordinator && _currentUser.Role != Role.Repair)
            {
                MessageBox.Show("У вас недостаточно прав для доступа к управлению оборудованием",
                    "Доступ запрещён", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using var form = new WarehouseManagementForm(_airportService);
            form.ShowDialog();
        }

        private void btnSuppliesManagement_Click(object sender, EventArgs e)
        {
            if (_currentUser.Role != Role.Coordinator && _currentUser.Role != Role.Personal)
            {
                MessageBox.Show("У вас недостаточно прав для управления припасами",
                    "Доступ запрещён", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using var form = new WarehouseManagementForm(_airportService);
            form.ShowDialog();
        }

        #endregion

        #region Menu Navigation

        private void menuRoutes_Click(object sender, EventArgs e)
        {
            if (_currentUser.Role == Role.Guest || _currentUser.Role == Role.Personal || _currentUser.Role == Role.Repair)
            {
                MessageBox.Show("У вас недостаточно прав для просмотра расписания воздушных путей",
                    "Доступ запрещён", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using var form = new RouteScheduleForm(_airportService);
            form.ShowDialog();
        }

        private void menuHangars_Click(object sender, EventArgs e)
        {
            if (_currentUser.Role == Role.Guest)
            {
                MessageBox.Show("У вас недостаточно прав для просмотра расписания ангаров",
                    "Доступ запрещён", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using var form = new HangarScheduleForm(_airportService);
            form.ShowDialog();
        }

        private void menuCrews_Click(object sender, EventArgs e)
        {
            if (_currentUser.Role != Role.Coordinator)
            {
                MessageBox.Show("У вас недостаточно прав для управления экипажами",
                    "Доступ запрещён", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using var form = new ReferenceManagementForm(_airportService, ReferenceManagementForm.ReferenceType.Crews);
            form.ShowDialog();
        }

        private void menuHangarReference_Click(object sender, EventArgs e)
        {
            if (_currentUser.Role != Role.Coordinator && _currentUser.Role != Role.Repair)
            {
                MessageBox.Show("У вас недостаточно прав для управления справочником ангаров",
                    "Доступ запрещён", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using var form = new ReferenceManagementForm(_airportService, ReferenceManagementForm.ReferenceType.Hangars);
            form.ShowDialog();
        }

        private void menuRouteReference_Click(object sender, EventArgs e)
        {
            if (_currentUser.Role != Role.Coordinator)
            {
                MessageBox.Show("У вас недостаточно прав для управления справочником путей",
                    "Доступ запрещён", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using var form = new ReferenceManagementForm(_airportService, ReferenceManagementForm.ReferenceType.Routes);
            form.ShowDialog();
        }

        private void menuEquipment_Click(object sender, EventArgs e)
        {
            if (_currentUser.Role != Role.Coordinator && _currentUser.Role != Role.Repair)
            {
                MessageBox.Show("У вас недостаточно прав для управления оборудованием",
                    "Доступ запрещён", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using var form = new WarehouseManagementForm(_airportService);
            form.ShowDialog();
        }

        private void menuSupplies_Click(object sender, EventArgs e)
        {
            if (_currentUser.Role != Role.Coordinator && _currentUser.Role != Role.Personal)
            {
                MessageBox.Show("У вас недостаточно прав для управления припасами",
                    "Доступ запрещён", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using var form = new WarehouseManagementForm(_airportService);
            form.ShowDialog();
        }

        #endregion

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
            _airportService?.Dispose();
        }
    }
}