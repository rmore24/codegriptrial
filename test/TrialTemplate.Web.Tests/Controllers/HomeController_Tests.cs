using System.Threading.Tasks;
using TrialTemplate.Models.TokenAuth;
using TrialTemplate.Web.Controllers;
using Shouldly;
using Xunit;

namespace TrialTemplate.Web.Tests.Controllers
{
    public class HomeController_Tests: TrialTemplateWebTestBase
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