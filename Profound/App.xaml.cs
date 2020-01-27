using Profound.Views;
using Xamarin.Forms;

namespace Profound
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new LogIn();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
