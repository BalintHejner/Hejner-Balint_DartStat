using System.Collections.ObjectModel;

namespace Hejner_Balint_DartStat.Views;

public partial class Statistics : ContentPage
{
	DartStatDatabase database;
	ObservableCollection<Round> rounds = new ObservableCollection<Round>();
	public Statistics()
	{
		InitializeComponent();
		database = new DartStatDatabase();
	}

	private void Load()
	{
		rounds = new ObservableCollection<Round>(database.getItemsAsync().Result);
		//TC_ta.Text = rounds.Where(x => x.DartsThrown == );
		//TC_ta.Text = rounds.Where(x => x.DartsThrown == );
		//TC_ta.Text = rounds.Where(x => x.DartsThrown == );
		//TC_ta.Text = rounds.Where(x => x.DartsThrown == );
		//TC_ta.Text = rounds.Where(x => x.DartsThrown == );
		//TC_ta.Text = rounds.Where(x => x.DartsThrown == );
    }


    protected override void OnAppearing()
    {
        base.OnAppearing();
		Load();
    }
}