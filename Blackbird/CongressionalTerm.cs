using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Blackbird;

public class CongressionalTerm {
    [JsonPropertyName("chamber")]
    public string? Chamber {get; set;}

    [JsonPropertyName("year")]
    public int? Year {get; set;}
}