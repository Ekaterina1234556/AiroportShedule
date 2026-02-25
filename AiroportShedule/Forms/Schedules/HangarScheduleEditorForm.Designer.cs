namespace AiroportShedule.Forms
{
    partial class HangarScheduleEditorForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            lblTitle = new Label();
            lblTimeInterval = new Label();
            txtTimeInterval = new TextBox();
            lblHangar = new Label();
            cmbHangar = new ComboBox();
            lblAircraft = new Label();
            cmbAircraft = new ComboBox();
            lblPersonnel = new Label();
            cmbPersonnel = new ComboBox();
            lblDescription = new Label();
            txtDescription = new TextBox();
            btnAction = new Button();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Times New Roman", 20F, FontStyle.Bold);
            lblTitle.ForeColor = Color.FromArgb(33, 37, 41);
            lblTitle.Location = new Point(30, 25);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(508, 45);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Добавление записи в ангар";
            // 
            // lblTimeInterval
            // 
            lblTimeInterval.AutoSize = true;
            lblTimeInterval.Font = new Font("Times New Roman", 14F);
            lblTimeInterval.ForeColor = Color.FromArgb(33, 37, 41);
            lblTimeInterval.Location = new Point(30, 100);
            lblTimeInterval.Name = "lblTimeInterval";
            lblTimeInterval.Size = new Size(277, 33);
            lblTimeInterval.TabIndex = 1;
            lblTimeInterval.Text = "Временной интервал*";
            // 
            // txtTimeInterval
            // 
            txtTimeInterval.BackColor = Color.White;
            txtTimeInterval.BorderStyle = BorderStyle.FixedSingle;
            txtTimeInterval.Font = new Font("Times New Roman", 14F);
            txtTimeInterval.ForeColor = Color.FromArgb(33, 37, 41);
            txtTimeInterval.Location = new Point(30, 145);
            txtTimeInterval.Name = "txtTimeInterval";
            txtTimeInterval.Size = new Size(500, 40);
            txtTimeInterval.TabIndex = 2;
            txtTimeInterval.Text = "09:00 - 12:00";
            // 
            // lblHangar
            // 
            lblHangar.AutoSize = true;
            lblHangar.Font = new Font("Times New Roman", 14F);
            lblHangar.ForeColor = Color.FromArgb(33, 37, 41);
            lblHangar.Location = new Point(30, 205);
            lblHangar.Name = "lblHangar";
            lblHangar.Size = new Size(100, 33);
            lblHangar.TabIndex = 3;
            lblHangar.Text = "Ангар*";
            // 
            // cmbHangar
            // 
            cmbHangar.BackColor = Color.White;
            cmbHangar.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbHangar.Font = new Font("Times New Roman", 14F);
            cmbHangar.ForeColor = Color.FromArgb(33, 37, 41);
            cmbHangar.FormattingEnabled = true;
            cmbHangar.Location = new Point(30, 250);
            cmbHangar.Name = "cmbHangar";
            cmbHangar.Size = new Size(500, 41);
            cmbHangar.TabIndex = 4;
            // 
            // lblAircraft
            // 
            lblAircraft.AutoSize = true;
            lblAircraft.Font = new Font("Times New Roman", 14F);
            lblAircraft.ForeColor = Color.FromArgb(33, 37, 41);
            lblAircraft.Location = new Point(30, 310);
            lblAircraft.Name = "lblAircraft";
            lblAircraft.Size = new Size(235, 33);
            lblAircraft.TabIndex = 5;
            lblAircraft.Text = "Воздушное судно*";
            // 
            // cmbAircraft
            // 
            cmbAircraft.BackColor = Color.White;
            cmbAircraft.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbAircraft.Font = new Font("Times New Roman", 14F);
            cmbAircraft.ForeColor = Color.FromArgb(33, 37, 41);
            cmbAircraft.FormattingEnabled = true;
            cmbAircraft.Location = new Point(30, 355);
            cmbAircraft.Name = "cmbAircraft";
            cmbAircraft.Size = new Size(500, 41);
            cmbAircraft.TabIndex = 6;
            // 
            // lblPersonnel
            // 
            lblPersonnel.AutoSize = true;
            lblPersonnel.Font = new Font("Times New Roman", 14F);
            lblPersonnel.ForeColor = Color.FromArgb(33, 37, 41);
            lblPersonnel.Location = new Point(30, 415);
            lblPersonnel.Name = "lblPersonnel";
            lblPersonnel.Size = new Size(141, 33);
            lblPersonnel.TabIndex = 7;
            lblPersonnel.Text = "Персонал*";
            // 
            // cmbPersonnel
            // 
            cmbPersonnel.BackColor = Color.White;
            cmbPersonnel.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPersonnel.Font = new Font("Times New Roman", 14F);
            cmbPersonnel.ForeColor = Color.FromArgb(33, 37, 41);
            cmbPersonnel.FormattingEnabled = true;
            cmbPersonnel.Location = new Point(30, 460);
            cmbPersonnel.Name = "cmbPersonnel";
            cmbPersonnel.Size = new Size(500, 41);
            cmbPersonnel.TabIndex = 8;
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Font = new Font("Times New Roman", 14F);
            lblDescription.ForeColor = Color.FromArgb(33, 37, 41);
            lblDescription.Location = new Point(30, 520);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(131, 33);
            lblDescription.TabIndex = 9;
            lblDescription.Text = "Описание";
            // 
            // txtDescription
            // 
            txtDescription.BackColor = Color.White;
            txtDescription.BorderStyle = BorderStyle.FixedSingle;
            txtDescription.Font = new Font("Times New Roman", 14F);
            txtDescription.ForeColor = Color.FromArgb(33, 37, 41);
            txtDescription.Location = new Point(30, 565);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(500, 100);
            txtDescription.TabIndex = 10;
            // 
            // btnAction
            // 
            btnAction.BackColor = Color.FromArgb(46, 90, 136);
            btnAction.FlatAppearance.BorderSize = 0;
            btnAction.FlatStyle = FlatStyle.Flat;
            btnAction.Font = new Font("Times New Roman", 14F, FontStyle.Bold);
            btnAction.ForeColor = Color.White;
            btnAction.Location = new Point(590, 488);
            btnAction.Name = "btnAction";
            btnAction.Size = new Size(280, 74);
            btnAction.TabIndex = 11;
            btnAction.Text = "Добавить запись";
            btnAction.UseVisualStyleBackColor = false;
            btnAction.Click += btnAction_Click;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.FromArgb(248, 249, 250);
            btnCancel.FlatAppearance.BorderColor = Color.FromArgb(46, 90, 136);
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Times New Roman", 14F, FontStyle.Bold);
            btnCancel.ForeColor = Color.FromArgb(46, 90, 136);
            btnCancel.Location = new Point(590, 593);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(280, 72);
            btnCancel.TabIndex = 12;
            btnCancel.Text = "Отмена";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // HangarScheduleEditorForm
            // 
            AutoScaleDimensions = new SizeF(15F, 33F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(248, 249, 250);
            ClientSize = new Size(900, 692);
            Controls.Add(btnCancel);
            Controls.Add(btnAction);
            Controls.Add(txtDescription);
            Controls.Add(lblDescription);
            Controls.Add(cmbPersonnel);
            Controls.Add(lblPersonnel);
            Controls.Add(cmbAircraft);
            Controls.Add(lblAircraft);
            Controls.Add(cmbHangar);
            Controls.Add(lblHangar);
            Controls.Add(txtTimeInterval);
            Controls.Add(lblTimeInterval);
            Controls.Add(lblTitle);
            Font = new Font("Times New Roman", 14F);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "HangarScheduleEditorForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Добавление записи в ангар — Аэропорт";
            Load += HangarScheduleEditorForm_Load;
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblTimeInterval;
        private System.Windows.Forms.TextBox txtTimeInterval;
        private System.Windows.Forms.Label lblHangar;
        private System.Windows.Forms.ComboBox cmbHangar;
        private System.Windows.Forms.Label lblAircraft;
        private System.Windows.Forms.ComboBox cmbAircraft;
        private System.Windows.Forms.Label lblPersonnel;
        private System.Windows.Forms.ComboBox cmbPersonnel;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Button btnAction;
        private System.Windows.Forms.Button btnCancel;
    }
}