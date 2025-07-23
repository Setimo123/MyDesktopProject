using Consultation.App.Repository;
using Consultation.App.Repository.IRepository;
using Consultation.App.Service.IService;
using Consultation.App.Views.IViews;
using Consultation.Domain;
using Consultation.Infrastructure.Data;
using Consultation.Service.IService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consultation.App.Service
{
    public class AdminAccountServices : IAdminAccountServices
    {
        private readonly IAdminAccountRepository _adminAccountrepository;
     

        public AdminAccountServices(AppDbContext context)
        {
            _adminAccountrepository = new AdminAccountRepository(context);
        }

        public async Task<Admin?> AdminAccount(string userID)
        {
            return await _adminAccountrepository.GetAdminAccount(userID);
        }

    }
}
