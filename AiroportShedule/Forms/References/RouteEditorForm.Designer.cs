namespace AiroportShedule.Forms
{
    partial class RouteEditorForm
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
            lblRouteName = new Label();
            txtRouteName = new TextBox();
            lblExample = new Label();
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
            lblTitle.Size = new Size(424, 45);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Добавление маршрута";
            // 
            // lblRouteName
            // 
            lblRouteName.AutoSize = true;
            lblRouteName.Font = new Font("Times New Roman", 14F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lblRouteName.ForeColor = Color.FromArgb(33, 37, 41);
            lblRouteName.Location = new Point(30, 100);
            lblRouteName.Name = "lblRouteName";
            lblRouteName.Size = new Size(141, 33);
            lblRouteName.TabIndex = 1;
            lblRouteName.Text = "Маршрут*";
            // 
            // txtRouteName
            // 
            txtRouteName.BackColor = Color.White;
            txtRouteName.BorderStyle = BorderStyle.FixedSingle;
            txtRouteName.Font = new Font("Times New Roman", 14F, FontStyle.Regular, GraphicsUnit.Point, 204);
            txtRouteName.ForeColor = Color.FromArgb(33, 37, 41);
            txtRouteName.Location = new Point(30, 145);
            txtRouteName.Name = "txtRouteName";
            txtRouteName.Size = new Size(500, 40);
            txtRouteName.TabIndex = 2;
            // 
            // lblExample
            // 
            lblExample.AutoSize = true;
            lblExample.Font = new Font("Times New Roman", 12F, FontStyle.Italic, GraphicsUnit.Point, 204);
            lblExample.ForeColor = Color.FromArgb(108, 117, 125);
            lblExample.Location = new Point(30, 195);
            lblExample.Name = "lblExample";
            lblExample.Size = new Size(389, 27);
            lblExample.TabIndex = 3;
            lblExample.Text = "Пример: Москва - Санкт-Петербург";
            // 
            // btnAction
            // 
            btnAction.BackColor = Color.FromArgb(46, 90, 136);
            btnAction.FlatAppearance.BorderSize = 0;
            btnAction.FlatStyle = FlatStyle.Flat;
            btnAction.Font = new Font("Times New Roman", 14F, FontStyle.Bold, GraphicsUnit.Point, 204);
            btnAction.ForeColor = Color.White;
            btnAction.Location = new Point(580, 145);
            btnAction.Name = "btnAction";
            btnAction.Size = new Size(280, 60);
            btnAction.TabIndex = 4;
            btnAction.Text = "Добавить маршрут";
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
            btnCancel.Location = new Point(580, 225);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(280, 60);
            btnCancel.TabIndex = 5;
            btnCancel.Text = "Отмена";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // RouteEditorForm
            // 
            AutoScaleDimensions = new SizeF(15F, 33F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(248, 249, 250);
            ClientSize = new Size(900, 350);
            Controls.Add(btnCancel);
            Controls.Add(btnAction);
            Controls.Add(lblExample);
            Controls.Add(txtRouteName);
            Controls.Add(lblRouteName);
            Controls.Add(lblTitle);
            Font = new Font("Times New Roman", 14F, FontStyle.Regular, GraphicsUnit.Point, 204);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "RouteEditorForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Добавление маршрута — Аэропорт";
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblRouteName;
        private System.Windows.Forms.TextBox txtRouteName;
        private System.Windows.Forms.Label lblExample;
        private System.Windows.Forms.Button btnAction;
        private System.Windows.Forms.Button btnCancel;
    }
}