using Consultation.App.Dashboard;
using Consultation.App.Repository;
using Consultation.App.Service;
using Consultation.App.Service.IService;
using Consultation.App.ViewModels.DashboardModels;
using Consultation.App.Views;
using Consultation.App.Views.IViews;
using Consultation.Domain.Enum;
using Consultation.Service.IService;
using Microsoft.VisualBasic.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consultation.App.Presenters
{
    public class DashboardPresenter
    {
        private readonly IDashboardView _dashboardview;
        private readonly IConsultationRequestServices _consultationrequestservices;
        private readonly IMainView _mainview;

        public DashboardPresenter(IDashboardView dashboardview, IConsultationRequestServices consultationrequestservices,
            IMainView mainview)
        {
            _mainview = mainview;
            _dashboardview = dashboardview;
            _consultationrequestservices = consultationrequestservices;
            _dashboardview.ShowCPEConsultationData += ShowCPEConsultationData;
        }

        public void ShowCPEConsultationData(object? sender, EventArgs e)
        {
            var consultationRequest = _consultationrequestservices.TotalPendingConsultation("CPE", Status.Pending);
            _dashboardview.TotalPendingConsultation = 5;
        }

    }
}
