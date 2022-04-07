using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows;
using Client.ChatService;

namespace Client.Windows
{
    public partial class RegistrationWindow : Window
    {
        private ChatClient client;

        private bool exit;

        public RegistrationWindow(ChatClient client)
        {
            InitializeComponent();
            this.client = client;
            exit = true;
        }

        private void RegistrationWindow_Closing(object sender, CancelEventArgs e)
        {
            if (exit)
                client.Close();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (!client.UserRegistrationAsync(textBoxRegName.Text).Result)
            {
                MessageBox.Show("Пользователь с данным именем уже зарегистрирован, попробуйте другое!");
            }
            else
            {
                MessageBox.Show($"Вы были зарегистрированы в нашем чате под именем - {textBoxRegName.Text}");
                var newWindow = new MainWindow(client, textBoxRegName.Text);
                exit = false;
                Close();
                newWindow.Show();
            }
        }
    }
}
