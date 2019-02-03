using Exxat.SupportPro.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exxat.SupportPro.API.Repositories
{
    public interface IQueryRepository
    {
        Task<List<Module>> GetAll();
        Task<List<CommonQuery>> GetAllQueries(int moduleId);
        Task<CommonQuery> GetQuery(int queryId);
    }
    public class QueryRepository:IQueryRepository
    {
        protected readonly ModelContext.ModelContext ModelContext;
        public QueryRepository(ModelContext.ModelContext modelContext)
        {
            ModelContext = modelContext;
        }

        public async Task<List<Module>> GetAll()
        {
            try
            {
                var modules = ModelContext.Module.ToList();
                return modules;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public async Task<List<CommonQuery>> GetAllQueries(int moduleId)
        {
            try
            {
                return ModelContext.CommonQueries.Where(x => x.ModuleId == moduleId).ToList();
            }
            catch(Exception e)
            {
                throw e;
            }
        }

        public async Task<CommonQuery> GetQuery(int queryId)
        {
            try
            {
                return ModelContext.CommonQueries.Where(x => x.QueryId == queryId).FirstOrDefault();
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
