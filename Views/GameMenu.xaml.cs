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

    //Disappointment = Immeasurable
    //App = Not good enough
    //I am sorry.

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