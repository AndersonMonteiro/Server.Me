using System.Threading.Tasks;
using ServeMe.Infrastructure.CrossCutting.Response;
using ServeMe.Main.Domain.Entities;
using ServeMe.Main.Domain.Repositories;
using ServeMe.Main.Domain.Services;

namespace ServeMe.Main.Services
{
    public class TestCoreServ : ITestCoreServ
    {
        protected readonly ITestCoreRepo testCoreRepo;

        public TestCoreServ(ITestCoreRepo testCoreRepo)
        {
            this.testCoreRepo = testCoreRepo;
        }

        public async Task<Response<TestCore>> TestCore()
        {
            var result = await testCoreRepo.TestCore();

            return Response.CreateResponse(result);
        }
    }
}
