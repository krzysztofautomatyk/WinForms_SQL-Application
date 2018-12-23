namespace WinForms_SQL_Application
{
    partial class CreateTournament
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateTournament));
            this.addTeamButton = new System.Windows.Forms.Button();
            this.entryFeeValue = new System.Windows.Forms.TextBox();
            this.selectTeamLabel = new System.Windows.Forms.Label();
            this.torunamentNameValue = new System.Windows.Forms.TextBox();
            this.entryFeeLabel = new System.Windows.Forms.Label();
            this.torunamentPlayersListBox = new System.Windows.Forms.ListBox();
            this.unplayedOnlyCheckbox = new System.Windows.Forms.CheckBox();
            this.selectTeamDropDown = new System.Windows.Forms.ComboBox();
            this.tournamentNameLabel = new System.Windows.Forms.Label();
            this.createTournamentLabel = new System.Windows.Forms.Label();
            this.createNewLinkLabel = new System.Windows.Forms.LinkLabel();
            this.createPrizeButton = new System.Windows.Forms.Button();
            this.torunamentPlayersLabel = new System.Windows.Forms.Label();
            this.deleteSelectedPlayerButton = new System.Windows.Forms.Button();
            this.deleteSelectedPrizeButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.prizesListBox = new System.Windows.Forms.ListBox();
            this.createTournamentButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // addTeamButton
            // 
            this.addTeamButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.addTeamButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGreen;
            this.addTeamButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.addTeamButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addTeamButton.Font = new System.Drawing.Font("Segoe UI Black", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.addTeamButton.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.addTeamButton.Location = new System.Drawing.Point(83, 283);
            this.addTeamButton.Margin = new System.Windows.Forms.Padding(2);
            this.addTeamButton.Name = "addTeamButton";
            this.addTeamButton.Size = new System.Drawing.Size(205, 49);
            this.addTeamButton.TabIndex = 27;
            this.addTeamButton.Text = "Add Team";
            this.addTeamButton.UseVisualStyleBackColor = true;
            // 
            // entryFeeValue
            // 
            this.entryFeeValue.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.entryFeeValue.Location = new System.Drawing.Point(145, 145);
            this.entryFeeValue.Margin = new System.Windows.Forms.Padding(2);
            this.entryFeeValue.Name = "entryFeeValue";
            this.entryFeeValue.Size = new System.Drawing.Size(188, 36);
            this.entryFeeValue.TabIndex = 25;
            this.entryFeeValue.Text = "0";
            // 
            // selectTeamLabel
            // 
            this.selectTeamLabel.AutoSize = true;
            this.selectTeamLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.selectTeamLabel.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.selectTeamLabel.Location = new System.Drawing.Point(12, 193);
            this.selectTeamLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.selectTeamLabel.Name = "selectTeamLabel";
            this.selectTeamLabel.Size = new System.Drawing.Size(159, 37);
            this.selectTeamLabel.TabIndex = 24;
            this.selectTeamLabel.Text = "Select team";
            // 
            // torunamentNameValue
            // 
            this.torunamentNameValue.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.torunamentNameValue.Location = new System.Drawing.Point(19, 99);
            this.torunamentNameValue.Margin = new System.Windows.Forms.Padding(2);
            this.torunamentNameValue.Name = "torunamentNameValue";
            this.torunamentNameValue.Size = new System.Drawing.Size(314, 36);
            this.torunamentNameValue.TabIndex = 22;
            // 
            // entryFeeLabel
            // 
            this.entryFeeLabel.AutoSize = true;
            this.entryFeeLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.entryFeeLabel.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.entryFeeLabel.Location = new System.Drawing.Point(12, 143);
            this.entryFeeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.entryFeeLabel.Name = "entryFeeLabel";
            this.entryFeeLabel.Size = new System.Drawing.Size(131, 37);
            this.entryFeeLabel.TabIndex = 21;
            this.entryFeeLabel.Text = "Entry Fee";
            // 
            // torunamentPlayersListBox
            // 
            this.torunamentPlayersListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.torunamentPlayersListBox.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.torunamentPlayersListBox.FormattingEnabled = true;
            this.torunamentPlayersListBox.ItemHeight = 30;
            this.torunamentPlayersListBox.Location = new System.Drawing.Point(355, 99);
            this.torunamentPlayersListBox.Margin = new System.Windows.Forms.Padding(2);
            this.torunamentPlayersListBox.Name = "torunamentPlayersListBox";
            this.torunamentPlayersListBox.Size = new System.Drawing.Size(295, 122);
            this.torunamentPlayersListBox.TabIndex = 19;
            // 
            // unplayedOnlyCheckbox
            // 
            this.unplayedOnlyCheckbox.AutoSize = true;
            this.unplayedOnlyCheckbox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.unplayedOnlyCheckbox.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.unplayedOnlyCheckbox.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.unplayedOnlyCheckbox.Location = new System.Drawing.Point(566, 17);
            this.unplayedOnlyCheckbox.Margin = new System.Windows.Forms.Padding(2);
            this.unplayedOnlyCheckbox.Name = "unplayedOnlyCheckbox";
            this.unplayedOnlyCheckbox.Size = new System.Drawing.Size(191, 36);
            this.unplayedOnlyCheckbox.TabIndex = 18;
            this.unplayedOnlyCheckbox.Text = "Unplayed Only";
            this.unplayedOnlyCheckbox.UseVisualStyleBackColor = true;
            // 
            // selectTeamDropDown
            // 
            this.selectTeamDropDown.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectTeamDropDown.FormattingEnabled = true;
            this.selectTeamDropDown.Location = new System.Drawing.Point(19, 232);
            this.selectTeamDropDown.Margin = new System.Windows.Forms.Padding(2);
            this.selectTeamDropDown.Name = "selectTeamDropDown";
            this.selectTeamDropDown.Size = new System.Drawing.Size(314, 38);
            this.selectTeamDropDown.TabIndex = 17;
            // 
            // tournamentNameLabel
            // 
            this.tournamentNameLabel.AutoSize = true;
            this.tournamentNameLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tournamentNameLabel.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.tournamentNameLabel.Location = new System.Drawing.Point(12, 60);
            this.tournamentNameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.tournamentNameLabel.Name = "tournamentNameLabel";
            this.tournamentNameLabel.Size = new System.Drawing.Size(245, 37);
            this.tournamentNameLabel.TabIndex = 16;
            this.tournamentNameLabel.Text = "Tournament Name";
            // 
            // createTournamentLabel
            // 
            this.createTournamentLabel.AutoSize = true;
            this.createTournamentLabel.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.createTournamentLabel.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.createTournamentLabel.Location = new System.Drawing.Point(11, 9);
            this.createTournamentLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.createTournamentLabel.Name = "createTournamentLabel";
            this.createTournamentLabel.Size = new System.Drawing.Size(291, 45);
            this.createTournamentLabel.TabIndex = 14;
            this.createTournamentLabel.Text = "Create Tournament";
            // 
            // createNewLinkLabel
            // 
            this.createNewLinkLabel.AutoSize = true;
            this.createNewLinkLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.createNewLinkLabel.Location = new System.Drawing.Point(215, 202);
            this.createNewLinkLabel.Name = "createNewLinkLabel";
            this.createNewLinkLabel.Size = new System.Drawing.Size(118, 25);
            this.createNewLinkLabel.TabIndex = 28;
            this.createNewLinkLabel.TabStop = true;
            this.createNewLinkLabel.Text = "Create Team";
            // 
            // createPrizeButton
            // 
            this.createPrizeButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.createPrizeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGreen;
            this.createPrizeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.createPrizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createPrizeButton.Font = new System.Drawing.Font("Segoe UI Black", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.createPrizeButton.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.createPrizeButton.Location = new System.Drawing.Point(83, 345);
            this.createPrizeButton.Margin = new System.Windows.Forms.Padding(2);
            this.createPrizeButton.Name = "createPrizeButton";
            this.createPrizeButton.Size = new System.Drawing.Size(205, 49);
            this.createPrizeButton.TabIndex = 29;
            this.createPrizeButton.Text = "Create Prize";
            this.createPrizeButton.UseVisualStyleBackColor = true;
            // 
            // torunamentPlayersLabel
            // 
            this.torunamentPlayersLabel.AutoSize = true;
            this.torunamentPlayersLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.torunamentPlayersLabel.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.torunamentPlayersLabel.Location = new System.Drawing.Point(348, 60);
            this.torunamentPlayersLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.torunamentPlayersLabel.Name = "torunamentPlayersLabel";
            this.torunamentPlayersLabel.Size = new System.Drawing.Size(193, 37);
            this.torunamentPlayersLabel.TabIndex = 30;
            this.torunamentPlayersLabel.Text = "Team / Players";
            // 
            // deleteSelectedPlayerButton
            // 
            this.deleteSelectedPlayerButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.deleteSelectedPlayerButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGreen;
            this.deleteSelectedPlayerButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.deleteSelectedPlayerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteSelectedPlayerButton.Font = new System.Drawing.Font("Segoe UI Black", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.deleteSelectedPlayerButton.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.deleteSelectedPlayerButton.Location = new System.Drawing.Point(665, 116);
            this.deleteSelectedPlayerButton.Margin = new System.Windows.Forms.Padding(2);
            this.deleteSelectedPlayerButton.Name = "deleteSelectedPlayerButton";
            this.deleteSelectedPlayerButton.Size = new System.Drawing.Size(179, 95);
            this.deleteSelectedPlayerButton.TabIndex = 31;
            this.deleteSelectedPlayerButton.Text = "Delete Selected";
            this.deleteSelectedPlayerButton.UseVisualStyleBackColor = true;
            // 
            // deleteSelectedPrizeButton
            // 
            this.deleteSelectedPrizeButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.deleteSelectedPrizeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGreen;
            this.deleteSelectedPrizeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.deleteSelectedPrizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteSelectedPrizeButton.Font = new System.Drawing.Font("Segoe UI Black", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.deleteSelectedPrizeButton.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.deleteSelectedPrizeButton.Location = new System.Drawing.Point(665, 300);
            this.deleteSelectedPrizeButton.Margin = new System.Windows.Forms.Padding(2);
            this.deleteSelectedPrizeButton.Name = "deleteSelectedPrizeButton";
            this.deleteSelectedPrizeButton.Size = new System.Drawing.Size(179, 95);
            this.deleteSelectedPrizeButton.TabIndex = 34;
            this.deleteSelectedPrizeButton.Text = "Delete Selected";
            this.deleteSelectedPrizeButton.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.label1.Location = new System.Drawing.Point(348, 244);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 37);
            this.label1.TabIndex = 33;
            this.label1.Text = "Team / Players";
            // 
            // prizesListBox
            // 
            this.prizesListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.prizesListBox.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.prizesListBox.FormattingEnabled = true;
            this.prizesListBox.ItemHeight = 30;
            this.prizesListBox.Location = new System.Drawing.Point(355, 283);
            this.prizesListBox.Margin = new System.Windows.Forms.Padding(2);
            this.prizesListBox.Name = "prizesListBox";
            this.prizesListBox.Size = new System.Drawing.Size(295, 122);
            this.prizesListBox.TabIndex = 32;
            // 
            // createTournamentButton
            // 
            this.createTournamentButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.createTournamentButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGreen;
            this.createTournamentButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.createTournamentButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createTournamentButton.Font = new System.Drawing.Font("Segoe UI Black", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.createTournamentButton.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.createTournamentButton.Location = new System.Drawing.Point(277, 430);
            this.createTournamentButton.Margin = new System.Windows.Forms.Padding(2);
            this.createTournamentButton.Name = "createTournamentButton";
            this.createTournamentButton.Size = new System.Drawing.Size(287, 72);
            this.createTournamentButton.TabIndex = 35;
            this.createTournamentButton.Text = "Create Tournament";
            this.createTournamentButton.UseVisualStyleBackColor = true;
            // 
            // CreateTournament
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(868, 525);
            this.Controls.Add(this.createTournamentButton);
            this.Controls.Add(this.deleteSelectedPrizeButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.prizesListBox);
            this.Controls.Add(this.deleteSelectedPlayerButton);
            this.Controls.Add(this.torunamentPlayersLabel);
            this.Controls.Add(this.createPrizeButton);
            this.Controls.Add(this.createNewLinkLabel);
            this.Controls.Add(this.addTeamButton);
            this.Controls.Add(this.entryFeeValue);
            this.Controls.Add(this.selectTeamLabel);
            this.Controls.Add(this.torunamentNameValue);
            this.Controls.Add(this.entryFeeLabel);
            this.Controls.Add(this.torunamentPlayersListBox);
            this.Controls.Add(this.unplayedOnlyCheckbox);
            this.Controls.Add(this.selectTeamDropDown);
            this.Controls.Add(this.tournamentNameLabel);
            this.Controls.Add(this.createTournamentLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CreateTournament";
            this.Text = "Create Tournament";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addTeamButton;
        private System.Windows.Forms.TextBox entryFeeValue;
        private System.Windows.Forms.Label selectTeamLabel;
        private System.Windows.Forms.TextBox torunamentNameValue;
        private System.Windows.Forms.Label entryFeeLabel;
        private System.Windows.Forms.ListBox torunamentPlayersListBox;
        private System.Windows.Forms.CheckBox unplayedOnlyCheckbox;
        private System.Windows.Forms.ComboBox selectTeamDropDown;
        private System.Windows.Forms.Label tournamentNameLabel;
        private System.Windows.Forms.Label createTournamentLabel;
        private System.Windows.Forms.LinkLabel createNewLinkLabel;
        private System.Windows.Forms.Button createPrizeButton;
        private System.Windows.Forms.Label torunamentPlayersLabel;
        private System.Windows.Forms.Button deleteSelectedPlayerButton;
        private System.Windows.Forms.Button deleteSelectedPrizeButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox prizesListBox;
        private System.Windows.Forms.Button createTournamentButton;
    }
}