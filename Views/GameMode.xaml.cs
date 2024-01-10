using Hejner_Balint_DartStat.Viewmodels;
using System.Security.Cryptography.X509Certificates;

namespace Hejner_Balint_DartStat.Views;

public partial class GameMode : ContentPage
{
    public int NumberOfLegs { get; set; }
    public GameModeViewModel gameModeViewModel { get; set; }

    public GameMode()
	{
		InitializeComponent();
		gameModeViewModel = new GameModeViewModel();
		comboBox.ItemsSource = gameModeViewModel.Legs;
		//startBtn.Command = gameModeViewModel.NumberOfLegs;
		//NumberOfLegs = comboBox.SelectedIndex + 1;
	}

  //  private async void startBtn_Clicked(object sender, EventArgs e)
  //  {
		////if (comboBox.SelectedValue != null)
		////{
  ////          await Navigation.PushAsync(new GameMenu());
		////}
		////else
		////{
		////	await Shell.Current.DisplayAlert("Error!", "Please select a number!", "Okay");
		////}
  //  }
}