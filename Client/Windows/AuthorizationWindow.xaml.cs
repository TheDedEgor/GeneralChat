using System.ComponentModel;
using System.Windows;
using Client.ChatService;

namespace Client.Windows
{
    public partial class AuthorizationWindow : Window
    {
        private ChatClient client;

        private bool exit;

        public AuthorizationWindow(ChatClient client)
        {
            InitializeComponent();
            this.client = client;
            exit = true;
        }

        private void AuthorizationWindow_Closing(object sender, CancelEventArgs e)
        {
            if (exit)
                client.Close();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (!client.UserAuthorizationAsync(textBoxAuthName.Text).Result)
            {
                MessageBox.Show("Неверное имя пользователя!");
            }
            else
            {
                MessageBox.Show($"Вы вошли в чат под именем - {textBoxAuthName.Text}");
                var newWindow = new MainWindow(client, textBoxAuthName.Text);
                exit = false;
                Close();
                newWindow.Show();
            }
        }
    }
}
