using System;
using System.Text.Json;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Blackbird;

public class Leadership
{
    [JsonPropertyName("congress")]
    public int Congress { get; set; }

    [JsonPropertyName("type")]
    public string Type { get; set; }
}