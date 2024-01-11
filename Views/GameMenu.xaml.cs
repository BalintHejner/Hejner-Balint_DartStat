using CommunityToolkit.Mvvm.ComponentModel;
using Hejner_Balint_DartStat.Viewmodels;
using System.Collections.ObjectModel;
using System.Security.Cryptography;

namespace Hejner_Balint_DartStat.Views;


public partial class GameMenu : ContentPage
{
	DartStatDatabase database;
	GameMenuViewModel viewModel = new GameMenuViewModel();


    public GameMenu()
	{
		InitializeComponent();
		database = new DartStatDatabase();
	}

    //Bind the mainpage button text to score_LB.Text - 100%!!!!!!!!!!!!!!!!!!!!!!!!!!!!
    //Bind the combobox selected item to legnumber label - 100%!!!!!!!!!!!!!!!!!!!!!!!!!!!!
    //Fill the outs dictionary and bind it with the out_LB - 99% (FU)
    //Make the saveBtn push data into SQLite and change the text of score_LB and out_LB - 100%
    //Make the Toplist and Statistics pull down data from the database

    protected override void OnAppearing()
    {
        base.OnAppearing();
        Load();
    }

    private void Load()
    {
        viewModel.FillDictionary();
    }

    private void Clearbtn_Clicked(object sender, EventArgs e)
    {
        disappointingEntry.Text = "";
    }

    private void Savebtn_Clicked(object sender, EventArgs e)
    {

    }

    //private void Load()
    //{
    //	viewModel.EntryToWork(this.disappointingEntry);
    //}

    //   protected override void OnAppearing()
    //   {
    //       base.OnAppearing();
    //	Load();
    //   }


}