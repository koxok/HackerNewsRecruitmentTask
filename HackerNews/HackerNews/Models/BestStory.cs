using Newtonsoft.Json;

namespace HackerNews.Models;

public class BestStory
{
    [JsonProperty]
    public int Id { get; set; }
}