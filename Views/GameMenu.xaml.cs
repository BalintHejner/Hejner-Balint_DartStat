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

    }

    private void Savebtn_Clicked(object sender, EventArgs e)
    {

    }
}