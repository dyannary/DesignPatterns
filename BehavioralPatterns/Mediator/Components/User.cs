using Mediator.Mediator;
using System;

namespace Mediator.Components
{
    public abstract class User
    {
        public string Name { get; }

        private ICollegeChat? _chatRoom;

        public User(string name)
        {
            Name = name;
        }

        internal void SetChat(ICollegeChat chatRoom)
        {
            _chatRoom = chatRoom;
        }

        public void Send(string message) 
        {
            _chatRoom.Send(Name, message);
        }

        public void SendTo<T>(string message) where T : User
        {
            _chatRoom?.SendTo<T>(Name, message);
        }

        public virtual void Receive(string from, string message)
        {
            Console.Write($"{Name} (" +
                $"{this.GetType().Name}) " +
                $"received from {from} " +
                $"message: < {message} > \n\n");
        }
    }
}
