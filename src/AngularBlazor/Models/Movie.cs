using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Threading;

namespace AngularBlazor.Models
{
    public class MovieResult
    {
        public List<MovieResultItem> Result { get; set; }
    }

    public class MovieResultItem
    {
        public Movie Properties { get; set; }
    }

    public class Movie
    {
        public string Title { get; set; }
        [JsonPropertyName("episode_id")] public int Episode { get; set; }
        [JsonPropertyName("release_date")] public DateTime ReleaseDate { get; set; }
    }
}