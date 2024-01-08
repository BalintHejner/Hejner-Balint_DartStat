using Hejner_Balint_DartStat.Viewmodels;

namespace Hejner_Balint_DartStat.Views;

public partial class GameMode : ContentPage
{
    public int NumberOfLegs { get; set; }
    public GameModeViewModel gameModeViewModel { get; set; }

    public GameMode()
	{
		InitializeComponent();
		gameModeViewModel = new GameModeViewModel();
		this.BindingContext = gameModeViewModel;
	}

}