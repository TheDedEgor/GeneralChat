using System.Collections.Generic;
using System.Runtime.Serialization;
using System.ServiceModel;

namespace ServiceChat
{
    [ServiceContract]
    public interface IChat
    {
        [OperationContract]
        bool UserRegistration(string name);

        [OperationContract]
        bool UserAuthorization(string name);

        [OperationContract]
        List<Message> GetAllMessages();

        [OperationContract]
        User GetUser(string name);

        [OperationContract]
        void SendMessage(string name, string message);

        [OperationContract]
        List<Message> GetAddMessages(string name);

        [OperationContract]
        void ClearAddMessages(string name);
    }

    [DataContract]
    public class User
    {
        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public List<Message> AddMessages { get; set; }

        public User(string Name)
        {
            this.Name = Name;
            this.AddMessages = new List<Message>();
        }

        public User() { }
    }

    [DataContract]
    public class Message
    {
        [DataMember]
        public string Content { get; set; }

        [DataMember]
        public User Sender { get; set; }

        public Message() { }
    }
}
