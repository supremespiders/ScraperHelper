namespace ScraperHelper.Models;

public class NeededField
{
    public FieldType FieldType { get; set; }
    public string Key { get; set; }
    public string Value { get; set; }
}

public enum FieldType
{
    Header,
    Cookie,
    FormData
}