using ServeMe.Infrastructure.CrossCutting.Response;
using ServeMe.Main.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ServeMe.Main.Domain.Services
{
    public interface ITestCoreServ
    {
        Task<Response<TestCore>> TestCore();
    }
}
