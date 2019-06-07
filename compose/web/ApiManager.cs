using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using web.Models;

namespace web
{
    internal class ApiManager
    {
        internal static async Task<IEnumerable<Player>> GetPlayers()
        {
            using (var client = new HttpClient())
            {
                //client.BaseAddress = new Uri("http://localhost:8301/api/");
                client.BaseAddress = new Uri("http://app/api/");

                //HTTP GET
                var result = await client.GetAsync("players");
                if (result.IsSuccessStatusCode)
                {
                    return await result.Content.ReadAsAsync<IList<Player>>();
                }
                else //web api sent error response 
                {
                    throw new ApplicationException($"Error response {result.StatusCode}");
                }
            }
        }
    }
}