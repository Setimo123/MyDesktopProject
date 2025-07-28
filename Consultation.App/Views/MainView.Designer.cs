﻿namespace Consultation.App.Views
{
    partial class MainView
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainView));
            sidePanel = new Syncfusion.Windows.Forms.Tools.GradientPanel();
            pictureBoxLogo = new PictureBox();
            label3 = new Label();
            buttonPreference = new Button();
            settings_icon = new ImageList(components);
            label2 = new Label();
            buttonSFManagement = new Button();
            userManagement_icon = new ImageList(components);
            buttonConsultation = new Button();
            consultation_icon = new ImageList(components);
            buttonBulletin = new Button();
            bulletin_icon = new ImageList(components);
            label1 = new Label();
            buttonDashboard = new Button();
            dashboard_icon = new ImageList(components);
            profilePanel = new Panel();
            labelProfileRole = new Label();
            labelProfileName = new Label();
            pictureBoxProfile = new PictureBox();
            panelContainer = new Panel();
            ((System.ComponentModel.ISupportInitialize)sidePanel).BeginInit();
            sidePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).BeginInit();
            profilePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxProfile).BeginInit();
            SuspendLayout();
            // 
            // sidePanel
            // 
            sidePanel.BackColor = SystemColors.ActiveCaption;
            sidePanel.BackgroundColor = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, Color.FromArgb(117, 7, 39), Color.FromArgb(197, 62, 63));
            sidePanel.Border3DStyle = Border3DStyle.Flat;
            sidePanel.BorderStyle = BorderStyle.None;
            sidePanel.Controls.Add(pictureBoxLogo);
            sidePanel.Controls.Add(label3);
            sidePanel.Controls.Add(buttonPreference);
            sidePanel.Controls.Add(label2);
            sidePanel.Controls.Add(buttonSFManagement);
            sidePanel.Controls.Add(buttonConsultation);
            sidePanel.Controls.Add(buttonBulletin);
            sidePanel.Controls.Add(label1);
            sidePanel.Controls.Add(buttonDashboard);
            sidePanel.Controls.Add(profilePanel);
            sidePanel.Dock = DockStyle.Left;
            sidePanel.ForeColor = SystemColors.ControlText;
            sidePanel.Location = new Point(0, 0);
            sidePanel.Margin = new Padding(4, 5, 4, 5);
            sidePanel.Name = "sidePanel";
            sidePanel.Size = new Size(371, 1050);
            sidePanel.TabIndex = 0;
            // 
            // pictureBoxLogo
            // 
            pictureBoxLogo.BackColor = Color.Transparent;
            pictureBoxLogo.Image = Properties.Icons.LOGO_name__Custom___1_;
            pictureBoxLogo.Location = new Point(9, 42);
            pictureBoxLogo.Margin = new Padding(4, 5, 4, 5);
            pictureBoxLogo.Name = "pictureBoxLogo";
            pictureBoxLogo.Size = new Size(354, 160);
            pictureBoxLogo.TabIndex = 0;
            pictureBoxLogo.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold);
            label3.ForeColor = SystemColors.ControlLightLight;
            label3.Location = new Point(23, 711);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(128, 33);
            label3.TabIndex = 11;
            label3.Text = "Settings";
            // 
            // buttonPreference
            // 
            buttonPreference.BackColor = Color.Transparent;
            buttonPreference.FlatAppearance.BorderSize = 0;
            buttonPreference.FlatStyle = FlatStyle.Flat;
            buttonPreference.Font = new Font("Microsoft Sans Serif", 12F);
            buttonPreference.ForeColor = SystemColors.ControlLightLight;
            buttonPreference.ImageAlign = ContentAlignment.MiddleLeft;
            buttonPreference.ImageIndex = 0;
            buttonPreference.ImageList = settings_icon;
            buttonPreference.Location = new Point(14, 772);
            buttonPreference.Margin = new Padding(4, 5, 4, 5);
            buttonPreference.Name = "buttonPreference";
            buttonPreference.Size = new Size(353, 80);
            buttonPreference.TabIndex = 10;
            buttonPreference.Text = "   Security";
            buttonPreference.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonPreference.UseVisualStyleBackColor = false;
            // 
            // settings_icon
            // 
            settings_icon.ColorDepth = ColorDepth.Depth32Bit;
            settings_icon.ImageStream = (ImageListStreamer)resources.GetObject("settings_icon.ImageStream");
            settings_icon.TransparentColor = Color.Transparent;
            settings_icon.Images.SetKeyName(0, "m_settings.png");
            settings_icon.Images.SetKeyName(1, "m_settings_select.png");
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold);
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(34, 578);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(194, 33);
            label2.TabIndex = 7;
            label2.Text = "Management";
            // 
            // buttonSFManagement
            // 
            buttonSFManagement.BackColor = Color.Transparent;
            buttonSFManagement.FlatAppearance.BorderSize = 0;
            buttonSFManagement.FlatStyle = FlatStyle.Flat;
            buttonSFManagement.Font = new Font("Microsoft Sans Serif", 12F);
            buttonSFManagement.ForeColor = SystemColors.ControlLightLight;
            buttonSFManagement.ImageAlign = ContentAlignment.MiddleLeft;
            buttonSFManagement.ImageIndex = 0;
            buttonSFManagement.ImageList = userManagement_icon;
            buttonSFManagement.Location = new Point(23, 626);
            buttonSFManagement.Margin = new Padding(4, 5, 4, 5);
            buttonSFManagement.Name = "buttonSFManagement";
            buttonSFManagement.Size = new Size(353, 80);
            buttonSFManagement.TabIndex = 6;
            buttonSFManagement.Text = "   User Management";
            buttonSFManagement.TextAlign = ContentAlignment.MiddleLeft;
            buttonSFManagement.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonSFManagement.UseVisualStyleBackColor = false;
            // 
            // userManagement_icon
            // 
            userManagement_icon.ColorDepth = ColorDepth.Depth32Bit;
            userManagement_icon.ImageStream = (ImageListStreamer)resources.GetObject("userManagement_icon.ImageStream");
            userManagement_icon.TransparentColor = Color.Transparent;
            userManagement_icon.Images.SetKeyName(0, "m_user.png");
            userManagement_icon.Images.SetKeyName(1, "m_user_select.png");
            // 
            // buttonConsultation
            // 
            buttonConsultation.BackColor = Color.Transparent;
            buttonConsultation.FlatAppearance.BorderSize = 0;
            buttonConsultation.FlatStyle = FlatStyle.Flat;
            buttonConsultation.Font = new Font("Microsoft Sans Serif", 12F);
            buttonConsultation.ForeColor = SystemColors.ControlLightLight;
            buttonConsultation.ImageAlign = ContentAlignment.MiddleLeft;
            buttonConsultation.ImageIndex = 0;
            buttonConsultation.ImageList = consultation_icon;
            buttonConsultation.Location = new Point(23, 470);
            buttonConsultation.Margin = new Padding(4, 5, 4, 5);
            buttonConsultation.Name = "buttonConsultation";
            buttonConsultation.Size = new Size(353, 80);
            buttonConsultation.TabIndex = 5;
            buttonConsultation.Text = "   Consultation";
            buttonConsultation.TextAlign = ContentAlignment.MiddleLeft;
            buttonConsultation.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonConsultation.UseVisualStyleBackColor = false;
            // 
            // consultation_icon
            // 
            consultation_icon.ColorDepth = ColorDepth.Depth32Bit;
            consultation_icon.ImageStream = (ImageListStreamer)resources.GetObject("consultation_icon.ImageStream");
            consultation_icon.TransparentColor = Color.Transparent;
            consultation_icon.Images.SetKeyName(0, "m_consult.png");
            consultation_icon.Images.SetKeyName(1, "m_consult_select.png");
            // 
            // buttonBulletin
            // 
            buttonBulletin.BackColor = Color.Transparent;
            buttonBulletin.FlatAppearance.BorderSize = 0;
            buttonBulletin.FlatStyle = FlatStyle.Flat;
            buttonBulletin.Font = new Font("Microsoft Sans Serif", 12F);
            buttonBulletin.ForeColor = SystemColors.ControlLightLight;
            buttonBulletin.ImageAlign = ContentAlignment.MiddleLeft;
            buttonBulletin.ImageIndex = 0;
            buttonBulletin.ImageList = bulletin_icon;
            buttonBulletin.Location = new Point(23, 375);
            buttonBulletin.Margin = new Padding(4, 5, 4, 5);
            buttonBulletin.Name = "buttonBulletin";
            buttonBulletin.Size = new Size(353, 70);
            buttonBulletin.TabIndex = 4;
            buttonBulletin.Text = "   Bulletin";
            buttonBulletin.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonBulletin.UseVisualStyleBackColor = false;
            // 
            // bulletin_icon
            // 
            bulletin_icon.ColorDepth = ColorDepth.Depth32Bit;
            bulletin_icon.ImageStream = (ImageListStreamer)resources.GetObject("bulletin_icon.ImageStream");
            bulletin_icon.TransparentColor = Color.Transparent;
            bulletin_icon.Images.SetKeyName(0, "m_bulletin.png");
            bulletin_icon.Images.SetKeyName(1, "m_bulletin-select.png");
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(23, 235);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(82, 33);
            label1.TabIndex = 3;
            label1.Text = "Main";
            // 
            // buttonDashboard
            // 
            buttonDashboard.BackColor = Color.Transparent;
            buttonDashboard.Cursor = Cursors.Hand;
            buttonDashboard.FlatAppearance.BorderSize = 0;
            buttonDashboard.FlatStyle = FlatStyle.Flat;
            buttonDashboard.Font = new Font("Microsoft Sans Serif", 12F);
            buttonDashboard.ForeColor = SystemColors.ControlLightLight;
            buttonDashboard.ImageAlign = ContentAlignment.MiddleLeft;
            buttonDashboard.ImageIndex = 0;
            buttonDashboard.ImageList = dashboard_icon;
            buttonDashboard.Location = new Point(23, 295);
            buttonDashboard.Margin = new Padding(4, 5, 4, 5);
            buttonDashboard.Name = "buttonDashboard";
            buttonDashboard.Size = new Size(353, 70);
            buttonDashboard.TabIndex = 2;
            buttonDashboard.Text = "  Dashboard";
            buttonDashboard.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonDashboard.UseVisualStyleBackColor = false;
            // 
            // dashboard_icon
            // 
            dashboard_icon.ColorDepth = ColorDepth.Depth32Bit;
            dashboard_icon.ImageStream = (ImageListStreamer)resources.GetObject("dashboard_icon.ImageStream");
            dashboard_icon.TransparentColor = Color.Transparent;
            dashboard_icon.Images.SetKeyName(0, "m_dashboard.png");
            dashboard_icon.Images.SetKeyName(1, "m_dashboard_select.png");
            // 
            // profilePanel
            // 
            profilePanel.Controls.Add(labelProfileRole);
            profilePanel.Controls.Add(labelProfileName);
            profilePanel.Controls.Add(pictureBoxProfile);
            profilePanel.Dock = DockStyle.Bottom;
            profilePanel.Location = new Point(0, 892);
            profilePanel.Margin = new Padding(4, 5, 4, 5);
            profilePanel.Name = "profilePanel";
            profilePanel.Size = new Size(371, 158);
            profilePanel.TabIndex = 1;
            // 
            // labelProfileRole
            // 
            labelProfileRole.AutoSize = true;
            labelProfileRole.BackColor = Color.Transparent;
            labelProfileRole.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelProfileRole.Location = new Point(126, 80);
            labelProfileRole.Margin = new Padding(4, 0, 4, 0);
            labelProfileRole.Name = "labelProfileRole";
            labelProfileRole.Size = new Size(64, 29);
            labelProfileRole.TabIndex = 2;
            labelProfileRole.Text = "Role";
            // 
            // labelProfileName
            // 
            labelProfileName.AutoSize = true;
            labelProfileName.BackColor = Color.Transparent;
            labelProfileName.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelProfileName.Location = new Point(126, 40);
            labelProfileName.Margin = new Padding(4, 0, 4, 0);
            labelProfileName.Name = "labelProfileName";
            labelProfileName.Size = new Size(145, 29);
            labelProfileName.TabIndex = 1;
            labelProfileName.Text = "John Name";
            // 
            // pictureBoxProfile
            // 
            pictureBoxProfile.BackColor = Color.White;
            pictureBoxProfile.Location = new Point(23, 40);
            pictureBoxProfile.Margin = new Padding(4, 5, 4, 5);
            pictureBoxProfile.Name = "pictureBoxProfile";
            pictureBoxProfile.Size = new Size(80, 93);
            pictureBoxProfile.TabIndex = 0;
            pictureBoxProfile.TabStop = false;
            // 
            // panelContainer
            // 
            panelContainer.Dock = DockStyle.Fill;
            panelContainer.Location = new Point(371, 0);
            panelContainer.Margin = new Padding(4, 5, 4, 5);
            panelContainer.Name = "panelContainer";
            panelContainer.Size = new Size(1553, 1050);
            panelContainer.TabIndex = 11;
            // 
            // MainView
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = SystemColors.Window;
            ClientSize = new Size(1924, 1050);
            Controls.Add(panelContainer);
            Controls.Add(sidePanel);
            Margin = new Padding(4, 5, 4, 5);
            Name = "MainView";
            Text = "UMECA";
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)sidePanel).EndInit();
            sidePanel.ResumeLayout(false);
            sidePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).EndInit();
            profilePanel.ResumeLayout(false);
            profilePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxProfile).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Syncfusion.Windows.Forms.Tools.GradientPanel sidePanel;
        private Panel profilePanel;
        private PictureBox pictureBoxLogo;
        private Button buttonDashboard;
        private Label label1;
        private Button buttonConsultation;
        private Button buttonBulletin;
        private Label label3;
        private Button buttonPreference;
        private Label label2;
        private Button buttonSFManagement;
        private Label labelProfileRole;
        private Label labelProfileName;
        private PictureBox pictureBoxProfile;
        private ImageList dashboard_icon;
        private ImageList consultation_icon;
        private ImageList bulletin_icon;
        private ImageList settings_icon;
        private ImageList userManagement_icon;
        private Panel panelContainer;
    }
}