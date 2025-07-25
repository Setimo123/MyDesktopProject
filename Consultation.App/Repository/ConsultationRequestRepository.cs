using Consultation.App.Repository.IRepository;
using Consultation.Domain;
using Consultation.Infrastructure.Data;
using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consultation.App.Repository
{
    public class ConsultationRequestRepository : IConsultationRequestRepository
    {
        private readonly AppDbContext _context;

        public ConsultationRequestRepository(AppDbContext context) => _context = context;

        public async Task<List<ConsultationRequest>> GetConsultation(string ProgramName)
        {
            try
            {
                var ConsultationRequestList = await _context.ConsultationRequest.Where(x => x.ProgramName == ProgramName)
                    .ToListAsync();
                return ConsultationRequestList;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"ConsultationRequestRepository Error: {ex.Message}");
                return null;
            }
        }
    }
}
