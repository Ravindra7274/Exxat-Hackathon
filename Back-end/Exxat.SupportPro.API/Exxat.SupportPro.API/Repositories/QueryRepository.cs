using Exxat.SupportPro.API.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exxat.SupportPro.API.Repositories
{
    public interface IQueryRepository
    {
        Task<List<Module>> GetAll();
        Task<List<CommonQuery>> GetAllQueries(int id);
        Task<CommonQuery> GetQuery(int queryId);
        Task<object> ExecuteAsync(string query, string queryType);
    }
    public class QueryRepository:IQueryRepository
    {
        protected readonly ModelContext.ModelContext ModelContext;
        public QueryRepository(ModelContext.ModelContext modelContext)
        {
            ModelContext = modelContext;
        }

        public async Task<object> ExecuteAsync(string query, string queryType)
        {
            try
            {
                if(!string.IsNullOrEmpty(queryType))
                {
                    switch (queryType)
                    {
                        case "select":
                            List<object> res = new List<object>();
                            using (var cmd = ModelContext.Database.GetDbConnection().CreateCommand())
                            {
                                cmd.CommandText = query;
                                await ModelContext.Database.OpenConnectionAsync();
                                using (var reader = await cmd.ExecuteReaderAsync())
                                {
                                    while (await reader.ReadAsync())
                                    {
                                        for (int i = 0; i < reader.FieldCount; i++)
                                        {
                                            res.Add(reader[i]);
                                        }
                                    }
                                    return res;
                                }
                            }
                        default:
                            return await ModelContext.Database.ExecuteSqlCommandAsync(query);
                    }
                }
                else
                {
                    throw new Exception("Query Type error");
                }
            }
            catch(Exception e)
            {
                throw e;
            }
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
