using ProjectBigBang.Models.DTO;
using ProjectBigBang.Models;

namespace ProjectBigBang.Interfaces
{
    public interface IUser
    {
        Task<User?> Add(User user);
        Task<User?> Update(User user);
        User? Delete(UserDTO userDTO);
        Task<User?> Get(UserDTO userDTO);
        Task<List<User>?> GetAll();
    }
}
