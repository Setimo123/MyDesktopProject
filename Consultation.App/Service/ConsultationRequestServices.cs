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

        public async Task<Faculty> GetFacultyInformation(int facultyID)
        {
            try
            {
                var consultationFacultyInfo = await _repository.GetFacultyaInfoConsultationRequests(facultyID);

                if (consultationFacultyInfo.Faculty == null)
                    MessageBox.Show("No faculty information found.");

                return new Faculty 
                { 
                    FacultyName = consultationFacultyInfo.Faculty.FacultyName
                };
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error Message: {ex.Message}");
                return null;
            }
        }

        public async Task<Student> GetStudentInformation(int studentID)
        {
            try
            {
                var consultationStudentInfo = await _repository.GetStudenInfoConsultationRequests(studentID);

                if (consultationStudentInfo.Student == null)
                    MessageBox.Show("No faculty information found.");

                return new Student
                {
                    StudentName = consultationStudentInfo.Student.StudentName
                };
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error Message: {ex.Message}");
                return null;
            }
        }
    }
}
