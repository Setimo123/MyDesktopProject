using Consultation.App.Helpers;
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
    public partial class ConsultationDashBoardCard : UserControl
    {
        public string SubjectName { set => materialLabelSubjectName.Text = value; }

        public string RequestedBy { set => materialLabelRequestedBy.Text = value; }

        public string RequestedTo { set => materialLabelRequestedTo.Text = value; }

        public string ConsultationComplete { set => materialLabelDateSchedule.Text = value ; }
        public string RequestedByDate { set => materialLabelDateRequested.Text = value; }
        public string Program { set => materialLabelProgram.Text = value; }
        public string Concern { set => materialLabelConcern.Text = value; }

        public string DateSchedule { set => materialLabelDateSchedule.Text = value; }



        public ConsultationDashBoardCard()
        {
            InitializeComponent();
            this.BackColor = Color.White;
        }

        public ConsultationDashBoardCard(string subjectName,string requestedBy,string requestedTo,
            string concern,string program,string requestedByDate,string dateSchedule)
        {
            InitializeComponent();
            SubjectName = subjectName;
            RequestedBy = requestedBy;
            RequestedTo = requestedTo;
            Concern = concern;
            Program = program;
            RequestedByDate = requestedByDate;
            DateSchedule = dateSchedule; 
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            Color borderColor = Color.SteelBlue;  
            int borderThickness = 2;            
            int cornerRadius = 15;                

            var g = e.Graphics;
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            using (var path = MaterialSkinCardUIHelper.SetRoundedCorners(new Rectangle(0, 0, this.Width - 1, this.Height - 1), cornerRadius))
            using (var pen = new Pen(borderColor, borderThickness))
            {
                g.DrawPath(pen, path); // ✅ Draw border only
            }
        }

        private void materialLabel1_Click(object sender, EventArgs e)
        {

        }
    }
}
