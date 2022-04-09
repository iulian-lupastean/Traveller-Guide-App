using System;
using Application;
using Xunit;
using Moq;
using Autofac.Extras.Moq;
using AutoFixture;
using TravelerGuideApp.Application;
using TravelerGuideApp.Application.Cities.Commands.DeleteCity;

namespace City.Create
{
    public class Create
    {
        [Fact]
        public void DeleteCity_ValidCall()
        {
            using (var mock = AutoMock.GetLoose())
            {
                var fixture = new Fixture();
                var city = fixture.Build<TravelerGuideApp.Domain.Entities.City>().Create();
                mock.Mock<ICityRepository>().Setup(x => x.DeleteCity(city.Id));
                var cls = mock.Create<DeleteCityCommand>();
                mock.Mock<ICityRepository>().Verify(x => x.DeleteCity(city.Id), Times.Once);
            }
        }
    }
}