using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Hejner_Balint_DartStat.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hejner_Balint_DartStat.Viewmodels
{
    public partial class MainPageViewModel : ObservableObject
    {
        [ICommand]
        Task NavigateToGameMode()
        {
            //if (!String.IsNullOrWhiteSpace(playerOneName) && !String.IsNullOrWhiteSpace(playerTwoName))
            //{
            //    return Shell.Current.GoToAsync($"{nameof(GamePage)}?pOneName={playerOneName}&pTwoName={playerTwoName}");
            //}
            return Shell.Current.GoToAsync($"{nameof(GameMode)}");
            //return Shell.Current.DisplayAlert("Hiba!", "Mindekét játékos nevét kötelező megadni!", "Ok");
        }

        public MainPageViewModel()
        {
            
        }

    }
}
