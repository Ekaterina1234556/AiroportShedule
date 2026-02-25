namespace AiroportShedule.Forms
{
    partial class HangarScheduleForm
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
            btnMarkComplete = new Button();
            btnDelete = new Button();
            btnEdit = new Button();
            btnAdd = new Button();
            dgvSchedule = new DataGridView();
            pnlFilter = new Panel();
            lblHangarFilter = new Label();
            cmbHangarFilter = new ComboBox();
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
            lblTitle.Size = new Size(524, 45);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Расписание работ в ангарах";
            // 
            // pnlButtons
            // 
            pnlButtons.Controls.Add(btnMarkComplete);
            pnlButtons.Controls.Add(btnDelete);
            pnlButtons.Controls.Add(btnEdit);
            pnlButtons.Controls.Add(btnAdd);
            pnlButtons.Dock = DockStyle.Bottom;
            pnlButtons.Location = new Point(0, 680);
            pnlButtons.Name = "pnlButtons";
            pnlButtons.Size = new Size(1200, 100);
            pnlButtons.TabIndex = 1;
            // 
            // btnMarkComplete
            // 
            btnMarkComplete.BackColor = Color.Gray;
            btnMarkComplete.FlatAppearance.BorderSize = 0;
            btnMarkComplete.FlatStyle = FlatStyle.Flat;
            btnMarkComplete.Font = new Font("Times New Roman", 14F, FontStyle.Bold, GraphicsUnit.Point, 204);
            btnMarkComplete.ForeColor = Color.White;
            btnMarkComplete.Location = new Point(958, 7);
            btnMarkComplete.Name = "btnMarkComplete";
            btnMarkComplete.Size = new Size(230, 82);
            btnMarkComplete.TabIndex = 3;
            btnMarkComplete.Text = "Отметить выполнено";
            btnMarkComplete.UseVisualStyleBackColor = false;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.FromArgb(220, 38, 38);
            btnDelete.FlatAppearance.BorderSize = 0;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Font = new Font("Times New Roman", 14F, FontStyle.Bold, GraphicsUnit.Point, 204);
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(715, 7);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(226, 82);
            btnDelete.TabIndex = 2;
            btnDelete.Text = "Удалить запись";
            btnDelete.UseVisualStyleBackColor = false;
            // 
            // btnEdit
            // 
            btnEdit.BackColor = Color.FromArgb(46, 90, 136);
            btnEdit.FlatAppearance.BorderSize = 0;
            btnEdit.FlatStyle = FlatStyle.Flat;
            btnEdit.Font = new Font("Times New Roman", 14F, FontStyle.Bold, GraphicsUnit.Point, 204);
            btnEdit.ForeColor = Color.White;
            btnEdit.Location = new Point(425, 7);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(271, 81);
            btnEdit.TabIndex = 1;
            btnEdit.Text = "Редактировать";
            btnEdit.UseVisualStyleBackColor = false;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.FromArgb(46, 90, 136);
            btnAdd.FlatAppearance.BorderSize = 0;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("Times New Roman", 14F, FontStyle.Bold, GraphicsUnit.Point, 204);
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(128, 6);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(280, 82);
            btnAdd.TabIndex = 0;
            btnAdd.Text = "Добавить запись";
            btnAdd.UseVisualStyleBackColor = false;
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
            pnlFilter.Controls.Add(lblHangarFilter);
            pnlFilter.Controls.Add(cmbHangarFilter);
            pnlFilter.Dock = DockStyle.Top;
            pnlFilter.Location = new Point(0, 0);
            pnlFilter.Name = "pnlFilter";
            pnlFilter.Size = new Size(1200, 61);
            pnlFilter.TabIndex = 3;
            // 
            // lblHangarFilter
            // 
            lblHangarFilter.AutoSize = true;
            lblHangarFilter.Font = new Font("Times New Roman", 14F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lblHangarFilter.ForeColor = Color.FromArgb(33, 37, 41);
            lblHangarFilter.Location = new Point(30, 15);
            lblHangarFilter.Name = "lblHangarFilter";
            lblHangarFilter.Size = new Size(94, 33);
            lblHangarFilter.TabIndex = 1;
            lblHangarFilter.Text = "Ангар:";
            // 
            // cmbHangarFilter
            // 
            cmbHangarFilter.BackColor = Color.White;
            cmbHangarFilter.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbHangarFilter.Font = new Font("Times New Roman", 14F, FontStyle.Regular, GraphicsUnit.Point, 204);
            cmbHangarFilter.ForeColor = Color.FromArgb(33, 37, 41);
            cmbHangarFilter.FormattingEnabled = true;
            cmbHangarFilter.Location = new Point(150, 10);
            cmbHangarFilter.Name = "cmbHangarFilter";
            cmbHangarFilter.Size = new Size(300, 41);
            cmbHangarFilter.TabIndex = 0;
            // 
            // HangarScheduleForm
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
            Name = "HangarScheduleForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Расписание работ в ангарах — Аэропорт";
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
        private System.Windows.Forms.Label lblHangarFilter;
        private System.Windows.Forms.ComboBox cmbHangarFilter;
        private System.Windows.Forms.Button btnMarkComplete;
    }
}