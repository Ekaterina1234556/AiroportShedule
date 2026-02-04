namespace AiroportShedule.Forms
{
    partial class WarehouseManagementForm
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
            tabControl = new TabControl();
            tabPageEquipment = new TabPage();
            pnlEquipmentButtons = new Panel();
            btnDeleteEquipment = new Button();
            btnEditEquipment = new Button();
            btnAddEquipment = new Button();
            dgvEquipment = new DataGridView();
            lblEquipmentTitle = new Label();
            tabPageSupplies = new TabPage();
            pnlSuppliesButtons = new Panel();
            btnDeleteSupply = new Button();
            btnEditSupply = new Button();
            btnAddSupply = new Button();
            dgvSupplies = new DataGridView();
            lblSuppliesTitle = new Label();
            lblTitle = new Label();
            tabControl.SuspendLayout();
            tabPageEquipment.SuspendLayout();
            pnlEquipmentButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEquipment).BeginInit();
            tabPageSupplies.SuspendLayout();
            pnlSuppliesButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSupplies).BeginInit();
            SuspendLayout();
            // 
            // tabControl
            // 
            tabControl.Controls.Add(tabPageEquipment);
            tabControl.Controls.Add(tabPageSupplies);
            tabControl.Font = new Font("Times New Roman", 14F, FontStyle.Regular, GraphicsUnit.Point, 204);
            tabControl.Location = new Point(30, 90);
            tabControl.Name = "tabControl";
            tabControl.SelectedIndex = 0;
            tabControl.Size = new Size(940, 620);
            tabControl.TabIndex = 0;
            // 
            // tabPageEquipment
            // 
            tabPageEquipment.BackColor = Color.FromArgb(248, 249, 250);
            tabPageEquipment.Controls.Add(pnlEquipmentButtons);
            tabPageEquipment.Controls.Add(dgvEquipment);
            tabPageEquipment.Controls.Add(lblEquipmentTitle);
            tabPageEquipment.Location = new Point(4, 42);
            tabPageEquipment.Name = "tabPageEquipment";
            tabPageEquipment.Padding = new Padding(3);
            tabPageEquipment.Size = new Size(932, 574);
            tabPageEquipment.TabIndex = 0;
            tabPageEquipment.Text = "Оборудование";
            // 
            // pnlEquipmentButtons
            // 
            pnlEquipmentButtons.Controls.Add(btnDeleteEquipment);
            pnlEquipmentButtons.Controls.Add(btnEditEquipment);
            pnlEquipmentButtons.Controls.Add(btnAddEquipment);
            pnlEquipmentButtons.Dock = DockStyle.Bottom;
            pnlEquipmentButtons.Location = new Point(3, 456);
            pnlEquipmentButtons.Name = "pnlEquipmentButtons";
            pnlEquipmentButtons.Size = new Size(926, 115);
            pnlEquipmentButtons.TabIndex = 2;
            // 
            // btnDeleteEquipment
            // 
            btnDeleteEquipment.BackColor = Color.FromArgb(220, 38, 38);
            btnDeleteEquipment.FlatAppearance.BorderSize = 0;
            btnDeleteEquipment.FlatStyle = FlatStyle.Flat;
            btnDeleteEquipment.Font = new Font("Times New Roman", 14F, FontStyle.Bold, GraphicsUnit.Point, 204);
            btnDeleteEquipment.ForeColor = Color.White;
            btnDeleteEquipment.Location = new Point(620, 10);
            btnDeleteEquipment.Name = "btnDeleteEquipment";
            btnDeleteEquipment.Size = new Size(290, 50);
            btnDeleteEquipment.TabIndex = 2;
            btnDeleteEquipment.Text = "Удалить оборудование";
            btnDeleteEquipment.UseVisualStyleBackColor = false;
            btnDeleteEquipment.Click += btnDeleteEquipment_Click;
            // 
            // btnEditEquipment
            // 
            btnEditEquipment.BackColor = Color.FromArgb(46, 90, 136);
            btnEditEquipment.FlatAppearance.BorderSize = 0;
            btnEditEquipment.FlatStyle = FlatStyle.Flat;
            btnEditEquipment.Font = new Font("Times New Roman", 14F, FontStyle.Bold, GraphicsUnit.Point, 204);
            btnEditEquipment.ForeColor = Color.White;
            btnEditEquipment.Location = new Point(320, 10);
            btnEditEquipment.Name = "btnEditEquipment";
            btnEditEquipment.Size = new Size(290, 50);
            btnEditEquipment.TabIndex = 1;
            btnEditEquipment.Text = "Редактировать";
            btnEditEquipment.UseVisualStyleBackColor = false;
            btnEditEquipment.Click += btnEditEquipment_Click;
            // 
            // btnAddEquipment
            // 
            btnAddEquipment.BackColor = Color.FromArgb(46, 90, 136);
            btnAddEquipment.FlatAppearance.BorderSize = 0;
            btnAddEquipment.FlatStyle = FlatStyle.Flat;
            btnAddEquipment.Font = new Font("Times New Roman", 14F, FontStyle.Bold, GraphicsUnit.Point, 204);
            btnAddEquipment.ForeColor = Color.White;
            btnAddEquipment.Location = new Point(20, 10);
            btnAddEquipment.Name = "btnAddEquipment";
            btnAddEquipment.Size = new Size(290, 50);
            btnAddEquipment.TabIndex = 0;
            btnAddEquipment.Text = "Добавить оборудование";
            btnAddEquipment.UseVisualStyleBackColor = false;
            btnAddEquipment.Click += btnAddEquipment_Click;
            // 
            // dgvEquipment
            // 
            dgvEquipment.BackgroundColor = Color.White;
            dgvEquipment.BorderStyle = BorderStyle.None;
            dgvEquipment.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvEquipment.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEquipment.Dock = DockStyle.Fill;
            dgvEquipment.Location = new Point(3, 3);
            dgvEquipment.Name = "dgvEquipment";
            dgvEquipment.RowHeadersWidth = 62;
            dgvEquipment.RowTemplate.Height = 35;
            dgvEquipment.Size = new Size(926, 568);
            dgvEquipment.TabIndex = 1;
            // 
            // lblEquipmentTitle
            // 
            lblEquipmentTitle.AutoSize = true;
            lblEquipmentTitle.Font = new Font("Times New Roman", 16F, FontStyle.Bold, GraphicsUnit.Point, 204);
            lblEquipmentTitle.ForeColor = Color.FromArgb(33, 37, 41);
            lblEquipmentTitle.Location = new Point(20, 20);
            lblEquipmentTitle.Name = "lblEquipmentTitle";
            lblEquipmentTitle.Size = new Size(326, 36);
            lblEquipmentTitle.TabIndex = 0;
            lblEquipmentTitle.Text = "Список оборудования";
            // 
            // tabPageSupplies
            // 
            tabPageSupplies.BackColor = Color.FromArgb(248, 249, 250);
            tabPageSupplies.Controls.Add(pnlSuppliesButtons);
            tabPageSupplies.Controls.Add(dgvSupplies);
            tabPageSupplies.Controls.Add(lblSuppliesTitle);
            tabPageSupplies.Location = new Point(4, 42);
            tabPageSupplies.Name = "tabPageSupplies";
            tabPageSupplies.Padding = new Padding(3);
            tabPageSupplies.Size = new Size(932, 574);
            tabPageSupplies.TabIndex = 1;
            tabPageSupplies.Text = "Припасы";
            // 
            // pnlSuppliesButtons
            // 
            pnlSuppliesButtons.Controls.Add(btnDeleteSupply);
            pnlSuppliesButtons.Controls.Add(btnEditSupply);
            pnlSuppliesButtons.Controls.Add(btnAddSupply);
            pnlSuppliesButtons.Dock = DockStyle.Bottom;
            pnlSuppliesButtons.Location = new Point(3, 456);
            pnlSuppliesButtons.Name = "pnlSuppliesButtons";
            pnlSuppliesButtons.Size = new Size(926, 115);
            pnlSuppliesButtons.TabIndex = 3;
            // 
            // btnDeleteSupply
            // 
            btnDeleteSupply.BackColor = Color.FromArgb(220, 38, 38);
            btnDeleteSupply.FlatAppearance.BorderSize = 0;
            btnDeleteSupply.FlatStyle = FlatStyle.Flat;
            btnDeleteSupply.Font = new Font("Times New Roman", 14F, FontStyle.Bold, GraphicsUnit.Point, 204);
            btnDeleteSupply.ForeColor = Color.White;
            btnDeleteSupply.Location = new Point(620, 10);
            btnDeleteSupply.Name = "btnDeleteSupply";
            btnDeleteSupply.Size = new Size(290, 50);
            btnDeleteSupply.TabIndex = 2;
            btnDeleteSupply.Text = "Удалить припас";
            btnDeleteSupply.UseVisualStyleBackColor = false;
            btnDeleteSupply.Click += btnDeleteSupply_Click;
            // 
            // btnEditSupply
            // 
            btnEditSupply.BackColor = Color.FromArgb(46, 90, 136);
            btnEditSupply.FlatAppearance.BorderSize = 0;
            btnEditSupply.FlatStyle = FlatStyle.Flat;
            btnEditSupply.Font = new Font("Times New Roman", 14F, FontStyle.Bold, GraphicsUnit.Point, 204);
            btnEditSupply.ForeColor = Color.White;
            btnEditSupply.Location = new Point(320, 10);
            btnEditSupply.Name = "btnEditSupply";
            btnEditSupply.Size = new Size(290, 50);
            btnEditSupply.TabIndex = 1;
            btnEditSupply.Text = "Редактировать";
            btnEditSupply.UseVisualStyleBackColor = false;
            btnEditSupply.Click += btnEditSupply_Click;
            // 
            // btnAddSupply
            // 
            btnAddSupply.BackColor = Color.FromArgb(46, 90, 136);
            btnAddSupply.FlatAppearance.BorderSize = 0;
            btnAddSupply.FlatStyle = FlatStyle.Flat;
            btnAddSupply.Font = new Font("Times New Roman", 14F, FontStyle.Bold, GraphicsUnit.Point, 204);
            btnAddSupply.ForeColor = Color.White;
            btnAddSupply.Location = new Point(20, 10);
            btnAddSupply.Name = "btnAddSupply";
            btnAddSupply.Size = new Size(290, 50);
            btnAddSupply.TabIndex = 0;
            btnAddSupply.Text = "Добавить припас";
            btnAddSupply.UseVisualStyleBackColor = false;
            btnAddSupply.Click += btnAddSupply_Click;
            // 
            // dgvSupplies
            // 
            dgvSupplies.BackgroundColor = Color.White;
            dgvSupplies.BorderStyle = BorderStyle.None;
            dgvSupplies.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvSupplies.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSupplies.Dock = DockStyle.Fill;
            dgvSupplies.Location = new Point(3, 3);
            dgvSupplies.Name = "dgvSupplies";
            dgvSupplies.RowHeadersWidth = 62;
            dgvSupplies.RowTemplate.Height = 35;
            dgvSupplies.Size = new Size(926, 568);
            dgvSupplies.TabIndex = 2;
            // 
            // lblSuppliesTitle
            // 
            lblSuppliesTitle.AutoSize = true;
            lblSuppliesTitle.Font = new Font("Times New Roman", 16F, FontStyle.Bold, GraphicsUnit.Point, 204);
            lblSuppliesTitle.ForeColor = Color.FromArgb(33, 37, 41);
            lblSuppliesTitle.Location = new Point(20, 20);
            lblSuppliesTitle.Name = "lblSuppliesTitle";
            lblSuppliesTitle.Size = new Size(264, 36);
            lblSuppliesTitle.TabIndex = 1;
            lblSuppliesTitle.Text = "Список припасов";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Times New Roman", 20F, FontStyle.Bold, GraphicsUnit.Point, 204);
            lblTitle.ForeColor = Color.FromArgb(33, 37, 41);
            lblTitle.Location = new Point(30, 25);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(419, 45);
            lblTitle.TabIndex = 1;
            lblTitle.Text = "Управление складами";
            // 
            // WarehouseManagementForm
            // 
            AutoScaleDimensions = new SizeF(15F, 33F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(248, 249, 250);
            ClientSize = new Size(1000, 740);
            Controls.Add(lblTitle);
            Controls.Add(tabControl);
            Font = new Font("Times New Roman", 14F, FontStyle.Regular, GraphicsUnit.Point, 204);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "WarehouseManagementForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Управление складами — Аэропорт";
            tabControl.ResumeLayout(false);
            tabPageEquipment.ResumeLayout(false);
            tabPageEquipment.PerformLayout();
            pnlEquipmentButtons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvEquipment).EndInit();
            tabPageSupplies.ResumeLayout(false);
            tabPageSupplies.PerformLayout();
            pnlSuppliesButtons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvSupplies).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPageEquipment;
        private System.Windows.Forms.TabPage tabPageSupplies;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.DataGridView dgvEquipment;
        private System.Windows.Forms.Label lblEquipmentTitle;
        private System.Windows.Forms.Panel pnlEquipmentButtons;
        private System.Windows.Forms.Button btnDeleteEquipment;
        private System.Windows.Forms.Button btnEditEquipment;
        private System.Windows.Forms.Button btnAddEquipment;
        private System.Windows.Forms.DataGridView dgvSupplies;
        private System.Windows.Forms.Label lblSuppliesTitle;
        private System.Windows.Forms.Panel pnlSuppliesButtons;
        private System.Windows.Forms.Button btnDeleteSupply;
        private System.Windows.Forms.Button btnEditSupply;
        private System.Windows.Forms.Button btnAddSupply;
    }
}