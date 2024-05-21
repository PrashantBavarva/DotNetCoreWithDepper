using Azure.Core;
using Dapper;
using Irock.PatientHealthApp.DTO;
using Irock.PatientHealthApp.Repository.Interfaces.Base;

namespace Irock.PatientHealthApp.Repository.Repository.Base
{
    public class BaseRepository : IBaseRepository
    {
        private readonly DapperContext _dapperContext;
        public BaseRepository(DapperContext dapperContext) 
        {
            this._dapperContext = dapperContext;
        }
        public async Task<bool> Add<TRequest>(string query, TRequest entity)
        {
            using (var connection = _dapperContext.CreateConnection())
            {
                var result = await connection.ExecuteAsync(query, entity);
                if (result == 1)
                {
                    return true;
                }
            }
            return false;
        }
     
        public async Task<List<TResponse>> GetAllAsync<TResponse>(string query)
        {
            using (var connection = _dapperContext.CreateConnection())
            {
                var result = await connection.QueryAsync<TResponse>(query);
                return result.ToList();
            }
        }

        public async Task<TResponse?> GetByIdAsync<TResponse>(string query, Guid id)
        {
            using (var connection = _dapperContext.CreateConnection())
            {
                return await connection.QueryFirstAsync<TResponse>(query, new { Id = id});
            }
        }

        public async Task<List<TResponse>?> FindByConditionAsync<TRequest, TResponse>(string query, TRequest request)
        {
            using (var connection = _dapperContext.CreateConnection())
            {
                var result = await connection.QueryAsync<TResponse>(query,request);
                return result.ToList();
            }
        }
        
        public async Task<bool> Delete(string query, Guid id)
        {
            using(var connection = _dapperContext.CreateConnection())
            {
                return await connection.QueryFirstAsync<bool>(query, new { Id = id });
            }
        }
    }
}
