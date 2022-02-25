using System;
using System.Threading.Tasks;
using RestSharp;
using

namespace MealPrep.Models
{
  class ApiHelper
  {
    public static async Task<string> ApiCall(string apiKey)
    {
      RestClient client = new RestClient("https://api.spoonacular.com/mealplanner");
      RestRequest request = new RestRequest($"generate?timeFrame=week&apiKey={EnvironmentVariables.ApiKey}", Method.Get);
      var response = await client.ExecuteTaskAsync(request);
      return response.Content;
    }
  }
}