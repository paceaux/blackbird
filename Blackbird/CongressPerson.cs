using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Blackbird;


public class CongressPerson
{
    [JsonPropertyName("bioguideId")]
    public string? BioguideId { get; set; }

    [JsonPropertyName("birthYear")]
    public int? BirthYear { get; set; }

    [JsonPropertyName("cosponsoredLegislation")]
    public LegislationReference? CosponsoredLegislation {get; set;}
    
    [JsonPropertyName("sponsoredLegislation")]
    public LegislationReference? SponsoredLegislation {get; set;}

    [JsonPropertyName("district")]
    public int? District { get; set; }

    [JsonPropertyName("partyName")]
    public string? PartyName { get; set; }

    [JsonPropertyName("partyHistory")]
    public List<PartyHistory>? PartyHistory { get; set; }

    [JsonPropertyName("state")]
    public string? State { get; set; }

    // [JsonPropertyName("terms")]
    // public List<Term>? Terms { get; set; }


    [JsonPropertyName("depiction")]
    public CongressDepiction? Depiction {get; set;}

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("url")]
    public string? Url { get; set; }

    [JsonPropertyName("honorificName")]
    public string? HonorificName { get; set; }


    public string LastName {
        get {
            string name = Name;
            if (name != null) {

            string[] nameParts = name.Split(",");
            return nameParts[0];
            } else {
                return "";
            }
        }
    }
    public string FirstName {
        get {
            string name = Name;
            if (name != null) {

            string[] nameParts = name.Split(",");
            return nameParts[1];
            } else {
                return "";
            }
        }
    }

    // public string Chamber {
    //     get {
    //         Term currentTerm = Terms.Find(term => term.HasFinishedTerm == false);
    //         return currentTerm.Chamber;
    //     }
    // }

}

public class Term {
    [JsonPropertyName("chamber")]
    public string? Chamber { get; set; }

    [JsonPropertyName("endYear")]
    public int EndYear { get; set; }

    [JsonPropertyName("startYear")]
    public int StartYear { get; set; }

    public bool HasFinishedTerm {
        get {
            return EndYear > 0 && StartYear > 0;
        }
    }

    public int TimeInOffice {
        get {
            int currentYear = DateTime.Now.Year;
            if (HasFinishedTerm) {
                return EndYear - StartYear;
            } else {
                return currentYear - StartYear;
            }
        }
    }
}

public class LegislationReference {
    [JsonPropertyName("count")]
    public int Count {get; set;}

    [JsonPropertyName("URL")]
    public string? Url { get; set; }
}

public class AddressInformation
{
    public string? City { get; set; }
    public string? District { get; set; }
    public string? OfficeAddress { get; set; }
    public string? PhoneNumber { get; set; }
    public int ZipCode { get; set; }
}

public class PartyHistory
{
    public string? PartyAbbreviation { get; set; }
    public string? PartyName { get; set; }
    public int StartYear { get; set; }
}