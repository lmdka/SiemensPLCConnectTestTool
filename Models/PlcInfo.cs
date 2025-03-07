namespace AvaloniaProject.Models;

public class PlcInfo
{
    private string IpAddress { get; set; } = "127.0.0.1";
    private string CpuType { get; set; } = "";
    private int RackNumber { get; set; } = 0;
    private int NotchNumber { get; set; } = 0;
    private string ConnectStatus { get; set; } = "";
    
}