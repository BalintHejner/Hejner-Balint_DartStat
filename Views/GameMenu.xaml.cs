using Hejner_Balint_DartStat.Viewmodels;

namespace Hejner_Balint_DartStat.Views;

public partial class GameMenu : ContentPage
{
	public GameMenu()
	{
		InitializeComponent();
		var viewmodel = new GameMenuViewModel(displayEntry);
		BindingContext = viewmodel;
	}
}