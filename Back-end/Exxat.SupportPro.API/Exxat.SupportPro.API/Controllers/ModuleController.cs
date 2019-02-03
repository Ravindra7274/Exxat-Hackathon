using System.Collections.Generic;
using System.Threading.Tasks;
using Exxat.SupportPro.API.Models;
using Exxat.SupportPro.API.Services;
using Microsoft.AspNetCore.Mvc;

namespace Exxat.SupportPro.API.Controllers
{
    [Route("[controller]")]
    public class ModuleController : ControllerBase
    {
        protected readonly IModuleService _moduleService;
        public ModuleController(IModuleService moduleService)
        {
            _moduleService = moduleService;
        }
        [HttpGet]
        public async Task<List<Module>> GetAsync()
        {
            return await _moduleService.GetAllModules();
        }
    }
}
