using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;
using TravelerGuideApp.API;
using TravelerGuideApp.API.DTOs;
using TravelerGuideApp.Application.Commands;
using TravelerGuideApp.Domain.Entities;
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
            Assert.AreEqual(HttpStatusCode.OK, response.StatusCode);
        }

        [TestMethod]
        public async Task Get_All_Cities_ShouldReturnExistingCity()
        {
            var client = _factory.CreateClient();
            var response = await client.GetAsync("api/Cities");

            var result = await response.Content.ReadAsStringAsync();
            List<CityGetDto> cities = JsonConvert.DeserializeObject<List<CityGetDto>>(result);
            CityGetDto city = new CityGetDto { Id = 1, Name = "Madrid", Country = "Spain", Locations = new List<LocationPutPostDto>() };
            Assert.AreEqual(JsonConvert.SerializeObject(city), JsonConvert.SerializeObject(cities[0]));
        }
        [TestMethod]
        public async Task Create_City_ShouldReturnOKStatusCode()
        {
            var city = new CreateCityCommand
            {

                Name = "Madrid",
                Country = "Spain"
            };
            var client = _factory.CreateClient();
            var response = await client.PostAsync("/api/Cities", new StringContent(JsonConvert.SerializeObject(city), Encoding.UTF8, "application/json"));
            Assert.IsTrue(response.StatusCode == HttpStatusCode.OK);
        }

        [TestMethod]
        public async Task Delete_City_ShouldDeleteAllLocationsFromCity()
        {
            int cityId = 1;
            var client = _factory.CreateClient();
            await client.DeleteAsync($"api/Cities/{cityId}");
            var result = await client.GetAsync($"api/Locations/{cityId}/Locations");
            Assert.IsTrue(result.StatusCode == HttpStatusCode.NotFound);
        }

    }
}
