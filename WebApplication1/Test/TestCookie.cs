using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.TestHost;
using Microsoft.Extensions.DependencyInjection;
using Moq;
using NUnit.Framework;
using WebApplication1.Models;

namespace WebApplication1.Test
{
    public class TestCookie
    {
        private UserService _service;

        [SetUp]
        public void Init()
        {
            var httpContextAccessorMock = new Mock<IHttpContextAccessor>();
            httpContextAccessorMock.Setup(x => x.HttpContext.Request.Cookies["username"]).Returns("yubaolee");

            var server = new TestServer(WebHost.CreateDefaultBuilder()
                .ConfigureServices(u =>u.AddScoped(x =>httpContextAccessorMock.Object))
                .UseStartup<Startup>());
            _service = server.Host.Services.GetService<UserService>();
        }
        [Test]
        public void TestLogin()
        {
            bool result = _service.IsLogin();
            Assert.IsTrue(result);
        }
    }
}

