﻿using Consultation.App.Views.Controls.BulletinManagement;
using Consultation.App.Dashboard.Activity_Feed_Panel;
using Consultation.App.Presenters;
using Consultation.App.ViewModels.DashboardModels;
using Consultation.App.Views.Controls.Dashboard.Quick_Actions_Panel;
using Consultation.App.Views.IViews;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Consultation.App.Service;

namespace Consultation.App.Dashboard
{
    public partial class DashboardView : UserControl, IDashboardView
    {
        public event EventHandler ButtonClick;

        private Color bulletinDefaultColor;
        private Color consultationDefaultColor;
        private Color hoverColor = Color.LightBlue;


        private DashboardPresenter _presenter;

        public UserControl AsUserControl => this;



        public DashboardView()
        {
            InitializeComponent();
            //this.Load += MainDashboardUserControl_Load;

            createNewBulletin1.Cursor = Cursors.Hand;
            manageConsultation1.Cursor = Cursors.Hand;
            addUser1.Cursor = Cursors.Hand;
            systemSettings1.Cursor = Cursors.Hand;
            BulletinButton.Cursor = Cursors.Hand;
            ConsultationButton.Cursor = Cursors.Hand;

            bulletinDefaultColor = createNewBulletin1.BackColor;
            consultationDefaultColor = manageConsultation1.BackColor;


            MakePanelClickable(materialCardCPE, (s, e) => ShowCPEConsultationData?.Invoke(s, e));


            //hover events for buttons
            AttachHoverEvents(createNewBulletin1, createNewBulletin1_MouseEnter, createNewBulletin1_MouseLeave);
            AttachHoverEvents(materialCardCPE, MaterialCPE_MouseEnter, MaterialCPE_MouseLeave);
            AttachHoverEvents(manageConsultation1, manageConsultation1_MouseEnter, manageConsultation1_MouseLeave);
            AttachHoverEvents(addUser1, addUser1_MouseEnter, addUser1_MouseLeave);
            AttachHoverEvents(systemSettings1, systemSettings1_MouseEnter, systemSettings1_MouseLeave);


        }

        private void MakePanelClickable(Panel panel, EventHandler handler)
        {
            panel.Click += handler;

            foreach (Control ctrl in panel.Controls)
            {
                ctrl.Click += handler;
            }
        }


        //private async void MainDashboardUserControl_Load(object sender, EventArgs e)
        //{
        //    ActivityFeedPanel.Controls.Add(new Bulletin());
        //    BulletinButton.CustomBorderThickness = new Padding(0, 0, 0, 3);

        //    _presenter = new DashboardPresenter(this, new ConsultationRequestServices());
        //}

        public void LoadRecentBulletins(List<BulletinModel> bulletins)
        {
            ActivityFeedPanel.Controls.Clear();

            foreach (var b in bulletins)
            {
                var card = new BulletinCards(b.Title, b.Status, b.Body, b.DatePosted);
                ActivityFeedPanel.Controls.Add(card);
            }
        }

        public void LoadRecentConsultations(List<ConsultationModel> consultations)
        {
            ActivityFeedPanel.Controls.Clear();

            foreach (var c in consultations)
            {
                var card = new ConsultationCards(c.Title, c.Status, c.Body, c.Course, c.DateScheduled);
                ActivityFeedPanel.Controls.Add(card);
            }
        }

        public void UpdateDashboardStats(int published, int pending, int completed, int upcoming)
        {
            BulletinPublishedCount.Text = published.ToString();
            PendingApprovalsCount.Text = pending.ToString();
            ConsultationsCompletedCount.Text = completed.ToString();
            UpcomingSessionsCount.Text = upcoming.ToString();
        }

        public void UpdateConsultationStats(int CPE, int EE, int ECE, int CE, int ME, int CHE)
        {
            ConsultationCountCPE.Text = CPE.ToString();
            ConsultationCountEE.Text = EE.ToString();
            ConsultationCountECE.Text = ECE.ToString();
            ConsultationCountCE.Text = CE.ToString();
            ConsultationCountME.Text = ME.ToString();
            ConsultationCountCHE.Text = CHE.ToString();
        }

        private void BulletinButton_Click_1(object sender, EventArgs e)
        {
            ResetButtonBorders();
            BulletinButton.CustomBorderThickness = new Padding(0, 0, 0, 3);
            BulletinButton.CustomBorderColor = Color.Red;
            BulletinButton.ForeColor = Color.Red;

            ActivityFeedPanel.Controls.Clear();
            ActivityFeedPanel.Controls.Add(new Bulletin());
        }

        private void ConsultationButton_Click_1(object sender, EventArgs e)
        {
            ResetButtonBorders();
            ConsultationButton.CustomBorderThickness = new Padding(0, 0, 0, 3);
            ConsultationButton.CustomBorderColor = Color.Red;
            ConsultationButton.ForeColor = Color.Red;

            ActivityFeedPanel.Controls.Clear();
            ActivityFeedPanel.Controls.Add(new Consultation2());
        }

        private void ResetButtonBorders()
        {
            BulletinButton.CustomBorderThickness = new Padding(0, 0, 0, 0);
            ConsultationButton.CustomBorderThickness = new Padding(0, 0, 0, 0);

            BulletinButton.ForeColor = Color.Black;
            ConsultationButton.ForeColor = Color.Black;
        }

        private void AttachHoverEvents(Control parent, EventHandler onEnter, EventHandler onLeave)
        {
            parent.MouseEnter += onEnter;
            parent.MouseLeave += onLeave;

            foreach (Control child in parent.Controls)
            {
                AttachHoverEvents(child, onEnter, onLeave);
            }
        }

        private void createNewBulletin1_Load(object sender, EventArgs e)
        {
        }

        private void createNewBulletin1_MouseEnter(object sender, EventArgs e)
        {
            createNewBulletin1.BackColor = hoverColor;
        }

        private void MaterialCPE_MouseEnter(object sender, EventArgs e)
        {
            materialCardCPE.BackColor = hoverColor;
        }
        private void createNewBulletin1_MouseLeave(object sender, EventArgs e)
        {
            createNewBulletin1.BackColor = bulletinDefaultColor;
        }
        private void MaterialCPE_MouseLeave(object sender, EventArgs e)
        {
            materialCardCPE.BackColor = bulletinDefaultColor;
        }

        private void manageConsultation1_MouseEnter(object sender, EventArgs e)
        {
            manageConsultation1.BackColor = hoverColor;
        }

        private void manageConsultation1_MouseLeave(object sender, EventArgs e)
        {
            manageConsultation1.BackColor = consultationDefaultColor;
        }

        private void addUser1_MouseEnter(object sender, EventArgs e)
        {
            addUser1.BackColor = hoverColor;
        }

        private void addUser1_MouseLeave(object sender, EventArgs e)
        {
            addUser1.BackColor = consultationDefaultColor;
        }

        private void systemSettings1_MouseEnter(object sender, EventArgs e)
        {
            systemSettings1.BackColor = hoverColor;
        }

        private void systemSettings1_MouseLeave(object sender, EventArgs e)
        {
            systemSettings1.BackColor = consultationDefaultColor;
        }

        private void createNewBulletin1_Click(object sender, EventArgs e)
        {
        }

        private void DashboardView_Load(object sender, EventArgs e)
        {

        }

        //All events in the DashBoard
        public event EventHandler ShowCPEConsultationData;

        //All Properties
        public string AdminName { set => lbl_UserName.Text = value; }
        public int TotalPendingConsultation { set => PendingApprovalsCount.Text = value.ToString(); }
        public int TotalCompletConsultation { set => ConsultationsCompletedCount.Text = value.ToString(); }
        public int TotalUpcomingConsultation { set => UpcomingSessionsCount.Text = value.ToString(); }


    }
}
