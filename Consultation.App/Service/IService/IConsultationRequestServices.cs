using Consultation.Domain;
using Consultation.Domain.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consultation.App.Service.IService
{
    public interface IConsultationRequestServices
    {
        //Task<int> TotalCompletedConsultation(string programName);
        Task<int> TotalPendingConsultation(string programName, Status status);
        Task<List<ConsultationRequest>> ListOfConsultation(string programName);

        Task<ConsultationRequest?> GetStudentInformation(int facultyID);

        Task<List<ConsultationRequest>> GetListFaclutyStudentInformation(string programName);

    }
}
