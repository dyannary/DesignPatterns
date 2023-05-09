using Mediator.Components;
using Mediator.ConcreteMediator;

var breakingBadChatRoom = new CollegeGeneralChat();

var walter = new Developer("Walter White");
var jessy = new Developer("Jesse Pinkman");
var gustavo = new Developer("Gustavo Fring");
var badger = new Developer("Badger Mayhew");

//Register members
breakingBadChatRoom.RegisterMembers(walter, jessy, gustavo, badger);

//Messaging
walter.Send("Hi, everyone!"); //on public window

Console.ReadLine();