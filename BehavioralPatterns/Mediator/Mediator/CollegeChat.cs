using Mediator.Components;

namespace Mediator.Mediator
{
    public abstract class CollegeChat
    {
        public abstract void Register(ChatRoomMember member);

        public abstract void Send(string from, string message);

        //public abstract void SendTo<T>(string from, string message) where
        //    T : ChatRoomMember;
    }
}
