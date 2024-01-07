using Hejner_Balint_DartStat.Views;

namespace Hejner_Balint_DartStat
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
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