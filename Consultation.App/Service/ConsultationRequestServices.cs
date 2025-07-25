using Consultation.App.Repository;
using Consultation.App.Repository.IRepository;
using Consultation.App.Service.IService;
using Consultation.Domain.Enum;
using Consultation.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consultation.App.Service
{
    public class ConsultationRequestServices : IConsultationRequestServices
    {
        private readonly IConsultationRequestRepository _repository;
        public ConsultationRequestServices(AppDbContext context)
        {
            _repository = new ConsultationRequestRepository(context);
        }
        public async Task<int> TotalPendingConsultation(string programName, Status status)
        {
            //For Pending session Card
            try
            {
                var consultations = await _repository.GetConsultation(programName);

                //if (consultations == null)
                //    return 0;

                int totalpending = consultations.Where(c => c.Status == status).Count();
                return totalpending;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"ConsultationRequestServices Error{ex.Message}");
                return 0;
            }
        
        }
    }
}
