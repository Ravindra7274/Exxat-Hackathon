using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exxat.SupportPro.API.Repositories
{
    public interface IQueryRepository
    {
        Task<List<string>> GetAll();
    }
    public class QueryRepository:IQueryRepository
    {
        protected readonly ModelContext.ModelContext ModelContext;
        public QueryRepository(ModelContext.ModelContext modelContext)
        {
            ModelContext = modelContext;
        }

        public async Task<List<string>> GetAll()
        {
            try
            {
                List<string> ModuleNames = new List<string>();
                var modules = ModelContext.Module.ToList();
                foreach (var module in modules)
                {
                    ModuleNames.Add(module.Name);
                }
                return ModuleNames;
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
