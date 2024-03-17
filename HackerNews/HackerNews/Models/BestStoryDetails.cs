using Newtonsoft.Json;

namespace HackerNews.Models;

public class BestStoryDetails : BestStory
{
    [JsonProperty(PropertyName = "by")]
    public string By { get; set; }
    
    [JsonProperty(PropertyName = "descendants")]
    public int Descendants { get; set; }

    [JsonProperty(PropertyName = "kids")] 
    public List<int> Kids { get; set; } = new List<int>();
    
    [JsonProperty(PropertyName = "score")]
    public int Score { get; set; }
    
    [JsonProperty(PropertyName = "time")]
    public long Time { get; set; }
    
    [JsonProperty(PropertyName = "title")]
    public string Title { get; set; }
    
    [JsonProperty(PropertyName = "type")]
    public string Type { get; set; }
    
    [JsonProperty(PropertyName = "url")]
    public string Url { get; set; }
}