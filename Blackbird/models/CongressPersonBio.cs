using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Blackbird;


public class CongressPersonBio
{
    [JsonPropertyName("bioguideId")]
    public string BioguideId { get; set; }

    [JsonPropertyName("birthYear")]
    public string BirthYear { get; set; }

    [JsonPropertyName("cosponsoredLegislation")]
    public LegislationReference CosponsoredLegislation { get; set; }

    [JsonPropertyName("depiction")]
    public CongressDepiction Depiction { get; set; }

    [JsonPropertyName("directOrderName")]
    public string DirectOrderName { get; set; }

    [JsonPropertyName("firstName")]
    public string FirstName { get; set; }

    [JsonPropertyName("honorificName")]
    public string HonorificName { get; set; }

    [JsonPropertyName("invertedOrderName")]
    public string InvertedOrderName { get; set; }

    [JsonPropertyName("lastName")]
    public string LastName { get; set; }

    [JsonPropertyName("leadership")]
    public List<Leadership> Leadership { get; set; }

    [JsonPropertyName("partyHistory")]
    public List<PartyHistory> PartyHistory { get; set; }

    [JsonPropertyName("sponsoredLegislation")]
    public LegislationReference SponsoredLegislation { get; set; }

    [JsonPropertyName("state")]
    public string State { get; set; }

    [JsonPropertyName("terms")]
    public List<Term> Terms { get; set; }

    [JsonPropertyName("updateDate")]
    public DateTime UpdateDate { get; set; }

}
