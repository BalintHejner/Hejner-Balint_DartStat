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
    public partial class GameModeViewModel : ObservableObject
    {
        public ObservableCollection<int> Legs { get; set; } 

        [ObservableProperty]
        int legNumber;
        public GameModeViewModel()
        {
            Legs = new ObservableCollection<int>
            {
                1, 2, 3, 4, 5
            };

            NumberOfLegs = new Command(Leg);
        }

        public ICommand NumberOfLegs { get; }

        private void Leg()
        {
            Shell.Current.GoToAsync($"{nameof(GameMenu)}?legnumber={legNumber}");
        }
    }
}
