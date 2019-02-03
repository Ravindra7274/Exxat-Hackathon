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

        // GET api/values/5
        [HttpGet("{id}")]
        public async Task<List<CommonQuery>> GetAsync(int id)
        {
            return await _queryService.GetCommonQuery(id);
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
