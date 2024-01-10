using CommunityToolkit.Mvvm.ComponentModel;
using System.Collections.ObjectModel;

namespace Hejner_Balint_DartStat.Viewmodels
{
    [QueryProperty(nameof(LegNumber), "legNumber")]
    public partial class GameMenuViewModel : ObservableObject
    {
        DartStatDatabase database;
        //public ICommand AppendDigitCommand { get; }
        //public ICommand ClearDisplayCommand { get; }
        //public ICommand SaveDisplayCommand { get; }
        public ObservableCollection<string> Scores { get; }
        public int Score { get; set; }
        public string Out { get; set; }
        public Dictionary<int, string> Outs { get; }

        private Entry displayEntry;
        private Label score_LB;

        List<GameMenuViewModel> outts = new List<GameMenuViewModel>();

        [ObservableProperty] int legNumber;

        //public void EntryToWork(Entry displayEntry)
        //{
        //    this.displayEntry = displayEntry;
        //}

        public GameMenuViewModel()
        {
            Scores = new ObservableCollection<string>();
            for (int i = 1; i <= 501; i++)
            {
                Scores.Add(i.ToString());
            }
            //AppendDigitCommand = new Command<string>(AppendDigit);
            //ClearDisplayCommand = new Command(ClearDisplay);
            //SaveDisplayCommand = new Command(SaveDisplay);
            database = new DartStatDatabase();

            // foreach (var item in File.ReadAllLines("Outs.txt"))
            //{
            //    GameMenuViewModel datas = new GameMenuViewModel(item);
            //    outts.Add(datas);
            //}


            //foreach (var line in outts)
            //{
            //    if (!Outs.ContainsKey(line.Score))
            //    {
            //        Outs.Add(Score, Out);
            //    }
            //}
        }


        //public GameMenuViewModel(string sor)
        //{
        //    string[] data = sor.Split(':');
        //    Score = int.Parse(data[0]);
        //    Out = data[1];
        //}

        //private void AppendDigit(string digit)
        //{
        //    displayEntry.Text += digit;
        //}

        //private void ClearDisplay()
        //{
        //    displayEntry.Text = "";
        //}

        //private async void SaveDisplay()
        //{
        //    int legs = 0;
        //    for (int i = 1; i < LegNumber; i++)
        //    {
        //        legs = i;
        //    }

        //    Round ujKor = new Round(legs, legNumber*3, int.Parse(displayEntry.Text), int.Parse(score_LB.Text)  - int.Parse(displayEntry.Text), int.Parse(displayEntry.Text) / legNumber * 3);

        //    displayEntry.Text = "";

        //    await database.SaveItemAsync(ujKor);
        //}

    }
}
