using System.Text.Json.Serialization;

namespace SCPFoundation.Models;

public class SCPItem
{
    private string _class = "unknown";
    private string _procedure = "";
    private string _description = "";

    [JsonPropertyName("id")]
    public string? Id { get; set; }

    [JsonPropertyName("title")]
    public string? Title { get; set; }

    [JsonPropertyName("class")]
    public string? Class
    {
        get => _class;
        set
        {
            if (value == null)
                _class = "unknown";
            else if (value.Contains("KETER", StringComparison.OrdinalIgnoreCase))
                _class = "keter";
            else if (value.Contains("EUCLID", StringComparison.OrdinalIgnoreCase))
                _class = "euclid";
            else if (value.Contains("SAFE", StringComparison.OrdinalIgnoreCase))
                _class = "safe";
            else
                _class = "unknown";
        }
    }

    [JsonPropertyName("procedure")]
    public string? Procedure
    {
        get => _procedure;
        set
        {
            if (string.IsNullOrEmpty(value))
                _procedure = "No Record of Special Containment Procedures";
            else
                _procedure = value;
        }
    }

    [JsonPropertyName("description")]
    public string? Description
    {
        get => _description;
        set
        {
            if (string.IsNullOrEmpty(value))
                _description = "No Description Records";
            else
                _description = value;
        }
    }

    [JsonPropertyName("image")]
    public string? Image { get; set; }

    [JsonPropertyName("caption")]
    public string? Caption { get; set; }
}
