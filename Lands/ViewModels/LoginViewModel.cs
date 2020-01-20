namespace Lands.ViewModels
{
    using System.Windows.Input;
    using GalaSoft.MvvmLight.Command;
    using Xamarin.Forms;

    public class LoginViewModel : BaseViewModel
    {

        #region Attributes

        private string password;

        private bool isRunning;
        private bool isEnabled;
        #endregion


        #region Properties
        public string Email { get; set; }

        public string Password
        {
            get { return this.password; }
            set { SetValue(ref this.password, value); }
        }

        public bool IsRunning
        {
            get { return this.isRunning; }
            set { SetValue(ref this.isRunning, value); }
        }

        public bool IsRemembered { get; set; }

        public bool IsEnabled
        {
            get { return this.isEnabled; }
            set { SetValue(ref this.isEnabled, value); }
        }

        #endregion

        #region Constructor
        public LoginViewModel()
        {
            this.IsRemembered = true;
            this.isEnabled = true;
        }
        #endregion

        #region Commands

        public ICommand LoginCommand
        {
            get
            {
                return new RelayCommand(Login);
            }
        }



        private async void Login()
        {
            if (string.IsNullOrEmpty(this.Email))
            {
                await Application.Current.MainPage.DisplayAlert("Error", "You Must Enter an Email", "Accept");
                return;
            }
            if (string.IsNullOrEmpty(this.Password))
            {
                await Application.Current.MainPage.DisplayAlert("Error", "You Must Enter an Password", "Accept");
                return;
            }
            
            this.IsRunning = true;
            this.IsEnabled = false;


            if(this.Email != "p@hotmail.com" || this.password != "1234")
            {
                this.IsRunning = false;
                this.IsEnabled = true;
                await Application.Current.MainPage.DisplayAlert("Error", "Email or Password incorrect", "Accept");
                this.password = string.Empty;
                return;
            }

            await Application.Current.MainPage.DisplayAlert(
                "OK",
                "Fuck yeahhh",
                "Accept"
            );

        }
        #endregion
    }
}
