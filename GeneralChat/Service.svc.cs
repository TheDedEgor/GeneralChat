using System.Collections.Generic;

namespace ServiceChat
{
    static class Chat
    {
        static private List<Message> messages = new List<Message>();

        static public void AddMessage(string name, string message)
        {
            var sender = Users.GetUser(name);
            messages.Add(new Message() { Content = message, Sender = sender });
        }

        static public List<Message> GetAllMessages()
        {
            return messages;
        }
    }

    static class Users
    {
        static private List<User> users = new List<User>();

        static public User GetUser(string name)
        {
            foreach (var item in users)
            {
                if(item.Name == name)
                    return item;
            }
            return null;
        }

        static public bool ContainsUser(string name)
        {
            foreach (var item in users)
            {
                if (item.Name == name)
                    return true;
            }
            return false;
        }

        static public void AddUser(string name)
        {
            users.Add(new User(name));
        }

        static public void AddMessage(string name, string message)
        {
            var user = GetUser(name);
            foreach (var item in users)
            {
                if (item.Name != name)
                    item.AddMessages.Add(new Message() { Content = message, Sender = user });
            }
        }
    }

    public class Service : IChat
    {
        public User GetUser(string name)
        {
            return Users.GetUser(name);
        }

        public void SendMessage(string name, string message)
        {
            Users.AddMessage(name, message);
            Chat.AddMessage(name, message);
        }

        public List<Message> GetAllMessages()
        {
            return Chat.GetAllMessages();
        }

        public bool UserAuthorization(string name)
        {
            if (!Users.ContainsUser(name))
                return false;
            return true;
        }

        public bool UserRegistration(string name)
        {
            if (Users.ContainsUser(name))
                return false;
            Users.AddUser(name);
            return true;
        }

        public List<Message> GetAddMessages(string name)
        {
            return Users.GetUser(name).AddMessages;
        }

        public void ClearAddMessages(string name)
        {
            Users.GetUser(name).AddMessages.Clear();
        }

        public void ChangeOnlineStatusUser(string name, bool status)
        {
            Users.GetUser(name).Online = status;
        }
    }
}
