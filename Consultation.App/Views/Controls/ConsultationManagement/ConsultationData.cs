﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consultation.App.Views.Controls.ConsultationManagement
{
    public class ConsultationData
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string CourseCode { get; set; }
        public string Faculty { get; set; }
        public string Location { get; set; }
        public string IDNumber { get; set; }
        public string Concern { get; set; }
        public string Date { get; set; }
        public string Time { get; set; }

        public string Status { get; set; }
        public ConsultationData Data { get; internal set; }
    }

}