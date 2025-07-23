using Consultation.App.Dashboard;
using Consultation.App.Repository.IRepository;
using Consultation.App.Service;
using Consultation.App.Service.IService;
using Consultation.App.Views;
using Consultation.App.Views.IViews;
using Consultation.Service;
using Consultation.Service.IService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consultation.App.Presenters
{
    public class LogInPresenter
    {
        private readonly ILoginView _loginView;
        private IAuthService _authservice;
        private IAdminAccountServices _adminAccountServices;
        private readonly IDashboardView _boardview;
        private readonly IMainView _mainview;

        public LogInPresenter(ILoginView loginView, IAuthService authservice, IAdminAccountServices adminAccountServices,
            IDashboardView boardview,IMainView mainview)
        {
            _loginView = loginView;
            _authservice = authservice;
            _adminAccountServices = adminAccountServices;
            _boardview = boardview;
            _mainview = mainview;
            _loginView.LogInEvent += LogIn; 
        }
        // EllaineMusni.550200@umindanao.edu.ph
        // AQAAAAIAAYagAAAAEIG5jButwoJ4JYY+4qNfa5qxkFZGPY6GQfJ75BlTwCeGgWTJyosYMMIp8oKd60fYeQ==

        // MyAdmin123!


        public async void LogIn(object? sender, EventArgs e)
        {
           var user = await _authservice.Login(_loginView.useremail, _loginView.password);
         
            if (user == null)
            {
                _loginView.ShowMessage("Invalid Credentials");
                return;
            }
            if (user.UserType.ToString() != "Admin")
            {
                _loginView.ShowMessage("Invalid User");
                return;
            }

            _loginView.ShowMessage("Logged In Successful");
            _loginView.ShowMessage($"{user.Id}");
            var admin = await _adminAccountServices.AdminAccount(user.Id);

            if (admin == null)
            {
                _loginView.ShowMessage("Admin not found");
                return;
            }
  
            _boardview.AdminName = admin.AdminName;
            _mainview.LoadControl((UserControl)_boardview);
            _loginView.HideForm();
            _mainview.ShowForm();

        }
        
    }
}
