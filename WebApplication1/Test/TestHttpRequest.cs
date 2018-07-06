// ***********************************************************************
// Assembly         : WebApplication1
// Author           : 李玉宝
// Created          : 07-06-2018
//
// Last Modified By : 李玉宝
// Last Modified On : 07-06-2018
// ***********************************************************************
// <copyright file="TestHttpRequest.cs" company="WebApplication1">
//     Copyright (c) http://www.openauth.me. All rights reserved.
// </copyright>
// <summary>
// mock a http request
// </summary>
// ***********************************************************************


using System;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.TestHost;
using NUnit.Framework;

namespace WebApplication1.Test
{
    public class TestHttpRequest
    {
        private TestServer _testServer;

        [SetUp]
        public void Init()
        {
            _testServer = new TestServer(WebHost.CreateDefaultBuilder().UseStartup<Startup>());
        }
        [Test]
        public void TestLogin()
        {
            var client = _testServer.CreateClient();
            
            var result = client.GetStringAsync("/api/values/checklogin?name=yubao&password=yubao");
            Console.WriteLine(result.Result);
           
        }
    }
}

