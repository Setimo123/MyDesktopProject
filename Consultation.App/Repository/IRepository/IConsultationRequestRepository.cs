using Consultation.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consultation.App.Repository.IRepository
{
    public interface IConsultationRequestRepository
    {
        Task<List<ConsultationRequest>> GetConsultation(string ProgramName);

    }
}
