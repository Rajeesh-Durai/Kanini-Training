using ProjectBigBang.Interfaces;
using ProjectBigBang.Models.DTO;
using ProjectBigBang.Models;
using System.Security.Cryptography;
using System.Text;
namespace ProjectBigBang.Services
{
    public class UserService : IUserService
    {
        private readonly IUser _userRepo;
        private readonly ITokenGenerate _tokenService;

        public UserService(IUser userRepo, ITokenGenerate tokenService)
        {
            _userRepo = userRepo;
            _tokenService = tokenService;
        }
        public async Task<UserDTO> LogIN(UserDTO userDTO)
        {
            UserDTO? user = null;
            var userData = await _userRepo.Get(userDTO);

            if (userData != null)
            {
                var hmac = new HMACSHA512(userData.HashKey);

                var userPass = hmac.ComputeHash(Encoding.UTF8.GetBytes(userDTO.Password));
                for (int i = 0; i < userPass.Length; i++)
                {
                    if (userPass[i] != userData.Password[i])
                        return null;
                }
                user = new UserDTO();
                user.UserName = userData.UserName;
                user.Role = userData.Role;
                user.Token = _tokenService.GenerateToken(user);
            }
            if (user == null)
            {
                throw new ArgumentNullException("users is empty");
            }
            return user;
        }

        public async Task<UserDTO> Register(UserRegisterDTO userRegisterDTO)
        {
            UserDTO? user = null;

            using (var hmac = new HMACSHA512())
            {
                userRegisterDTO.Password = hmac.ComputeHash(Encoding.UTF8.GetBytes(userRegisterDTO.UserPassword));
                userRegisterDTO.HashKey = hmac.Key;
                var resultUser = await _userRepo.Add(userRegisterDTO);
                if (resultUser != null)
                {
                    user = new UserDTO();
                    user.UserName = resultUser.UserName;
                    user.Role = resultUser.Role;
                    user.Token = _tokenService.GenerateToken(user);
                }
            }
            if (user == null)
            {
                throw new ArgumentNullException("users is empty");
            }
            return user;
        }


        public async Task<UserDTO?> Update(UserRegisterDTO user)
        {
            var users = await _userRepo.GetAll();
            if (users == null)
            {
                throw new ArgumentNullException("users is empty");
            }
            User? myUser = users.SingleOrDefault(u => u.UserName == user.UserName);
            if (myUser == null)
            {
                throw new ArgumentNullException("MyUser is empty");
            }
            if (myUser != null)
            {
                myUser.Name = user.Name;
                myUser.PhoneNumber = user.PhoneNumber;
                myUser.Address = user.Address;
                var hmac = new HMACSHA512();
                myUser.Password = hmac.ComputeHash(Encoding.UTF8.GetBytes(user.UserPassword));
                myUser.HashKey = hmac.Key;
                myUser.Role = user.Role;
                myUser.EmailId = user.EmailId;
                UserDTO userDTO = new UserDTO();
                userDTO.UserName = myUser.UserName;
                userDTO.Role = myUser.Role;
                userDTO.Token = _tokenService.GenerateToken(userDTO);
                var newUser = _userRepo.Update(myUser);
                if (newUser != null)
                {
                    return userDTO;
                }
                return null;
            }

            return null;
        }

        public async Task<bool> Update_Password(UserDTO userDTO)
        {
            User user = new User();
            var users = await _userRepo.GetAll();
            if (users == null)
            {
                throw new ArgumentNullException("users is empty");
            }
            var myUser = users.SingleOrDefault(u => u.UserName == userDTO.UserName);
            if (myUser != null)
            {
                var hmac = new HMACSHA512();
                user.Password = hmac.ComputeHash(Encoding.UTF8.GetBytes(userDTO.Password));
                user.HashKey = hmac.Key;
                user.Name = myUser.Name;
                user.Role = myUser.Role;
                user.Address = myUser.Address;
                user.PhoneNumber = myUser.PhoneNumber;
                user.EmailId = myUser.EmailId;
                var newUser = _userRepo.Update(user);
                if (newUser != null)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
