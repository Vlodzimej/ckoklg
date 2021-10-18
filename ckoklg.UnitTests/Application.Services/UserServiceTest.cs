using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;
using System.Collections.Generic;
using System.Text;
using ckoklg.Application.Interfaces;

namespace ckoklg.UnitTests.Application.Services
{
    [TestClass]
    public class UserServiceTest
    {
        Mock<IUserService> userService = new Mock<IUserService>();

        public void Test()
		{
            //userService.Setup
		}
    }
}
