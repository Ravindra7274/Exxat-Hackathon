using System.Collections.Generic;
using System.Threading.Tasks;
using Exxat.SupportPro.API.Models;
using Exxat.SupportPro.API.Services;
using Microsoft.AspNetCore.Mvc;

namespace Exxat.SupportPro.API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class QueryController : ControllerBase
    {
        protected readonly IQueryService _queryService;
        public QueryController(IQueryService queryService)
        {
            _queryService = queryService;
        }
        [HttpGet]
        public async Task<List<Module>> GetAsync()
        {
            return await _queryService.GetAllModules();
        }

        [HttpGet("{id}")]
        public async Task<List<CommonQuery>> GetAsync(int id)
        {
            return await _queryService.GetCommonQuery(id);
        }

        [HttpGet("[action]")]
        public async Task<object> ExecuteQuery(string query, string queryType)
        {
            return await _queryService.ExecuteQueryAsync(query, queryType);
        }
        
    }
}
