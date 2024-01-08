using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Microsoft.Maui.Controls;
using Hejner_Balint_DartStat;
using CommunityToolkit.Mvvm.ComponentModel;
using Hejner_Balint_DartStat.Views;
using System.Security.Cryptography;

namespace Hejner_Balint_DartStat.Viewmodels
{
    public partial class GameMenuViewModel : ObservableObject
    {
        DartStatDatabase database;
        public ICommand AppendDigitCommand { get; }
        public ICommand ClearDisplayCommand { get; }
        public ICommand SaveDisplayCommand { get; }

        private Entry displayEntry;

        public GameMenuViewModel()
        {

        }

        public GameMenuViewModel(Entry displayEntry)
        {
            this.displayEntry = displayEntry;
            AppendDigitCommand = new Command<string>(AppendDigit);
            ClearDisplayCommand = new Command(ClearDisplay);
            //SaveDisplayCommand = new Command(SaveDisplay);
            database = new DartStatDatabase();
        }

        private void AppendDigit(string digit)
        {
            displayEntry.Text += digit;
        }

        private void ClearDisplay()
        {
            displayEntry.Text = string.Empty;
        }

        //private async void SaveDisplay()
        //{
        //    Round ujKor = new Round(0, legNumber*3, int.Parse(displayEntry.Text), 0 - int.Parse(displayEntry.Text), int.Parse(displayEntry.Text) / legnumber*3);

        //    displayEntry.Text = "";

        //    await database.SaveItemAsync(ujKor);
        //}

        //[ObservableProperty] int legNumber;

        //[QueryProperty(nameof(GameMode), "legNumber")]
    
    }
}
