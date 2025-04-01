using System.Net;
using System.Net.Http.Json;
using Microsoft.AspNetCore.Mvc.Testing;

namespace Integration.Tests;

public class TimeEndpointTests(WebApplicationFactory<Program> factory) : IClassFixture<WebApplicationFactory<Program>>
{
    [Fact]
    public async Task GetCurrentTime_ShouldReturnCurrentTime()
    {
        HttpClient client = factory.CreateClient();

        HttpResponseMessage response = await client.GetAsync("/time");

        response.EnsureSuccessStatusCode();
        DateTime result = await response.Content.ReadFromJsonAsync<DateTime>();
        DateTime currentTime = DateTime.UtcNow;

        Assert.Equal(result.Day, currentTime.Day);
    }

    [Fact]
    public async Task GetCurrentTime_ShouldReturnStatus200OK()
    {
        HttpClient client = factory.CreateClient();

        HttpResponseMessage response = await client.GetAsync("/time");

        Assert.Equal(HttpStatusCode.OK, response.StatusCode);
    }
}