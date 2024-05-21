using Azure;
using Irock.PatientHealthApp.Database.Entity;
using Irock.PatientHealthApp.DTO;
using Irock.PatientHealthApp.Repository.Interfaces;
using Irock.PatientHealthApp.Repository.Repository;
using Irock.PatientHealthApp.Serivces.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Irock.PatientHealthApp.Serivces.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;
        public UserService(IUserRepository userRepository)
        {
            this._userRepository = userRepository;
        }

        public async Task<ResponseModel<UserDTO>> AddUser(UserDTO user)
        {
            user.Id = Guid.NewGuid();
            var response = new ResponseModel<UserDTO>();
            var query = "Insert into Users" +
                        " (Id,FirstName,LastName,Address,City,Email) " +
                        "VALUES (@Id,@FirstName,@LastName,@Address,@City,@Email)";

            var result = await _userRepository.Add<UserDTO>(query, user);
            response.Success = result;
            return (response);
        }

        public async Task<ResponseModel<List<UserDTO>>> GetAllAsync()
        {
            var response = new ResponseModel<List<UserDTO>>();
            var query = "Proc_GetUsers";
            var result = await _userRepository.GetAllAsync<UserDTO>(query);

            response.Success = true;
            response.Date = result;
            return (response);
        }

        public async Task<ResponseModel<UserDTO>> GetByIdAsync(Guid id)
        {
            var response = new ResponseModel<UserDTO>();
            var query = "SELECT * FROM Users where Id = @Id";
            var result = await _userRepository.GetByIdAsync<UserDTO>(query, id);
            if(result != null)
            {
                response.Success = true;
                response.Date = result;
            }
            return (response);
        }

        public async Task<ResponseModel<UserDTO>> DeleteUserById(Guid id)
        {
            var response = new ResponseModel<UserDTO>();
            var query = "DETELE FROM Users WHERE Id = @Id";
            response.Success= await _userRepository.Delete(query, id);
            if(response.Success)
            {
                response.Message = "User deleted successfully";
            }
            return (response);
        }
    }
}
