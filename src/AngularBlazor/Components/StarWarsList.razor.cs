using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using AngularBlazor.Models;
using Microsoft.AspNetCore.Components;

namespace AngularBlazor.Components
{
    public partial class StarWarsList
    {
        [Inject] private HttpClient _httpClient { get; set; }
        private List<Movie> Movies { get; set; } = new();

        private async void LoadAllMovies()
        {
            var result = await _httpClient.GetFromJsonAsync<MovieResult>("https://www.swapi.tech/api/films/");
            Movies = result?.Result.Select(movieItem => movieItem.Properties).ToList();
            StateHasChanged();
        }
    }
}