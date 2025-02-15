using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Blackbird;

public class SponsoredLegislation
{
    [JsonPropertyName("congress")]
    public int? Congress {get; set;}

    [JsonPropertyName("introducedDate")]
    public string? IntroducedDate {get; set;}

    [JsonPropertyName("latestAction")]
    public LatestAction? LatestAction {get; set;}

    [JsonPropertyName("number")]
    public string? Number {get; set;}

    [JsonPropertyName("policyArea")]
    public PolicyArea? PolicyArea {get; set;}

    [JsonPropertyName("title")]
    public string? Title {get; set;}

    [JsonPropertyName("url")]
    public string? Url {get; set;}

    [JsonPropertyName("type")]
    public string? Type {get; set;}
}

public class PolicyArea {
    [JsonPropertyName("name")]
    public string? Name {get; set;}
}

public class LatestAction {
    [JsonPropertyName("actionDate")]
    public string? ActionDate {get; set;}

    [JsonPropertyName("text")]
    public string? Text {get; set;}
}