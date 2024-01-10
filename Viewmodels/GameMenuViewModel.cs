﻿using Android.Service.Autofill;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Collections.ObjectModel;

namespace Hejner_Balint_DartStat.Viewmodels
{
    [QueryProperty(nameof(StartingScore), "scorestarting")]
    [QueryProperty(nameof(Practicinglegs), "numberofleg")]
    public partial class GameMenuViewModel : ObservableObject
    {

        [ObservableProperty] int startingScore;
        [ObservableProperty] int practicinglegs;
        [ObservableProperty] int labeltextscore;
        [ObservableProperty] string theoutstext;
        [ObservableProperty] bool istheoutvisible = false;

        [ICommand]
        async Task NavigateEntryScoreToLabelScore()
        {
            startingScore = startingScore - labeltextscore;


            if (Outs.ContainsKey(startingScore))
            {
                istheoutvisible = true;
                theoutstext = Outs[startingScore];
            }
        }

        DartStatDatabase database;
        //public ICommand AppendDigitCommand { get; }
        //public ICommand ClearDisplayCommand { get; }
        //public ICommand SaveDisplayCommand { get; }
        //public ObservableCollection<int> Scores { get; }
        //public int Score { get; set; }
        //public string Out { get; set; }
        public Dictionary<int, string> Outs = new Dictionary<int, string>();

        private Entry disappointingEntry;
        private Label score_LB;

        //List<GameMenuViewModel> outts = new List<GameMenuViewModel>();


        public void EntryToWork(Entry disappointingEntry)
        {
            this.disappointingEntry = disappointingEntry;
        }

        public async void FillDictionary()
        {
            using Stream fileStream = await FileSystem.Current.OpenAppPackageFileAsync("Outs.txt");
            using StreamReader reader = new StreamReader(fileStream);
            while (!reader.EndOfStream)
            {
                string[] line = reader.ReadLine().Split(':');
                Outs.Add(int.Parse(line[0]), line[1]);
            }
        }
        public GameMenuViewModel()
        {
            //Scores = new ObservableCollection<int>();
            //for (int i = 1; i <= 501; i++)
            //{
            //    Scores.Add(i);
            //}
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
        //    disappointingEntry.Text += digit;
        //}

        //private void ClearDisplay()
        //{
        //    disappointingEntry.Text = "";
        //}

        //private async void Savedisplay()
        //{
        //    int legs = 0;
        //    for (int i = 1; i < LegNumber; i++)
        //    {
        //        legs = i;
        //    }

        //    Round ujkor = new Round(legs, LegNumber * 3, int.Parse(disappointingEntry.Text), int.Parse(score_LB.Text) - int.Parse(disappointingEntry.Text), int.Parse(disappointingEntry.Text) / LegNumber * 3);

        //    disappointingEntry.Text = "";

        //    await database.SaveItemAsync(ujkor);
        //}

    }
}
