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
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblTimeInterval = new System.Windows.Forms.Label();
            this.txtTimeInterval = new System.Windows.Forms.TextBox();
            this.lblHangar = new System.Windows.Forms.Label();
            this.cmbHangar = new System.Windows.Forms.ComboBox();
            this.lblAircraft = new System.Windows.Forms.Label();
            this.cmbAircraft = new System.Windows.Forms.ComboBox();
            this.lblPersonnel = new System.Windows.Forms.Label();
            this.cmbPersonnel = new System.Windows.Forms.ComboBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.btnAction = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.lblTitle.Location = new System.Drawing.Point(30, 25);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(480, 46);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Добавление записи в ангар";
            // 
            // lblTimeInterval
            // 
            this.lblTimeInterval.AutoSize = true;
            this.lblTimeInterval.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.lblTimeInterval.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.lblTimeInterval.Location = new System.Drawing.Point(30, 100);
            this.lblTimeInterval.Name = "lblTimeInterval";
            this.lblTimeInterval.Size = new System.Drawing.Size(240, 33);
            this.lblTimeInterval.TabIndex = 1;
            this.lblTimeInterval.Text = "Временной интервал*";
            // 
            // txtTimeInterval
            // 
            this.txtTimeInterval.BackColor = System.Drawing.Color.White;
            this.txtTimeInterval.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTimeInterval.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.txtTimeInterval.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.txtTimeInterval.Location = new System.Drawing.Point(30, 145);
            this.txtTimeInterval.Name = "txtTimeInterval";
            this.txtTimeInterval.Size = new System.Drawing.Size(500, 40);
            this.txtTimeInterval.TabIndex = 2;
            this.txtTimeInterval.Text = "09:00 - 12:00";
            // 
            // lblHangar
            // 
            this.lblHangar.AutoSize = true;
            this.lblHangar.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.lblHangar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.lblHangar.Location = new System.Drawing.Point(30, 205);
            this.lblHangar.Name = "lblHangar";
            this.lblHangar.Size = new System.Drawing.Size(90, 33);
            this.lblHangar.TabIndex = 3;
            this.lblHangar.Text = "Ангар*";
            // 
            // cmbHangar
            // 
            this.cmbHangar.BackColor = System.Drawing.Color.White;
            this.cmbHangar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbHangar.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.cmbHangar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.cmbHangar.FormattingEnabled = true;
            this.cmbHangar.Location = new System.Drawing.Point(30, 250);
            this.cmbHangar.Name = "cmbHangar";
            this.cmbHangar.Size = new System.Drawing.Size(500, 41);
            this.cmbHangar.TabIndex = 4;
            // 
            // lblAircraft
            // 
            this.lblAircraft.AutoSize = true;
            this.lblAircraft.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.lblAircraft.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.lblAircraft.Location = new System.Drawing.Point(30, 310);
            this.lblAircraft.Name = "lblAircraft";
            this.lblAircraft.Size = new System.Drawing.Size(220, 33);
            this.lblAircraft.TabIndex = 5;
            this.lblAircraft.Text = "Воздушное судно*";
            // 
            // cmbAircraft
            // 
            this.cmbAircraft.BackColor = System.Drawing.Color.White;
            this.cmbAircraft.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAircraft.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.cmbAircraft.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.cmbAircraft.FormattingEnabled = true;
            this.cmbAircraft.Location = new System.Drawing.Point(30, 355);
            this.cmbAircraft.Name = "cmbAircraft";
            this.cmbAircraft.Size = new System.Drawing.Size(500, 41);
            this.cmbAircraft.TabIndex = 6;
            // 
            // lblPersonnel
            // 
            this.lblPersonnel.AutoSize = true;
            this.lblPersonnel.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.lblPersonnel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.lblPersonnel.Location = new System.Drawing.Point(30, 415);
            this.lblPersonnel.Name = "lblPersonnel";
            this.lblPersonnel.Size = new System.Drawing.Size(135, 33);
            this.lblPersonnel.TabIndex = 7;
            this.lblPersonnel.Text = "Персонал*";
            // 
            // cmbPersonnel
            // 
            this.cmbPersonnel.BackColor = System.Drawing.Color.White;
            this.cmbPersonnel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPersonnel.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.cmbPersonnel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.cmbPersonnel.FormattingEnabled = true;
            this.cmbPersonnel.Location = new System.Drawing.Point(30, 460);
            this.cmbPersonnel.Name = "cmbPersonnel";
            this.cmbPersonnel.Size = new System.Drawing.Size(500, 41);
            this.cmbPersonnel.TabIndex = 8;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.lblDescription.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.lblDescription.Location = new System.Drawing.Point(30, 520);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(123, 33);
            this.lblDescription.TabIndex = 9;
            this.lblDescription.Text = "Описание";
            // 
            // txtDescription
            // 
            this.txtDescription.BackColor = System.Drawing.Color.White;
            this.txtDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDescription.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.txtDescription.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.txtDescription.Location = new System.Drawing.Point(30, 565);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(500, 100);
            this.txtDescription.TabIndex = 10;
            // 
            // btnAction
            // 
            this.btnAction.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(90)))), ((int)(((byte)(136)))));
            this.btnAction.FlatAppearance.BorderSize = 0;
            this.btnAction.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAction.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold);
            this.btnAction.ForeColor = System.Drawing.Color.White;
            this.btnAction.Location = new System.Drawing.Point(580, 585);
            this.btnAction.Name = "btnAction";
            this.btnAction.Size = new System.Drawing.Size(280, 60);
            this.btnAction.TabIndex = 11;
            this.btnAction.Text = "Добавить запись";
            this.btnAction.UseVisualStyleBackColor = false;
            this.btnAction.Click += new System.EventHandler(this.btnAction_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.btnCancel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(90)))), ((int)(((byte)(136)))));
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold);
            this.btnCancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(90)))), ((int)(((byte)(136)))));
            this.btnCancel.Location = new System.Drawing.Point(580, 665);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(280, 60);
            this.btnCancel.TabIndex = 12;
            this.btnCancel.Text = "Отмена";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // HangarScheduleEditorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 33F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(900, 755);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAction);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.cmbPersonnel);
            this.Controls.Add(this.lblPersonnel);
            this.Controls.Add(this.cmbAircraft);
            this.Controls.Add(this.lblAircraft);
            this.Controls.Add(this.cmbHangar);
            this.Controls.Add(this.lblHangar);
            this.Controls.Add(this.txtTimeInterval);
            this.Controls.Add(this.lblTimeInterval);
            this.Controls.Add(this.lblTitle);
            this.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "HangarScheduleEditorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Добавление записи в ангар — Аэропорт";
            this.Load += new System.EventHandler(this.HangarScheduleEditorForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

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