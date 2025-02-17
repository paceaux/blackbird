using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Blackbird;

public class LegislationReference
{
    [JsonPropertyName("count")]
    public int Count { get; set; }

    [JsonPropertyName("url")]
    public string Url { get; set; }
}
