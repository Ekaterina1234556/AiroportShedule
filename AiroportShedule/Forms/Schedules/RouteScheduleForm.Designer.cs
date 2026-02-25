namespace AiroportShedule.Forms
{
    partial class RouteScheduleForm
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
            pnlButtons = new Panel();
            btnAllowLanding = new Button();
            btnAllowTakeoff = new Button();
            btnDelete = new Button();
            btnEdit = new Button();
            btnAdd = new Button();
            dgvSchedule = new DataGridView();
            pnlFilter = new Panel();
            lblDateFilter = new Label();
            dtpFilterDate = new DateTimePicker();
            pnlButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSchedule).BeginInit();
            pnlFilter.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Times New Roman", 20F, FontStyle.Bold, GraphicsUnit.Point, 204);
            lblTitle.ForeColor = Color.FromArgb(33, 37, 41);
            lblTitle.Location = new Point(30, 25);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(557, 45);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Расписание воздушных путей";
            // 
            // pnlButtons
            // 
            pnlButtons.Controls.Add(btnAllowLanding);
            pnlButtons.Controls.Add(btnAllowTakeoff);
            pnlButtons.Controls.Add(btnDelete);
            pnlButtons.Controls.Add(btnEdit);
            pnlButtons.Controls.Add(btnAdd);
            pnlButtons.Dock = DockStyle.Bottom;
            pnlButtons.Location = new Point(0, 680);
            pnlButtons.Name = "pnlButtons";
            pnlButtons.Size = new Size(1200, 100);
            pnlButtons.TabIndex = 1;
            // 
            // btnAllowLanding
            // 
            btnAllowLanding.BackColor = Color.FromArgb(59, 130, 246);
            btnAllowLanding.FlatAppearance.BorderSize = 0;
            btnAllowLanding.FlatStyle = FlatStyle.Flat;
            btnAllowLanding.Font = new Font("Times New Roman", 14F, FontStyle.Bold, GraphicsUnit.Point, 204);
            btnAllowLanding.ForeColor = Color.White;
            btnAllowLanding.Location = new Point(950, 10);
            btnAllowLanding.Name = "btnAllowLanding";
            btnAllowLanding.Size = new Size(230, 78);
            btnAllowLanding.TabIndex = 4;
            btnAllowLanding.Text = "Разрешить посадку";
            btnAllowLanding.UseVisualStyleBackColor = false;
            btnAllowLanding.Click += btnAllowLanding_Click;
            // 
            // btnAllowTakeoff
            // 
            btnAllowTakeoff.BackColor = Color.FromArgb(34, 197, 94);
            btnAllowTakeoff.FlatAppearance.BorderSize = 0;
            btnAllowTakeoff.FlatStyle = FlatStyle.Flat;
            btnAllowTakeoff.Font = new Font("Times New Roman", 14F, FontStyle.Bold, GraphicsUnit.Point, 204);
            btnAllowTakeoff.ForeColor = Color.White;
            btnAllowTakeoff.Location = new Point(700, 10);
            btnAllowTakeoff.Name = "btnAllowTakeoff";
            btnAllowTakeoff.Size = new Size(230, 78);
            btnAllowTakeoff.TabIndex = 3;
            btnAllowTakeoff.Text = "Разрешить взлёт";
            btnAllowTakeoff.UseVisualStyleBackColor = false;
            btnAllowTakeoff.Click += btnAllowTakeoff_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.FromArgb(220, 38, 38);
            btnDelete.FlatAppearance.BorderSize = 0;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Font = new Font("Times New Roman", 14F, FontStyle.Bold, GraphicsUnit.Point, 204);
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(450, 10);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(230, 80);
            btnDelete.TabIndex = 2;
            btnDelete.Text = "Удалить рейс";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnEdit
            // 
            btnEdit.BackColor = Color.FromArgb(46, 90, 136);
            btnEdit.FlatAppearance.BorderSize = 0;
            btnEdit.FlatStyle = FlatStyle.Flat;
            btnEdit.Font = new Font("Times New Roman", 14F, FontStyle.Bold, GraphicsUnit.Point, 204);
            btnEdit.ForeColor = Color.White;
            btnEdit.Location = new Point(230, 10);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(200, 80);
            btnEdit.TabIndex = 1;
            btnEdit.Text = "Редактировать";
            btnEdit.UseVisualStyleBackColor = false;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.FromArgb(46, 90, 136);
            btnAdd.FlatAppearance.BorderSize = 0;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("Times New Roman", 14F, FontStyle.Bold, GraphicsUnit.Point, 204);
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(12, 10);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(200, 80);
            btnAdd.TabIndex = 0;
            btnAdd.Text = "Добавить рейс";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // dgvSchedule
            // 
            dgvSchedule.BackgroundColor = Color.White;
            dgvSchedule.BorderStyle = BorderStyle.None;
            dgvSchedule.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvSchedule.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSchedule.Dock = DockStyle.Fill;
            dgvSchedule.Location = new Point(0, 61);
            dgvSchedule.Name = "dgvSchedule";
            dgvSchedule.RowHeadersWidth = 62;
            dgvSchedule.RowTemplate.Height = 35;
            dgvSchedule.Size = new Size(1200, 619);
            dgvSchedule.TabIndex = 2;
            // 
            // pnlFilter
            // 
            pnlFilter.Controls.Add(lblDateFilter);
            pnlFilter.Controls.Add(dtpFilterDate);
            pnlFilter.Dock = DockStyle.Top;
            pnlFilter.Location = new Point(0, 0);
            pnlFilter.Name = "pnlFilter";
            pnlFilter.Size = new Size(1200, 61);
            pnlFilter.TabIndex = 3;
            // 
            // lblDateFilter
            // 
            lblDateFilter.AutoSize = true;
            lblDateFilter.Font = new Font("Times New Roman", 14F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lblDateFilter.ForeColor = Color.FromArgb(33, 37, 41);
            lblDateFilter.Location = new Point(30, 15);
            lblDateFilter.Name = "lblDateFilter";
            lblDateFilter.Size = new Size(204, 33);
            lblDateFilter.TabIndex = 1;
            lblDateFilter.Text = "Фильтр по дате:";
            // 
            // dtpFilterDate
            // 
            dtpFilterDate.CalendarFont = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            dtpFilterDate.Font = new Font("Times New Roman", 14F, FontStyle.Regular, GraphicsUnit.Point, 204);
            dtpFilterDate.Format = DateTimePickerFormat.Short;
            dtpFilterDate.Location = new Point(240, 9);
            dtpFilterDate.Name = "dtpFilterDate";
            dtpFilterDate.Size = new Size(200, 40);
            dtpFilterDate.TabIndex = 0;
            // 
            // RouteScheduleForm
            // 
            AutoScaleDimensions = new SizeF(15F, 33F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(248, 249, 250);
            ClientSize = new Size(1200, 780);
            Controls.Add(dgvSchedule);
            Controls.Add(pnlFilter);
            Controls.Add(pnlButtons);
            Controls.Add(lblTitle);
            Font = new Font("Times New Roman", 14F, FontStyle.Regular, GraphicsUnit.Point, 204);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "RouteScheduleForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Расписание воздушных путей — Аэропорт";
            pnlButtons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvSchedule).EndInit();
            pnlFilter.ResumeLayout(false);
            pnlFilter.PerformLayout();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel pnlButtons;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.DataGridView dgvSchedule;
        private System.Windows.Forms.Panel pnlFilter;
        private System.Windows.Forms.Label lblDateFilter;
        private System.Windows.Forms.DateTimePicker dtpFilterDate;
        private System.Windows.Forms.Button btnAllowTakeoff;
        private System.Windows.Forms.Button btnAllowLanding;
    }
}