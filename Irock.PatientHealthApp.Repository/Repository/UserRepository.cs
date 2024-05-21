using Dapper;
using Irock.PatientHealthApp.Database;
using Irock.PatientHealthApp.Database.Entity;
using Irock.PatientHealthApp.DTO;
using Irock.PatientHealthApp.Repository.Interfaces;
using Irock.PatientHealthApp.Repository.Interfaces.Base;
using Irock.PatientHealthApp.Repository.Repository.Base;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace Irock.PatientHealthApp.Repository.Repository
{
    public class UserRepository : BaseRepository,IUserRepository
    {
        private readonly DapperContext _dapperContext;
        public UserRepository(DapperContext _dapperContext) : base(_dapperContext) 
        {
            this._dapperContext = _dapperContext;
        }

        //public async Task<bool> Add(UserDTO userDTO)
        //{
        //    userDTO.Id = Guid.NewGuid();
        //    var query = "Insert into Users" +
        //                " (Id,FirstName,LastName,Address,City,Email) " +
        //                "VALUES (@Id,@FirstName,@LastName,@Address,@City,@Email)";

        //    using (var connection = _dapperContext.CreateConnection())
        //    {
        //        var result = await connection.ExecuteAsync(query, userDTO);
        //        if(result == 1)
        //        {
        //            return true;
        //        }
        //    }
        //    return false;
        //}

        //public async Task<bool> Delete(Guid id)
        //{
        //    var query = "Delete from Users where Id = @Id";
        //    using(var connection = _dapperContext.CreateConnection())
        //    {
        //        var result = await connection.ExecuteAsync(query,new { Id = id});
        //        if(result == 1)
        //        {
        //            return true;
        //        }
        //    }
        //    return false;
        //}

        //public async Task<IEnumerable<UserDTO>> GetAll()
        //{
        //    var query = "SELECT * FROM Users";
        //    using (var connection = _dapperContext.CreateConnection())
        //    {
        //        var users = await connection.QueryAsync<UserDTO>(query);
        //        return users.ToList();
        //    }
        //}

        //public Task<UserDTO> GetById(Guid id)
        //{
        //    throw new NotImplementedException();
        //}

        //public Task<bool> Update(UserDTO userDTO)
        //{
        //    throw new NotImplementedException();
        //}
    }
}
