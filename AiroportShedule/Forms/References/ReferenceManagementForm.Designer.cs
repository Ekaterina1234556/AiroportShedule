namespace AiroportShedule.Forms
{
    partial class ReferenceManagementForm
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
            lblTitle = new Label();
            tabControl = new TabControl();
            tabPageFlightCrew = new TabPage();
            pnlFlightCrewButtons = new Panel();
            btnDeleteFlightCrew = new Button();
            btnEditFlightCrew = new Button();
            btnAddFlightCrew = new Button();
            dgvFlightCrew = new DataGridView();
            tabPageSupportCrew = new TabPage();
            pnlSupportCrewButtons = new Panel();
            btnDeleteSupportCrew = new Button();
            btnEditSupportCrew = new Button();
            btnAddSupportCrew = new Button();
            dgvSupportCrew = new DataGridView();
            tabPageSingleList = new TabPage();
            pnlSingleListButtons = new Panel();
            btnDeleteSingle = new Button();
            btnEditSingle = new Button();
            btnAddSingle = new Button();
            dgvSingleList = new DataGridView();
            lblListTitle = new Label();
            tabControl.SuspendLayout();
            tabPageFlightCrew.SuspendLayout();
            pnlFlightCrewButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvFlightCrew).BeginInit();
            tabPageSupportCrew.SuspendLayout();
            pnlSupportCrewButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSupportCrew).BeginInit();
            tabPageSingleList.SuspendLayout();
            pnlSingleListButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSingleList).BeginInit();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Times New Roman", 20F, FontStyle.Bold, GraphicsUnit.Point, 204);
            lblTitle.ForeColor = Color.FromArgb(33, 37, 41);
            lblTitle.Location = new Point(30, 25);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(430, 45);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Справочник экипажей";
            // 
            // tabControl
            // 
            tabControl.Controls.Add(tabPageFlightCrew);
            tabControl.Controls.Add(tabPageSupportCrew);
            tabControl.Controls.Add(tabPageSingleList);
            tabControl.Font = new Font("Times New Roman", 14F, FontStyle.Regular, GraphicsUnit.Point, 204);
            tabControl.Location = new Point(30, 90);
            tabControl.Name = "tabControl";
            tabControl.SelectedIndex = 0;
            tabControl.Size = new Size(940, 620);
            tabControl.TabIndex = 1;
            // 
            // tabPageFlightCrew
            // 
            tabPageFlightCrew.BackColor = Color.FromArgb(248, 249, 250);
            tabPageFlightCrew.Controls.Add(pnlFlightCrewButtons);
            tabPageFlightCrew.Controls.Add(dgvFlightCrew);
            tabPageFlightCrew.Location = new Point(4, 42);
            tabPageFlightCrew.Name = "tabPageFlightCrew";
            tabPageFlightCrew.Padding = new Padding(3);
            tabPageFlightCrew.Size = new Size(932, 574);
            tabPageFlightCrew.TabIndex = 0;
            tabPageFlightCrew.Text = "Полётный персонал";
            // 
            // pnlFlightCrewButtons
            // 
            pnlFlightCrewButtons.Controls.Add(btnDeleteFlightCrew);
            pnlFlightCrewButtons.Controls.Add(btnEditFlightCrew);
            pnlFlightCrewButtons.Controls.Add(btnAddFlightCrew);
            pnlFlightCrewButtons.Dock = DockStyle.Bottom;
            pnlFlightCrewButtons.Location = new Point(3, 456);
            pnlFlightCrewButtons.Name = "pnlFlightCrewButtons";
            pnlFlightCrewButtons.Size = new Size(926, 115);
            pnlFlightCrewButtons.TabIndex = 2;
            // 
            // btnDeleteFlightCrew
            // 
            btnDeleteFlightCrew.BackColor = Color.FromArgb(220, 38, 38);
            btnDeleteFlightCrew.FlatAppearance.BorderSize = 0;
            btnDeleteFlightCrew.FlatStyle = FlatStyle.Flat;
            btnDeleteFlightCrew.Font = new Font("Times New Roman", 14F, FontStyle.Bold, GraphicsUnit.Point, 204);
            btnDeleteFlightCrew.ForeColor = Color.White;
            btnDeleteFlightCrew.Location = new Point(620, 10);
            btnDeleteFlightCrew.Name = "btnDeleteFlightCrew";
            btnDeleteFlightCrew.Size = new Size(290, 87);
            btnDeleteFlightCrew.TabIndex = 2;
            btnDeleteFlightCrew.Text = "Удалить";
            btnDeleteFlightCrew.UseVisualStyleBackColor = false;
            btnDeleteFlightCrew.Click += btnDeleteFlightCrew_Click;
            // 
            // btnEditFlightCrew
            // 
            btnEditFlightCrew.BackColor = Color.FromArgb(46, 90, 136);
            btnEditFlightCrew.FlatAppearance.BorderSize = 0;
            btnEditFlightCrew.FlatStyle = FlatStyle.Flat;
            btnEditFlightCrew.Font = new Font("Times New Roman", 14F, FontStyle.Bold, GraphicsUnit.Point, 204);
            btnEditFlightCrew.ForeColor = Color.White;
            btnEditFlightCrew.Location = new Point(320, 10);
            btnEditFlightCrew.Name = "btnEditFlightCrew";
            btnEditFlightCrew.Size = new Size(290, 87);
            btnEditFlightCrew.TabIndex = 1;
            btnEditFlightCrew.Text = "Редактировать";
            btnEditFlightCrew.UseVisualStyleBackColor = false;
            btnEditFlightCrew.Click += btnEditFlightCrew_Click;
            // 
            // btnAddFlightCrew
            // 
            btnAddFlightCrew.BackColor = Color.FromArgb(46, 90, 136);
            btnAddFlightCrew.FlatAppearance.BorderSize = 0;
            btnAddFlightCrew.FlatStyle = FlatStyle.Flat;
            btnAddFlightCrew.Font = new Font("Times New Roman", 14F, FontStyle.Bold, GraphicsUnit.Point, 204);
            btnAddFlightCrew.ForeColor = Color.White;
            btnAddFlightCrew.Location = new Point(20, 10);
            btnAddFlightCrew.Name = "btnAddFlightCrew";
            btnAddFlightCrew.Size = new Size(290, 87);
            btnAddFlightCrew.TabIndex = 0;
            btnAddFlightCrew.Text = "Добавить";
            btnAddFlightCrew.UseVisualStyleBackColor = false;
            btnAddFlightCrew.Click += btnAddFlightCrew_Click;
            // 
            // dgvFlightCrew
            // 
            dgvFlightCrew.BackgroundColor = Color.White;
            dgvFlightCrew.BorderStyle = BorderStyle.None;
            dgvFlightCrew.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvFlightCrew.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvFlightCrew.Dock = DockStyle.Fill;
            dgvFlightCrew.Location = new Point(3, 3);
            dgvFlightCrew.Name = "dgvFlightCrew";
            dgvFlightCrew.RowHeadersWidth = 62;
            dgvFlightCrew.RowTemplate.Height = 35;
            dgvFlightCrew.Size = new Size(926, 568);
            dgvFlightCrew.TabIndex = 1;
            dgvFlightCrew.CellContentClick += dgvFlightCrew_CellContentClick;
            // 
            // tabPageSupportCrew
            // 
            tabPageSupportCrew.BackColor = Color.FromArgb(248, 249, 250);
            tabPageSupportCrew.Controls.Add(pnlSupportCrewButtons);
            tabPageSupportCrew.Controls.Add(dgvSupportCrew);
            tabPageSupportCrew.Location = new Point(4, 42);
            tabPageSupportCrew.Name = "tabPageSupportCrew";
            tabPageSupportCrew.Padding = new Padding(3);
            tabPageSupportCrew.Size = new Size(932, 574);
            tabPageSupportCrew.TabIndex = 1;
            tabPageSupportCrew.Text = "Обслуживающий персонал";
            // 
            // pnlSupportCrewButtons
            // 
            pnlSupportCrewButtons.Controls.Add(btnDeleteSupportCrew);
            pnlSupportCrewButtons.Controls.Add(btnEditSupportCrew);
            pnlSupportCrewButtons.Controls.Add(btnAddSupportCrew);
            pnlSupportCrewButtons.Dock = DockStyle.Bottom;
            pnlSupportCrewButtons.Location = new Point(3, 456);
            pnlSupportCrewButtons.Name = "pnlSupportCrewButtons";
            pnlSupportCrewButtons.Size = new Size(926, 115);
            pnlSupportCrewButtons.TabIndex = 3;
            // 
            // btnDeleteSupportCrew
            // 
            btnDeleteSupportCrew.BackColor = Color.FromArgb(220, 38, 38);
            btnDeleteSupportCrew.FlatAppearance.BorderSize = 0;
            btnDeleteSupportCrew.FlatStyle = FlatStyle.Flat;
            btnDeleteSupportCrew.Font = new Font("Times New Roman", 14F, FontStyle.Bold, GraphicsUnit.Point, 204);
            btnDeleteSupportCrew.ForeColor = Color.White;
            btnDeleteSupportCrew.Location = new Point(620, 10);
            btnDeleteSupportCrew.Name = "btnDeleteSupportCrew";
            btnDeleteSupportCrew.Size = new Size(290, 88);
            btnDeleteSupportCrew.TabIndex = 2;
            btnDeleteSupportCrew.Text = "Удалить";
            btnDeleteSupportCrew.UseVisualStyleBackColor = false;
            btnDeleteSupportCrew.Click += btnDeleteSupportCrew_Click;
            // 
            // btnEditSupportCrew
            // 
            btnEditSupportCrew.BackColor = Color.FromArgb(46, 90, 136);
            btnEditSupportCrew.FlatAppearance.BorderSize = 0;
            btnEditSupportCrew.FlatStyle = FlatStyle.Flat;
            btnEditSupportCrew.Font = new Font("Times New Roman", 14F, FontStyle.Bold, GraphicsUnit.Point, 204);
            btnEditSupportCrew.ForeColor = Color.White;
            btnEditSupportCrew.Location = new Point(320, 10);
            btnEditSupportCrew.Name = "btnEditSupportCrew";
            btnEditSupportCrew.Size = new Size(290, 88);
            btnEditSupportCrew.TabIndex = 1;
            btnEditSupportCrew.Text = "Редактировать";
            btnEditSupportCrew.UseVisualStyleBackColor = false;
            btnEditSupportCrew.Click += btnEditSupportCrew_Click;
            // 
            // btnAddSupportCrew
            // 
            btnAddSupportCrew.BackColor = Color.FromArgb(46, 90, 136);
            btnAddSupportCrew.FlatAppearance.BorderSize = 0;
            btnAddSupportCrew.FlatStyle = FlatStyle.Flat;
            btnAddSupportCrew.Font = new Font("Times New Roman", 14F, FontStyle.Bold, GraphicsUnit.Point, 204);
            btnAddSupportCrew.ForeColor = Color.White;
            btnAddSupportCrew.Location = new Point(20, 10);
            btnAddSupportCrew.Name = "btnAddSupportCrew";
            btnAddSupportCrew.Size = new Size(290, 88);
            btnAddSupportCrew.TabIndex = 0;
            btnAddSupportCrew.Text = "Добавить";
            btnAddSupportCrew.UseVisualStyleBackColor = false;
            btnAddSupportCrew.Click += btnAddSupportCrew_Click;
            // 
            // dgvSupportCrew
            // 
            dgvSupportCrew.BackgroundColor = Color.White;
            dgvSupportCrew.BorderStyle = BorderStyle.None;
            dgvSupportCrew.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvSupportCrew.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSupportCrew.Dock = DockStyle.Fill;
            dgvSupportCrew.Location = new Point(3, 3);
            dgvSupportCrew.Name = "dgvSupportCrew";
            dgvSupportCrew.RowHeadersWidth = 62;
            dgvSupportCrew.RowTemplate.Height = 35;
            dgvSupportCrew.Size = new Size(926, 568);
            dgvSupportCrew.TabIndex = 2;
            // 
            // tabPageSingleList
            // 
            tabPageSingleList.BackColor = Color.FromArgb(248, 249, 250);
            tabPageSingleList.Controls.Add(pnlSingleListButtons);
            tabPageSingleList.Controls.Add(dgvSingleList);
            tabPageSingleList.Controls.Add(lblListTitle);
            tabPageSingleList.Location = new Point(4, 42);
            tabPageSingleList.Name = "tabPageSingleList";
            tabPageSingleList.Padding = new Padding(3);
            tabPageSingleList.Size = new Size(932, 574);
            tabPageSingleList.TabIndex = 2;
            tabPageSingleList.Text = "Ангары";
            // 
            // pnlSingleListButtons
            // 
            pnlSingleListButtons.Controls.Add(btnDeleteSingle);
            pnlSingleListButtons.Controls.Add(btnEditSingle);
            pnlSingleListButtons.Controls.Add(btnAddSingle);
            pnlSingleListButtons.Dock = DockStyle.Bottom;
            pnlSingleListButtons.Location = new Point(3, 456);
            pnlSingleListButtons.Name = "pnlSingleListButtons";
            pnlSingleListButtons.Size = new Size(926, 115);
            pnlSingleListButtons.TabIndex = 3;
            // 
            // btnDeleteSingle
            // 
            btnDeleteSingle.BackColor = Color.FromArgb(220, 38, 38);
            btnDeleteSingle.FlatAppearance.BorderSize = 0;
            btnDeleteSingle.FlatStyle = FlatStyle.Flat;
            btnDeleteSingle.Font = new Font("Times New Roman", 14F, FontStyle.Bold, GraphicsUnit.Point, 204);
            btnDeleteSingle.ForeColor = Color.White;
            btnDeleteSingle.Location = new Point(620, 10);
            btnDeleteSingle.Name = "btnDeleteSingle";
            btnDeleteSingle.Size = new Size(290, 89);
            btnDeleteSingle.TabIndex = 2;
            btnDeleteSingle.Text = "Удалить";
            btnDeleteSingle.UseVisualStyleBackColor = false;
            btnDeleteSingle.Click += btnDeleteHangar_Click;
            // 
            // btnEditSingle
            // 
            btnEditSingle.BackColor = Color.FromArgb(46, 90, 136);
            btnEditSingle.FlatAppearance.BorderSize = 0;
            btnEditSingle.FlatStyle = FlatStyle.Flat;
            btnEditSingle.Font = new Font("Times New Roman", 14F, FontStyle.Bold, GraphicsUnit.Point, 204);
            btnEditSingle.ForeColor = Color.White;
            btnEditSingle.Location = new Point(320, 10);
            btnEditSingle.Name = "btnEditSingle";
            btnEditSingle.Size = new Size(290, 89);
            btnEditSingle.TabIndex = 1;
            btnEditSingle.Text = "Редактировать";
            btnEditSingle.UseVisualStyleBackColor = false;
            btnEditSingle.Click += btnEditHangar_Click;
            // 
            // btnAddSingle
            // 
            btnAddSingle.BackColor = Color.FromArgb(46, 90, 136);
            btnAddSingle.FlatAppearance.BorderSize = 0;
            btnAddSingle.FlatStyle = FlatStyle.Flat;
            btnAddSingle.Font = new Font("Times New Roman", 14F, FontStyle.Bold, GraphicsUnit.Point, 204);
            btnAddSingle.ForeColor = Color.White;
            btnAddSingle.Location = new Point(20, 10);
            btnAddSingle.Name = "btnAddSingle";
            btnAddSingle.Size = new Size(290, 89);
            btnAddSingle.TabIndex = 0;
            btnAddSingle.Text = "Добавить";
            btnAddSingle.UseVisualStyleBackColor = false;
            btnAddSingle.Click += btnAddHangar_Click;
            // 
            // dgvSingleList
            // 
            dgvSingleList.BackgroundColor = Color.White;
            dgvSingleList.BorderStyle = BorderStyle.None;
            dgvSingleList.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvSingleList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSingleList.Dock = DockStyle.Fill;
            dgvSingleList.Location = new Point(3, 3);
            dgvSingleList.Name = "dgvSingleList";
            dgvSingleList.RowHeadersWidth = 62;
            dgvSingleList.RowTemplate.Height = 35;
            dgvSingleList.Size = new Size(926, 568);
            dgvSingleList.TabIndex = 2;
            // 
            // lblListTitle
            // 
            lblListTitle.AutoSize = true;
            lblListTitle.Font = new Font("Times New Roman", 16F, FontStyle.Bold, GraphicsUnit.Point, 204);
            lblListTitle.ForeColor = Color.FromArgb(33, 37, 41);
            lblListTitle.Location = new Point(20, 20);
            lblListTitle.Name = "lblListTitle";
            lblListTitle.Size = new Size(278, 36);
            lblListTitle.TabIndex = 0;
            lblListTitle.Text = "Список персонала";
            // 
            // ReferenceManagementForm
            // 
            AutoScaleDimensions = new SizeF(15F, 33F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(248, 249, 250);
            ClientSize = new Size(1000, 740);
            Controls.Add(tabControl);
            Controls.Add(lblTitle);
            Font = new Font("Times New Roman", 14F, FontStyle.Regular, GraphicsUnit.Point, 204);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ReferenceManagementForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Справочник экипажей — Аэропорт";
            tabControl.ResumeLayout(false);
            tabPageFlightCrew.ResumeLayout(false);
            pnlFlightCrewButtons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvFlightCrew).EndInit();
            tabPageSupportCrew.ResumeLayout(false);
            pnlSupportCrewButtons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvSupportCrew).EndInit();
            tabPageSingleList.ResumeLayout(false);
            tabPageSingleList.PerformLayout();
            pnlSingleListButtons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvSingleList).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPageFlightCrew;
        private System.Windows.Forms.TabPage tabPageSupportCrew;
        private System.Windows.Forms.TabPage tabPageSingleList;
        private System.Windows.Forms.DataGridView dgvFlightCrew;
        private System.Windows.Forms.Label lblListTitle;
        private System.Windows.Forms.Panel pnlFlightCrewButtons;
        private System.Windows.Forms.Button btnDeleteFlightCrew;
        private System.Windows.Forms.Button btnEditFlightCrew;
        private System.Windows.Forms.Button btnAddFlightCrew;
        private System.Windows.Forms.DataGridView dgvSupportCrew;
        private System.Windows.Forms.Panel pnlSupportCrewButtons;
        private System.Windows.Forms.Button btnDeleteSupportCrew;
        private System.Windows.Forms.Button btnEditSupportCrew;
        private System.Windows.Forms.Button btnAddSupportCrew;
        private System.Windows.Forms.DataGridView dgvSingleList;
        private System.Windows.Forms.Panel pnlSingleListButtons;
        private System.Windows.Forms.Button btnDeleteSingle;
        private System.Windows.Forms.Button btnEditSingle;
        private System.Windows.Forms.Button btnAddSingle;
    }
}