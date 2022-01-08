using System;

namespace WpfStyletIntro.ViewModels;

public class SecondPageViewModel : PageViewModel
{
    private DateTime _timeCreated;
    public DateTime TimeCreated
    {
        get => _timeCreated;
        set => SetAndNotify(ref _timeCreated, value);
    }

    public SecondPageViewModel()
    {
        Title = "Second Page View Model";
        TimeCreated = DateTime.Now;
    }
}
