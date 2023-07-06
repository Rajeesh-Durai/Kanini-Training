using ProjectBigBang.Models.DTO;

namespace ProjectBigBang.Interfaces
{
    public interface ITokenGenerate
    {
        public string GenerateToken(UserDTO user);

    }
}
