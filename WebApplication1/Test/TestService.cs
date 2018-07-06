using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.TestHost;
using Microsoft.Extensions.DependencyInjection;
using NUnit.Framework;
using WebApplication1.Models;

namespace WebApplication1.Test
{
    public class TestService
    {
        private UserService _service;

        [SetUp]
        public void Init()
        {
            var server = new TestServer(WebHost.CreateDefaultBuilder().UseStartup<Startup>());
            _service = server.Host.Services.GetService<UserService>();
        }
        [Test]
        public void TestLogin()
        {
            bool result = _service.CheckLogin(new UserInfo { Name = "yubao", Password = "yubao" });
            Assert.IsTrue(result);
        }
    }
}

