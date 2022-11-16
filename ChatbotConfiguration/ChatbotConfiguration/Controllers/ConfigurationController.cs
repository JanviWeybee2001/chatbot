using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ChatbotConfiguration.Model;
using ChatbotConfiguration.Repository;
using Microsoft.AspNetCore.Mvc;

namespace ChatbotConfiguration.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ConfigurationController : Controller
    {
        private readonly IGetWorkflowRepository getWorkflow = null;

        public ConfigurationController(IGetWorkflowRepository _getWorkflow)
        {
            getWorkflow = _getWorkflow;
        }

        [HttpGet]
        [Route("getFlow/{id}")]
        public async Task<IActionResult> GetFlow([FromRoute] int id)
        {
            var temp = await getWorkflow.getFlow(id);
            return Ok(temp);
        }

        [HttpGet]
        [Route("getQuetion/{id}")]
        public async Task<IActionResult> GetQuetion([FromRoute] int id)
        {
            var result = await getWorkflow.getQuetion(id);
            return Ok(result);
        }


    }
}
