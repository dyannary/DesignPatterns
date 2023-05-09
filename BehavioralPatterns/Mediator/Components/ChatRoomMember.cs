using Mediator.Mediator;

namespace Mediator.Components
{
    public abstract class ChatRoomMember
    {
        public string Name { get; }

        private CollegeChat _chatRoom;

        public ChatRoomMember(string name)
        {
            this.Name = name;
        }

        internal void SetChatRoom(CollegeChat chatRoom)
        {
            this._chatRoom = chatRoom;
        }

        public void Send(string message) 
        {
            this._chatRoom.Send(this.Name, message);
        }

        public virtual void Recieve(string from, string message) 
        {
            Console.WriteLine($"---- Received Action for Member: {this.Name} in baseClass ----");
        }
    }
}
