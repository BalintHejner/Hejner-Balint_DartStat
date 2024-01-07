using Hejner_Balint_DartStat.Viewmodels;

namespace Hejner_Balint_DartStat.Views;

public partial class GameMenu : ContentPage
{
	DartStatDatabase database;

	public GameMenu()
	{
		InitializeComponent();
		database = new DartStatDatabase();
	}

    private void Button_Clicked(object sender, EventArgs e)
    {
        //if (!String.IsNullOrWhiteSpace(termekNev_ENT.Text))
        //{
        //    Round ujTermek = new Round(termekNev_ENT.Text, int.Parse(darab_ENT.Text), kategória_PCK.SelectedItem == null ? "" : kategória_PCK.SelectedItem.ToString());

        //    termekNev_ENT.IsEnabled = false;
        //    termekNev_ENT.IsEnabled = true;
        //    termekNev_ENT.Text = "";

        //    darab_ENT.Text = "1";
        //    kategória_PCK.SelectedItem = null;

        //    await database.SaveItemAsync(ujTermek);

        //}
        //else
        //{
        //    await DisplayAlert("Hiba!", "A termék nevét kötelezõ megadni!", "OK");
        //}
    }
}