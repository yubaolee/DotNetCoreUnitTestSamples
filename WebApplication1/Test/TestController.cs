using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.TestHost;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Microsoft.Extensions.DependencyInjection;
using NUnit.Framework;
using OpenAuth.WebApi.Controllers;
using WebApplication1.Models;

namespace WebApplication1.Test
{
    public class TestController
    {
        private ValuesController _controller;

        [SetUp]
        public void Init()
        {
            var server = new TestServer(WebHost.CreateDefaultBuilder().UseStartup<Startup>());
            _controller = server.Host.Services.GetService<ValuesController>();
        }
        [Test]
        public void TestLogin()
        {
            bool result = _controller.CheckLogin(new UserInfo{Name = "yubao",Password = "yubao"});
            Assert.IsTrue(result);
        }
    }
}

