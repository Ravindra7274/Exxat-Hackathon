using Exxat.SupportPro.API.Models;
using Exxat.SupportPro.API.Repositories;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Exxat.SupportPro.API.Services
{
    public interface IQueryService
    {
        Task<List<Module>> GetAllModules();
        Task<List<CommonQuery>> GetCommonQuery(int id);
        Task<object> ExecuteQueryAsync(string query, string queryType);
    }
    public class QueryService: IQueryService
    {
        protected readonly IQueryRepository _queryRepository;
        public QueryService(IQueryRepository queryRepository)
        {
            _queryRepository = queryRepository;
        }

        public Task<object> ExecuteQueryAsync(string query, string queryType)
        {
            return _queryRepository.ExecuteAsync(query, queryType);
        }

        public Task<List<Module>> GetAllModules()
        {
            return _queryRepository.GetAll();
        }

        public async Task<List<CommonQuery>> GetCommonQuery(int id)
        {
            return await _queryRepository.GetAllQueries(id);
        }
    }
}
