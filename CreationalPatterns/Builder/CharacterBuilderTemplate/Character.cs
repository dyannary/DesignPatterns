using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.CharacterBuilderTemplate
{
    class Character
    {
        private string _characterModel;

        private Dictionary<string, string> _parameters
        = new Dictionary<string, string>();

        public Character(string characterModel)
        {
            _characterModel = characterModel;
        }
        public string this[string key]
        {
            get { return _parameters[key]; }
            set { _parameters[key] = value; }
        }

        public void Show()
        {
            Console.WriteLine("\n---------------------------");
            Console.WriteLine("Character model: {0}", _characterModel);
            Console.WriteLine(" Nickname: {0}", _parameters["nickname"]);
            Console.WriteLine(" Armor: {0}", _parameters["armor"]);
            Console.WriteLine(" Weapon: {0}", _parameters["weapon"]);
            Console.WriteLine(" Main skill: {0}", _parameters["mainSkill"]);
        }
    }
}
