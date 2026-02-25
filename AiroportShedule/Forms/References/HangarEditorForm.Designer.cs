namespace AiroportShedule.Forms
{
    partial class HangarEditorForm
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
            lblType = new Label();
            cmbType = new ComboBox();
            lblSize = new Label();
            txtSize = new TextBox();
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
            lblTitle.Size = new Size(364, 45);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Добавление ангара";
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
            // lblType
            // 
            lblType.AutoSize = true;
            lblType.Font = new Font("Times New Roman", 14F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lblType.ForeColor = Color.FromArgb(33, 37, 41);
            lblType.Location = new Point(30, 205);
            lblType.Name = "lblType";
            lblType.Size = new Size(74, 33);
            lblType.TabIndex = 3;
            lblType.Text = "Тип*";
            // 
            // cmbType
            // 
            cmbType.BackColor = Color.White;
            cmbType.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbType.Font = new Font("Times New Roman", 14F, FontStyle.Regular, GraphicsUnit.Point, 204);
            cmbType.ForeColor = Color.FromArgb(33, 37, 41);
            cmbType.FormattingEnabled = true;
            cmbType.Items.AddRange(new object[] { "Открытый", "Закрытый" });
            cmbType.Location = new Point(30, 250);
            cmbType.Name = "cmbType";
            cmbType.Size = new Size(500, 41);
            cmbType.TabIndex = 4;
            // 
            // lblSize
            // 
            lblSize.AutoSize = true;
            lblSize.Font = new Font("Times New Roman", 14F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lblSize.ForeColor = Color.FromArgb(33, 37, 41);
            lblSize.Location = new Point(30, 310);
            lblSize.Name = "lblSize";
            lblSize.Size = new Size(98, 33);
            lblSize.TabIndex = 5;
            lblSize.Text = "Размер";
            // 
            // txtSize
            // 
            txtSize.BackColor = Color.White;
            txtSize.BorderStyle = BorderStyle.FixedSingle;
            txtSize.Font = new Font("Times New Roman", 14F, FontStyle.Regular, GraphicsUnit.Point, 204);
            txtSize.ForeColor = Color.FromArgb(33, 37, 41);
            txtSize.Location = new Point(30, 355);
            txtSize.Name = "txtSize";
            txtSize.Size = new Size(500, 40);
            txtSize.TabIndex = 6;
            // 
            // btnAction
            // 
            btnAction.BackColor = Color.FromArgb(46, 90, 136);
            btnAction.FlatAppearance.BorderSize = 0;
            btnAction.FlatStyle = FlatStyle.Flat;
            btnAction.Font = new Font("Times New Roman", 14F, FontStyle.Bold, GraphicsUnit.Point, 204);
            btnAction.ForeColor = Color.White;
            btnAction.Location = new Point(580, 250);
            btnAction.Name = "btnAction";
            btnAction.Size = new Size(280, 60);
            btnAction.TabIndex = 7;
            btnAction.Text = "Добавить ангар";
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
            btnCancel.Location = new Point(580, 335);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(280, 60);
            btnCancel.TabIndex = 8;
            btnCancel.Text = "Отмена";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // HangarEditorForm
            // 
            AutoScaleDimensions = new SizeF(15F, 33F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(248, 249, 250);
            ClientSize = new Size(900, 450);
            Controls.Add(btnCancel);
            Controls.Add(btnAction);
            Controls.Add(txtSize);
            Controls.Add(lblSize);
            Controls.Add(cmbType);
            Controls.Add(lblType);
            Controls.Add(txtName);
            Controls.Add(lblName);
            Controls.Add(lblTitle);
            Font = new Font("Times New Roman", 14F, FontStyle.Regular, GraphicsUnit.Point, 204);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "HangarEditorForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Добавление ангара — Аэропорт";
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.ComboBox cmbType;
        private System.Windows.Forms.Label lblSize;
        private System.Windows.Forms.TextBox txtSize;
        private System.Windows.Forms.Button btnAction;
        private System.Windows.Forms.Button btnCancel;
    }
}