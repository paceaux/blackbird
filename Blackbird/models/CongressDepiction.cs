using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Blackbird;

public class CongressDepiction {
    
    [JsonPropertyName("attribution")]
    public string? Attribution {get; set;}

    [JsonPropertyName("imageUrl")]
    public string? ImageUrl {get; set;}
}