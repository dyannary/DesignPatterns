using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Builder.CharacterBuilderTemplate;

namespace Builder.CharacterModels
{
    class RainyDayBuilder: CharacterBuilder
    {
        public RainyDayBuilder() 
        {
            character = new Character("Rainy Day");
        }

        public override void SetNickname()
        {
            Console.Write("Set your nickname: ");
            Character["nickname"] = Console.ReadLine();
        }

        public override void SetArmor()
        {
            Character["armor"] = "Second Skin";
        }
        public override void SetWeapon()
        {
            Character["weapon"] = "Axe";
        }
        public override void SetMainPowerSkill()
        {
            Character["mainSkill"] = "Mind control";
        }
    }
}
