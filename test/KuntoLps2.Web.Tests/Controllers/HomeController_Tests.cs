﻿using System.Threading.Tasks;
using KuntoLps2.Models.TokenAuth;
using KuntoLps2.Web.Controllers;
using Shouldly;
using Xunit;

namespace KuntoLps2.Web.Tests.Controllers
{
    public class HomeController_Tests: KuntoLps2WebTestBase
    {
        [Fact]
        public async Task Index_Test()
        {
            await AuthenticateAsync(null, new AuthenticateModel
            {
                UserNameOrEmailAddress = "admin",
                Password = "123qwe"
            });

            //Act
            var response = await GetResponseAsStringAsync(
                GetUrl<HomeController>(nameof(HomeController.Index))
            );

            //Assert
            response.ShouldNotBeNullOrEmpty();
        }
    }
}