using System;
using System.Text.Json;
using System.Net.Http;
using System.Text.Json.Serialization;
namespace Blackbird;

public class CongressApi
{
    /*
    this should be set in the environment
    */
    private static readonly string apiKey = "yG1ifYPkVFhrJdb7u3DMjPSO4yc19AkfJAKVhF51";
    /* Is it worth it for this to be a URL? */
    private static readonly string baseUrl = "https://api.congress.gov/v3/";

    public static async Task<MembersResponse?> GetMembersByState(string state) {
        if (string.IsNullOrEmpty(state)) {
            throw new ArgumentNullException(nameof(state));
        }
        HttpClient client = new();
        string requestUrl = $"{baseUrl}member/{state}?api_key={apiKey}&format=json";
        var request = new HttpRequestMessage(HttpMethod.Get, requestUrl);
        var response = await client.SendAsync(request);

        if (response.IsSuccessStatusCode) {
            using var responseStream = await response.Content.ReadAsStreamAsync();
            if (responseStream != null) {
                try {
                    MembersResponse MembersResponse = await JsonSerializer.DeserializeAsync<MembersResponse>(responseStream);
                    return MembersResponse;
                } catch (Exception) {
                    throw new Exception("Something went wrong at serialization");
                }
            } else {
                throw new Exception("Response stream was null");
            }
        } else {
            throw new Exception("Could not get Member data");
        }
    }
    public static async Task<MemberResponse?> GetMember(string bioguideId) {
        if (string.IsNullOrEmpty(bioguideId)) {
            throw new ArgumentNullException(nameof(bioguideId));
        }
        HttpClient client = new();
        string requestUrl = $"{baseUrl}member/{bioguideId}?api_key={apiKey}&format=json";
        var request = new HttpRequestMessage(HttpMethod.Get, requestUrl);
        var response = await client.SendAsync(request);

        if (response.IsSuccessStatusCode) {
            using var responseStream = await response.Content.ReadAsStreamAsync();
            if (responseStream != null) {
                try {
                    MemberResponse MemberResponse = await JsonSerializer.DeserializeAsync<MemberResponse>(responseStream);

                    return MemberResponse;
                } catch (Exception) {
                    throw new Exception("Something went wrong at serialization");
                }
            } else {
                throw new Exception("Response stream was null");
            }
        } else {
            throw new Exception("Could not get Member data");
        }
    }

    public static async Task<SponsoredLegislationResponse?> GetSponsoredLegislation(string bioguideId) {
        if (string.IsNullOrEmpty(bioguideId)) {
            throw new ArgumentNullException(nameof(bioguideId));
        }
        HttpClient client = new();
        string requestUrl = $"{baseUrl}/member/{bioguideId}/sponsored-legislation?api_key={apiKey}";
        var request = new HttpRequestMessage(HttpMethod.Get, requestUrl);
        var response = await client.SendAsync(request);

        if (response.IsSuccessStatusCode)
        {
            using var responseStream = await response.Content.ReadAsStreamAsync();
            SponsoredLegislationResponse legislationData = await JsonSerializer.DeserializeAsync<SponsoredLegislationResponse>(responseStream);
            return legislationData;
        } else
        {
            throw new Exception("Could not get legislation data");
        }
    }
}

public class MemberResponse
{
    [JsonPropertyName("member")]
    public CongressPersonBio? Member { get; set; }
}

public class MembersResponse
{

    [JsonPropertyName("members")]
    public List<CongressPerson>? Members { get; set; }

}

public class SponsoredLegislationResponse {
    [JsonPropertyName("sponsoredLegislation")]
    public List<SponsoredLegislation>? SponsoredLegislations { get; set; }
}
