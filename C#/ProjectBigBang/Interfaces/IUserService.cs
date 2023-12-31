﻿using ProjectBigBang.Models.DTO;

namespace ProjectBigBang.Interfaces
{
    public interface IUserService
    {
        Task<UserDTO> Register(UserRegisterDTO userRegisterDTO);
        Task<UserDTO> LogIN(UserDTO userDTO);
        Task<UserDTO?> Update(UserRegisterDTO user);
        Task<bool> Update_Password(UserDTO userRegisterDTO);
    }
}
