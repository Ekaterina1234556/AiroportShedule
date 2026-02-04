namespace AiroportShedule.Forms
{
    partial class SupplyEditorForm
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
            lblCategory = new Label();
            cmbCategory = new ComboBox();
            lblQuantity = new Label();
            numQuantity = new NumericUpDown();
            lblUnit = new Label();
            txtUnit = new TextBox();
            lblHangar = new Label();
            cmbHangar = new ComboBox();
            lblDescription = new Label();
            txtDescription = new TextBox();
            btnAction = new Button();
            btnCancel = new Button();
            ((System.ComponentModel.ISupportInitialize)numQuantity).BeginInit();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Times New Roman", 20F, FontStyle.Bold, GraphicsUnit.Point, 204);
            lblTitle.ForeColor = Color.FromArgb(33, 37, 41);
            lblTitle.Location = new Point(30, 25);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(390, 45);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Добавление припаса";
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
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.Font = new Font("Times New Roman", 14F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lblCategory.ForeColor = Color.FromArgb(33, 37, 41);
            lblCategory.Location = new Point(30, 205);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(135, 33);
            lblCategory.TabIndex = 3;
            lblCategory.Text = "Категория";
            // 
            // cmbCategory
            // 
            cmbCategory.BackColor = Color.White;
            cmbCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCategory.Font = new Font("Times New Roman", 14F, FontStyle.Regular, GraphicsUnit.Point, 204);
            cmbCategory.ForeColor = Color.FromArgb(33, 37, 41);
            cmbCategory.FormattingEnabled = true;
            cmbCategory.Items.AddRange(new object[] { "Топливо", "Масло", "Запчасти", "Инструменты", "Другое" });
            cmbCategory.Location = new Point(30, 250);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.Size = new Size(500, 41);
            cmbCategory.TabIndex = 4;
            // 
            // lblQuantity
            // 
            lblQuantity.AutoSize = true;
            lblQuantity.Font = new Font("Times New Roman", 14F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lblQuantity.ForeColor = Color.FromArgb(33, 37, 41);
            lblQuantity.Location = new Point(30, 310);
            lblQuantity.Name = "lblQuantity";
            lblQuantity.Size = new Size(154, 33);
            lblQuantity.TabIndex = 5;
            lblQuantity.Text = "Количество";
            // 
            // numQuantity
            // 
            numQuantity.Font = new Font("Times New Roman", 14F, FontStyle.Regular, GraphicsUnit.Point, 204);
            numQuantity.Location = new Point(30, 355);
            numQuantity.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            numQuantity.Name = "numQuantity";
            numQuantity.Size = new Size(200, 40);
            numQuantity.TabIndex = 6;
            numQuantity.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // lblUnit
            // 
            lblUnit.AutoSize = true;
            lblUnit.Font = new Font("Times New Roman", 14F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lblUnit.ForeColor = Color.FromArgb(33, 37, 41);
            lblUnit.Location = new Point(250, 310);
            lblUnit.Name = "lblUnit";
            lblUnit.Size = new Size(185, 33);
            lblUnit.TabIndex = 7;
            lblUnit.Text = "Ед. измерения";
            // 
            // txtUnit
            // 
            txtUnit.BackColor = Color.White;
            txtUnit.BorderStyle = BorderStyle.FixedSingle;
            txtUnit.Font = new Font("Times New Roman", 14F, FontStyle.Regular, GraphicsUnit.Point, 204);
            txtUnit.ForeColor = Color.FromArgb(33, 37, 41);
            txtUnit.Location = new Point(250, 355);
            txtUnit.Name = "txtUnit";
            txtUnit.Size = new Size(280, 40);
            txtUnit.TabIndex = 8;
            txtUnit.Text = "шт.";
            // 
            // lblHangar
            // 
            lblHangar.AutoSize = true;
            lblHangar.Font = new Font("Times New Roman", 14F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lblHangar.ForeColor = Color.FromArgb(33, 37, 41);
            lblHangar.Location = new Point(30, 415);
            lblHangar.Name = "lblHangar";
            lblHangar.Size = new Size(100, 33);
            lblHangar.TabIndex = 9;
            lblHangar.Text = "Ангар*";
            // 
            // cmbHangar
            // 
            cmbHangar.BackColor = Color.White;
            cmbHangar.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbHangar.Font = new Font("Times New Roman", 14F, FontStyle.Regular, GraphicsUnit.Point, 204);
            cmbHangar.ForeColor = Color.FromArgb(33, 37, 41);
            cmbHangar.FormattingEnabled = true;
            cmbHangar.Location = new Point(30, 460);
            cmbHangar.Name = "cmbHangar";
            cmbHangar.Size = new Size(500, 41);
            cmbHangar.TabIndex = 10;
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Font = new Font("Times New Roman", 14F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lblDescription.ForeColor = Color.FromArgb(33, 37, 41);
            lblDescription.Location = new Point(30, 520);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(131, 33);
            lblDescription.TabIndex = 11;
            lblDescription.Text = "Описание";
            // 
            // txtDescription
            // 
            txtDescription.BackColor = Color.White;
            txtDescription.BorderStyle = BorderStyle.FixedSingle;
            txtDescription.Font = new Font("Times New Roman", 14F, FontStyle.Regular, GraphicsUnit.Point, 204);
            txtDescription.ForeColor = Color.FromArgb(33, 37, 41);
            txtDescription.Location = new Point(30, 565);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(500, 100);
            txtDescription.TabIndex = 12;
            // 
            // btnAction
            // 
            btnAction.BackColor = Color.FromArgb(46, 90, 136);
            btnAction.FlatAppearance.BorderSize = 0;
            btnAction.FlatStyle = FlatStyle.Flat;
            btnAction.Font = new Font("Times New Roman", 14F, FontStyle.Bold, GraphicsUnit.Point, 204);
            btnAction.ForeColor = Color.White;
            btnAction.Location = new Point(580, 585);
            btnAction.Name = "btnAction";
            btnAction.Size = new Size(280, 60);
            btnAction.TabIndex = 13;
            btnAction.Text = "Добавить припас";
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
            btnCancel.Location = new Point(580, 665);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(280, 60);
            btnCancel.TabIndex = 14;
            btnCancel.Text = "Отмена";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // SupplyEditorForm
            // 
            AutoScaleDimensions = new SizeF(15F, 33F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(248, 249, 250);
            ClientSize = new Size(900, 755);
            Controls.Add(btnCancel);
            Controls.Add(btnAction);
            Controls.Add(txtDescription);
            Controls.Add(lblDescription);
            Controls.Add(cmbHangar);
            Controls.Add(lblHangar);
            Controls.Add(txtUnit);
            Controls.Add(lblUnit);
            Controls.Add(numQuantity);
            Controls.Add(lblQuantity);
            Controls.Add(cmbCategory);
            Controls.Add(lblCategory);
            Controls.Add(txtName);
            Controls.Add(lblName);
            Controls.Add(lblTitle);
            Font = new Font("Times New Roman", 14F, FontStyle.Regular, GraphicsUnit.Point, 204);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "SupplyEditorForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Добавление припаса — Аэропорт";
            Load += SupplyEditorForm_Load;
            Click += SupplyEditorForm_Load;
            ((System.ComponentModel.ISupportInitialize)numQuantity).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.ComboBox cmbCategory;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.NumericUpDown numQuantity;
        private System.Windows.Forms.Label lblUnit;
        private System.Windows.Forms.TextBox txtUnit;
        private System.Windows.Forms.Label lblHangar;
        private System.Windows.Forms.ComboBox cmbHangar;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Button btnAction;
        private System.Windows.Forms.Button btnCancel;
    }
}