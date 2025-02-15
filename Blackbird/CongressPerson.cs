using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Blackbird;


public class CongressPerson
{
    [JsonPropertyName("district")]
    public int? District { get; set; }

    [JsonPropertyName("partyName")]
    public string? PartyName { get; set; }

    [JsonPropertyName("state")]
    public string? State { get; set; }

    // [JsonPropertyName("terms")]
    // public List<Term>? Terms { get; set; }

    [JsonPropertyName("bioguideId")]
    public string? BioguideId { get; set; }

    [JsonPropertyName("depiction")]
    public CongressDepiction? Depiction {get; set;}

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("url")]
    public string? Url { get; set; }

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