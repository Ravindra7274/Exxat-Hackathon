using Exxat.SupportPro.API.Models;
using Exxat.SupportPro.API.Repositories;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Exxat.SupportPro.API.Services
{
    public interface IQueryService
    {
        Task<List<Module>> GetAllModules();
    }
    public class QueryService: IQueryService
    {
        protected readonly IQueryRepository _queryRepository;
        public QueryService(IQueryRepository queryRepository)
        {
            _queryRepository = queryRepository;
        }

        public Task<List<Module>> GetAllModules()
        {
            return _queryRepository.GetAll();
        }
    }
}
