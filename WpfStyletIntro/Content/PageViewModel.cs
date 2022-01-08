using Stylet;

namespace WpfStyletIntro.ViewModels;

public abstract class PageViewModel : Screen
{
    private string? _title;
    public string? Title
    {
        get => _title;
        set => SetAndNotify(ref _title, value);
    }
}
