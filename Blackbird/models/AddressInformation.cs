using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Blackbird;

public class AddressInformation
{
    public string? City { get; set; }
    public string? District { get; set; }
    public string? OfficeAddress { get; set; }
    public string? PhoneNumber { get; set; }
    public int ZipCode { get; set; }
}