using Consultation.App.Dashboard;
using Consultation.App.Repository;
using Consultation.App.Service;
using Consultation.App.Service.IService;
using Consultation.App.ViewModels.DashboardModels;
using Consultation.App.Views;
using Consultation.App.Views.IViews;
using Consultation.Domain;
using Consultation.Domain.Enum;
using Consultation.Service.IService;
using Microsoft.VisualBasic.Logging;
using System;
using System.Collections.Generic;
using System.ComponentModel;
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

        private string ProgramName { get; set; }

        private readonly BindingSource _bindingSource = new BindingSource();

        public DashboardPresenter(IDashboardView dashboardview, IConsultationRequestServices consultationrequestservices,
            IMainView mainview)
        {
            _mainview = mainview;
            _dashboardview = dashboardview;
            _consultationrequestservices = consultationrequestservices;
            _dashboardview.ShowConsultationData += ShowCPEConsultationData;
            _dashboardview.ShowConsultationDataList += ShowConsultationDataList;
        }

        //Reusable Method for binding source 

        //private async Task BindingSourceList()
        //{
        //    //List that get all the data 
        //    List<ConsultationRequest> consultationList =
        //        await _consultationrequestservices.ListOfConsultation(_programName);

        //    _bindingSource.DataSource = new BindingList<ConsultationRequest>(consultationList);
            
        //    //_dashboardview.DisplayListConsultationBinding(_bindingSource);
        //}

        public async void ShowCPEConsultationData(object? sender, EventArgs e)
        {
           var consultationRequest = await _consultationrequestservices.TotalPendingConsultation("CPE", Status.Pending);
           _dashboardview.TotalPendingConsultation = consultationRequest;
            //_programName = _dashboardview.ProgramNameCPE;
        }

        public async void ShowConsultationDataList(object? sender, EventArgs e)
        {
            var consultationRequest = await _consultationrequestservices.TotalPendingConsultation(_dashboardview.ProgramName, Status.Pending);
            _dashboardview.TotalPendingConsultation = consultationRequest;

            List<ConsultationRequest> consultationList = 
                await _consultationrequestservices.ListOfConsultation(_dashboardview.ProgramName);

            List<ConsultationRequest> studentFacultyInfo =
                await _consultationrequestservices.GetListFaclutyStudentInformation(_dashboardview.ProgramName);

            _dashboardview.DisplayListConsultation(studentFacultyInfo);
        }
    }
}
