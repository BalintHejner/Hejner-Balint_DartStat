using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.Input;
using Hejner_Balint_DartStat.Views;

namespace Hejner_Balint_DartStat.Viewmodels
{
    
    public partial class MainPageViewModel : ObservableObject
    {
        [ObservableProperty]
        int threeOone = 301;

        [ObservableProperty]
        int fiveOone = 501;

        [ICommand]
        Task Navigate301ToScoreLabel() 
        {
            return Shell.Current.GoToAsync($"{nameof(GameMode)}?startingscore={threeOone}");
        }

        [ICommand]
        Task Navigate501ToScoreLabel()
        {
            return Shell.Current.GoToAsync($"{nameof(GameMode)}?startingscore={fiveOone}");
        }

        public MainPageViewModel()
        {
            
        }
    }
}
