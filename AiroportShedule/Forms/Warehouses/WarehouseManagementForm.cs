using AiroportShedule.Services;
using System;
using System.Windows.Forms;

namespace AiroportShedule.Forms
{
    public partial class WarehouseManagementForm : Form
    {
        private readonly AirportService _airportService;

        public WarehouseManagementForm(AirportService airportService)
        {
            InitializeComponent();
            _airportService = airportService ?? throw new ArgumentNullException(nameof(airportService));
            InitializeDataGridViews();
            LoadData();
        }

        private void InitializeDataGridViews()
        {
            dgvEquipment.AutoGenerateColumns = false;
            dgvEquipment.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Id",
                HeaderText = "ID",
                Width = 60,
                Visible = false
            });
            dgvEquipment.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Name",
                HeaderText = "Наименование",
                Width = 250
            });
            dgvEquipment.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Description",
                HeaderText = "Описание",
                Width = 350
            });
            dgvEquipment.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "HangarName",
                HeaderText = "Ангар",
                Width = 150
            });
            dgvEquipment.Columns.Add(new DataGridViewCheckBoxColumn
            {
                DataPropertyName = "IsWorking",
                HeaderText = "Работает",
                Width = 100
            });

            dgvSupplies.AutoGenerateColumns = false;
            dgvSupplies.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Id",
                HeaderText = "ID",
                Width = 60,
                Visible = false
            });
            dgvSupplies.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Name",
                HeaderText = "Наименование",
                Width = 250
            });
            dgvSupplies.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Category",
                HeaderText = "Категория",
                Width = 150
            });
            dgvSupplies.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Quantity",
                HeaderText = "Количество",
                Width = 120
            });
            dgvSupplies.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Unit",
                HeaderText = "Ед. изм.",
                Width = 100
            });
            dgvSupplies.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "HangarName",
                HeaderText = "Ангар",
                Width = 150
            });
        }

        private void LoadData()
        {
            try
            {
                var equipment = _airportService.GetEquipment();
                dgvEquipment.DataSource = equipment;

                var supplies = _airportService.GetSupplies();
                dgvSupplies.DataSource = supplies;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка загрузки данных: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAddEquipment_Click(object sender, EventArgs e)
        {
            using var editor = new EquipmentEditorForm(_airportService);
            if (editor.ShowDialog() == DialogResult.OK)
            {
                LoadData();
                MessageBox.Show("Оборудование успешно добавлено", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnEditEquipment_Click(object sender, EventArgs e)
        {
            if (dgvEquipment.SelectedRows.Count == 0)
            {
                MessageBox.Show("Выберите оборудование для редактирования", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var equipmentId = (int)dgvEquipment.SelectedRows[0].Cells["Id"].Value;
            var equipment = _airportService.GetEquipmentById(equipmentId);

            if (equipment == null)
            {
                MessageBox.Show("Оборудование не найдено", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using var editor = new EquipmentEditorForm(_airportService, equipment);
            if (editor.ShowDialog() == DialogResult.OK)
            {
                LoadData();
                MessageBox.Show("Оборудование успешно обновлено", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnDeleteEquipment_Click(object sender, EventArgs e)
        {
            if (dgvEquipment.SelectedRows.Count == 0)
            {
                MessageBox.Show("Выберите оборудование для удаления", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var result = MessageBox.Show("Вы уверены, что хотите удалить выбранное оборудование?\nЭто действие нельзя отменить.", "Подтверждение удаления", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);

            if (result == DialogResult.Yes)
            {
                var equipmentId = (int)dgvEquipment.SelectedRows[0].Cells["Id"].Value;

                try
                {
                    if (_airportService.DeleteEquipment(equipmentId))
                    {
                        LoadData();
                        MessageBox.Show("Оборудование успешно удалено", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Не удалось удалить оборудование", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка при удалении: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnAddSupply_Click(object sender, EventArgs e)
        {
            using var editor = new SupplyEditorForm(_airportService);
            if (editor.ShowDialog() == DialogResult.OK)
            {
                LoadData();
                MessageBox.Show("Припас успешно добавлен", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnEditSupply_Click(object sender, EventArgs e)
        {
            if (dgvSupplies.SelectedRows.Count == 0)
            {
                MessageBox.Show("Выберите припас для редактирования", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var supplyId = (int)dgvSupplies.SelectedRows[0].Cells["Id"].Value;
            var supply = _airportService.GetSupplyById(supplyId);

            if (supply == null)
            {
                MessageBox.Show("Припас не найден", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using var editor = new SupplyEditorForm(_airportService, supply);
            if (editor.ShowDialog() == DialogResult.OK)
            {
                LoadData();
                MessageBox.Show("Припас успешно обновлён", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnDeleteSupply_Click(object sender, EventArgs e)
        {
            if (dgvSupplies.SelectedRows.Count == 0)
            {
                MessageBox.Show("Выберите припас для удаления", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var result = MessageBox.Show("Вы уверены, что хотите удалить выбранный припас?\nЭто действие нельзя отменить.", "Подтверждение удаления", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);

            if (result == DialogResult.Yes)
            {
                var supplyId = (int)dgvSupplies.SelectedRows[0].Cells["Id"].Value;

                try
                {
                    if (_airportService.DeleteSupply(supplyId))
                    {
                        LoadData();
                        MessageBox.Show("Припас успешно удалён", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Не удалось удалить припас", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка при удалении: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}