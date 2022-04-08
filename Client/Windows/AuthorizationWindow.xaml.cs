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

        private void ContinueButton_Click(object sender, RoutedEventArgs e)
        {
            if (!client.UserAuthorizationAsync(textBoxAuthName.Text).Result)
            {
                MessageBox.Show("Неверное имя пользователя!");
                textBoxAuthName.Text = "";
            }
            else
            {
                var user = client.GetUserAsync(textBoxAuthName.Text).Result;
                if(user.Online == true)
                {
                    MessageBox.Show($"Данный пользователь уже вошел в чат с таким именем");
                    textBoxAuthName.Text = "";
                    return;
                }
                MessageBox.Show($"Вы вошли в чат под именем - {textBoxAuthName.Text}");
                var newWindow = new MainWindow(client, textBoxAuthName.Text);
                exit = false;
                client.ChangeOnlineStatusUserAsync(textBoxAuthName.Text, true);
                Close();
                newWindow.Show();
            }
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            client.Close();
            var newWindow = new InitialWindow();
            Close();
            newWindow.Show();
        }
    }
}
