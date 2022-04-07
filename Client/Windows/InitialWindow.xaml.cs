using System.ComponentModel;
using System.Windows;
using Client.ChatService;

namespace Client.Windows
{
    public partial class InitialWindow : Window
    {
        private ChatClient client;

        private bool exit;

        public InitialWindow()
        {
            InitializeComponent();
            client = new ChatClient();
            exit = true;
        }

        private void InitialWindow_Closing(object sender, CancelEventArgs e)
        {
            if (exit)
                client.Close();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var newWindow = new RegistrationWindow(client);
            exit = false;
            Close();
            newWindow.Show();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            var newWindow = new AuthorizationWindow(client);
            exit = false;
            Close();
            newWindow.Show();
        }
    }
}
