namespace Chatter.Client.Providers
{
    public class FormProvider
    {
        private static ConnectWindow _connectWindow;

        public static ConnectWindow ConnectWindow
        {
            get
            {
                if (_connectWindow == null)
                {
                    _connectWindow = new ConnectWindow();
                }
                return _connectWindow;
            }
        }
    }
}