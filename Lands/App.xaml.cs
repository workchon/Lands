namespace Lands
{
    using Views;
    using Xamarin.Forms;
    public partial class App : Application
    {
        #region constructors

        public App()
        {
            InitializeComponent();

            this.MainPage = new NavigationPage(new LoginPage());
        }

        #endregion
        #region Metodos

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
        #endregion
    }
}
