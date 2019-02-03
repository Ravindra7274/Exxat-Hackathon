using Exxat.SupportPro.API.Models;
using Exxat.SupportPro.API.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Exxat.SupportPro.API.Services
{
    public interface IQueryService
    {
        Task<List<Module>> GetAllModules();
        Task<object> ExecuteQueryAsync(string query, string queryType);
        Task<List<CommonQuery>> GetCommonQueries(int moduleId);
        Task<CommonQuery> GetCommonQuery(int queryId);
        string Generate(string query, Dictionary<string, string> clauses);
    }
    public class QueryService : IQueryService
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

        public string Generate(string query, Dictionary<string, string> clauses)
        {
            string newQuery = "";
            foreach (var keyVal in clauses)
            {
                newQuery = new StringBuilder(query)
                     .Replace("{" + keyVal.Key + "}", keyVal.Value)
                     .ToString()
                     .ToLower();
            }
            return newQuery;
        }

        public Task<List<Module>> GetAllModules()
        {
            return _queryRepository.GetAll();
        }

        public async Task<List<CommonQuery>> GetCommonQueries(int moduleId)
        {
            return await _queryRepository.GetAllQueries(moduleId);
        }

        public async Task<CommonQuery> GetCommonQuery(int queryId)
        {
            return await _queryRepository.GetQuery(queryId);
        }
    }
}
