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
		comboBox.ItemsSource = gameModeViewModel.Legs;
		startBtn.Command = gameModeViewModel.NumberOfLegs;
	}

    private async void startBtn_Clicked(object sender, EventArgs e)
    {
		if (comboBox.SelectedValue != null)
		{
            await Navigation.PushAsync(new GameMenu());
		}
		else
		{
			await Shell.Current.DisplayAlert("Error!", "Please select a number!", "Okay");
		}
    }
}