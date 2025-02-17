using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Blackbird;

public class PartyHistory
{
    public string? PartyAbbreviation { get; set; }
    public string? PartyName { get; set; }
    public int StartYear { get; set; }
}