using Firebase.Database;
using HackerNews.Models;
using Microsoft.Extensions.Caching.Memory;
using Newtonsoft.Json;

namespace HackerNews.Services;

public class GetBestStoriesService : BackgroundService
{
    private readonly IMemoryCache _cache;
    public GetBestStoriesService(IMemoryCache cache)
    {
        _cache = cache;
    }
    
    protected override async Task ExecuteAsync(CancellationToken stoppingToken)
    {
        await GetBestStoriesId();
    }

    private async Task GetBestStoriesId()
    {
        var firebaseUrl = "https://hacker-news.firebaseio.com/";

        var firebaseClient = new FirebaseClient(firebaseUrl);

        var subscription = firebaseClient
            .Child("v0/beststories")
            .AsObservable<int>()
            .Subscribe(async storyId =>
            {
                var storyDetails = await GetStoryDetails(storyId.Object);
                _cache.Set(storyId.Key, storyDetails);
            });
    }
    
    private async Task<BestStoryDetails> GetStoryDetails(int storyId)
    {
        using (HttpClient client = new HttpClient())
        {
            HttpResponseMessage response = await client.GetAsync($"https://hacker-news.firebaseio.com/v0/item/{storyId}.json");
            if (response.IsSuccessStatusCode)
            {
                string responseData = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<BestStoryDetails>(responseData);
            }
            else
            {
                Console.WriteLine($"Failed to retrieve story details for ID {storyId}. Status code: {response.StatusCode}");
                return null;
            }
        }
    }
}