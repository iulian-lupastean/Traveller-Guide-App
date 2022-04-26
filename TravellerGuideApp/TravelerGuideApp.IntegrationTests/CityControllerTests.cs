using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TravelerGuideApp.API;
using TravelerGuideApp.IntegrationTests.SocialMedia.Host.IntegrationTests;

namespace TravelerGuideApp.IntegrationTests
{
    [TestClass]
    public class CityControllerTests
    {
        private static TestContext _testContext;
        private static WebApplicationFactory<Startup> _factory;


        [ClassInitialize]
        public static void ClassInit(TestContext testContext)
        {
            _testContext = testContext;
            _factory = new CustomWebApplicationFactory<Startup>();
        }
        [TestMethod]
        public async Task Get_All_Cities_ShouldReturnOKResponse()
        {
            var client = _factory.CreateClient();
            var response = await client.GetAsync("api/Cities");
            Assert.AreEqual((int)HttpStatusCode.OK, response.StatusCode);
        }
    }
}