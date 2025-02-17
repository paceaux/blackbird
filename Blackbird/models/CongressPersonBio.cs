using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Blackbird;


public class CongressPersonBio
{
    [JsonPropertyName("bioguideId")]
    public string? BioguideId { get; set; }

    [JsonPropertyName("birthYear")]
    public int? BirthYear { get; set; }

    // [JsonPropertyName("cosponsoredLegislation")]
    // public LegislationReference? CosponsoredLegislation { get; set; }

    // [JsonPropertyName("sponsoredLegislation")]
    // public LegislationReference? SponsoredLegislation { get; set; }

    // [JsonPropertyName("district")]
    // public int? District { get; set; }

    // [JsonPropertyName("partyName")]
    // public string? PartyName { get; set; }

    // [JsonPropertyName("partyHistory")]
    // public List<PartyHistory>? PartyHistory { get; set; }

    // [JsonPropertyName("state")]
    // public string? State { get; set; }

    // [JsonPropertyName("terms")]
    // public List<Term>? Terms { get; set; }


    // [JsonPropertyName("depiction")]
    // public CongressDepiction? Depiction { get; set; }

    // [JsonPropertyName("url")]
    // public string? Url { get; set; }

    // [JsonPropertyName("directOrderName")]
    // public string? DirectOrderName { get; set; }

    [JsonPropertyName("honorificName")]
    public string? HonorificName { get; set; }

    // [JsonPropertyName("lastName")]
    // public string? LastName { get; set; }


    // [JsonPropertyName("firstName")]
    // public string? FirstName { get; set; }

}
