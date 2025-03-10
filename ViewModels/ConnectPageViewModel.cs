using System.Collections.Generic;
using System.Text.RegularExpressions;
using AvaloniaProject.Models;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace AvaloniaProject.ViewModels;

public partial class ConnectPageViewModel : ViewModelBase
{
    [ObservableProperty] private string _inputIpAddress = "";
    [ObservableProperty] private string _inputCpuType = "";
    [ObservableProperty] private string _inputRackNumber = "";
    [ObservableProperty] private string _inputNotchNumber = "";
    [ObservableProperty] private string _ipAddress = "";
    [ObservableProperty] private string _cpuType = "";
    [ObservableProperty] private string _rackNumber = "";
    [ObservableProperty] private string _notchNumber = "";
    [ObservableProperty] private string _connectStatus = "no";
    [ObservableProperty] private string _connectStatusColor = "red";
    [ObservableProperty] private bool _isConnectButtonEnabled = true;


    public List<string> CpuTypes { get; } =
    [
        "",
        "S71200",
        "S71500",
        "S71700",
        "S71800",
        "S72000"
    ];

    [RelayCommand]
    private void Connect()
    {
        if (InputIpAddress == "") return;
        if (InputCpuType == "") return;
        if (InputRackNumber == "") return;
        if (InputNotchNumber == "") return;

        if (!IsValidIpAddress(InputIpAddress)) return;
        IsConnectButtonEnabled = false;
        IpAddress = InputIpAddress;
        CpuType = InputCpuType;
        RackNumber = InputRackNumber;
        NotchNumber = InputNotchNumber;
        // 连接逻辑
        ConnectStatus = "ok";
        ConnectStatusColor = "green";
    }

    [RelayCommand]
    private void Disconnect()
    {
        IpAddress = "";
        CpuType = "";
        RackNumber = "";
        NotchNumber = "";
        IsConnectButtonEnabled = true;
        // 断开连接逻辑
        ConnectStatus = "no";
        ConnectStatusColor = "red";
    }


    // 判断填写的是不是IPV4地址
    private static bool IsValidIpAddress(string ipAddress)
    {
        // IPv4 正则表达式
        const string ipv4Pattern =
            @"^((25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\.){3}(25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)$";
        // IPv6 正则表达式
        const string ipv6Pattern = @"^([0-9a-fA-F]{1,4}:){7}[0-9a-fA-F]{1,4}$";
        // 判断是否为 IPv4 或 IPv6
        // return Ipv4Regex().IsMatch(ipAddress) || Ipv6Regex().IsMatch(ipAddress);
        return Ipv4Regex().IsMatch(ipAddress);
    }

    [GeneratedRegex(@"^((25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\.){3}(25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)$")]
    private static partial Regex Ipv4Regex();

    [GeneratedRegex("^([0-9a-fA-F]{1,4}:){7}[0-9a-fA-F]{1,4}$")]
    private static partial Regex Ipv6Regex();
}