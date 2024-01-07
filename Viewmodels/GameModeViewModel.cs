using Hejner_Balint_DartStat.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hejner_Balint_DartStat.Viewmodels
{
    public class GameModeViewModel
    {
        public ObservableCollection<GameMode> Legs { get; set; }
        public GameModeViewModel()
        {
            this.Legs = new ObservableCollection<GameMode>
            {
                new GameMode() { NumberOfLegs = 1 },
                new GameMode() { NumberOfLegs = 2 },
                new GameMode() { NumberOfLegs = 3 },
                new GameMode() { NumberOfLegs = 4 },
                new GameMode() { NumberOfLegs = 5 }
            };
        }
    }
}
