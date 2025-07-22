﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Consultation.App.Views.Controls.ConsultationManagement;
using Consultation.App.Views.Controls.ConsultationManagement.IView;
using Consultation.Infrastructure.Data;

namespace Consultation.App.ConsultationManagement
{

    public partial class CSWindow : UserControl, ICSWindowView
    {
       
        public event EventHandler<ConsultationCard> CardArchived;
        public event EventHandler LoadConsultationRequest;
        //public event EventHandler RemoveConsulationRequest;

        public CSWindow()
        {
            InitializeComponent();

            LoadConsultationRequest?.Invoke(this, EventArgs.Empty);

            // what does this do??
            using (var context = new AppDbContext())
            {
                var consutations = context.ConsultationRequest
                    .OrderByDescending(c => c.DateSchedule)
                    .ToList();

                var consulationData = consutations.Select(c => new ConsultationData
                {
                    ID = c.ConsultationID,
                    Name = c.Student.StudentName,
                    CourseCode = c.SubjectCode,
                    Concern = c.Concern,
                    Date = c.DateSchedule.ToShortDateString(),
                    Time = c.StartedTime.ToShortTimeString(),
                    Faculty = c.Faculty.FacultyName,
                    IDNumber = c.Student.StudentUMID,
                    Location = "",
                    Status = c.Status.ToString()
                }).ToList();

                if(consulationData.Count == 0)
                {
                    ConsultationCard card = new ConsultationCard(new ConsultationData
                    {
                        Name = "No consultation requests available.",
                        CourseCode = "",
                        Concern = "",
                        Date = "",
                        Time = "",
                        Faculty = "",
                        IDNumber = "",
                        Location = "",
                        Status = ""
                    });
                    card.ArchiveRequested += (s, e) => CardArchived?.Invoke(s, card);
                    WindowPanelConsultation.Controls.Add(card);
                }

                foreach (var data in consulationData)
                {

                    ConsultationCard card = new ConsultationCard(data);


                    card.ArchiveRequested += (s, e) => CardArchived?.Invoke(s, card);

                    WindowPanelConsultation.Controls.Add(card);
                }

            }

        }

        private void OnArchiveRequested(ConsultationCard card)
        {
          
            CardArchived?.Invoke(this, card);
        }

        public void RemoveCard(ConsultationCard card)
        {
            if (WindowPanelConsultation.Controls.Contains(card))
                WindowPanelConsultation.Controls.Remove(card);
        }
    }
}
