using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Windows;
using System.Windows.Input;
using System.Windows.Threading;
using Client.ChatService;

namespace Client
{
    public class Message
    {
        public string Text { get; set; }

        public HorizontalAlignment Align { get; set; }
    }

    public partial class MainWindow : Window
    {
        public ObservableCollection<Message> Messages;

        private ChatClient client;

        private string name;

        private int countUserMessages;

        private DispatcherTimer timer;

        public MainWindow(ChatClient client, string name)
        {
            InitializeComponent();
            this.client = client;
            var res = this.client.GetAllMessagesAsync().Result;
            List<Message> mes = new List<Message>();
            foreach (var item in res)
            {
                if (item.Sender.Name == name)
                    mes.Add(new Message() { Text = item.Content, Align = HorizontalAlignment.Right });
                else
                    mes.Add(new Message() { Text = item.Content, Align = HorizontalAlignment.Left });
            }
            Messages = new ObservableCollection<Message>(mes);
            chat.ItemsSource = Messages;
            this.name = name;
            timer = new DispatcherTimer();
            timer.Interval = new TimeSpan(0, 0, 3);
            timer.Tick += UpdateMessages;
            timer.Start();
        }

        private void UpdateMessages(object sender, EventArgs e)
        {
            var mes = client.GetAddMessages(name);
            foreach (var item in mes)
            {
                Messages.Add(new Message() { Text = item.Content, Align = HorizontalAlignment.Left });
            }
            client.ClearAddMessages(name);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var message = $"{name}: {sendMessage.Text}";
            Messages.Add(new Message() { Text = message, Align = HorizontalAlignment.Right });
            client.SendMessageAsync(name, message);
            sendMessage.Text = "";
        }

        private void MainWindow_Closing(object sender, CancelEventArgs e)
        {
            timer.Stop();
            client.Close();
        }

        private void sendMessage_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                var message = $"{name}: {sendMessage.Text}";
                Messages.Add(new Message() { Text = message, Align = HorizontalAlignment.Right });
                client.SendMessageAsync(name, message);
                sendMessage.Text = "";
            }
        }
    }
}
