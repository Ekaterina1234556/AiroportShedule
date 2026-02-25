namespace AiroportShedule.Forms
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            menuMain = new MenuStrip();
            mnuSchedule = new ToolStripMenuItem();
            mnuRoutes = new ToolStripMenuItem();
            mnuHangars = new ToolStripMenuItem();
            mnuCrews = new ToolStripMenuItem();
            mnuReferences = new ToolStripMenuItem();
            mnuCrewReference = new ToolStripMenuItem();
            mnuSupportStaff = new ToolStripMenuItem();
            mnuFlightStaff = new ToolStripMenuItem();
            mnuHangarReference = new ToolStripMenuItem();
            mnuRouteReference = new ToolStripMenuItem();
            mnuWarehouses = new ToolStripMenuItem();
            mnuEquipment = new ToolStripMenuItem();
            mnuSupplies = new ToolStripMenuItem();
            statusMain = new StatusStrip();
            stsUser = new ToolStripStatusLabel();
            stsSeparator1 = new ToolStripStatusLabel();
            stsAirport = new ToolStripStatusLabel();
            stsSeparator2 = new ToolStripStatusLabel();
            stsTime = new ToolStripStatusLabel();
            pnlScheduleSection = new Panel();
            lblFlightsScheduleTitle = new Label();
            dgvFlightsSchedule = new Zuby.ADGV.AdvancedDataGridView();
            pnlCrudButtons = new Panel();
            btnAddFlight = new Button();
            btnEditFlight = new Button();
            btnDeleteFlight = new Button();
            tableLayoutPanelMain = new TableLayoutPanel();
            pnlAirportMapCanvas = new Panel();
            lblAirportMapTitle = new Label();
            pnlAirportControls = new Panel();
            btnMaintenance = new Button();
            btnSuppliesManagement = new Button();
            btnAllowTakeoff = new Button();
            btnAllowLanding = new Button();
            pnlAirportSection = new Panel();
            menuMain.SuspendLayout();
            statusMain.SuspendLayout();
            pnlScheduleSection.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvFlightsSchedule).BeginInit();
            pnlCrudButtons.SuspendLayout();
            tableLayoutPanelMain.SuspendLayout();
            pnlAirportMapCanvas.SuspendLayout();
            pnlAirportControls.SuspendLayout();
            pnlAirportSection.SuspendLayout();
            SuspendLayout();
            // 
            // menuMain
            // 
            menuMain.BackColor = Color.FromArgb(46, 90, 136);
            menuMain.Font = new Font("Times New Roman", 14F, FontStyle.Bold, GraphicsUnit.Point, 204);
            menuMain.ForeColor = Color.White;
            menuMain.ImageScalingSize = new Size(24, 24);
            menuMain.Items.AddRange(new ToolStripItem[] { mnuSchedule, mnuReferences, mnuWarehouses });
            menuMain.Location = new Point(0, 0);
            menuMain.Name = "menuMain";
            menuMain.Padding = new Padding(8, 3, 0, 3);
            menuMain.Size = new Size(1496, 42);
            menuMain.TabIndex = 0;
            menuMain.Text = "Main Menu";
            // 
            // mnuSchedule
            // 
            mnuSchedule.DropDownItems.AddRange(new ToolStripItem[] { mnuRoutes, mnuHangars, mnuCrews });
            mnuSchedule.Font = new Font("Times New Roman", 14F, FontStyle.Bold, GraphicsUnit.Point, 204);
            mnuSchedule.ForeColor = Color.White;
            mnuSchedule.Name = "mnuSchedule";
            mnuSchedule.Size = new Size(176, 36);
            mnuSchedule.Text = "Расписание";
            // 
            // mnuRoutes
            // 
            mnuRoutes.Font = new Font("Times New Roman", 14F, FontStyle.Regular, GraphicsUnit.Point, 204);
            mnuRoutes.ForeColor = Color.Black;
            mnuRoutes.Name = "mnuRoutes";
            mnuRoutes.Size = new Size(319, 42);
            mnuRoutes.Text = "Воздушные пути";
            mnuRoutes.Click += menuRoutes_Click;
            // 
            // mnuHangars
            // 
            mnuHangars.Font = new Font("Times New Roman", 14F, FontStyle.Regular, GraphicsUnit.Point, 204);
            mnuHangars.ForeColor = Color.Black;
            mnuHangars.Name = "mnuHangars";
            mnuHangars.Size = new Size(319, 42);
            mnuHangars.Text = "Ангары";
            mnuHangars.Click += menuHangars_Click;
            // 
            // mnuCrews
            // 
            mnuCrews.Font = new Font("Times New Roman", 14F, FontStyle.Regular, GraphicsUnit.Point, 204);
            mnuCrews.ForeColor = Color.Black;
            mnuCrews.Name = "mnuCrews";
            mnuCrews.Size = new Size(319, 42);
            mnuCrews.Text = "Экипажи";
            mnuCrews.Click += menuCrews_Click;
            // 
            // mnuReferences
            // 
            mnuReferences.DropDownItems.AddRange(new ToolStripItem[] { mnuCrewReference, mnuHangarReference, mnuRouteReference });
            mnuReferences.Font = new Font("Times New Roman", 14F, FontStyle.Bold, GraphicsUnit.Point, 204);
            mnuReferences.ForeColor = Color.White;
            mnuReferences.Name = "mnuReferences";
            mnuReferences.Size = new Size(204, 36);
            mnuReferences.Text = "Справочники";
            // 
            // mnuCrewReference
            // 
            mnuCrewReference.DropDownItems.AddRange(new ToolStripItem[] { mnuSupportStaff, mnuFlightStaff });
            mnuCrewReference.Font = new Font("Times New Roman", 14F, FontStyle.Regular, GraphicsUnit.Point, 204);
            mnuCrewReference.ForeColor = Color.Black;
            mnuCrewReference.Name = "mnuCrewReference";
            mnuCrewReference.Size = new Size(227, 42);
            mnuCrewReference.Text = "Экипажи";
            // 
            // mnuSupportStaff
            // 
            mnuSupportStaff.Font = new Font("Times New Roman", 14F, FontStyle.Regular, GraphicsUnit.Point, 204);
            mnuSupportStaff.ForeColor = Color.Black;
            mnuSupportStaff.Name = "mnuSupportStaff";
            mnuSupportStaff.Size = new Size(440, 42);
            mnuSupportStaff.Text = "Обслуживающий персонал";
            mnuSupportStaff.Click += menuCrews_Click;
            // 
            // mnuFlightStaff
            // 
            mnuFlightStaff.Font = new Font("Times New Roman", 14F, FontStyle.Regular, GraphicsUnit.Point, 204);
            mnuFlightStaff.ForeColor = Color.Black;
            mnuFlightStaff.Name = "mnuFlightStaff";
            mnuFlightStaff.Size = new Size(440, 42);
            mnuFlightStaff.Text = "Полётный персонал";
            mnuFlightStaff.Click += menuCrews_Click;
            // 
            // mnuHangarReference
            // 
            mnuHangarReference.Font = new Font("Times New Roman", 14F, FontStyle.Regular, GraphicsUnit.Point, 204);
            mnuHangarReference.ForeColor = Color.Black;
            mnuHangarReference.Name = "mnuHangarReference";
            mnuHangarReference.Size = new Size(227, 42);
            mnuHangarReference.Text = "Ангары";
            mnuHangarReference.Click += menuHangars_Click;
            // 
            // mnuRouteReference
            // 
            mnuRouteReference.Font = new Font("Times New Roman", 14F, FontStyle.Regular, GraphicsUnit.Point, 204);
            mnuRouteReference.ForeColor = Color.Black;
            mnuRouteReference.Name = "mnuRouteReference";
            mnuRouteReference.Size = new Size(227, 42);
            mnuRouteReference.Text = "Пути";
            mnuRouteReference.Click += menuRouteReference_Click;
            // 
            // mnuWarehouses
            // 
            mnuWarehouses.DropDownItems.AddRange(new ToolStripItem[] { mnuEquipment, mnuSupplies });
            mnuWarehouses.Font = new Font("Times New Roman", 14F, FontStyle.Bold, GraphicsUnit.Point, 204);
            mnuWarehouses.ForeColor = Color.White;
            mnuWarehouses.Name = "mnuWarehouses";
            mnuWarehouses.Size = new Size(132, 36);
            mnuWarehouses.Text = "Склады";
            // 
            // mnuEquipment
            // 
            mnuEquipment.Font = new Font("Times New Roman", 14F, FontStyle.Regular, GraphicsUnit.Point, 204);
            mnuEquipment.ForeColor = Color.Black;
            mnuEquipment.Name = "mnuEquipment";
            mnuEquipment.Size = new Size(287, 42);
            mnuEquipment.Text = "Оборудование";
            mnuEquipment.Click += btnSuppliesManagement_Click;
            // 
            // mnuSupplies
            // 
            mnuSupplies.Font = new Font("Times New Roman", 14F, FontStyle.Regular, GraphicsUnit.Point, 204);
            mnuSupplies.ForeColor = Color.Black;
            mnuSupplies.Name = "mnuSupplies";
            mnuSupplies.Size = new Size(287, 42);
            mnuSupplies.Text = "Припасы";
            mnuSupplies.Click += btnSuppliesManagement_Click;
            // 
            // statusMain
            // 
            statusMain.BackColor = Color.FromArgb(46, 90, 136);
            statusMain.Font = new Font("Times New Roman", 14F, FontStyle.Regular, GraphicsUnit.Point, 204);
            statusMain.ForeColor = Color.White;
            statusMain.ImageScalingSize = new Size(24, 24);
            statusMain.Items.AddRange(new ToolStripItem[] { stsUser, stsSeparator1, stsAirport, stsSeparator2, stsTime });
            statusMain.Location = new Point(0, 810);
            statusMain.Name = "statusMain";
            statusMain.Padding = new Padding(15, 0, 15, 0);
            statusMain.Size = new Size(1496, 40);
            statusMain.SizingGrip = false;
            statusMain.TabIndex = 1;
            statusMain.Text = "Status Bar";
            // 
            // stsUser
            // 
            stsUser.Name = "stsUser";
            stsUser.Size = new Size(256, 33);
            stsUser.Text = "Пользователь: Гость";
            // 
            // stsSeparator1
            // 
            stsSeparator1.Name = "stsSeparator1";
            stsSeparator1.Size = new Size(20, 33);
            stsSeparator1.Text = "|";
            // 
            // stsAirport
            // 
            stsAirport.Name = "stsAirport";
            stsAirport.Size = new Size(1055, 33);
            stsAirport.Spring = true;
            stsAirport.Text = "Аэропорт: Шереметьево";
            // 
            // stsSeparator2
            // 
            stsSeparator2.Name = "stsSeparator2";
            stsSeparator2.Size = new Size(20, 33);
            stsSeparator2.Text = "|";
            // 
            // stsTime
            // 
            stsTime.ForeColor = Color.FromArgb(249, 115, 22);
            stsTime.Name = "stsTime";
            stsTime.Size = new Size(115, 33);
            stsTime.Text = "12:34:56";
            // 
            // pnlScheduleSection
            // 
            pnlScheduleSection.BackColor = Color.White;
            pnlScheduleSection.BorderStyle = BorderStyle.FixedSingle;
            pnlScheduleSection.Controls.Add(pnlCrudButtons);
            pnlScheduleSection.Controls.Add(dgvFlightsSchedule);
            pnlScheduleSection.Controls.Add(lblFlightsScheduleTitle);
            pnlScheduleSection.Dock = DockStyle.Fill;
            pnlScheduleSection.Location = new Point(904, 18);
            pnlScheduleSection.Margin = new Padding(10, 3, 3, 3);
            pnlScheduleSection.Name = "pnlScheduleSection";
            pnlScheduleSection.Padding = new Padding(25, 20, 25, 20);
            pnlScheduleSection.Size = new Size(574, 732);
            pnlScheduleSection.TabIndex = 1;
            // 
            // lblFlightsScheduleTitle
            // 
            lblFlightsScheduleTitle.AutoSize = true;
            lblFlightsScheduleTitle.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            lblFlightsScheduleTitle.ForeColor = Color.FromArgb(33, 37, 41);
            lblFlightsScheduleTitle.Location = new Point(15, 15);
            lblFlightsScheduleTitle.Margin = new Padding(4, 0, 4, 12);
            lblFlightsScheduleTitle.Name = "lblFlightsScheduleTitle";
            lblFlightsScheduleTitle.Size = new Size(327, 41);
            lblFlightsScheduleTitle.TabIndex = 0;
            lblFlightsScheduleTitle.Text = "Расписание рейсов";
            // 
            // dgvFlightsSchedule
            // 
            dgvFlightsSchedule.BackgroundColor = Color.White;
            dgvFlightsSchedule.BorderStyle = BorderStyle.None;
            dgvFlightsSchedule.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(46, 90, 136);
            dataGridViewCellStyle1.Font = new Font("Times New Roman", 14F, FontStyle.Bold, GraphicsUnit.Point, 204);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(96, 165, 250);
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvFlightsSchedule.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvFlightsSchedule.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.Font = new Font("Times New Roman", 14F, FontStyle.Regular, GraphicsUnit.Point, 204);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(33, 37, 41);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(147, 197, 253);
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvFlightsSchedule.DefaultCellStyle = dataGridViewCellStyle2;
            dgvFlightsSchedule.Dock = DockStyle.Fill;
            dgvFlightsSchedule.EnableHeadersVisualStyles = false;
            dgvFlightsSchedule.FilterAndSortEnabled = true;
            dgvFlightsSchedule.FilterStringChangedInvokeBeforeDatasourceUpdate = true;
            dgvFlightsSchedule.Font = new Font("Times New Roman", 14F, FontStyle.Regular, GraphicsUnit.Point, 204);
            dgvFlightsSchedule.GridColor = Color.FromArgb(226, 232, 240);
            dgvFlightsSchedule.Location = new Point(25, 20);
            dgvFlightsSchedule.Margin = new Padding(4);
            dgvFlightsSchedule.MaxFilterButtonImageHeight = 23;
            dgvFlightsSchedule.Name = "dgvFlightsSchedule";
            dgvFlightsSchedule.RightToLeft = RightToLeft.No;
            dgvFlightsSchedule.RowHeadersWidth = 62;
            dgvFlightsSchedule.Size = new Size(522, 690);
            dgvFlightsSchedule.SortStringChangedInvokeBeforeDatasourceUpdate = true;
            dgvFlightsSchedule.TabIndex = 0;
            // 
            // pnlCrudButtons
            // 
            pnlCrudButtons.Controls.Add(btnDeleteFlight);
            pnlCrudButtons.Controls.Add(btnEditFlight);
            pnlCrudButtons.Controls.Add(btnAddFlight);
            pnlCrudButtons.Dock = DockStyle.Bottom;
            pnlCrudButtons.Location = new Point(25, 592);
            pnlCrudButtons.Name = "pnlCrudButtons";
            pnlCrudButtons.Size = new Size(522, 118);
            pnlCrudButtons.TabIndex = 2;
            // 
            // btnAddFlight
            // 
            btnAddFlight.BackColor = Color.FromArgb(46, 90, 136);
            btnAddFlight.FlatAppearance.BorderSize = 0;
            btnAddFlight.FlatStyle = FlatStyle.Flat;
            btnAddFlight.Font = new Font("Times New Roman", 14F, FontStyle.Bold, GraphicsUnit.Point, 204);
            btnAddFlight.ForeColor = Color.White;
            btnAddFlight.Location = new Point(0, 0);
            btnAddFlight.Margin = new Padding(10, 5, 10, 5);
            btnAddFlight.Name = "btnAddFlight";
            btnAddFlight.Size = new Size(530, 38);
            btnAddFlight.TabIndex = 0;
            btnAddFlight.Text = "Добавить рейс";
            btnAddFlight.UseVisualStyleBackColor = false;
            btnAddFlight.Click += btnAddFlight_Click;
            // 
            // btnEditFlight
            // 
            btnEditFlight.BackColor = Color.FromArgb(46, 90, 136);
            btnEditFlight.FlatAppearance.BorderSize = 0;
            btnEditFlight.FlatStyle = FlatStyle.Flat;
            btnEditFlight.Font = new Font("Times New Roman", 14F, FontStyle.Bold, GraphicsUnit.Point, 204);
            btnEditFlight.ForeColor = Color.White;
            btnEditFlight.Location = new Point(0, 41);
            btnEditFlight.Margin = new Padding(10, 5, 10, 5);
            btnEditFlight.Name = "btnEditFlight";
            btnEditFlight.Size = new Size(530, 38);
            btnEditFlight.TabIndex = 1;
            btnEditFlight.Text = "Редактировать рейс";
            btnEditFlight.UseVisualStyleBackColor = false;
            btnEditFlight.Click += btnEditFlight_Click;
            // 
            // btnDeleteFlight
            // 
            btnDeleteFlight.BackColor = Color.FromArgb(220, 38, 38);
            btnDeleteFlight.FlatAppearance.BorderSize = 0;
            btnDeleteFlight.FlatStyle = FlatStyle.Flat;
            btnDeleteFlight.Font = new Font("Times New Roman", 14F, FontStyle.Bold, GraphicsUnit.Point, 204);
            btnDeleteFlight.ForeColor = Color.White;
            btnDeleteFlight.Location = new Point(0, 80);
            btnDeleteFlight.Margin = new Padding(10, 5, 10, 5);
            btnDeleteFlight.Name = "btnDeleteFlight";
            btnDeleteFlight.Size = new Size(530, 38);
            btnDeleteFlight.TabIndex = 2;
            btnDeleteFlight.Text = "Удалить рейс";
            btnDeleteFlight.UseVisualStyleBackColor = false;
            btnDeleteFlight.Click += btnDeleteFlight_Click;
            // 
            // tableLayoutPanelMain
            // 
            tableLayoutPanelMain.ColumnCount = 2;
            tableLayoutPanelMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60F));
            tableLayoutPanelMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            tableLayoutPanelMain.Controls.Add(pnlAirportSection, 0, 0);
            tableLayoutPanelMain.Controls.Add(pnlScheduleSection, 1, 0);
            tableLayoutPanelMain.Dock = DockStyle.Fill;
            tableLayoutPanelMain.Location = new Point(0, 42);
            tableLayoutPanelMain.Name = "tableLayoutPanelMain";
            tableLayoutPanelMain.Padding = new Padding(15);
            tableLayoutPanelMain.RowCount = 1;
            tableLayoutPanelMain.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanelMain.Size = new Size(1496, 768);
            tableLayoutPanelMain.TabIndex = 2;
            // 
            // pnlAirportMapCanvas
            // 
            pnlAirportMapCanvas.BackColor = Color.FromArgb(248, 249, 250);
            pnlAirportMapCanvas.Controls.Add(lblAirportMapTitle);
            pnlAirportMapCanvas.Dock = DockStyle.Fill;
            pnlAirportMapCanvas.Location = new Point(20, 20);
            pnlAirportMapCanvas.Name = "pnlAirportMapCanvas";
            pnlAirportMapCanvas.Size = new Size(824, 690);
            pnlAirportMapCanvas.TabIndex = 0;
            // 
            // lblAirportMapTitle
            // 
            lblAirportMapTitle.AutoSize = true;
            lblAirportMapTitle.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            lblAirportMapTitle.ForeColor = Color.FromArgb(33, 37, 41);
            lblAirportMapTitle.Location = new Point(25, 25);
            lblAirportMapTitle.Margin = new Padding(4, 0, 4, 0);
            lblAirportMapTitle.Name = "lblAirportMapTitle";
            lblAirportMapTitle.Size = new Size(637, 41);
            lblAirportMapTitle.TabIndex = 0;
            lblAirportMapTitle.Text = "Схема аэропорта в реальном времени";
            // 
            // pnlAirportControls
            // 
            pnlAirportControls.Controls.Add(btnAllowLanding);
            pnlAirportControls.Controls.Add(btnAllowTakeoff);
            pnlAirportControls.Controls.Add(btnSuppliesManagement);
            pnlAirportControls.Controls.Add(btnMaintenance);
            pnlAirportControls.Dock = DockStyle.Bottom;
            pnlAirportControls.Location = new Point(20, 542);
            pnlAirportControls.Name = "pnlAirportControls";
            pnlAirportControls.Size = new Size(824, 168);
            pnlAirportControls.TabIndex = 1;
            // 
            // btnMaintenance
            // 
            btnMaintenance.BackColor = Color.FromArgb(46, 90, 136);
            btnMaintenance.FlatAppearance.BorderSize = 0;
            btnMaintenance.FlatStyle = FlatStyle.Flat;
            btnMaintenance.Font = new Font("Times New Roman", 14F, FontStyle.Bold, GraphicsUnit.Point, 204);
            btnMaintenance.ForeColor = Color.White;
            btnMaintenance.Location = new Point(12, 12);
            btnMaintenance.Margin = new Padding(10);
            btnMaintenance.Name = "btnMaintenance";
            btnMaintenance.Size = new Size(375, 68);
            btnMaintenance.TabIndex = 0;
            btnMaintenance.Text = "Техническое обслуживание";
            btnMaintenance.UseVisualStyleBackColor = false;
            btnMaintenance.Click += btnMaintenance_Click;
            // 
            // btnSuppliesManagement
            // 
            btnSuppliesManagement.BackColor = Color.FromArgb(46, 90, 136);
            btnSuppliesManagement.FlatAppearance.BorderSize = 0;
            btnSuppliesManagement.FlatStyle = FlatStyle.Flat;
            btnSuppliesManagement.Font = new Font("Times New Roman", 14F, FontStyle.Bold, GraphicsUnit.Point, 204);
            btnSuppliesManagement.ForeColor = Color.White;
            btnSuppliesManagement.Location = new Point(12, 90);
            btnSuppliesManagement.Margin = new Padding(10);
            btnSuppliesManagement.Name = "btnSuppliesManagement";
            btnSuppliesManagement.Size = new Size(375, 68);
            btnSuppliesManagement.TabIndex = 1;
            btnSuppliesManagement.Text = "Управление припасами";
            btnSuppliesManagement.UseVisualStyleBackColor = false;
            btnSuppliesManagement.Click += btnSuppliesManagement_Click;
            // 
            // btnAllowTakeoff
            // 
            btnAllowTakeoff.BackColor = Color.FromArgb(46, 90, 136);
            btnAllowTakeoff.FlatAppearance.BorderSize = 0;
            btnAllowTakeoff.FlatStyle = FlatStyle.Flat;
            btnAllowTakeoff.Font = new Font("Times New Roman", 14F, FontStyle.Bold, GraphicsUnit.Point, 204);
            btnAllowTakeoff.ForeColor = Color.White;
            btnAllowTakeoff.Location = new Point(440, 12);
            btnAllowTakeoff.Margin = new Padding(10);
            btnAllowTakeoff.Name = "btnAllowTakeoff";
            btnAllowTakeoff.Size = new Size(375, 68);
            btnAllowTakeoff.TabIndex = 2;
            btnAllowTakeoff.Text = "Разрешить взлёт";
            btnAllowTakeoff.UseVisualStyleBackColor = false;
            btnAllowTakeoff.Click += btnAllowTakeoff_Click;
            // 
            // btnAllowLanding
            // 
            btnAllowLanding.BackColor = Color.FromArgb(46, 90, 136);
            btnAllowLanding.FlatAppearance.BorderSize = 0;
            btnAllowLanding.FlatStyle = FlatStyle.Flat;
            btnAllowLanding.Font = new Font("Times New Roman", 14F, FontStyle.Bold, GraphicsUnit.Point, 204);
            btnAllowLanding.ForeColor = Color.White;
            btnAllowLanding.Location = new Point(440, 90);
            btnAllowLanding.Margin = new Padding(10);
            btnAllowLanding.Name = "btnAllowLanding";
            btnAllowLanding.Size = new Size(375, 68);
            btnAllowLanding.TabIndex = 3;
            btnAllowLanding.Text = "Разрешить посадку";
            btnAllowLanding.UseVisualStyleBackColor = false;
            btnAllowLanding.Click += btnAllowLanding_Click;
            // 
            // pnlAirportSection
            // 
            pnlAirportSection.BackColor = Color.White;
            pnlAirportSection.BorderStyle = BorderStyle.FixedSingle;
            pnlAirportSection.Controls.Add(pnlAirportControls);
            pnlAirportSection.Controls.Add(pnlAirportMapCanvas);
            pnlAirportSection.Dock = DockStyle.Fill;
            pnlAirportSection.Location = new Point(18, 18);
            pnlAirportSection.Margin = new Padding(3, 3, 10, 3);
            pnlAirportSection.Name = "pnlAirportSection";
            pnlAirportSection.Padding = new Padding(20);
            pnlAirportSection.Size = new Size(866, 732);
            pnlAirportSection.TabIndex = 0;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(15F, 33F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(248, 249, 250);
            ClientSize = new Size(1496, 850);
            Controls.Add(tableLayoutPanelMain);
            Controls.Add(statusMain);
            Controls.Add(menuMain);
            Font = new Font("Times New Roman", 14F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Margin = new Padding(4);
            MinimumSize = new Size(1200, 700);
            Name = "MainForm";
            Text = "АИС Аэропорт — Панель управления";
            Load += MainForm_Load;
            menuMain.ResumeLayout(false);
            menuMain.PerformLayout();
            statusMain.ResumeLayout(false);
            statusMain.PerformLayout();
            pnlScheduleSection.ResumeLayout(false);
            pnlScheduleSection.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvFlightsSchedule).EndInit();
            pnlCrudButtons.ResumeLayout(false);
            tableLayoutPanelMain.ResumeLayout(false);
            pnlAirportMapCanvas.ResumeLayout(false);
            pnlAirportMapCanvas.PerformLayout();
            pnlAirportControls.ResumeLayout(false);
            pnlAirportSection.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        // Semantic control names (English)
        private MenuStrip menuMain;                          // Main application menu
        private ToolStripMenuItem mnuSchedule;               // Schedule menu section
        private ToolStripMenuItem mnuRoutes;                 // Routes menu item
        private ToolStripMenuItem mnuHangars;                // Hangars menu item
        private ToolStripMenuItem mnuCrews;                  // Crews menu item
        private ToolStripMenuItem mnuReferences;             // References menu section
        private ToolStripMenuItem mnuCrewReference;          // Crew reference submenu
        private ToolStripMenuItem mnuSupportStaff;           // Support staff reference
        private ToolStripMenuItem mnuFlightStaff;            // Flight staff reference
        private ToolStripMenuItem mnuHangarReference;        // Hangar reference
        private ToolStripMenuItem mnuRouteReference;         // Route reference
        private ToolStripMenuItem mnuWarehouses;             // Warehouses menu section
        private ToolStripMenuItem mnuEquipment;              // Equipment reference
        private ToolStripMenuItem mnuSupplies;               // Supplies reference
        private StatusStrip statusMain;                      // Application status bar
        private ToolStripStatusLabel stsUser;                // Current user display
        private ToolStripStatusLabel stsSeparator1;          // Visual separator in status bar
        private ToolStripStatusLabel stsAirport;             // Current airport display
        private ToolStripStatusLabel stsSeparator2;          // Visual separator in status bar
        private ToolStripStatusLabel stsTime;                // Current time display (orange accent)
        private Panel pnlScheduleSection;
        private Panel pnlCrudButtons;
        private Button btnDeleteFlight;
        private Button btnEditFlight;
        private Button btnAddFlight;
        private Zuby.ADGV.AdvancedDataGridView dgvFlightsSchedule;
        private Label lblFlightsScheduleTitle;
        private TableLayoutPanel tableLayoutPanelMain;
        private Panel pnlAirportSection;
        private Panel pnlAirportControls;
        private Button btnAllowLanding;
        private Button btnAllowTakeoff;
        private Button btnSuppliesManagement;
        private Button btnMaintenance;
        private Panel pnlAirportMapCanvas;
        private Label lblAirportMapTitle;
    }
}