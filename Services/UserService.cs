using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using study_web_platform.Entities;
using study_web_platform.Models;

namespace study_web_platform.Services
{
    public class UserService : IUserService
    {
        private readonly IEfRepository<User>? _userRepository;
        private readonly IConfiguration? _configuration;
        private readonly IMapper? _mapper;

        public UserService(IEfRepository<User> userRepository, IConfiguration configuration, IMapper mapper)
        {
            _userRepository = userRepository;
            _configuration = configuration;
            _mapper = mapper;
        }

        public AuthenticateResponce Authenticate(AuthenticateRequest models)
        {
            var user = _userRepository?.GetAll().FirstOrDefault(x => x.Username == models.Username && x.Password == models.Password);

            if (user == null)
                return null;

            var token = _configuration.GenerateJwtToken(user);

            return new AuthenticateResponce(user, token);
        }

        public async Task<AuthenticateResponce> Register(UserModel userModel)
        {
            var user = _mapper?.Map<User>(userModel);

            var addedUser = await _userRepository.Add(user);

            var responce = Authenticate(new AuthenticateRequest
            {
                Username = user.Username,
                Password = user.Password
            });

            return responce;
        }

        public IEnumerable<User> GetAll() => _userRepository.GetAll();

        public User GetById(int id) => _userRepository.GetById(id);

    }
}