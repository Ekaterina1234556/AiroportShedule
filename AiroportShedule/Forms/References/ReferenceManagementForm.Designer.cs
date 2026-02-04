namespace AiroportShedule.Forms
{
    partial class ReferenceManagementForm
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPageFlightCrew = new System.Windows.Forms.TabPage();
            this.pnlFlightCrewButtons = new System.Windows.Forms.Panel();
            this.btnDeleteFlightCrew = new System.Windows.Forms.Button();
            this.btnEditFlightCrew = new System.Windows.Forms.Button();
            this.btnAddFlightCrew = new System.Windows.Forms.Button();
            this.dgvFlightCrew = new System.Windows.Forms.DataGridView();
            this.lblListTitle = new System.Windows.Forms.Label();
            this.tabPageSupportCrew = new System.Windows.Forms.TabPage();
            this.pnlSupportCrewButtons = new System.Windows.Forms.Panel();
            this.btnDeleteSupportCrew = new System.Windows.Forms.Button();
            this.btnEditSupportCrew = new System.Windows.Forms.Button();
            this.btnAddSupportCrew = new System.Windows.Forms.Button();
            this.dgvSupportCrew = new System.Windows.Forms.DataGridView();
            this.tabPageSingleList = new System.Windows.Forms.TabPage();
            this.pnlSingleListButtons = new System.Windows.Forms.Panel();
            this.btnDeleteSingle = new System.Windows.Forms.Button();
            this.btnEditSingle = new System.Windows.Forms.Button();
            this.btnAddSingle = new System.Windows.Forms.Button();
            this.dgvSingleList = new System.Windows.Forms.DataGridView();
            this.tabControl.SuspendLayout();
            this.tabPageFlightCrew.SuspendLayout();
            this.pnlFlightCrewButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFlightCrew)).BeginInit();
            this.tabPageSupportCrew.SuspendLayout();
            this.pnlSupportCrewButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSupportCrew)).BeginInit();
            this.tabPageSingleList.SuspendLayout();
            this.pnlSingleListButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSingleList)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.lblTitle.Location = new System.Drawing.Point(30, 25);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(450, 46);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Справочник экипажей";
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPageFlightCrew);
            this.tabControl.Controls.Add(this.tabPageSupportCrew);
            this.tabControl.Controls.Add(this.tabPageSingleList);
            this.tabControl.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabControl.Location = new System.Drawing.Point(30, 90);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(940, 620);
            this.tabControl.TabIndex = 1;
            // 
            // tabPageFlightCrew
            // 
            this.tabPageFlightCrew.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.tabPageFlightCrew.Controls.Add(this.pnlFlightCrewButtons);
            this.tabPageFlightCrew.Controls.Add(this.dgvFlightCrew);
            this.tabPageFlightCrew.Controls.Add(this.lblListTitle);
            this.tabPageFlightCrew.Location = new System.Drawing.Point(4, 41);
            this.tabPageFlightCrew.Name = "tabPageFlightCrew";
            this.tabPageFlightCrew.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageFlightCrew.Size = new System.Drawing.Size(932, 575);
            this.tabPageFlightCrew.TabIndex = 0;
            this.tabPageFlightCrew.Text = "Полётный персонал";
            // 
            // pnlFlightCrewButtons
            // 
            this.pnlFlightCrewButtons.Controls.Add(this.btnDeleteFlightCrew);
            this.pnlFlightCrewButtons.Controls.Add(this.btnEditFlightCrew);
            this.pnlFlightCrewButtons.Controls.Add(this.btnAddFlightCrew);
            this.pnlFlightCrewButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlFlightCrewButtons.Location = new System.Drawing.Point(3, 457);
            this.pnlFlightCrewButtons.Name = "pnlFlightCrewButtons";
            this.pnlFlightCrewButtons.Size = new System.Drawing.Size(926, 115);
            this.pnlFlightCrewButtons.TabIndex = 2;
            // 
            // btnDeleteFlightCrew
            // 
            this.btnDeleteFlightCrew.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.btnDeleteFlightCrew.FlatAppearance.BorderSize = 0;
            this.btnDeleteFlightCrew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteFlightCrew.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDeleteFlightCrew.ForeColor = System.Drawing.Color.White;
            this.btnDeleteFlightCrew.Location = new System.Drawing.Point(620, 10);
            this.btnDeleteFlightCrew.Name = "btnDeleteFlightCrew";
            this.btnDeleteFlightCrew.Size = new System.Drawing.Size(290, 50);
            this.btnDeleteFlightCrew.TabIndex = 2;
            this.btnDeleteFlightCrew.Text = "Удалить";
            this.btnDeleteFlightCrew.UseVisualStyleBackColor = false;
            // 
            // btnEditFlightCrew
            // 
            this.btnEditFlightCrew.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(90)))), ((int)(((byte)(136)))));
            this.btnEditFlightCrew.FlatAppearance.BorderSize = 0;
            this.btnEditFlightCrew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditFlightCrew.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnEditFlightCrew.ForeColor = System.Drawing.Color.White;
            this.btnEditFlightCrew.Location = new System.Drawing.Point(320, 10);
            this.btnEditFlightCrew.Name = "btnEditFlightCrew";
            this.btnEditFlightCrew.Size = new System.Drawing.Size(290, 50);
            this.btnEditFlightCrew.TabIndex = 1;
            this.btnEditFlightCrew.Text = "Редактировать";
            this.btnEditFlightCrew.UseVisualStyleBackColor = false;
            // 
            // btnAddFlightCrew
            // 
            this.btnAddFlightCrew.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(90)))), ((int)(((byte)(136)))));
            this.btnAddFlightCrew.FlatAppearance.BorderSize = 0;
            this.btnAddFlightCrew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddFlightCrew.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAddFlightCrew.ForeColor = System.Drawing.Color.White;
            this.btnAddFlightCrew.Location = new System.Drawing.Point(20, 10);
            this.btnAddFlightCrew.Name = "btnAddFlightCrew";
            this.btnAddFlightCrew.Size = new System.Drawing.Size(290, 50);
            this.btnAddFlightCrew.TabIndex = 0;
            this.btnAddFlightCrew.Text = "Добавить";
            this.btnAddFlightCrew.UseVisualStyleBackColor = false;
            // 
            // dgvFlightCrew
            // 
            this.dgvFlightCrew.BackgroundColor = System.Drawing.Color.White;
            this.dgvFlightCrew.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvFlightCrew.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvFlightCrew.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFlightCrew.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvFlightCrew.Location = new System.Drawing.Point(3, 64);
            this.dgvFlightCrew.Name = "dgvFlightCrew";
            this.dgvFlightCrew.RowHeadersWidth = 62;
            this.dgvFlightCrew.RowTemplate.Height = 35;
            this.dgvFlightCrew.Size = new System.Drawing.Size(926, 393);
            this.dgvFlightCrew.TabIndex = 1;
            // 
            // lblListTitle
            // 
            this.lblListTitle.AutoSize = true;
            this.lblListTitle.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblListTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.lblListTitle.Location = new System.Drawing.Point(20, 20);
            this.lblListTitle.Name = "lblListTitle";
            this.lblListTitle.Size = new System.Drawing.Size(270, 36);
            this.lblListTitle.TabIndex = 0;
            this.lblListTitle.Text = "Список персонала";
            // 
            // tabPageSupportCrew
            // 
            this.tabPageSupportCrew.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.tabPageSupportCrew.Controls.Add(this.pnlSupportCrewButtons);
            this.tabPageSupportCrew.Controls.Add(this.dgvSupportCrew);
            this.tabPageSupportCrew.Controls.Add(this.lblListTitle);
            this.tabPageSupportCrew.Location = new System.Drawing.Point(4, 41);
            this.tabPageSupportCrew.Name = "tabPageSupportCrew";
            this.tabPageSupportCrew.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSupportCrew.Size = new System.Drawing.Size(932, 575);
            this.tabPageSupportCrew.TabIndex = 1;
            this.tabPageSupportCrew.Text = "Обслуживающий персонал";
            // 
            // pnlSupportCrewButtons
            // 
            this.pnlSupportCrewButtons.Controls.Add(this.btnDeleteSupportCrew);
            this.pnlSupportCrewButtons.Controls.Add(this.btnEditSupportCrew);
            this.pnlSupportCrewButtons.Controls.Add(this.btnAddSupportCrew);
            this.pnlSupportCrewButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlSupportCrewButtons.Location = new System.Drawing.Point(3, 457);
            this.pnlSupportCrewButtons.Name = "pnlSupportCrewButtons";
            this.pnlSupportCrewButtons.Size = new System.Drawing.Size(926, 115);
            this.pnlSupportCrewButtons.TabIndex = 3;
            // 
            // btnDeleteSupportCrew
            // 
            this.btnDeleteSupportCrew.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.btnDeleteSupportCrew.FlatAppearance.BorderSize = 0;
            this.btnDeleteSupportCrew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteSupportCrew.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDeleteSupportCrew.ForeColor = System.Drawing.Color.White;
            this.btnDeleteSupportCrew.Location = new System.Drawing.Point(620, 10);
            this.btnDeleteSupportCrew.Name = "btnDeleteSupportCrew";
            this.btnDeleteSupportCrew.Size = new System.Drawing.Size(290, 50);
            this.btnDeleteSupportCrew.TabIndex = 2;
            this.btnDeleteSupportCrew.Text = "Удалить";
            this.btnDeleteSupportCrew.UseVisualStyleBackColor = false;
            // 
            // btnEditSupportCrew
            // 
            this.btnEditSupportCrew.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(90)))), ((int)(((byte)(136)))));
            this.btnEditSupportCrew.FlatAppearance.BorderSize = 0;
            this.btnEditSupportCrew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditSupportCrew.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnEditSupportCrew.ForeColor = System.Drawing.Color.White;
            this.btnEditSupportCrew.Location = new System.Drawing.Point(320, 10);
            this.btnEditSupportCrew.Name = "btnEditSupportCrew";
            this.btnEditSupportCrew.Size = new System.Drawing.Size(290, 50);
            this.btnEditSupportCrew.TabIndex = 1;
            this.btnEditSupportCrew.Text = "Редактировать";
            this.btnEditSupportCrew.UseVisualStyleBackColor = false;
            // 
            // btnAddSupportCrew
            // 
            this.btnAddSupportCrew.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(90)))), ((int)(((byte)(136)))));
            this.btnAddSupportCrew.FlatAppearance.BorderSize = 0;
            this.btnAddSupportCrew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddSupportCrew.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAddSupportCrew.ForeColor = System.Drawing.Color.White;
            this.btnAddSupportCrew.Location = new System.Drawing.Point(20, 10);
            this.btnAddSupportCrew.Name = "btnAddSupportCrew";
            this.btnAddSupportCrew.Size = new System.Drawing.Size(290, 50);
            this.btnAddSupportCrew.TabIndex = 0;
            this.btnAddSupportCrew.Text = "Добавить";
            this.btnAddSupportCrew.UseVisualStyleBackColor = false;
            // 
            // dgvSupportCrew
            // 
            this.dgvSupportCrew.BackgroundColor = System.Drawing.Color.White;
            this.dgvSupportCrew.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvSupportCrew.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvSupportCrew.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSupportCrew.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSupportCrew.Location = new System.Drawing.Point(3, 64);
            this.dgvSupportCrew.Name = "dgvSupportCrew";
            this.dgvSupportCrew.RowHeadersWidth = 62;
            this.dgvSupportCrew.RowTemplate.Height = 35;
            this.dgvSupportCrew.Size = new System.Drawing.Size(926, 393);
            this.dgvSupportCrew.TabIndex = 2;
            // 
            // tabPageSingleList
            // 
            this.tabPageSingleList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.tabPageSingleList.Controls.Add(this.pnlSingleListButtons);
            this.tabPageSingleList.Controls.Add(this.dgvSingleList);
            this.tabPageSingleList.Controls.Add(this.lblListTitle);
            this.tabPageSingleList.Location = new System.Drawing.Point(4, 41);
            this.tabPageSingleList.Name = "tabPageSingleList";
            this.tabPageSingleList.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSingleList.Size = new System.Drawing.Size(932, 575);
            this.tabPageSingleList.TabIndex = 2;
            this.tabPageSingleList.Text = "Ангары";
            // 
            // pnlSingleListButtons
            // 
            this.pnlSingleListButtons.Controls.Add(this.btnDeleteSingle);
            this.pnlSingleListButtons.Controls.Add(this.btnEditSingle);
            this.pnlSingleListButtons.Controls.Add(this.btnAddSingle);
            this.pnlSingleListButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlSingleListButtons.Location = new System.Drawing.Point(3, 457);
            this.pnlSingleListButtons.Name = "pnlSingleListButtons";
            this.pnlSingleListButtons.Size = new System.Drawing.Size(926, 115);
            this.pnlSingleListButtons.TabIndex = 3;
            // 
            // btnDeleteSingle
            // 
            this.btnDeleteSingle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.btnDeleteSingle.FlatAppearance.BorderSize = 0;
            this.btnDeleteSingle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteSingle.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDeleteSingle.ForeColor = System.Drawing.Color.White;
            this.btnDeleteSingle.Location = new System.Drawing.Point(620, 10);
            this.btnDeleteSingle.Name = "btnDeleteSingle";
            this.btnDeleteSingle.Size = new System.Drawing.Size(290, 50);
            this.btnDeleteSingle.TabIndex = 2;
            this.btnDeleteSingle.Text = "Удалить";
            this.btnDeleteSingle.UseVisualStyleBackColor = false;
            // 
            // btnEditSingle
            // 
            this.btnEditSingle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(90)))), ((int)(((byte)(136)))));
            this.btnEditSingle.FlatAppearance.BorderSize = 0;
            this.btnEditSingle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditSingle.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnEditSingle.ForeColor = System.Drawing.Color.White;
            this.btnEditSingle.Location = new System.Drawing.Point(320, 10);
            this.btnEditSingle.Name = "btnEditSingle";
            this.btnEditSingle.Size = new System.Drawing.Size(290, 50);
            this.btnEditSingle.TabIndex = 1;
            this.btnEditSingle.Text = "Редактировать";
            this.btnEditSingle.UseVisualStyleBackColor = false;
            // 
            // btnAddSingle
            // 
            this.btnAddSingle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(90)))), ((int)(((byte)(136)))));
            this.btnAddSingle.FlatAppearance.BorderSize = 0;
            this.btnAddSingle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddSingle.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAddSingle.ForeColor = System.Drawing.Color.White;
            this.btnAddSingle.Location = new System.Drawing.Point(20, 10);
            this.btnAddSingle.Name = "btnAddSingle";
            this.btnAddSingle.Size = new System.Drawing.Size(290, 50);
            this.btnAddSingle.TabIndex = 0;
            this.btnAddSingle.Text = "Добавить";
            this.btnAddSingle.UseVisualStyleBackColor = false;
            // 
            // dgvSingleList
            // 
            this.dgvSingleList.BackgroundColor = System.Drawing.Color.White;
            this.dgvSingleList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvSingleList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvSingleList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSingleList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSingleList.Location = new System.Drawing.Point(3, 64);
            this.dgvSingleList.Name = "dgvSingleList";
            this.dgvSingleList.RowHeadersWidth = 62;
            this.dgvSingleList.RowTemplate.Height = 35;
            this.dgvSingleList.Size = new System.Drawing.Size(926, 393);
            this.dgvSingleList.TabIndex = 2;
            // 
            // ReferenceManagementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 33F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(1000, 740);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.lblTitle);
            this.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ReferenceManagementForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Справочник экипажей — Аэропорт";
            this.tabControl.ResumeLayout(false);
            this.tabPageFlightCrew.ResumeLayout(false);
            this.tabPageFlightCrew.PerformLayout();
            this.pnlFlightCrewButtons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFlightCrew)).EndInit();
            this.tabPageSupportCrew.ResumeLayout(false);
            this.tabPageSupportCrew.PerformLayout();
            this.pnlSupportCrewButtons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSupportCrew)).EndInit();
            this.tabPageSingleList.ResumeLayout(false);
            this.tabPageSingleList.PerformLayout();
            this.pnlSingleListButtons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSingleList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPageFlightCrew;
        private System.Windows.Forms.TabPage tabPageSupportCrew;
        private System.Windows.Forms.TabPage tabPageSingleList;
        private System.Windows.Forms.DataGridView dgvFlightCrew;
        private System.Windows.Forms.Label lblListTitle;
        private System.Windows.Forms.Panel pnlFlightCrewButtons;
        private System.Windows.Forms.Button btnDeleteFlightCrew;
        private System.Windows.Forms.Button btnEditFlightCrew;
        private System.Windows.Forms.Button btnAddFlightCrew;
        private System.Windows.Forms.DataGridView dgvSupportCrew;
        private System.Windows.Forms.Panel pnlSupportCrewButtons;
        private System.Windows.Forms.Button btnDeleteSupportCrew;
        private System.Windows.Forms.Button btnEditSupportCrew;
        private System.Windows.Forms.Button btnAddSupportCrew;
        private System.Windows.Forms.DataGridView dgvSingleList;
        private System.Windows.Forms.Panel pnlSingleListButtons;
        private System.Windows.Forms.Button btnDeleteSingle;
        private System.Windows.Forms.Button btnEditSingle;
        private System.Windows.Forms.Button btnAddSingle;
    }
}