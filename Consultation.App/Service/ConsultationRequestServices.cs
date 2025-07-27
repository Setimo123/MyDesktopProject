using Consultation.App.Repository;
using Consultation.App.Repository.IRepository;
using Consultation.App.Service.IService;
using Consultation.Domain;
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
        //Getting the total list by int which one number
        public async Task<int> TotalPendingConsultation(string programName, Status status)
        {
            try
            {
                var consultations = await _repository.GetConsultation(programName);

                if (consultations == null)
                    return 0;

                int totalpending = consultations.Where(c => c.Status == status).Count();
                return totalpending;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"ConsultationRequestServices Error{ex.Message}");
                return 0;
            }
        }

        public async Task<List<ConsultationRequest>> ListOfConsultation(string programName)
        {
            try
            {
                var consultations = await _repository.GetConsultation(programName);
                if (consultations == null)
                    MessageBox.Show("Error on the list");
                return consultations;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error Message: {ex.Message}");
                return new List<ConsultationRequest>();
            }
        }

        public async Task<List<ConsultationRequest>> GetListFaclutyStudentInformation(string programName)
        {
            try
            {
                var consultations = await _repository.GetConsultation(programName);

                if (consultations == null || !consultations.Any())
                    MessageBox.Show("No consultations found.");

                return consultations;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error Message: {ex.Message}");
                return new List<ConsultationRequest>();
            }
        }

        public Task<ConsultationRequest?> GetStudentInformation(int facultyID)
        {
            throw new NotImplementedException();
        }
    }
}
