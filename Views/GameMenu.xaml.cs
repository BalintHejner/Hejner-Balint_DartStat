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

    //Bind the mainpage button text to score_LB.Text
    //Bind the combobox selected item to legnumber label
    //Fill the outs dictionary and bind it with the out_LB
    //Make the saveBtn push data into SQLite and change the text of score_LB and out_LB
    //Make the Toplist and Statistics pull down data from the database

    private void Savebtn_Clicked(object sender, EventArgs e)
    {

    }

    private void Clearbtn_Clicked(object sender, EventArgs e)
    {
        disappointingEntry.Text = "";
    }

    //private void Load()
    //{
    //	viewModel.EntryToWork(this.displayEntry);
    //}

    //   protected override void OnAppearing()
    //   {
    //       base.OnAppearing();
    //	Load();
    //   }


}