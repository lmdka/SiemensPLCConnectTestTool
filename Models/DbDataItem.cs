namespace AvaloniaProject.Models;

public class DbDataItem(
    string dbName,
    string offset,
    string dataType,
    string readValue,
    string writeValue,
    string status)
{
    public string DbName { get; set; } = dbName;
    public string Offset { get; set; } = offset;
    public string DataType { get; set; } = dataType;
    public string ReadValue { get; set; } = readValue;
    public string WriteValue { get; set; } = writeValue;
    public string Status { get; set; } = status;
}