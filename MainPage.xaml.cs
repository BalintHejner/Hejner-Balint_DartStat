using Hejner_Balint_DartStat.Views;
using Hejner_Balint_DartStat.Viewmodels;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Hejner_Balint_DartStat
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
            BindingContext = new MainPageViewModel();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync($"{nameof(GameMode)}");
            //return Shell.Current.DisplayAlert("Hiba!", "A könyv címét kötelező megadni!", "Ok");
            
        }

        private void ImageButtonMusic_Clicked(object sender, EventArgs e)
        {
            imgBtnMsc.Source = "musiccrossed.svg";
            if (imgBtnMsc.Source.ToString() == "musiccrossed.svg")
            {
                imgBtnMsc.Source = "music.svg";
            }
        }

        private void ImageButtonList_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new GameMode());
        }
    }
        
}