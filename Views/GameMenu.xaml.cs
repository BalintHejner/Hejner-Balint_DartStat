using Hejner_Balint_DartStat.Viewmodels;

namespace Hejner_Balint_DartStat.Views;

public partial class GameMenu : ContentPage
{
	DartStatDatabase database;
	public GameMenuViewModel gameMenuViewModel { get; set; }

    public GameMenu()
	{
		InitializeComponent();
		database = new DartStatDatabase();
		score_LB.Text = "501";
		this.BindingContext = gameMenuViewModel;
	}

   
}