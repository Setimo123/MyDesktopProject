using Consultation.App.ConsultationManagement;
using Consultation.App.Views.Controls.ConsultationManagement;
using Consultation.App.Views.Controls.ConsultationManagement.IView;
using Consultation.Service.IService;
using Consultation.Domain.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consultation.App.Presenters.Consultation
{
    public class CSWindowPresenter
    {
        private ICSWindowView _cSWindow;
        private IEditConsultationService _editConsultationService;

        public CSWindowPresenter(ICSWindowView cSWindow, IEditConsultationService editConsultationService)
        {
            _cSWindow = cSWindow;
            _editConsultationService = editConsultationService;
            _cSWindow.LoadConsultationRequest += LoadConsultationRequest;
        }

        public async void LoadConsultationRequest(object? obj, EventArgs e)
        {
            ICollection<ConsultationCard> consultationCards = new List<ConsultationCard>();

            var consultations = await _editConsultationService.getAllConsultations();
        }
    }
}
