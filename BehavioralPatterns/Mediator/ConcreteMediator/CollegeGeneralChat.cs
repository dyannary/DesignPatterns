using Mediator.Components;
using Mediator.Mediator;

namespace Mediator.ConcreteMediator
{
    public class CollegeGeneralChat: CollegeChat
    {
        private List<ChatRoomMember> members = new List<ChatRoomMember>();


        public override void Register(ChatRoomMember member)
        {
            //bi-directional references
            member.SetChatRoom(this);
            this.members.Add(member);
        }

        public override void Send(string from, string message)
        {
            this.members.ForEach(m => m.Recieve(from, message));
        }

        public void RegisterMembers(params ChatRoomMember[] teamMembers) 
        {
            foreach (var member in teamMembers)
            {
                this.Register(member);
            }
        }
    }
}
