using Microsoft.VisualStudio.TestTools.UnitTesting;
using ListApp.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace ListApp.Services.Tests
{
    [TestClass()]
    public class UserServiceTests
    {
        [TestMethod()]
        public void GetUsersTest()
        {
            var us = new UserService();
            var users = us.GetUsers();
            Assert.IsNotNull(users);
        }
    }
}