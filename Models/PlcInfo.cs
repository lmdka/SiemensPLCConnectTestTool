namespace AvaloniaProject.Models;

// PLC连接静态类 全局使用
public static class PlcInfo
{
    // PLC机器IP地址
    public static string IpAddress { get; set; } = "127.0.0.1";

    // PLC CPU
    public static string CpuType { get; set; } = "";

    // 
    public static int RackNumber { get; set; } = 0;

    // 
    public static int NotchNumber { get; set; } = 0;

    // PLC连接状态
    public static string ConnectStatus { get; set; } = "";

    // 是否开启实时读取数据 默认不开启
    public static bool RealTimeReadStatus { get; set; } = false;
}