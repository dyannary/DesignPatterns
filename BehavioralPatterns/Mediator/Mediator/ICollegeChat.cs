using Mediator.Components;

namespace Mediator.Mediator
{
    public interface ICollegeChat
    {
        public abstract void Register(User user);

        public abstract void Send(string from, string message);

        void SendTo<T>(string from, string message) where T : User;
    }
}
