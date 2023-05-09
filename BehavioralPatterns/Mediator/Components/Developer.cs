namespace Mediator.Components
{
    public class Developer: ChatRoomMember
    {
        public Developer(string name): base(name)
        {
            
        }

        public override void Recieve(string from, string message)
        {
            Console.WriteLine($"{this.Name} ({nameof(Developer)}) has received {message}");
            base.Recieve(from, message);
        }
    }

    public class Tester: ChatRoomMember
    {
        public Tester(string name): base(name) { }
    }
}
