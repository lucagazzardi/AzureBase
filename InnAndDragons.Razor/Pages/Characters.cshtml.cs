using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using InnAndDragons.DataBusiness.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Newtonsoft.Json;

namespace InnAndDragons.Razor.Pages
{    
    public class CharactersModel : PageModel
    {
        private readonly HttpClient _client;
        public List<Character> characters { get; set; }

        public CharactersModel(IHttpClientFactory factory)
        {
            _client = factory.CreateClient("API");
        }

        public async Task OnGet()
        {
            var resp = await _client.GetAsync("api/character/getall");
            if (!resp.IsSuccessStatusCode)
            {
                throw new Exception();
            }

            string contentString = await resp.Content.ReadAsStringAsync();
            characters = JsonConvert.DeserializeObject<List<Character>>(contentString);
        }
    }
}
