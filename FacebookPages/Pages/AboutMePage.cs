﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacebookPages.Pages
{
    public partial class AboutMePage : BasePage
    {
        private System.Windows.Forms.Label labelAboutMe;
        private System.Windows.Forms.Label labelBirthDate;
        private System.Windows.Forms.Label labelAducation;
        private System.Windows.Forms.Label labelWorkingPlace;
        private System.Windows.Forms.Label labelStatus;
        private Buttons.PageSwitchButton buttonReturn;
        private System.Windows.Forms.Label labelHometown;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label Residence;
        public FacebookPages.Pages.Data.AboutMePageData Data { private get; set; }

        public AboutMePage()
        {
            InitializeComponent();
        }

        private void switchPageButton_Click(object sender, EventArgs e)
        {
            OnChangePage(sender, e);
        }

        private void InitializeComponent()
        {
            this.labelAboutMe = new System.Windows.Forms.Label();
            this.labelBirthDate = new System.Windows.Forms.Label();
            this.labelAducation = new System.Windows.Forms.Label();
            this.labelWorkingPlace = new System.Windows.Forms.Label();
            this.labelStatus = new System.Windows.Forms.Label();
            this.Residence = new System.Windows.Forms.Label();
            this.buttonReturn = new Buttons.PageSwitchButton();
            this.labelHometown = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // labelAboutMe
            // 
            this.labelAboutMe.AutoSize = true;
            this.labelAboutMe.Font = new System.Drawing.Font("Arial", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelAboutMe.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelAboutMe.Location = new System.Drawing.Point(23, 91);
            this.labelAboutMe.Name = "labelAboutMe";
            this.labelAboutMe.Size = new System.Drawing.Size(152, 34);
            this.labelAboutMe.TabIndex = 0;
            this.labelAboutMe.Text = "About me";
            this.labelAboutMe.Click += new System.EventHandler(this.labelAboutMe_Click);
            // 
            // labelBirthDate
            // 
            this.labelBirthDate.AutoSize = true;
            this.labelBirthDate.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBirthDate.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelBirthDate.Location = new System.Drawing.Point(44, 161);
            this.labelBirthDate.Name = "labelBirthDate";
            this.labelBirthDate.Size = new System.Drawing.Size(98, 25);
            this.labelBirthDate.TabIndex = 1;
            this.labelBirthDate.Text = "Birth date";
            // 
            // labelAducation
            // 
            this.labelAducation.AutoSize = true;
            this.labelAducation.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAducation.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelAducation.Location = new System.Drawing.Point(335, 172);
            this.labelAducation.Name = "labelAducation";
            this.labelAducation.Size = new System.Drawing.Size(100, 25);
            this.labelAducation.TabIndex = 2;
            this.labelAducation.Text = "Aducation";
            // 
            // labelWorkingPlace
            // 
            this.labelWorkingPlace.AutoSize = true;
            this.labelWorkingPlace.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWorkingPlace.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelWorkingPlace.Location = new System.Drawing.Point(335, 219);
            this.labelWorkingPlace.Name = "labelWorkingPlace";
            this.labelWorkingPlace.Size = new System.Drawing.Size(135, 25);
            this.labelWorkingPlace.TabIndex = 3;
            this.labelWorkingPlace.Text = "Working place";
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStatus.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelStatus.Location = new System.Drawing.Point(53, 206);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(65, 25);
            this.labelStatus.TabIndex = 4;
            this.labelStatus.Text = "Status";
            // 
            // Residence
            // 
            this.Residence.AutoSize = true;
            this.Residence.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Residence.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Residence.Location = new System.Drawing.Point(346, 265);
            this.Residence.Name = "Residence";
            this.Residence.Size = new System.Drawing.Size(98, 25);
            this.Residence.TabIndex = 5;
            this.Residence.Text = "Residence";
            // 
            // buttonReturn
            // 
            this.buttonReturn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.buttonReturn.Location = new System.Drawing.Point(0, 0);
            this.buttonReturn.Margin = new System.Windows.Forms.Padding(4);
            this.buttonReturn.Name = "buttonReturn";
            this.buttonReturn.PageChoice = Buttons.PageSwitchButton.ePageChoice.HomePage;
            this.buttonReturn.Size = new System.Drawing.Size(80, 36);
            this.buttonReturn.TabIndex = 69;
            this.buttonReturn.Text = "return";
            this.buttonReturn.UseVisualStyleBackColor = true;
            this.buttonReturn.Click += new System.EventHandler(this.switchPageButton_Click);
            // 
            // labelHometown
            // 
            this.labelHometown.AutoSize = true;
            this.labelHometown.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHometown.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelHometown.Location = new System.Drawing.Point(77, 265);
            this.labelHometown.Name = "labelHometown";
            this.labelHometown.Size = new System.Drawing.Size(106, 25);
            this.labelHometown.TabIndex = 70;
            this.labelHometown.Text = "Hometown";
            // 
            // textBox4
            // 
            this.textBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox4.BackColor = System.Drawing.SystemColors.Info;
            this.textBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.textBox4.Location = new System.Drawing.Point(305, 35);
            this.textBox4.Margin = new System.Windows.Forms.Padding(4);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(261, 28);
            this.textBox4.TabIndex = 71;
            this.textBox4.Text = "theme picture";
            this.textBox4.Visible = false;
            // 
            // AboutMePage
            // 
            this.BackColor = System.Drawing.Color.DarkBlue;
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.labelHometown);
            this.Controls.Add(this.buttonReturn);
            this.Controls.Add(this.Residence);
            this.Controls.Add(this.labelStatus);
            this.Controls.Add(this.labelWorkingPlace);
            this.Controls.Add(this.labelAducation);
            this.Controls.Add(this.labelBirthDate);
            this.Controls.Add(this.labelAboutMe);
            this.Name = "AboutMePage";
            this.Size = new System.Drawing.Size(743, 368);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void labelAboutMe_Click(object sender, EventArgs e)
        {

        }
    }
}
