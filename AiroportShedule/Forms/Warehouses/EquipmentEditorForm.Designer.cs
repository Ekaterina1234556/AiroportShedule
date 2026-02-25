namespace AiroportShedule.Forms
{
    partial class EquipmentEditorForm
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
            lblName = new Label();
            txtName = new TextBox();
            lblDescription = new Label();
            txtDescription = new TextBox();
            lblHangar = new Label();
            cmbHangar = new ComboBox();
            lblIsWorking = new Label();
            chkIsWorking = new CheckBox();
            btnAction = new Button();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Times New Roman", 20F, FontStyle.Bold, GraphicsUnit.Point, 204);
            lblTitle.ForeColor = Color.FromArgb(33, 37, 41);
            lblTitle.Location = new Point(30, 25);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(482, 45);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Добавление оборудования";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Times New Roman", 14F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lblName.ForeColor = Color.FromArgb(33, 37, 41);
            lblName.Location = new Point(30, 100);
            lblName.Name = "lblName";
            lblName.Size = new Size(138, 33);
            lblName.TabIndex = 1;
            lblName.Text = "Название*";
            // 
            // txtName
            // 
            txtName.BackColor = Color.White;
            txtName.BorderStyle = BorderStyle.FixedSingle;
            txtName.Font = new Font("Times New Roman", 14F, FontStyle.Regular, GraphicsUnit.Point, 204);
            txtName.ForeColor = Color.FromArgb(33, 37, 41);
            txtName.Location = new Point(30, 145);
            txtName.Name = "txtName";
            txtName.Size = new Size(500, 40);
            txtName.TabIndex = 2;
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Font = new Font("Times New Roman", 14F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lblDescription.ForeColor = Color.FromArgb(33, 37, 41);
            lblDescription.Location = new Point(30, 205);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(131, 33);
            lblDescription.TabIndex = 3;
            lblDescription.Text = "Описание";
            // 
            // txtDescription
            // 
            txtDescription.BackColor = Color.White;
            txtDescription.BorderStyle = BorderStyle.FixedSingle;
            txtDescription.Font = new Font("Times New Roman", 14F, FontStyle.Regular, GraphicsUnit.Point, 204);
            txtDescription.ForeColor = Color.FromArgb(33, 37, 41);
            txtDescription.Location = new Point(30, 250);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(500, 120);
            txtDescription.TabIndex = 4;
            // 
            // lblHangar
            // 
            lblHangar.AutoSize = true;
            lblHangar.Font = new Font("Times New Roman", 14F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lblHangar.ForeColor = Color.FromArgb(33, 37, 41);
            lblHangar.Location = new Point(30, 390);
            lblHangar.Name = "lblHangar";
            lblHangar.Size = new Size(100, 33);
            lblHangar.TabIndex = 5;
            lblHangar.Text = "Ангар*";
            // 
            // cmbHangar
            // 
            cmbHangar.BackColor = Color.White;
            cmbHangar.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbHangar.Font = new Font("Times New Roman", 14F, FontStyle.Regular, GraphicsUnit.Point, 204);
            cmbHangar.ForeColor = Color.FromArgb(33, 37, 41);
            cmbHangar.FormattingEnabled = true;
            cmbHangar.Location = new Point(30, 435);
            cmbHangar.Name = "cmbHangar";
            cmbHangar.Size = new Size(500, 41);
            cmbHangar.TabIndex = 6;
            // 
            // lblIsWorking
            // 
            lblIsWorking.AutoSize = true;
            lblIsWorking.Font = new Font("Times New Roman", 14F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lblIsWorking.ForeColor = Color.FromArgb(33, 37, 41);
            lblIsWorking.Location = new Point(30, 495);
            lblIsWorking.Name = "lblIsWorking";
            lblIsWorking.Size = new Size(233, 33);
            lblIsWorking.TabIndex = 7;
            lblIsWorking.Text = "Состояние работы";
            // 
            // chkIsWorking
            // 
            chkIsWorking.AutoSize = true;
            chkIsWorking.Font = new Font("Times New Roman", 14F, FontStyle.Regular, GraphicsUnit.Point, 204);
            chkIsWorking.ForeColor = Color.FromArgb(33, 37, 41);
            chkIsWorking.Location = new Point(30, 540);
            chkIsWorking.Name = "chkIsWorking";
            chkIsWorking.Size = new Size(145, 37);
            chkIsWorking.TabIndex = 8;
            chkIsWorking.Text = "Работает";
            chkIsWorking.UseVisualStyleBackColor = true;
            // 
            // btnAction
            // 
            btnAction.BackColor = Color.FromArgb(46, 90, 136);
            btnAction.FlatAppearance.BorderSize = 0;
            btnAction.FlatStyle = FlatStyle.Flat;
            btnAction.Font = new Font("Times New Roman", 14F, FontStyle.Bold, GraphicsUnit.Point, 204);
            btnAction.ForeColor = Color.White;
            btnAction.Location = new Point(580, 435);
            btnAction.Name = "btnAction";
            btnAction.Size = new Size(280, 85);
            btnAction.TabIndex = 9;
            btnAction.Text = "Добавить оборудование";
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
            btnCancel.Location = new Point(580, 540);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(280, 78);
            btnCancel.TabIndex = 10;
            btnCancel.Text = "Отмена";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // EquipmentEditorForm
            // 
            AutoScaleDimensions = new SizeF(15F, 33F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(248, 249, 250);
            ClientSize = new Size(900, 630);
            Controls.Add(btnCancel);
            Controls.Add(btnAction);
            Controls.Add(chkIsWorking);
            Controls.Add(lblIsWorking);
            Controls.Add(cmbHangar);
            Controls.Add(lblHangar);
            Controls.Add(txtDescription);
            Controls.Add(lblDescription);
            Controls.Add(txtName);
            Controls.Add(lblName);
            Controls.Add(lblTitle);
            Font = new Font("Times New Roman", 14F, FontStyle.Regular, GraphicsUnit.Point, 204);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "EquipmentEditorForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Добавление оборудования — Аэропорт";
            Load += EquipmentEditorForm_Load;
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label lblHangar;
        private System.Windows.Forms.ComboBox cmbHangar;
        private System.Windows.Forms.Label lblIsWorking;
        private System.Windows.Forms.CheckBox chkIsWorking;
        private System.Windows.Forms.Button btnAction;
        private System.Windows.Forms.Button btnCancel;
    }
}