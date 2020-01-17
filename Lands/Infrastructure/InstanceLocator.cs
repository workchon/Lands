namespace Lands.Infrastructure
{
    using ViewModels;
    public class InstanceLocator
    {
        #region properties
        public MainViewModel Main { get; set; }
        #endregion

        #region Constructor
        public InstanceLocator()
        {
            this.Main = new MainViewModel();
        }
        #endregion
    }
}
