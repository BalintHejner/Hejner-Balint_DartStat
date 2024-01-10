using Hejner_Balint_DartStat.Viewmodels;

namespace Hejner_Balint_DartStat.Views;

public partial class GameMenu : ContentPage
{
	DartStatDatabase database;
	GameMenuViewModel viewModel;

    public GameMenu()
	{
		InitializeComponent();
		database = new DartStatDatabase();
		viewModel = new GameMenuViewModel();
		score_LB.Text = "501";
	}

	private void Load()
	{
		viewModel.EntryToWork(this.displayEntry);
	}

    protected override void OnAppearing()
    {
        base.OnAppearing();
		Load();
    }


}