namespace TravelerGuideApp.Presentation
{

    public static class Program
    {
        static async Task Main(string[] args)
        {
            Seeder.SeedData();
            //var createCity = await _mediator.Send(new CreateCityCommand { Name = "Madrid", Country = "Spain" });
            //var deleteCity = await _mediator.Send(new DeleteCityCommand { Id = 1 });

        }
    }
}
