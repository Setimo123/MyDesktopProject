using Consultation.App.Views.Controls.BulletinManagement;
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
using Consultation.App.Helpers;
using MaterialSkin.Controls;
using Consultation.Domain;
using Consultation.App.Views;

namespace Consultation.App.Dashboard
{
    public partial class DashboardView : UserControl, IDashboardView
    {
        public event EventHandler ButtonClick;

        private Color hoverColor = Color.Red;

        private DashboardPresenter _presenter;

        public UserControl AsUserControl => this;

        public DashboardView()
        {
            InitializeComponent();
            //this.Load += MainDashboardUserControl_Load;

            MakePanelClickable(materialCardCPE, (s, e) => {
                ProgramName = "CPE";
                ActivityFeedLabel.Text = "Computer Engineering Activity Feed";
                ShowConsultationDataList?.Invoke(s, e);
            } );
            MakePanelClickable(materialCardME, (s, e) => {
                ProgramName = "ME";
                ActivityFeedLabel.Text = "Mechanical Engineering Activity Feed";
                ShowConsultationDataList?.Invoke(s, e);
            });
            MakePanelClickable(materialCardEE, (s, e) => {
                ProgramName = "EE";
                ActivityFeedLabel.Text = "Electrical Engineering Activity Feed";
                ShowConsultationDataList?.Invoke(s, e);
            });
            MakePanelClickable(materialCardECE, (s, e) => {
                ProgramName = "ECE";
                ActivityFeedLabel.Text = "Civil Engineering Activity Feed";
                ShowConsultationDataList?.Invoke(s, e);
            });
            MakePanelClickable(materialCardCE, (s, e) => {
                ProgramName = "CE";
                ActivityFeedLabel.Text = "Civil Engineering Activity Feed";
                ShowConsultationDataList?.Invoke(s, e);
            });

            MakePanelClickable(materialCardCHE, (s, e) => {
                ProgramName = "CHE";
                ActivityFeedLabel.Text = "Chemical Engineering Activity Feed";
                ShowConsultationDataList?.Invoke(s, e);
            });


            MaterialSkinCardUIHelper.AddHoverBorder(materialCardCPE, hoverColor, Color.White);
            MaterialSkinCardUIHelper.AddHoverBorder(materialCardME, hoverColor, Color.White);
            MaterialSkinCardUIHelper.AddHoverBorder(materialCardECE, hoverColor, Color.White);
            MaterialSkinCardUIHelper.AddHoverBorder(materialCardEE, hoverColor, Color.White);
            MaterialSkinCardUIHelper.AddHoverBorder(materialCardAllPrograms, hoverColor, Color.White);
            MaterialSkinCardUIHelper.AddHoverBorder(materialCardCE, hoverColor, Color.White);

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

        //public void LoadRecentBulletins(List<BulletinModel> bulletins)
        //{
        //    ActivityFeedPanel.Controls.Clear();

        //    foreach (var b in bulletins)
        //    {
        //        var card = new BulletinCards(b.Title, b.Status, b.Body, b.DatePosted);
        //        ActivityFeedPanel.Controls.Add(card);
        //    }
        //}

        //public void LoadRecentConsultations(List<ConsultationModel> consultations)
        //{
        //    ActivityFeedPanel.Controls.Clear();

        //    foreach (var c in consultations)
        //    {
        //        var card = new ConsultationCards(c.Title, c.Status, c.Body, c.Course, c.DateScheduled);
        //        ActivityFeedPanel.Controls.Add(card);
        //    }
        //}

        public void UpdateDashboardStats(int published, int pending, int completed, int upcoming)
        {
            BulletinPublishedCount.Text = published.ToString();
            PendingApprovalsCount.Text = pending.ToString();
            ConsultationsCompletedCount.Text = completed.ToString();
            UpcomingSessionsCount.Text = upcoming.ToString();
        }

        //private void BulletinButton_Click_1(object sender, EventArgs e)
        //{
        //    ResetButtonBorders();
        //    BulletinButton.CustomBorderThickness = new Padding(0, 0, 0, 3);
        //    BulletinButton.CustomBorderColor = Color.Red;
        //    BulletinButton.ForeColor = Color.Red;

        //    ActivityFeedPanel.Controls.Clear();
        //    ActivityFeedPanel.Controls.Add(new Bulletin());
        //}

        //private void ConsultationButton_Click_1(object sender, EventArgs e)
        //{
        //    ResetButtonBorders();
        //    ConsultationButton.CustomBorderThickness = new Padding(0, 0, 0, 3);
        //    ConsultationButton.CustomBorderColor = Color.Red;
        //    ConsultationButton.ForeColor = Color.Red;

        //    ActivityFeedPanel.Controls.Clear();
        //    ActivityFeedPanel.Controls.Add(new Consultation2());
        //}

        private void ResetButtonBorders()
        {
            BulletinButton.CustomBorderThickness = new Padding(0, 0, 0, 0);
            ConsultationButton.CustomBorderThickness = new Padding(0, 0, 0, 0);

            BulletinButton.ForeColor = Color.Black;
            ConsultationButton.ForeColor = Color.Black;
        }


        private void createNewBulletin1_Click(object sender, EventArgs e)
        {
        }

        private void DashboardView_Load(object sender, EventArgs e)
        {

        }

        private void BulletinPublishedCount_Click(object sender, EventArgs e)
        {

        }

        private void Test()
        {
            ConsultationDashBoardCard ca = new ConsultationDashBoardCard();
                flowLayoutActivityFeed.Controls.Add(ca);
        }

        //Normal List without Bindingsource
        public void DisplayListConsultation(List<ConsultationRequest> consultations, Faculty faculty,Student student)
        {
            //Everything should be show in one click
            flowLayoutActivityFeed.Controls.Clear();
            //Comment sa ni kay naay error
            if (faculty == null)
                MessageBox.Show($"No faculty found in the database");

            if (student == null)
                MessageBox.Show($"No student found in the database");

            foreach (ConsultationRequest c in consultations)
            {
                flowLayoutActivityFeed.Controls.Add(new ConsultationDashBoardCard(c.SubjectCode,
                    student.StudentName, faculty.FacultyName, c.Concern, c.ProgramName, c.DateRequested.ToString(),
                    c.DateSchedule.ToString()));
            }

        }

        //All events in the DashBoard
        public event EventHandler ShowConsultationData;
        public event EventHandler ShowConsultationDataList;

        //All Properties
        public int TotalPendingConsultation { set => PendingApprovalsCount.Text = value.ToString(); }
        public int TotalCompletConsultation { set => ConsultationsCompletedCount.Text = value.ToString(); }
        public int TotalUpcomingConsultation { set => UpcomingSessionsCount.Text = value.ToString(); }

        public string ProgramName { set; get; }

    }
}
