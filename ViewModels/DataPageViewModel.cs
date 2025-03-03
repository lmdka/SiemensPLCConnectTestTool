using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace AvaloniaProject.ViewModels;

public class DataPageViewModel : ViewModelBase
{
    public ObservableCollection<Person> People { get; }

    public DataPageViewModel()
    {
        var people = new List<Person>
        {
            new Person("Neil", "Armstrong"),
            new Person("Buzz", "Lightyear"),
            new Person("James", "Kirk")
        };
        People = new ObservableCollection<Person>(people);
    }
}