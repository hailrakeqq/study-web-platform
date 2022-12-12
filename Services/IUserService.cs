using System.Collections;
using System.Collections.Generic;
using study_web_platform.Entities;
using study_web_platform.Models;

namespace study_web_platform.Services
{
    public interface IUserService
    {
        AuthenticateResponce Authenticate(AuthenticateRequest models);
        Task<AuthenticateResponce> Register(UserModel userModel);
        IEnumerable<User> GetAll();
        User GetById(int id);
    }
}