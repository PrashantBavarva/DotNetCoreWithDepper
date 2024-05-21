using Azure.Core;
using Irock.PatientHealthApp.Database.Entity.NewFolder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Irock.PatientHealthApp.Repository.Interfaces.Base
{
    public interface IBaseRepository    
    {
        Task<List<TResponse>> GetAllAsync<TResponse>(string query);
        Task<TResponse?> GetByIdAsync<TResponse>(string query, Guid id);
        Task<bool> Add<TRequest>(string query,TRequest entity);
        Task<List<TResponse>?> FindByConditionAsync<TRequest,TResponse>(string query, TRequest request);
        Task<bool> Delete(string query, Guid id);
    }
}
