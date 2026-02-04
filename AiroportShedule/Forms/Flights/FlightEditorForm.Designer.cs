namespace AiroportShedule.Forms
{
    partial class FlightEditorForm
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
            lblRoute = new Label();
            cmbRoute = new ComboBox();
            lblAircraftLabel = new Label();
            cmbAircraft = new ComboBox();
            lblPilot = new Label();
            cmbPilot = new ComboBox();
            lblDeparture = new Label();
            dtpDate = new DateTimePicker();
            lblTimeSeparator1 = new Label();
            numDepartureHour = new NumericUpDown();
            lblColon1 = new Label();
            numDepartureMinute = new NumericUpDown();
            lblArrival = new Label();
            lblTimeSeparator2 = new Label();
            numArrivalHour = new NumericUpDown();
            lblColon2 = new Label();
            numArrivalMinute = new NumericUpDown();
            lblPassengers = new Label();
            numPassengers = new NumericUpDown();
            lblBaggage = new Label();
            numBaggage = new NumericUpDown();
            lblKg = new Label();
            btnAction = new Button();
            btnCancel = new Button();
            dateTimePicker1 = new DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)numDepartureHour).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numDepartureMinute).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numArrivalHour).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numArrivalMinute).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numPassengers).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numBaggage).BeginInit();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Times New Roman", 20F, FontStyle.Bold, GraphicsUnit.Point, 204);
            lblTitle.ForeColor = Color.FromArgb(33, 37, 41);
            lblTitle.Location = new Point(30, 25);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(342, 45);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Добавление рейса";
            // 
            // lblRoute
            // 
            lblRoute.AutoSize = true;
            lblRoute.Font = new Font("Times New Roman", 14F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lblRoute.ForeColor = Color.FromArgb(33, 37, 41);
            lblRoute.Location = new Point(30, 100);
            lblRoute.Name = "lblRoute";
            lblRoute.Size = new Size(127, 33);
            lblRoute.TabIndex = 1;
            lblRoute.Text = "Маршрут";
            // 
            // cmbRoute
            // 
            cmbRoute.BackColor = Color.White;
            cmbRoute.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbRoute.Font = new Font("Times New Roman", 14F, FontStyle.Regular, GraphicsUnit.Point, 204);
            cmbRoute.ForeColor = Color.FromArgb(33, 37, 41);
            cmbRoute.FormattingEnabled = true;
            cmbRoute.Location = new Point(30, 145);
            cmbRoute.Name = "cmbRoute";
            cmbRoute.Size = new Size(450, 41);
            cmbRoute.TabIndex = 2;
            // 
            // lblAircraftLabel
            // 
            lblAircraftLabel.AutoSize = true;
            lblAircraftLabel.Font = new Font("Times New Roman", 14F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lblAircraftLabel.ForeColor = Color.FromArgb(33, 37, 41);
            lblAircraftLabel.Location = new Point(30, 205);
            lblAircraftLabel.Name = "lblAircraftLabel";
            lblAircraftLabel.Size = new Size(221, 33);
            lblAircraftLabel.TabIndex = 3;
            lblAircraftLabel.Text = "Воздушное судно";
            // 
            // cmbAircraft
            // 
            cmbAircraft.BackColor = Color.White;
            cmbAircraft.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbAircraft.Font = new Font("Times New Roman", 14F, FontStyle.Regular, GraphicsUnit.Point, 204);
            cmbAircraft.ForeColor = Color.FromArgb(33, 37, 41);
            cmbAircraft.FormattingEnabled = true;
            cmbAircraft.Location = new Point(30, 250);
            cmbAircraft.Name = "cmbAircraft";
            cmbAircraft.Size = new Size(450, 41);
            cmbAircraft.TabIndex = 4;
            // 
            // lblPilot
            // 
            lblPilot.AutoSize = true;
            lblPilot.Font = new Font("Times New Roman", 14F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lblPilot.ForeColor = Color.FromArgb(33, 37, 41);
            lblPilot.Location = new Point(30, 310);
            lblPilot.Name = "lblPilot";
            lblPilot.Size = new Size(89, 33);
            lblPilot.TabIndex = 5;
            lblPilot.Text = "Пилот";
            // 
            // cmbPilot
            // 
            cmbPilot.BackColor = Color.White;
            cmbPilot.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPilot.Font = new Font("Times New Roman", 14F, FontStyle.Regular, GraphicsUnit.Point, 204);
            cmbPilot.ForeColor = Color.FromArgb(33, 37, 41);
            cmbPilot.FormattingEnabled = true;
            cmbPilot.Location = new Point(30, 355);
            cmbPilot.Name = "cmbPilot";
            cmbPilot.Size = new Size(450, 41);
            cmbPilot.TabIndex = 6;
            // 
            // lblDeparture
            // 
            lblDeparture.AutoSize = true;
            lblDeparture.Font = new Font("Times New Roman", 14F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lblDeparture.ForeColor = Color.FromArgb(33, 37, 41);
            lblDeparture.Location = new Point(30, 415);
            lblDeparture.Name = "lblDeparture";
            lblDeparture.Size = new Size(91, 33);
            lblDeparture.TabIndex = 7;
            lblDeparture.Text = "Вылет";
            // 
            // dtpDate
            // 
            dtpDate.CalendarFont = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            dtpDate.Font = new Font("Times New Roman", 14F, FontStyle.Regular, GraphicsUnit.Point, 204);
            dtpDate.Format = DateTimePickerFormat.Short;
            dtpDate.Location = new Point(30, 460);
            dtpDate.Name = "dtpDate";
            dtpDate.Size = new Size(180, 40);
            dtpDate.TabIndex = 8;
            // 
            // lblTimeSeparator1
            // 
            lblTimeSeparator1.AutoSize = true;
            lblTimeSeparator1.Font = new Font("Times New Roman", 14F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lblTimeSeparator1.ForeColor = Color.FromArgb(33, 37, 41);
            lblTimeSeparator1.Location = new Point(225, 465);
            lblTimeSeparator1.Name = "lblTimeSeparator1";
            lblTimeSeparator1.Size = new Size(23, 33);
            lblTimeSeparator1.TabIndex = 9;
            lblTimeSeparator1.Text = "/";
            // 
            // numDepartureHour
            // 
            numDepartureHour.Font = new Font("Times New Roman", 14F, FontStyle.Regular, GraphicsUnit.Point, 204);
            numDepartureHour.Location = new Point(260, 460);
            numDepartureHour.Maximum = new decimal(new int[] { 23, 0, 0, 0 });
            numDepartureHour.Name = "numDepartureHour";
            numDepartureHour.Size = new Size(65, 40);
            numDepartureHour.TabIndex = 10;
            // 
            // lblColon1
            // 
            lblColon1.AutoSize = true;
            lblColon1.Font = new Font("Times New Roman", 14F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lblColon1.ForeColor = Color.FromArgb(33, 37, 41);
            lblColon1.Location = new Point(335, 465);
            lblColon1.Name = "lblColon1";
            lblColon1.Size = new Size(23, 33);
            lblColon1.TabIndex = 11;
            lblColon1.Text = ":";
            // 
            // numDepartureMinute
            // 
            numDepartureMinute.Font = new Font("Times New Roman", 14F, FontStyle.Regular, GraphicsUnit.Point, 204);
            numDepartureMinute.Location = new Point(365, 460);
            numDepartureMinute.Maximum = new decimal(new int[] { 59, 0, 0, 0 });
            numDepartureMinute.Name = "numDepartureMinute";
            numDepartureMinute.Size = new Size(65, 40);
            numDepartureMinute.TabIndex = 12;
            // 
            // lblArrival
            // 
            lblArrival.AutoSize = true;
            lblArrival.Font = new Font("Times New Roman", 14F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lblArrival.ForeColor = Color.FromArgb(33, 37, 41);
            lblArrival.Location = new Point(30, 525);
            lblArrival.Name = "lblArrival";
            lblArrival.Size = new Size(101, 33);
            lblArrival.TabIndex = 13;
            lblArrival.Text = "Прилёт";
            // 
            // lblTimeSeparator2
            // 
            lblTimeSeparator2.AutoSize = true;
            lblTimeSeparator2.Font = new Font("Times New Roman", 14F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lblTimeSeparator2.ForeColor = Color.FromArgb(33, 37, 41);
            lblTimeSeparator2.Location = new Point(225, 575);
            lblTimeSeparator2.Name = "lblTimeSeparator2";
            lblTimeSeparator2.Size = new Size(23, 33);
            lblTimeSeparator2.TabIndex = 14;
            lblTimeSeparator2.Text = "/";
            // 
            // numArrivalHour
            // 
            numArrivalHour.Font = new Font("Times New Roman", 14F, FontStyle.Regular, GraphicsUnit.Point, 204);
            numArrivalHour.Location = new Point(260, 570);
            numArrivalHour.Maximum = new decimal(new int[] { 23, 0, 0, 0 });
            numArrivalHour.Name = "numArrivalHour";
            numArrivalHour.Size = new Size(65, 40);
            numArrivalHour.TabIndex = 15;
            // 
            // lblColon2
            // 
            lblColon2.AutoSize = true;
            lblColon2.Font = new Font("Times New Roman", 14F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lblColon2.ForeColor = Color.FromArgb(33, 37, 41);
            lblColon2.Location = new Point(335, 575);
            lblColon2.Name = "lblColon2";
            lblColon2.Size = new Size(23, 33);
            lblColon2.TabIndex = 16;
            lblColon2.Text = ":";
            // 
            // numArrivalMinute
            // 
            numArrivalMinute.Font = new Font("Times New Roman", 14F, FontStyle.Regular, GraphicsUnit.Point, 204);
            numArrivalMinute.Location = new Point(365, 570);
            numArrivalMinute.Maximum = new decimal(new int[] { 59, 0, 0, 0 });
            numArrivalMinute.Name = "numArrivalMinute";
            numArrivalMinute.Size = new Size(65, 40);
            numArrivalMinute.TabIndex = 17;
            // 
            // lblPassengers
            // 
            lblPassengers.AutoSize = true;
            lblPassengers.Font = new Font("Times New Roman", 14F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lblPassengers.ForeColor = Color.FromArgb(33, 37, 41);
            lblPassengers.Location = new Point(500, 100);
            lblPassengers.Name = "lblPassengers";
            lblPassengers.Size = new Size(149, 33);
            lblPassengers.TabIndex = 18;
            lblPassengers.Text = "Пассажиры";
            // 
            // numPassengers
            // 
            numPassengers.Font = new Font("Times New Roman", 14F, FontStyle.Regular, GraphicsUnit.Point, 204);
            numPassengers.Location = new Point(500, 145);
            numPassengers.Maximum = new decimal(new int[] { 500, 0, 0, 0 });
            numPassengers.Name = "numPassengers";
            numPassengers.Size = new Size(120, 40);
            numPassengers.TabIndex = 19;
            numPassengers.Value = new decimal(new int[] { 150, 0, 0, 0 });
            // 
            // lblBaggage
            // 
            lblBaggage.AutoSize = true;
            lblBaggage.Font = new Font("Times New Roman", 14F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lblBaggage.ForeColor = Color.FromArgb(33, 37, 41);
            lblBaggage.Location = new Point(500, 205);
            lblBaggage.Name = "lblBaggage";
            lblBaggage.Size = new Size(85, 33);
            lblBaggage.TabIndex = 20;
            lblBaggage.Text = "Багаж";
            // 
            // numBaggage
            // 
            numBaggage.Font = new Font("Times New Roman", 14F, FontStyle.Regular, GraphicsUnit.Point, 204);
            numBaggage.Location = new Point(500, 250);
            numBaggage.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            numBaggage.Name = "numBaggage";
            numBaggage.Size = new Size(120, 40);
            numBaggage.TabIndex = 21;
            numBaggage.Value = new decimal(new int[] { 2000, 0, 0, 0 });
            // 
            // lblKg
            // 
            lblKg.AutoSize = true;
            lblKg.Font = new Font("Times New Roman", 14F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lblKg.ForeColor = Color.FromArgb(33, 37, 41);
            lblKg.Location = new Point(630, 255);
            lblKg.Name = "lblKg";
            lblKg.Size = new Size(40, 33);
            lblKg.TabIndex = 22;
            lblKg.Text = "кг";
            // 
            // btnAction
            // 
            btnAction.BackColor = Color.FromArgb(46, 90, 136);
            btnAction.FlatAppearance.BorderSize = 0;
            btnAction.FlatStyle = FlatStyle.Flat;
            btnAction.Font = new Font("Times New Roman", 14F, FontStyle.Bold, GraphicsUnit.Point, 204);
            btnAction.ForeColor = Color.White;
            btnAction.Location = new Point(500, 460);
            btnAction.Name = "btnAction";
            btnAction.Size = new Size(280, 60);
            btnAction.TabIndex = 23;
            btnAction.Text = "Добавить рейс";
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
            btnCancel.Location = new Point(500, 540);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(280, 60);
            btnCancel.TabIndex = 24;
            btnCancel.Text = "Отмена";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CalendarFont = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            dateTimePicker1.Font = new Font("Times New Roman", 14F, FontStyle.Regular, GraphicsUnit.Point, 204);
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(30, 570);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(180, 40);
            dateTimePicker1.TabIndex = 25;
            // 
            // FlightEditorForm
            // 
            AutoScaleDimensions = new SizeF(15F, 33F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(248, 249, 250);
            ClientSize = new Size(820, 650);
            Controls.Add(dateTimePicker1);
            Controls.Add(btnCancel);
            Controls.Add(btnAction);
            Controls.Add(lblKg);
            Controls.Add(numBaggage);
            Controls.Add(lblBaggage);
            Controls.Add(numPassengers);
            Controls.Add(lblPassengers);
            Controls.Add(numArrivalMinute);
            Controls.Add(lblColon2);
            Controls.Add(numArrivalHour);
            Controls.Add(lblTimeSeparator2);
            Controls.Add(lblArrival);
            Controls.Add(numDepartureMinute);
            Controls.Add(lblColon1);
            Controls.Add(numDepartureHour);
            Controls.Add(lblTimeSeparator1);
            Controls.Add(dtpDate);
            Controls.Add(lblDeparture);
            Controls.Add(cmbPilot);
            Controls.Add(lblPilot);
            Controls.Add(cmbAircraft);
            Controls.Add(lblAircraftLabel);
            Controls.Add(cmbRoute);
            Controls.Add(lblRoute);
            Controls.Add(lblTitle);
            Font = new Font("Times New Roman", 14F, FontStyle.Regular, GraphicsUnit.Point, 204);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FlightEditorForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Добавление рейса — Аэропорт";
            Load += FlightEditorForm_Load;
            ((System.ComponentModel.ISupportInitialize)numDepartureHour).EndInit();
            ((System.ComponentModel.ISupportInitialize)numDepartureMinute).EndInit();
            ((System.ComponentModel.ISupportInitialize)numArrivalHour).EndInit();
            ((System.ComponentModel.ISupportInitialize)numArrivalMinute).EndInit();
            ((System.ComponentModel.ISupportInitialize)numPassengers).EndInit();
            ((System.ComponentModel.ISupportInitialize)numBaggage).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblRoute;
        private System.Windows.Forms.ComboBox cmbRoute;
        private System.Windows.Forms.Label lblAircraftLabel;
        private System.Windows.Forms.ComboBox cmbAircraft;
        private System.Windows.Forms.Label lblPilot;
        private System.Windows.Forms.ComboBox cmbPilot;
        private System.Windows.Forms.Label lblDeparture;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Label lblTimeSeparator1;
        private System.Windows.Forms.NumericUpDown numDepartureHour;
        private System.Windows.Forms.Label lblColon1;
        private System.Windows.Forms.NumericUpDown numDepartureMinute;
        private System.Windows.Forms.Label lblArrival;
        private System.Windows.Forms.Label lblTimeSeparator2;
        private System.Windows.Forms.NumericUpDown numArrivalHour;
        private System.Windows.Forms.Label lblColon2;
        private System.Windows.Forms.NumericUpDown numArrivalMinute;
        private System.Windows.Forms.Label lblPassengers;
        private System.Windows.Forms.NumericUpDown numPassengers;
        private System.Windows.Forms.Label lblBaggage;
        private System.Windows.Forms.NumericUpDown numBaggage;
        private System.Windows.Forms.Label lblKg;
        private System.Windows.Forms.Button btnAction;
        private System.Windows.Forms.Button btnCancel;
        private DateTimePicker dateTimePicker1;
    }
}