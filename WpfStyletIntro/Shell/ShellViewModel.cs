using Stylet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfStyletIntro.ViewModels;

public class ShellViewModel : Conductor<PageViewModel>
{
    public ShellViewModel()
    {
        ActiveItem = new FirstPageViewModel();
    }

    public void ShowFirstPageViewModel()
    {
        ActiveItem = new FirstPageViewModel();
    }

    public void ShowSecondPageViewModel()
    {
        ActiveItem = new SecondPageViewModel();
    }
}
