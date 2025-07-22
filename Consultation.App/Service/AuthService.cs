using System;
using System.Collections.Generic;
using System.Linq;
using Consultation.Repository.IRepository;
using Consultation.Repository;
using Consultation.Service.IService;
using Consultation.Domain;
using Consultation.Infrastructure.Data;
using Microsoft.AspNetCore.Identity;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.Identity.Client;
using Consultation.App.Repository.IRepository;


namespace Consultation.Service
{
    public class AuthService : IAuthService
    {
        private readonly IUserRepository _userRepository;
        private readonly PasswordHasher<Users> _passwordHasher;
        private Users? user;
        public string AdminUserID { get; set; }
      

        public AuthService(AppDbContext context)
        {
            _passwordHasher = new PasswordHasher<Users>();
            _userRepository = new UserRepository(context);

        }

        //This authenticate user account
        public async Task<Users?> Login(string email, string password)
        {
             user = await _userRepository.GetUserByEmail(email);
            if (user == null)
                return null;

           var result = _passwordHasher.VerifyHashedPassword(user, user.PasswordHash, password);
           return result == Microsoft.AspNetCore.Identity.PasswordVerificationResult.Success ? user : null;
        }

        
    }
}
