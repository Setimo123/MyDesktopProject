using Consultation.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consultation.App.Service.IService
{
    public interface IAdminAccountServices
    {
        Task<Admin?> AdminAccount();
        string UserID { set; get; }
    }
}
