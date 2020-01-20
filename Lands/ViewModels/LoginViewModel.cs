namespace Lands.ViewModels
{
    using System.Windows.Input;

    public class LoginViewModel
    {
        #region Properties
        public string Email { get; set; }

        public string PassWord { get; set; }

        public bool IsRunning { get; set; }

        public bool IsRemembered { get; set; }

        #endregion

        #region Commands

        public ICommand LoginCommand { get; set; }
        #endregion
    }
}
