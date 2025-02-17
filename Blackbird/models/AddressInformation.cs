using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Blackbird;

public class AddressInformation
{
    [JsonPropertyName("city")]
    public string? City { get; set; }
    [JsonPropertyName("district")]
    public string? District { get; set; }
    [JsonPropertyName("officeAddress")]
    public string? OfficeAddress { get; set; }
    [JsonPropertyName("phoneNumber")]
    public string? PhoneNumber { get; set; }
    [JsonPropertyName("zipCode")]
    public int ZipCode { get; set; }
}