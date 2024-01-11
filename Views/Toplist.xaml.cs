using System.Collections.ObjectModel;

namespace Hejner_Balint_DartStat.Views;

public partial class Toplist : ContentPage
{
    DartStatDatabase database;
    ObservableCollection<Round> rounds = new ObservableCollection<Round>();
    public Toplist()
	{
		InitializeComponent();
        database = new DartStatDatabase();
        rounds = new ObservableCollection<Round>(database.getItemsAsync().Result);
        lsv_topstats.ItemsSource = rounds;
    }

    //private void Load()
    //{
    //    //TC_ta.Text = rounds.Where(x => x.DartsThrown == );
    //    //TC_ta.Text = rounds.Where(x => x.DartsThrown == );
    //    //TC_ta.Text = rounds.Where(x => x.DartsThrown == );
    //    //TC_ta.Text = rounds.Where(x => x.DartsThrown == );
    //    //TC_ta.Text = rounds.Where(x => x.DartsThrown == );
    //    //TC_ta.Text = rounds.Where(x => x.DartsThrown == );
    //}


    //protected override void OnAppearing()
    //{
    //    base.OnAppearing();
    //    Load();
    //}
}