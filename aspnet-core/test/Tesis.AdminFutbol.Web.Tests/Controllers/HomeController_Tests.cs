using System.Threading.Tasks;
using Tesis.AdminFutbol.Models.TokenAuth;
using Tesis.AdminFutbol.Web.Controllers;
using Shouldly;
using Xunit;

namespace Tesis.AdminFutbol.Web.Tests.Controllers
{
    public class HomeController_Tests: AdminFutbolWebTestBase
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