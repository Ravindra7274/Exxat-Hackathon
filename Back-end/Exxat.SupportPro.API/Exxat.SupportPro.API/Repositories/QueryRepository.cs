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
                List<string> ModuleNames = new List<string>();
                var modules = ModelContext.Module.ToList();
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
