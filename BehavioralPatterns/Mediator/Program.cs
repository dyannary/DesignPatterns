using Mediator.Components;
using Mediator.ConcreteMediator;

var generalChat = new CollegeGeneralChat();

var george = new Student("George Washington");
var vince = new Student("Vince Plank");
var lee = new Student("Lee Miles");

var jeff = new Teacher("Prof. Jeff");
var martin = new Teacher("Prof. Martin");

generalChat.RegisterUsers(george, vince, lee, jeff, martin);

george.Send("Salut la toti.");

martin.SendTo<Teacher>("Maine, la ora 14:00, adunare generala!");