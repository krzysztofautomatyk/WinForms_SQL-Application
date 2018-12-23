namespace WinForms_SQL_Application
{
    partial class TorunamentDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TorunamentDashboard));
            this.createTournamnetButton = new System.Windows.Forms.Button();
            this.loadTournamnetButton = new System.Windows.Forms.Button();
            this.loadingExistingTournamentLabel = new System.Windows.Forms.Label();
            this.loadExistingTournamentDropDown = new System.Windows.Forms.ComboBox();
            this.tournamentDashboardLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // createTournamnetButton
            // 
            this.createTournamnetButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.createTournamnetButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGreen;
            this.createTournamnetButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.createTournamnetButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createTournamnetButton.Font = new System.Drawing.Font("Segoe UI Black", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.createTournamnetButton.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.createTournamnetButton.Location = new System.Drawing.Point(87, 271);
            this.createTournamnetButton.Margin = new System.Windows.Forms.Padding(2);
            this.createTournamnetButton.Name = "createTournamnetButton";
            this.createTournamnetButton.Size = new System.Drawing.Size(287, 72);
            this.createTournamnetButton.TabIndex = 54;
            this.createTournamnetButton.Text = "Create Tournament";
            this.createTournamnetButton.UseVisualStyleBackColor = true;
            // 
            // loadTournamnetButton
            // 
            this.loadTournamnetButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.loadTournamnetButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGreen;
            this.loadTournamnetButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.loadTournamnetButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loadTournamnetButton.Font = new System.Drawing.Font("Segoe UI Black", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.loadTournamnetButton.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.loadTournamnetButton.Location = new System.Drawing.Point(105, 197);
            this.loadTournamnetButton.Margin = new System.Windows.Forms.Padding(2);
            this.loadTournamnetButton.Name = "loadTournamnetButton";
            this.loadTournamnetButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.loadTournamnetButton.Size = new System.Drawing.Size(251, 49);
            this.loadTournamnetButton.TabIndex = 53;
            this.loadTournamnetButton.Text = "Load Tournament";
            this.loadTournamnetButton.UseVisualStyleBackColor = true;
            // 
            // loadingExistingTournamentLabel
            // 
            this.loadingExistingTournamentLabel.AutoSize = true;
            this.loadingExistingTournamentLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.loadingExistingTournamentLabel.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.loadingExistingTournamentLabel.Location = new System.Drawing.Point(63, 101);
            this.loadingExistingTournamentLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.loadingExistingTournamentLabel.Name = "loadingExistingTournamentLabel";
            this.loadingExistingTournamentLabel.Size = new System.Drawing.Size(334, 37);
            this.loadingExistingTournamentLabel.TabIndex = 52;
            this.loadingExistingTournamentLabel.Text = "Load Existing Tournament";
            // 
            // loadExistingTournamentDropDown
            // 
            this.loadExistingTournamentDropDown.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loadExistingTournamentDropDown.FormattingEnabled = true;
            this.loadExistingTournamentDropDown.Location = new System.Drawing.Point(13, 140);
            this.loadExistingTournamentDropDown.Margin = new System.Windows.Forms.Padding(2);
            this.loadExistingTournamentDropDown.Name = "loadExistingTournamentDropDown";
            this.loadExistingTournamentDropDown.Size = new System.Drawing.Size(435, 38);
            this.loadExistingTournamentDropDown.TabIndex = 51;
            // 
            // tournamentDashboardLabel
            // 
            this.tournamentDashboardLabel.AutoSize = true;
            this.tournamentDashboardLabel.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tournamentDashboardLabel.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.tournamentDashboardLabel.Location = new System.Drawing.Point(54, 21);
            this.tournamentDashboardLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.tournamentDashboardLabel.Name = "tournamentDashboardLabel";
            this.tournamentDashboardLabel.Size = new System.Drawing.Size(353, 45);
            this.tournamentDashboardLabel.TabIndex = 50;
            this.tournamentDashboardLabel.Text = "Tournament Dashboard";
            // 
            // TorunamentDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(463, 373);
            this.Controls.Add(this.createTournamnetButton);
            this.Controls.Add(this.loadTournamnetButton);
            this.Controls.Add(this.loadingExistingTournamentLabel);
            this.Controls.Add(this.loadExistingTournamentDropDown);
            this.Controls.Add(this.tournamentDashboardLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TorunamentDashboard";
            this.Text = "Torunament Dashboard";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button createTournamnetButton;
        private System.Windows.Forms.Button loadTournamnetButton;
        private System.Windows.Forms.Label loadingExistingTournamentLabel;
        private System.Windows.Forms.ComboBox loadExistingTournamentDropDown;
        private System.Windows.Forms.Label tournamentDashboardLabel;
    }
}