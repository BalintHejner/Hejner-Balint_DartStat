using Hejner_Balint_DartStat.Views;

namespace Hejner_Balint_DartStat
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(MainPage), typeof(MainPage));
            Routing.RegisterRoute(nameof(GameMode), typeof(GameMode));
            Routing.RegisterRoute(nameof(GameMenu), typeof(GameMenu));
            Routing.RegisterRoute(nameof(Toplist), typeof(Toplist));
            Routing.RegisterRoute(nameof(Statistics), typeof(Statistics));
        }
    }
}