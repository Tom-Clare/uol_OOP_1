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
            this.gbxAustria = new System.Windows.Forms.GroupBox();
            this.cbxAustria = new System.Windows.Forms.CheckBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblAustriaTitle = new System.Windows.Forms.Label();
            this.lblAustriaPopulation = new System.Windows.Forms.Label();
            this.btnAustriaYes = new System.Windows.Forms.Button();
            this.btnAustriaNo = new System.Windows.Forms.Button();
            this.btnAustriaAbstain = new System.Windows.Forms.Button();
            this.lblCountriesTitle = new System.Windows.Forms.Label();
            this.lblVotesTitle = new System.Windows.Forms.Label();
            this.gbxVotingTitles = new System.Windows.Forms.GroupBox();
            this.gbxSelectionBoxes = new System.Windows.Forms.GroupBox();
            this.cbxAllCountries = new System.Windows.Forms.CheckBox();
            this.cbxEurozoneCountries = new System.Windows.Forms.CheckBox();
            this.pnlCountryVotes.SuspendLayout();
            this.gbxAustria.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.gbxVotingTitles.SuspendLayout();
            this.gbxSelectionBoxes.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlCountryVotes
            // 
            this.pnlCountryVotes.BackColor = System.Drawing.SystemColors.Control;
            this.pnlCountryVotes.Controls.Add(this.gbxSelectionBoxes);
            this.pnlCountryVotes.Controls.Add(this.gbxVotingTitles);
            this.pnlCountryVotes.Controls.Add(this.gbxAustria);
            this.pnlCountryVotes.Location = new System.Drawing.Point(13, 13);
            this.pnlCountryVotes.Name = "pnlCountryVotes";
            this.pnlCountryVotes.Size = new System.Drawing.Size(493, 676);
            this.pnlCountryVotes.TabIndex = 0;
            // 
            // gbxAustria
            // 
            this.gbxAustria.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.gbxAustria.Controls.Add(this.btnAustriaAbstain);
            this.gbxAustria.Controls.Add(this.btnAustriaNo);
            this.gbxAustria.Controls.Add(this.btnAustriaYes);
            this.gbxAustria.Controls.Add(this.lblAustriaPopulation);
            this.gbxAustria.Controls.Add(this.lblAustriaTitle);
            this.gbxAustria.Controls.Add(this.pictureBox1);
            this.gbxAustria.Controls.Add(this.cbxAustria);
            this.gbxAustria.Location = new System.Drawing.Point(3, 70);
            this.gbxAustria.Name = "gbxAustria";
            this.gbxAustria.Size = new System.Drawing.Size(485, 67);
            this.gbxAustria.TabIndex = 1;
            this.gbxAustria.TabStop = false;
            // 
            // cbxAustria
            // 
            this.cbxAustria.AutoSize = true;
            this.cbxAustria.Location = new System.Drawing.Point(7, 30);
            this.cbxAustria.Name = "cbxAustria";
            this.cbxAustria.Size = new System.Drawing.Size(15, 14);
            this.cbxAustria.TabIndex = 0;
            this.cbxAustria.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(28, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // lblAustriaTitle
            // 
            this.lblAustriaTitle.AutoSize = true;
            this.lblAustriaTitle.Location = new System.Drawing.Point(134, 21);
            this.lblAustriaTitle.Name = "lblAustriaTitle";
            this.lblAustriaTitle.Size = new System.Drawing.Size(39, 13);
            this.lblAustriaTitle.TabIndex = 2;
            this.lblAustriaTitle.Text = "Austria";
            this.lblAustriaTitle.Click += new System.EventHandler(this.lblAustriaTitle_Click);
            // 
            // lblAustriaPopulation
            // 
            this.lblAustriaPopulation.AutoSize = true;
            this.lblAustriaPopulation.Location = new System.Drawing.Point(134, 38);
            this.lblAustriaPopulation.Name = "lblAustriaPopulation";
            this.lblAustriaPopulation.Size = new System.Drawing.Size(100, 13);
            this.lblAustriaPopulation.TabIndex = 3;
            this.lblAustriaPopulation.Text = "0.00% of population";
            // 
            // btnAustriaYes
            // 
            this.btnAustriaYes.Location = new System.Drawing.Point(251, 19);
            this.btnAustriaYes.Name = "btnAustriaYes";
            this.btnAustriaYes.Size = new System.Drawing.Size(70, 35);
            this.btnAustriaYes.TabIndex = 4;
            this.btnAustriaYes.Text = "Yes";
            this.btnAustriaYes.UseVisualStyleBackColor = true;
            this.btnAustriaYes.Click += new System.EventHandler(this.btnAustriaYes_Click);
            // 
            // btnAustriaNo
            // 
            this.btnAustriaNo.Location = new System.Drawing.Point(327, 19);
            this.btnAustriaNo.Name = "btnAustriaNo";
            this.btnAustriaNo.Size = new System.Drawing.Size(70, 35);
            this.btnAustriaNo.TabIndex = 5;
            this.btnAustriaNo.Text = "No";
            this.btnAustriaNo.UseVisualStyleBackColor = true;
            // 
            // btnAustriaAbstain
            // 
            this.btnAustriaAbstain.Location = new System.Drawing.Point(403, 19);
            this.btnAustriaAbstain.Name = "btnAustriaAbstain";
            this.btnAustriaAbstain.Size = new System.Drawing.Size(70, 35);
            this.btnAustriaAbstain.TabIndex = 6;
            this.btnAustriaAbstain.Text = "Abstain";
            this.btnAustriaAbstain.UseVisualStyleBackColor = true;
            // 
            // lblCountriesTitle
            // 
            this.lblCountriesTitle.AutoSize = true;
            this.lblCountriesTitle.Location = new System.Drawing.Point(6, 16);
            this.lblCountriesTitle.Name = "lblCountriesTitle";
            this.lblCountriesTitle.Size = new System.Drawing.Size(111, 13);
            this.lblCountriesTitle.TabIndex = 2;
            this.lblCountriesTitle.Text = "Countries participating";
            // 
            // lblVotesTitle
            // 
            this.lblVotesTitle.AutoSize = true;
            this.lblVotesTitle.Location = new System.Drawing.Point(248, 16);
            this.lblVotesTitle.Name = "lblVotesTitle";
            this.lblVotesTitle.Size = new System.Drawing.Size(34, 13);
            this.lblVotesTitle.TabIndex = 3;
            this.lblVotesTitle.Text = "Votes";
            // 
            // gbxVotingTitles
            // 
            this.gbxVotingTitles.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.gbxVotingTitles.Controls.Add(this.lblCountriesTitle);
            this.gbxVotingTitles.Controls.Add(this.lblVotesTitle);
            this.gbxVotingTitles.Location = new System.Drawing.Point(3, 1);
            this.gbxVotingTitles.Name = "gbxVotingTitles";
            this.gbxVotingTitles.Size = new System.Drawing.Size(485, 37);
            this.gbxVotingTitles.TabIndex = 4;
            this.gbxVotingTitles.TabStop = false;
            // 
            // gbxSelectionBoxes
            // 
            this.gbxSelectionBoxes.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.gbxSelectionBoxes.Controls.Add(this.cbxEurozoneCountries);
            this.gbxSelectionBoxes.Controls.Add(this.cbxAllCountries);
            this.gbxSelectionBoxes.Location = new System.Drawing.Point(3, 37);
            this.gbxSelectionBoxes.Name = "gbxSelectionBoxes";
            this.gbxSelectionBoxes.Size = new System.Drawing.Size(485, 37);
            this.gbxSelectionBoxes.TabIndex = 5;
            this.gbxSelectionBoxes.TabStop = false;
            // 
            // cbxAllCountries
            // 
            this.cbxAllCountries.AutoSize = true;
            this.cbxAllCountries.Location = new System.Drawing.Point(9, 14);
            this.cbxAllCountries.Name = "cbxAllCountries";
            this.cbxAllCountries.Size = new System.Drawing.Size(143, 17);
            this.cbxAllCountries.TabIndex = 0;
            this.cbxAllCountries.Text = "All countries participating";
            this.cbxAllCountries.UseVisualStyleBackColor = true;
            // 
            // cbxEurozoneCountries
            // 
            this.cbxEurozoneCountries.AutoSize = true;
            this.cbxEurozoneCountries.Location = new System.Drawing.Point(158, 14);
            this.cbxEurozoneCountries.Name = "cbxEurozoneCountries";
            this.cbxEurozoneCountries.Size = new System.Drawing.Size(201, 17);
            this.cbxEurozoneCountries.TabIndex = 1;
            this.cbxEurozoneCountries.Text = "Only Eurozone countries participating";
            this.cbxEurozoneCountries.UseVisualStyleBackColor = true;
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
            this.Load += new System.EventHandler(this.EUCalcForm_Load);
            this.pnlCountryVotes.ResumeLayout(false);
            this.gbxAustria.ResumeLayout(false);
            this.gbxAustria.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.gbxVotingTitles.ResumeLayout(false);
            this.gbxVotingTitles.PerformLayout();
            this.gbxSelectionBoxes.ResumeLayout(false);
            this.gbxSelectionBoxes.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlCountryVotes;
        private System.Windows.Forms.GroupBox gbxAustria;
        private System.Windows.Forms.CheckBox cbxAustria;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblAustriaPopulation;
        private System.Windows.Forms.Label lblAustriaTitle;
        private System.Windows.Forms.Button btnAustriaYes;
        private System.Windows.Forms.Button btnAustriaAbstain;
        private System.Windows.Forms.Button btnAustriaNo;
        private System.Windows.Forms.Label lblVotesTitle;
        private System.Windows.Forms.Label lblCountriesTitle;
        private System.Windows.Forms.GroupBox gbxVotingTitles;
        private System.Windows.Forms.GroupBox gbxSelectionBoxes;
        private System.Windows.Forms.CheckBox cbxAllCountries;
        private System.Windows.Forms.CheckBox cbxEurozoneCountries;
    }
}

