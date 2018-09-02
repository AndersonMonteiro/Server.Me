using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ServeMe.Infrastructure.CrossCutting.Response;
using ServeMe.Main.Domain.Services;

namespace ServeMe.WebApi.Controllers
{
    [Produces("application/json")]
    [Route("api/Test")]
    public class TestController : Controller
    {
        protected readonly ITestCoreServ testCoreServ;

        public TestController(ITestCoreServ testCoreServ)
        {
            this.testCoreServ = testCoreServ;
        }

        [HttpPost]
        public async Task<Response> Post()
        {
            var response = await testCoreServ.TestCore();

            return response;
        }
    }
}