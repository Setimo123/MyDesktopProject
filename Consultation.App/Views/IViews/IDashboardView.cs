using Consultation.App.Dashboard.Activity_Feed_Panel;
using Consultation.App.ViewModels.DashboardModels;
using Consultation.Domain;
using MaterialSkin.Controls;

namespace Consultation.App.Views.IViews
{
    public interface IDashboardView : IChildView
    {

        int TotalPendingConsultation { set; }
        int TotalCompletConsultation { set; }
        int TotalUpcomingConsultation { set; }

        string ProgramName { set; get; }

        // void DisplayListConsultationBinding(BindingSource List);
        void DisplayListConsultation(List<ConsultationRequest> List);
        event EventHandler ShowConsultationData;
        event EventHandler ShowConsultationDataList;
        //void LoadRecentBulletins(List<BulletinModel> bulletins);
        //void LoadRecentConsultations(List<ConsultationModel> consultations);

        //void UpdateDashboardStats(int published, int pending, int completed, int upcoming);

        //void UpdateConsultationStats(int CPE, int EE, int ECE, int CE, int ME, int CHE);


    }
}
