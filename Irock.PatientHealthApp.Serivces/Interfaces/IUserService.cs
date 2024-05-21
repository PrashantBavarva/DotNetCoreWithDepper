using Azure;
using Irock.PatientHealthApp.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Irock.PatientHealthApp.Serivces.Interfaces
{
    public interface IUserService
    {
        Task<ResponseModel<List<UserDTO>>> GetAllAsync();
        Task<ResponseModel<UserDTO>> GetByIdAsync(Guid id);
        Task<ResponseModel<UserDTO>> AddUser(UserDTO user);
        Task<ResponseModel<UserDTO>> DeleteUserById(Guid id);
    }
}
