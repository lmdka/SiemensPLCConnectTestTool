using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace AvaloniaProject.ViewModels;

public partial class MainWindowModel : ViewModelBase
{
    public string Greeting { get; } = "欢迎使用Avalonia UI!";

    [ObservableProperty]
    [NotifyPropertyChangedFor(nameof(ConnectPageIsActive))]
    [NotifyPropertyChangedFor(nameof(DataPageButtonIsActive))]
    [NotifyPropertyChangedFor(nameof(LogPageButtonIsActive))]
    [NotifyPropertyChangedFor(nameof(SettingPageButtonIsActive))]
    private ViewModelBase _currentPage;

    public bool ConnectPageIsActive => CurrentPage == _connectPage;
    public bool DataPageButtonIsActive => CurrentPage == _dataPage;
    public bool LogPageButtonIsActive => CurrentPage == _logPage;
    public bool SettingPageButtonIsActive => CurrentPage == _settingPage;

    private readonly ConnectPageViewModel _connectPage = new();
    private readonly DataPageViewModel _dataPage = new();
    private readonly LogPageViewModel _logPage = new();
    private readonly SettingPageViewModel _settingPage = new();


    public MainWindowModel()
    {
        CurrentPage = _connectPage;
    }


    [RelayCommand]
    private void GoToConnectPage()
    {
        CurrentPage = _connectPage;
    }

    [RelayCommand]
    private void GoToDataPage()
    {
        CurrentPage = _dataPage;
    }

    [RelayCommand]
    private void GoToLogPage()
    {
        CurrentPage = _logPage;
    }

    [RelayCommand]
    private void GoToSettingPage()
    {
        CurrentPage = _settingPage;
    }
}