using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adita.PlexNet.Wpf.Hosting.Sample.ViewModels
{
    [ObservableObject]
    public partial class MainViewModel
    {
        [ObservableProperty]
        private string _data = "This is main view";
    }
}
