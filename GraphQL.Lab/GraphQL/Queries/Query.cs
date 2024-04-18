using GraphQL.Lab.GqlTypes;

namespace GraphQL.Lab.GraphQL.Queries
{
  public class Query
  {

    private static readonly string[] Summaries = new[]
    {
          "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
      };


    public async Task<ForecastGql> GetForecast()
    {
      return new ForecastGql
      {
        Date = DateOnly.FromDateTime(DateTime.Now.AddDays(Random.Shared.Next(1, 10))),
        TemperatureC = Random.Shared.Next(-20, 55),
        Summary = Summaries[Random.Shared.Next(Summaries.Length)]
      };
    }


  }
}