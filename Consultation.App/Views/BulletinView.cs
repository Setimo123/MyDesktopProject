﻿using Consultation.App.Views.Controls.BulletinManagement;
using Consultation.App.Views.IViews;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Consultation.App.Views
{
    public partial class BulletinView : UserControl, IBulletinView
    {
        public BulletinView()
        {
            InitializeComponent();

            btnBulletinView_Click(btnBulletinView, EventArgs.Empty);
        }

        public UserControl AsUserControl => this;

        private void btnCreateBulletin_Click(object sender, EventArgs e)
        {
            CreateBulletin bulletinForm = new CreateBulletin();
            bulletinForm.ShowDialog();
            btnBulletinView_Click(btnBulletinView, EventArgs.Empty);    // automatic refresh
        }

        private void btnBulletinView_Click(object sender, EventArgs e)
        {
            btnBulletinView.ForeColor = Color.FromArgb(190, 0, 2);
            btnBulletinView.Font = new Font(btnBulletinView.Font, FontStyle.Bold);
            btnArchive.ForeColor = Color.FromArgb(86, 93, 109);
            btnArchive.Font = new Font(btnArchive.Font, FontStyle.Regular);
            MoveUnderline(btnBulletinView);

            lblBulletinHeader.Text = "Active Bulletins";

            // backend
            flpBulletinList.Controls.Clear();
            for (int i = 0; i < 5; ++i)
            {
                flpBulletinList.Controls.Add(new BulletinCard());
            }
        }

        private void btnArchive_Click(object sender, EventArgs e)
        {
            btnArchive.ForeColor = Color.FromArgb(190, 0, 2);
            btnArchive.Font = new Font(btnBulletinView.Font, FontStyle.Bold);
            btnBulletinView.ForeColor = Color.FromArgb(86, 93, 109);
            btnBulletinView.Font = new Font(btnArchive.Font, FontStyle.Regular);
            MoveUnderline(btnArchive);

            lblBulletinHeader.Text = "Archived Bulletins";

            // backend
            flpBulletinList.Controls.Clear();
            for (int i = 0; i < 3; ++i)
            {
                flpBulletinList.Controls.Add(new ArchiveCard());
            }
        }

        private void MoveUnderline(Guna.UI2.WinForms.Guna2Button targetButton)
        {
            panelUnderline.Width = targetButton.Width;
            panelUnderline.Left = targetButton.Left;
            panelUnderline.Top = targetButton.Bottom - 4;
            panelUnderline.Visible = true;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            if (lblBulletinHeader.Text == "Active Bulletins")
            {
                btnBulletinView_Click(btnBulletinView, EventArgs.Empty);
            }
            else
            {
                btnArchive_Click(btnArchive, EventArgs.Empty);
            }
        }
    }
}