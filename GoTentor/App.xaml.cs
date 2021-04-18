using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using GoTentor.View;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace GoTentor
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            //set main page as navigation page   
            MainPage = new NavigationPage(new LoginPage());
        }

        protected override void OnStart()
        {
            // Handle when your app starts  
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps  
        }

        protected override void OnResume()
        {
            // Handle when your app resumes  
        }
    }
}