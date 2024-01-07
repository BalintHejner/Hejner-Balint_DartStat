using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Microsoft.Maui.Controls;

namespace Hejner_Balint_DartStat.Viewmodels
{
    public class GameMenuViewModel
    {
        public ICommand AppendDigitCommand { get; }
        public ICommand ClearDisplayCommand { get; }

        private Entry displayEntry;

        public GameMenuViewModel(Entry displayEntry)
        {
            this.displayEntry = displayEntry;
            AppendDigitCommand = new Command<string>(AppendDigit);
            ClearDisplayCommand = new Command(ClearDisplay);
        }

        private void AppendDigit(string digit)
        {
            displayEntry.Text += digit;
        }

        private void ClearDisplay()
        {
            displayEntry.Text = string.Empty;
        }
    }
}
