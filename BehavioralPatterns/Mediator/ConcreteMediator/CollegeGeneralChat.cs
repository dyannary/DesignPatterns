using Mediator.Components;
using Mediator.Mediator;

namespace Mediator.ConcreteMediator
{
    public class CollegeGeneralChat: ICollegeChat
    {
        private List<User> _users = new List<User>();

        public void Register(User user)
        {
            user.SetChat(this);
            _users.Add(user);
        }

        public void Send(string from, string message)
        {
            _users.ForEach(u =>
            {
                if (u.Name != from)
                    u.Receive(from, message);
            });
        }

        public void SendTo<T>(string from, string message) where T : User
        {
            _users.OfType<T>()
                .ToList()
                .ForEach(u =>
                {
                    if (u.Name != from)
                        u.Receive(from, message);
                });
        }

        public void RegisterUsers(params User[] users)
        {
            foreach (var user in users)
                Register(user);
        }
    }
}
