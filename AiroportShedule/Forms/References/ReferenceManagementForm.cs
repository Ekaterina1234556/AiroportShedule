using AiroportShedule.Services;
using System;
using System.Windows.Forms;

namespace AiroportShedule.Forms
{
    public partial class ReferenceManagementForm : Form
    {
        private readonly AirportService _airportService;
        private readonly ReferenceType _referenceType;

        public enum ReferenceType
        {
            Crews,
            Hangars,
            Routes
        }

        public ReferenceManagementForm(AirportService airportService, ReferenceType referenceType)
        {
            InitializeComponent();
            _airportService = airportService ?? throw new ArgumentNullException(nameof(airportService));
            _referenceType = referenceType;
            InitializeForm();
            LoadData();
        }

        private void InitializeForm()
        {
            switch (_referenceType)
            {
                case ReferenceType.Crews:
                    Text = "Справочник экипажей — Аэропорт";
                    lblTitle.Text = "Справочник экипажей";
                    lblListTitle.Text = "Список персонала";
                    tabControl.TabPages.Clear();
                    tabControl.TabPages.Add(tabPageFlightCrew);
                    tabControl.TabPages.Add(tabPageSupportCrew);
                    tabPageFlightCrew.Text = "Полётный персонал";
                    tabPageSupportCrew.Text = "Обслуживающий персонал";
                    break;

                case ReferenceType.Hangars:
                    Text = "Справочник ангаров — Аэропорт";
                    lblTitle.Text = "Справочник ангаров";
                    lblListTitle.Text = "Список ангаров";
                    tabControl.TabPages.Clear();
                    tabControl.TabPages.Add(tabPageSingleList);
                    tabPageSingleList.Text = "Ангары";
                    break;

                case ReferenceType.Routes:
                    Text = "Справочник путей — Аэропорт";
                    lblTitle.Text = "Справочник путей";
                    lblListTitle.Text = "Список маршрутов";
                    tabControl.TabPages.Clear();
                    tabControl.TabPages.Add(tabPageSingleList);
                    tabPageSingleList.Text = "Маршруты";
                    break;
            }

            SetupDataGridViews();
        }

        private void SetupDataGridViews()
        {
            switch (_referenceType)
            {
                case ReferenceType.Crews:
                    dgvFlightCrew.AutoGenerateColumns = false;
                    dgvFlightCrew.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Id", HeaderText = "ID", Width = 60, Visible = false });
                    dgvFlightCrew.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "FullName", HeaderText = "ФИО", Width = 280 });
                    dgvFlightCrew.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Role", HeaderText = "Должность", Width = 150 });
                    dgvFlightCrew.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "FlightHours", HeaderText = "Налё", Width = 100 });
                    dgvFlightCrew.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "ExperienceYears", HeaderText = "Стаж", Width = 80 });

                    dgvSupportCrew.AutoGenerateColumns = false;
                    dgvSupportCrew.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Id", HeaderText = "ID", Width = 60, Visible = false });
                    dgvSupportCrew.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "FullName", HeaderText = "ФИО", Width = 280 });
                    dgvSupportCrew.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Role", HeaderText = "Должность", Width = 150 });
                    dgvSupportCrew.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "FlightHours", HeaderText = "Налёт", Width = 100 });
                    dgvSupportCrew.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "ExperienceYears", HeaderText = "Стаж", Width = 80 });
                    break;

                case ReferenceType.Hangars:
                    dgvSingleList.AutoGenerateColumns = false;
                    dgvSingleList.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Id", HeaderText = "ID", Width = 60, Visible = false });
                    dgvSingleList.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Name", HeaderText = "Название", Width = 200 });
                    dgvSingleList.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Type", HeaderText = "Тип", Width = 150 });
                    dgvSingleList.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Size", HeaderText = "Размер", Width = 150 });
                    break;

                case ReferenceType.Routes:
                    dgvSingleList.AutoGenerateColumns = false;
                    dgvSingleList.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Id", HeaderText = "ID", Width = 60, Visible = false });
                    dgvSingleList.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Name", HeaderText = "Маршрут", Width = 450 });
                    break;
            }
        }

        private void LoadData()
        {
            try
            {
                switch (_referenceType)
                {
                    case ReferenceType.Crews:
                        var flightCrew = _airportService.GetCrewMembers("Пилот");
                        dgvFlightCrew.DataSource = flightCrew;

                        var supportCrew = _airportService.GetCrewMembers("Обслуживающий персонал");
                        dgvSupportCrew.DataSource = supportCrew;
                        break;

                    case ReferenceType.Hangars:
                        var hangars = _airportService.GetHangars();
                        dgvSingleList.DataSource = hangars;
                        break;

                    case ReferenceType.Routes:
                        var routes = _airportService.GetRoutes();
                        dgvSingleList.DataSource = routes;
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка загрузки данных: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAddFlightCrew_Click(object sender, EventArgs e)
        {
            using var editor = new CrewEditorForm(_airportService, CrewEditorForm.CrewType.Flight);
            if (editor.ShowDialog() == DialogResult.OK)
            {
                LoadData();
                MessageBox.Show("Сотрудник успешно добавлен", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnEditFlightCrew_Click(object sender, EventArgs e)
        {
            if (dgvFlightCrew.SelectedRows.Count == 0)
            {
                MessageBox.Show("Выберите сотрудника для редактирования", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var crewId = (int)dgvFlightCrew.SelectedRows[0].Cells[0].Value;
            var crew = _airportService.GetCrewMemberById(crewId);

            if (crew == null)
            {
                MessageBox.Show("Сотрудник не найден", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using var editor = new CrewEditorForm(_airportService, CrewEditorForm.CrewType.Flight, crew);
            if (editor.ShowDialog() == DialogResult.OK)
            {
                LoadData();
                MessageBox.Show("Сотрудник успешно обновлён", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnDeleteFlightCrew_Click(object sender, EventArgs e)
        {
            if (dgvFlightCrew.SelectedRows.Count == 0)
            {
                MessageBox.Show("Выберите сотрудника для удаления", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var result = MessageBox.Show("Вы уверены, что хотите удалить выбранного сотрудника?\nЭто действие нельзя отменить.", "Подтверждение удаления", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);

            if (result == DialogResult.Yes)
            {
                var crewId = (int)dgvFlightCrew.SelectedRows[0].Cells[0].Value;

                try
                {
                    if (_airportService.DeleteCrewMember(crewId))
                    {
                        LoadData();
                        MessageBox.Show("Сотрудник успешно удалён", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Не удалось удалить сотрудника", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка при удалении: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnAddSupportCrew_Click(object sender, EventArgs e)
        {
            using var editor = new CrewEditorForm(_airportService, CrewEditorForm.CrewType.Support);
            if (editor.ShowDialog() == DialogResult.OK)
            {
                LoadData();
                MessageBox.Show("Сотрудник успешно добавлен", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnEditSupportCrew_Click(object sender, EventArgs e)
        {
            if (dgvSupportCrew.SelectedRows.Count == 0)
            {
                MessageBox.Show("Выберите сотрудника для редактирования", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var crewId = (int)dgvSupportCrew.SelectedRows[0].Cells[0].Value;
            var crew = _airportService.GetCrewMemberById(crewId);

            if (crew == null)
            {
                MessageBox.Show("Сотрудник не найден", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Определяем тип редактора на основе роли сотрудника
            CrewEditorForm.CrewType editorType;

            if (crew.Role == "Техник")
            {
                editorType = CrewEditorForm.CrewType.Support; // Используем Support для техников (как в вашей логике)
            }
            else if (crew.Role == "Обслуживающий персонал")
            {
                editorType = CrewEditorForm.CrewType.Support; // Оба типа используют один редактор
            }
            else
            {
                // Если роль не поддерживается, используем Support по умолчанию
                editorType = CrewEditorForm.CrewType.Support;
            }

            using var editor = new CrewEditorForm(_airportService, editorType, crew);
            if (editor.ShowDialog() == DialogResult.OK)
            {
                LoadData();
                MessageBox.Show("Сотрудник успешно обновлён", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnDeleteSupportCrew_Click(object sender, EventArgs e)
        {
            if (dgvSupportCrew.SelectedRows.Count == 0)
            {
                MessageBox.Show("Выберите сотрудника для удаления", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var result = MessageBox.Show("Вы уверены, что хотите удалить выбранного сотрудника?\nЭто действие нельзя отменить.", "Подтверждение удаления", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);

            if (result == DialogResult.Yes)
            {
                var crewId = (int)dgvSupportCrew.SelectedRows[0].Cells[0].Value;

                try
                {
                    if (_airportService.DeleteCrewMember(crewId))
                    {
                        LoadData();
                        MessageBox.Show("Сотрудник успешно удалён", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Не удалось удалить сотрудника", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка при удалении: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnAddHangar_Click(object sender, EventArgs e)
        {
            using var editor = new HangarEditorForm(_airportService);
            if (editor.ShowDialog() == DialogResult.OK)
            {
                LoadData();
                MessageBox.Show("Ангар успешно добавлен", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnEditHangar_Click(object sender, EventArgs e)
        {
            if (dgvSingleList.SelectedRows.Count == 0)
            {
                MessageBox.Show("Выберите ангар для редактирования", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var hangarId = (int)dgvSingleList.SelectedRows[0].Cells[0].Value;
            var hangar = _airportService.GetHangarById(hangarId);

            if (hangar == null)
            {
                MessageBox.Show("Ангар не найден", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using var editor = new HangarEditorForm(_airportService, hangar);
            if (editor.ShowDialog() == DialogResult.OK)
            {
                LoadData();
                MessageBox.Show("Ангар успешно обновлён", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnDeleteHangar_Click(object sender, EventArgs e)
        {
            if (dgvSingleList.SelectedRows.Count == 0)
            {
                MessageBox.Show("Выберите ангар для удаления", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var result = MessageBox.Show("Вы уверены, что хотите удалить выбранный ангар?\nЭто действие нельзя отменить.", "Подтверждение удаления", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);

            if (result == DialogResult.Yes)
            {
                var hangarId = (int)dgvSingleList.SelectedRows[0].Cells[0].Value;

                try
                {
                    if (_airportService.DeleteHangar(hangarId))
                    {
                        LoadData();
                        MessageBox.Show("Ангар успешно удалён", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Не удалось удалить ангар", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка при удалении: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnAddRoute_Click(object sender, EventArgs e)
        {
            using var editor = new RouteEditorForm(_airportService);
            if (editor.ShowDialog() == DialogResult.OK)
            {
                LoadData();
                MessageBox.Show("Маршрут успешно добавлен", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnEditRoute_Click(object sender, EventArgs e)
        {
            if (dgvSingleList.SelectedRows.Count == 0)
            {
                MessageBox.Show("Выберите маршрут для редактирования", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var routeId = (int)dgvSingleList.SelectedRows[0].Cells[0].Value;
            var route = _airportService.GetRouteById(routeId);

            if (route == null)
            {
                MessageBox.Show("Маршрут не найден", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using var editor = new RouteEditorForm(_airportService, route);
            if (editor.ShowDialog() == DialogResult.OK)
            {
                LoadData();
                MessageBox.Show("Маршрут успешно обновлён", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnDeleteRoute_Click(object sender, EventArgs e)
        {
            if (dgvSingleList.SelectedRows.Count == 0)
            {
                MessageBox.Show("Выберите маршрут для удаления", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var result = MessageBox.Show("Вы уверены, что хотите удалить выбранный маршрут?\nЭто действие нельзя отменить.", "Подтверждение удаления", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);

            if (result == DialogResult.Yes)
            {
                var routeId = (int)dgvSingleList.SelectedRows[0].Cells[0].Value;

                try
                {
                    if (_airportService.DeleteRoute(routeId))
                    {
                        LoadData();
                        MessageBox.Show("Маршрут успешно удалён", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Не удалось удалить маршрут", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка при удалении: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void dgvFlightCrew_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}