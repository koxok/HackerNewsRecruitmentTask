using HackerNews.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;

namespace HackerNews.Controllers;

[ApiController]
[Route("[controller]")]
public class BestStoriesDetailsController : ControllerBase
{
    private readonly IMemoryCache _cache;
    public BestStoriesDetailsController(IMemoryCache cache)
    {
        _cache = cache;
    }

    [HttpGet(Name = "GetDetailsOfBestStories")]
    public async Task<IEnumerable<BestStoryDetails>> GetDetailsOfBestStories(int numberOfStories)
    {
        var bestStoryDetailsList = new List<BestStoryDetails>();

        for (int i = 0; i < numberOfStories; i++)
        {
            var details = new BestStoryDetails();
            _cache.TryGetValue<BestStoryDetails>(i.ToString(), out details);
            bestStoryDetailsList.Add(details);
        }
        
        return bestStoryDetailsList;
    }
}