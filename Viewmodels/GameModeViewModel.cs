using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Hejner_Balint_DartStat.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Hejner_Balint_DartStat.Viewmodels
{
    [QueryProperty(nameof(StartingScore), "startingscore")]
    public partial class GameModeViewModel : ObservableObject
    {

        [ObservableProperty] int startingScore;

        [ObservableProperty] int legNumber;

        [ICommand]
        Task NavigateSelectedItemtoLegLabel()
        {
            if (legNumber != 0)
            {
                return Shell.Current.GoToAsync($"{nameof(GameMenu)}?numberofleg={legNumber}&scorestarting={startingScore}");
            }
            else
            {
                return Shell.Current.DisplayAlert("Error!", "Please select a number!", "Okay");
            }
            
        }

        //[ICommand]
        //Task NavigateAmountToScoreLabel()
        //{
        //    return Shell.Current.GoToAsync($"{nameof(GameMenu)}?scorestarting={startingScore}");
        //}

        public ObservableCollection<int> Legs { get; set; }
        public GameModeViewModel()
        {
            Legs = new ObservableCollection<int>
            {
                1, 2, 3, 4, 5
            };
        }
    }
}
