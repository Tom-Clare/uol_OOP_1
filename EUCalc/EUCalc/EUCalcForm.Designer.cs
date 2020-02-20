namespace EUCalc
{
    partial class EUCalcForm
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
            this.pnlCountryVotes = new System.Windows.Forms.Panel();
            this.pnlCountryVoting = new System.Windows.Forms.Panel();
            this.btnAustriaAbstain = new System.Windows.Forms.Button();
            this.btnAustriaYes = new System.Windows.Forms.Button();
            this.btnAustriaNo = new System.Windows.Forms.Button();
            this.cbxAustria = new System.Windows.Forms.CheckBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblAustriaPopulation = new System.Windows.Forms.Label();
            this.lblAustriaTitle = new System.Windows.Forms.Label();
            this.pnlParticipationButtons = new System.Windows.Forms.Panel();
            this.cbxEurozoneCountries = new System.Windows.Forms.CheckBox();
            this.cbxAllCountries = new System.Windows.Forms.CheckBox();
            this.pnlVotingTitles = new System.Windows.Forms.Panel();
            this.lblVotesTitle = new System.Windows.Forms.Label();
            this.lblCountriesTitle = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.pnlCountryVotes.SuspendLayout();
            this.pnlCountryVoting.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlParticipationButtons.SuspendLayout();
            this.pnlVotingTitles.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlCountryVotes
            // 
            this.pnlCountryVotes.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pnlCountryVotes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlCountryVotes.Controls.Add(this.pnlCountryVoting);
            this.pnlCountryVotes.Controls.Add(this.pnlParticipationButtons);
            this.pnlCountryVotes.Controls.Add(this.pnlVotingTitles);
            this.pnlCountryVotes.Location = new System.Drawing.Point(7, 9);
            this.pnlCountryVotes.Name = "pnlCountryVotes";
            this.pnlCountryVotes.Size = new System.Drawing.Size(448, 691);
            this.pnlCountryVotes.TabIndex = 0;
            // 
            // pnlCountryVoting
            // 
            this.pnlCountryVoting.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlCountryVoting.Controls.Add(this.btnAustriaAbstain);
            this.pnlCountryVoting.Controls.Add(this.btnAustriaYes);
            this.pnlCountryVoting.Controls.Add(this.btnAustriaNo);
            this.pnlCountryVoting.Controls.Add(this.cbxAustria);
            this.pnlCountryVoting.Controls.Add(this.pictureBox1);
            this.pnlCountryVoting.Controls.Add(this.lblAustriaPopulation);
            this.pnlCountryVoting.Controls.Add(this.lblAustriaTitle);
            this.pnlCountryVoting.Location = new System.Drawing.Point(-1, 67);
            this.pnlCountryVoting.Name = "pnlCountryVoting";
            this.pnlCountryVoting.Size = new System.Drawing.Size(448, 65);
            this.pnlCountryVoting.TabIndex = 1;
            // 
            // btnAustriaAbstain
            // 
            this.btnAustriaAbstain.Location = new System.Drawing.Point(388, 16);
            this.btnAustriaAbstain.Name = "btnAustriaAbstain";
            this.btnAustriaAbstain.Size = new System.Drawing.Size(35, 35);
            this.btnAustriaAbstain.TabIndex = 6;
            this.btnAustriaAbstain.Text = "A";
            this.btnAustriaAbstain.UseVisualStyleBackColor = true;
            // 
            // btnAustriaYes
            // 
            this.btnAustriaYes.Location = new System.Drawing.Point(306, 16);
            this.btnAustriaYes.Name = "btnAustriaYes";
            this.btnAustriaYes.Size = new System.Drawing.Size(35, 35);
            this.btnAustriaYes.TabIndex = 4;
            this.btnAustriaYes.Text = "Y";
            this.btnAustriaYes.UseVisualStyleBackColor = true;
            // 
            // btnAustriaNo
            // 
            this.btnAustriaNo.Location = new System.Drawing.Point(347, 16);
            this.btnAustriaNo.Name = "btnAustriaNo";
            this.btnAustriaNo.Size = new System.Drawing.Size(35, 35);
            this.btnAustriaNo.TabIndex = 5;
            this.btnAustriaNo.Text = "N";
            this.btnAustriaNo.UseVisualStyleBackColor = true;
            // 
            // cbxAustria
            // 
            this.cbxAustria.AutoSize = true;
            this.cbxAustria.Location = new System.Drawing.Point(6, 27);
            this.cbxAustria.Name = "cbxAustria";
            this.cbxAustria.Size = new System.Drawing.Size(15, 14);
            this.cbxAustria.TabIndex = 0;
            this.cbxAustria.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(31, 7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // lblAustriaPopulation
            // 
            this.lblAustriaPopulation.AutoSize = true;
            this.lblAustriaPopulation.Location = new System.Drawing.Point(137, 35);
            this.lblAustriaPopulation.Name = "lblAustriaPopulation";
            this.lblAustriaPopulation.Size = new System.Drawing.Size(100, 13);
            this.lblAustriaPopulation.TabIndex = 3;
            this.lblAustriaPopulation.Text = "0.00% of population";
            // 
            // lblAustriaTitle
            // 
            this.lblAustriaTitle.AutoSize = true;
            this.lblAustriaTitle.Location = new System.Drawing.Point(137, 18);
            this.lblAustriaTitle.Name = "lblAustriaTitle";
            this.lblAustriaTitle.Size = new System.Drawing.Size(39, 13);
            this.lblAustriaTitle.TabIndex = 2;
            this.lblAustriaTitle.Text = "Austria";
            // 
            // pnlParticipationButtons
            // 
            this.pnlParticipationButtons.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlParticipationButtons.Controls.Add(this.cbxEurozoneCountries);
            this.pnlParticipationButtons.Controls.Add(this.cbxAllCountries);
            this.pnlParticipationButtons.Location = new System.Drawing.Point(-1, 36);
            this.pnlParticipationButtons.Name = "pnlParticipationButtons";
            this.pnlParticipationButtons.Size = new System.Drawing.Size(448, 32);
            this.pnlParticipationButtons.TabIndex = 6;
            // 
            // cbxEurozoneCountries
            // 
            this.cbxEurozoneCountries.AutoSize = true;
            this.cbxEurozoneCountries.Location = new System.Drawing.Point(155, 7);
            this.cbxEurozoneCountries.Name = "cbxEurozoneCountries";
            this.cbxEurozoneCountries.Size = new System.Drawing.Size(201, 17);
            this.cbxEurozoneCountries.TabIndex = 1;
            this.cbxEurozoneCountries.Text = "Only Eurozone countries participating";
            this.cbxEurozoneCountries.UseVisualStyleBackColor = true;
            // 
            // cbxAllCountries
            // 
            this.cbxAllCountries.AutoSize = true;
            this.cbxAllCountries.Location = new System.Drawing.Point(6, 7);
            this.cbxAllCountries.Name = "cbxAllCountries";
            this.cbxAllCountries.Size = new System.Drawing.Size(143, 17);
            this.cbxAllCountries.TabIndex = 0;
            this.cbxAllCountries.Text = "All countries participating";
            this.cbxAllCountries.UseVisualStyleBackColor = true;
            // 
            // pnlVotingTitles
            // 
            this.pnlVotingTitles.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlVotingTitles.Controls.Add(this.lblVotesTitle);
            this.pnlVotingTitles.Controls.Add(this.lblCountriesTitle);
            this.pnlVotingTitles.Location = new System.Drawing.Point(-1, -1);
            this.pnlVotingTitles.Name = "pnlVotingTitles";
            this.pnlVotingTitles.Size = new System.Drawing.Size(448, 38);
            this.pnlVotingTitles.TabIndex = 1;
            // 
            // lblVotesTitle
            // 
            this.lblVotesTitle.AutoSize = true;
            this.lblVotesTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.lblVotesTitle.Location = new System.Drawing.Point(303, 9);
            this.lblVotesTitle.Name = "lblVotesTitle";
            this.lblVotesTitle.Size = new System.Drawing.Size(49, 17);
            this.lblVotesTitle.TabIndex = 3;
            this.lblVotesTitle.Text = "Votes";
            // 
            // lblCountriesTitle
            // 
            this.lblCountriesTitle.AutoSize = true;
            this.lblCountriesTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.lblCountriesTitle.Location = new System.Drawing.Point(3, 9);
            this.lblCountriesTitle.Name = "lblCountriesTitle";
            this.lblCountriesTitle.Size = new System.Drawing.Size(172, 17);
            this.lblCountriesTitle.TabIndex = 2;
            this.lblCountriesTitle.Text = "Countries participating";
            // 
            // EUCalcForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 711);
            this.Controls.Add(this.pnlCountryVotes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "EUCalcForm";
            this.Text = "EU Voting Calculator";
            this.pnlCountryVotes.ResumeLayout(false);
            this.pnlCountryVoting.ResumeLayout(false);
            this.pnlCountryVoting.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlParticipationButtons.ResumeLayout(false);
            this.pnlParticipationButtons.PerformLayout();
            this.pnlVotingTitles.ResumeLayout(false);
            this.pnlVotingTitles.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlCountryVotes;
        private System.Windows.Forms.CheckBox cbxAustria;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblAustriaPopulation;
        private System.Windows.Forms.Label lblAustriaTitle;
        private System.Windows.Forms.Button btnAustriaYes;
        private System.Windows.Forms.Button btnAustriaAbstain;
        private System.Windows.Forms.Button btnAustriaNo;
        private System.Windows.Forms.Label lblVotesTitle;
        private System.Windows.Forms.Label lblCountriesTitle;
        private System.Windows.Forms.CheckBox cbxAllCountries;
        private System.Windows.Forms.CheckBox cbxEurozoneCountries;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Panel pnlVotingTitles;
        private System.Windows.Forms.Panel pnlParticipationButtons;
        private System.Windows.Forms.Panel pnlCountryVoting;
    }
}

