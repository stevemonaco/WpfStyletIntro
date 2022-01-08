using Stylet;

namespace WpfStyletIntro.ViewModels;

public class FirstPageViewModel : PageViewModel
{
    private BindableCollection<string> _books;
    public BindableCollection<string> Books
    {
        get => _books;
        set => SetAndNotify(ref _books, value);
    }

    public FirstPageViewModel()
    {
        Title = "First Page View Model";

        _books = new BindableCollection<string>()
        {
            "First book",
            "Second book",
            "Third book"
        };
    }
}
