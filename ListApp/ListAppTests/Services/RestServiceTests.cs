using Microsoft.VisualStudio.TestTools.UnitTesting;
using ListApp.Services;
using System;
using System.Collections.Generic;
using System.Text;
using ListApp.Models;
using ListApp.Data;

namespace ListApp.Services.Tests
{
    [TestClass()]
    public class RestServiceTests
    {
        [TestMethod()]
        public void GetResponseTest()
        {
            var us = new RestService();
            var users = us.GetResponse<List<Person>>(Constants.UsersUrl);
            Assert.IsNotNull(users);
        }
    }
}