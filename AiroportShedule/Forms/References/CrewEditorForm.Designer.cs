namespace AiroportShedule.Forms
{
    partial class CrewEditorForm
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
            lblFullName = new Label();
            txtFullName = new TextBox();
            lblRole = new Label();
            cmbRole = new ComboBox();
            lblFlightHours = new Label();
            numFlightHours = new NumericUpDown();
            lblExperience = new Label();
            numExperience = new NumericUpDown();
            lblLogin = new Label();
            txtLogin = new TextBox();
            lblPassword = new Label();
            txtPassword = new TextBox();
            btnAction = new Button();
            btnCancel = new Button();
            ((System.ComponentModel.ISupportInitialize)numFlightHours).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numExperience).BeginInit();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Times New Roman", 20F, FontStyle.Bold, GraphicsUnit.Point, 204);
            lblTitle.ForeColor = Color.FromArgb(33, 37, 41);
            lblTitle.Location = new Point(30, 25);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(367, 45);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Добавление пилота";
            // 
            // lblFullName
            // 
            lblFullName.AutoSize = true;
            lblFullName.Font = new Font("Times New Roman", 14F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lblFullName.ForeColor = Color.FromArgb(33, 37, 41);
            lblFullName.Location = new Point(30, 100);
            lblFullName.Name = "lblFullName";
            lblFullName.Size = new Size(90, 33);
            lblFullName.TabIndex = 1;
            lblFullName.Text = "ФИО*";
            // 
            // txtFullName
            // 
            txtFullName.BackColor = Color.White;
            txtFullName.BorderStyle = BorderStyle.FixedSingle;
            txtFullName.Font = new Font("Times New Roman", 14F, FontStyle.Regular, GraphicsUnit.Point, 204);
            txtFullName.ForeColor = Color.FromArgb(33, 37, 41);
            txtFullName.Location = new Point(30, 145);
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(500, 40);
            txtFullName.TabIndex = 2;
            // 
            // lblRole
            // 
            lblRole.AutoSize = true;
            lblRole.Font = new Font("Times New Roman", 14F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lblRole.ForeColor = Color.FromArgb(33, 37, 41);
            lblRole.Location = new Point(30, 205);
            lblRole.Name = "lblRole";
            lblRole.Size = new Size(148, 33);
            lblRole.TabIndex = 3;
            lblRole.Text = "Должность";
            // 
            // cmbRole
            // 
            cmbRole.BackColor = Color.White;
            cmbRole.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbRole.Font = new Font("Times New Roman", 14F, FontStyle.Regular, GraphicsUnit.Point, 204);
            cmbRole.ForeColor = Color.FromArgb(33, 37, 41);
            cmbRole.FormattingEnabled = true;
            cmbRole.Location = new Point(30, 250);
            cmbRole.Name = "cmbRole";
            cmbRole.Size = new Size(500, 41);
            cmbRole.TabIndex = 4;
            // 
            // lblFlightHours
            // 
            lblFlightHours.AutoSize = true;
            lblFlightHours.Font = new Font("Times New Roman", 14F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lblFlightHours.ForeColor = Color.FromArgb(33, 37, 41);
            lblFlightHours.Location = new Point(30, 310);
            lblFlightHours.Name = "lblFlightHours";
            lblFlightHours.Size = new Size(91, 33);
            lblFlightHours.TabIndex = 5;
            lblFlightHours.Text = "На лёт";
            // 
            // numFlightHours
            // 
            numFlightHours.Font = new Font("Times New Roman", 14F, FontStyle.Regular, GraphicsUnit.Point, 204);
            numFlightHours.Location = new Point(30, 355);
            numFlightHours.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            numFlightHours.Name = "numFlightHours";
            numFlightHours.Size = new Size(200, 40);
            numFlightHours.TabIndex = 6;
            // 
            // lblExperience
            // 
            lblExperience.AutoSize = true;
            lblExperience.Font = new Font("Times New Roman", 14F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lblExperience.ForeColor = Color.FromArgb(33, 37, 41);
            lblExperience.Location = new Point(250, 310);
            lblExperience.Name = "lblExperience";
            lblExperience.Size = new Size(77, 33);
            lblExperience.TabIndex = 7;
            lblExperience.Text = "Стаж";
            // 
            // numExperience
            // 
            numExperience.Font = new Font("Times New Roman", 14F, FontStyle.Regular, GraphicsUnit.Point, 204);
            numExperience.Location = new Point(250, 355);
            numExperience.Maximum = new decimal(new int[] { 50, 0, 0, 0 });
            numExperience.Name = "numExperience";
            numExperience.Size = new Size(120, 40);
            numExperience.TabIndex = 8;
            // 
            // lblLogin
            // 
            lblLogin.AutoSize = true;
            lblLogin.Font = new Font("Times New Roman", 14F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lblLogin.ForeColor = Color.FromArgb(33, 37, 41);
            lblLogin.Location = new Point(30, 415);
            lblLogin.Name = "lblLogin";
            lblLogin.Size = new Size(102, 33);
            lblLogin.TabIndex = 9;
            lblLogin.Text = "Логин*";
            // 
            // txtLogin
            // 
            txtLogin.BackColor = Color.White;
            txtLogin.BorderStyle = BorderStyle.FixedSingle;
            txtLogin.Font = new Font("Times New Roman", 14F, FontStyle.Regular, GraphicsUnit.Point, 204);
            txtLogin.ForeColor = Color.FromArgb(33, 37, 41);
            txtLogin.Location = new Point(30, 460);
            txtLogin.Name = "txtLogin";
            txtLogin.Size = new Size(250, 40);
            txtLogin.TabIndex = 10;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Times New Roman", 14F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lblPassword.ForeColor = Color.FromArgb(33, 37, 41);
            lblPassword.Location = new Point(300, 415);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(101, 33);
            lblPassword.TabIndex = 11;
            lblPassword.Text = "Пароль";
            // 
            // txtPassword
            // 
            txtPassword.BackColor = Color.White;
            txtPassword.BorderStyle = BorderStyle.FixedSingle;
            txtPassword.Font = new Font("Times New Roman", 14F, FontStyle.Regular, GraphicsUnit.Point, 204);
            txtPassword.ForeColor = Color.FromArgb(33, 37, 41);
            txtPassword.Location = new Point(300, 460);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(230, 40);
            txtPassword.TabIndex = 12;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // btnAction
            // 
            btnAction.BackColor = Color.FromArgb(46, 90, 136);
            btnAction.FlatAppearance.BorderSize = 0;
            btnAction.FlatStyle = FlatStyle.Flat;
            btnAction.Font = new Font("Times New Roman", 14F, FontStyle.Bold, GraphicsUnit.Point, 204);
            btnAction.ForeColor = Color.White;
            btnAction.Location = new Point(594, 250);
            btnAction.Name = "btnAction";
            btnAction.Size = new Size(280, 105);
            btnAction.TabIndex = 13;
            btnAction.Text = "Добавить сотрудника";
            btnAction.UseVisualStyleBackColor = false;
            btnAction.Click += btnAction_Click;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.FromArgb(248, 249, 250);
            btnCancel.FlatAppearance.BorderColor = Color.FromArgb(46, 90, 136);
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Times New Roman", 14F, FontStyle.Bold, GraphicsUnit.Point, 204);
            btnCancel.ForeColor = Color.FromArgb(46, 90, 136);
            btnCancel.Location = new Point(594, 397);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(280, 103);
            btnCancel.TabIndex = 14;
            btnCancel.Text = "Отмена";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // CrewEditorForm
            // 
            AutoScaleDimensions = new SizeF(15F, 33F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(248, 249, 250);
            ClientSize = new Size(900, 549);
            Controls.Add(btnCancel);
            Controls.Add(btnAction);
            Controls.Add(txtPassword);
            Controls.Add(lblPassword);
            Controls.Add(txtLogin);
            Controls.Add(lblLogin);
            Controls.Add(numExperience);
            Controls.Add(lblExperience);
            Controls.Add(numFlightHours);
            Controls.Add(lblFlightHours);
            Controls.Add(cmbRole);
            Controls.Add(lblRole);
            Controls.Add(txtFullName);
            Controls.Add(lblFullName);
            Controls.Add(lblTitle);
            Font = new Font("Times New Roman", 14F, FontStyle.Regular, GraphicsUnit.Point, 204);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "CrewEditorForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Добавление пилота — Аэропорт";
            Load += CrewEditorForm_Load;
            ((System.ComponentModel.ISupportInitialize)numFlightHours).EndInit();
            ((System.ComponentModel.ISupportInitialize)numExperience).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblFullName;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.Label lblRole;
        private System.Windows.Forms.ComboBox cmbRole;
        private System.Windows.Forms.Label lblFlightHours;
        private System.Windows.Forms.NumericUpDown numFlightHours;
        private System.Windows.Forms.Label lblExperience;
        private System.Windows.Forms.NumericUpDown numExperience;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnAction;
        private System.Windows.Forms.Button btnCancel;
    }
}