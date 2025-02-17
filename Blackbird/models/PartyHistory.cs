using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Blackbird;

public class PartyHistory
{
    [JsonPropertyName("partyAbbreviation")]
    public string? PartyAbbreviation { get; set; }
    [JsonPropertyName("partyName")]
    public string? PartyName { get; set; }
    [JsonPropertyName("startYear")]
    public int StartYear { get; set; }
}