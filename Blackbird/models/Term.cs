using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Blackbird;


public class Term
{
    [JsonPropertyName("chamber")]
    public string Chamber { get; set; }

    [JsonPropertyName("congress")]
    public int Congress { get; set; }

    [JsonPropertyName("endYear")]
    public int EndYear { get; set; }

    [JsonPropertyName("memberType")]
    public string MemberType { get; set; }

    [JsonPropertyName("startYear")]
    public int StartYear { get; set; }

    [JsonPropertyName("stateCode")]
    public string StateCode { get; set; }

    [JsonPropertyName("stateName")]
    public string StateName { get; set; }
}