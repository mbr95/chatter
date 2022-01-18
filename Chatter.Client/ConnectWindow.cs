using System.Windows.Forms;
using System;

namespace Chatter.Client
{
    public partial class ConnectWindow : Form
    {
        public ConnectWindow()
        {
            InitializeComponent();
        }
        
        private void UsernameInput_TextChanged(object sender, System.EventArgs e)
        {
            ConnectBtn.Enabled = !string.IsNullOrEmpty(UsernameInput.Text);
        }

        private async void ConnectBtn_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                var userWindow = new UserWindow(UsernameInput.Text);
                Hide();
                userWindow.ShowDialog();
            }
            catch (Exception exception)
            {
                ConnectionLabel.Text = $"Couldn\'t connect...\n{exception.Message}";
            }
        }
    }
}