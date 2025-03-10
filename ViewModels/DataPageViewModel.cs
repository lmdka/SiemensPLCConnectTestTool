using System.Collections.Generic;
using System.Collections.ObjectModel;
using AvaloniaProject.Models;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace AvaloniaProject.ViewModels;

public partial class DataPageViewModel : ViewModelBase
{
    public ObservableCollection<DbDataItem> DbDataItems { get; }

    public DataPageViewModel()
    {
        var list = new List<DbDataItem>();
        DbDataItems = new ObservableCollection<DbDataItem>(list);
    }

    [ObservableProperty] private string _inputDataType = "";
    [ObservableProperty] private string _inputDbName = "";
    [ObservableProperty] private string _inputOffset = "";
    [ObservableProperty] private string _inputBit = "";

    public List<string> DataTypes { get; } =
    [
        "",
        "string",
        "bool",
        "int",
    ];


    [RelayCommand]
    private void AddDbDataItem()
    {
        if (InputDbName == "") return;
        if (InputOffset == "") return;
        if (InputDataType == "") return;
        var item = new DbDataItem(InputDbName, InputOffset, InputDataType, "", "", "1");
        DbDataItems.Add(item);

        InputDbName = "";
        InputOffset = "";
        InputDataType = "";
        InputBit = "";
    }
}