using Hejner_Balint_DartStat.Views;
using Hejner_Balint_DartStat.Viewmodels;

namespace Hejner_Balint_DartStat
{
    public partial class MainPage : ContentPage
    {
        MainPageViewModel mainPageViewModel = new MainPageViewModel();

        public MainPage()
        {
            InitializeComponent();
            BindingContext = mainPageViewModel;

        }

        private void Button_Clicked(object sender, EventArgs e)
        {
           Navigation.PushAsync(new GameMode());  
        }

        private void ImageButtonMusic_Clicked(object sender, EventArgs e)
        {

        }

        private void ImageButtonList_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Toplist());
        }
    }
        
}