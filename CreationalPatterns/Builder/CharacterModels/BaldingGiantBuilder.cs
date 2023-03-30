using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Builder.CharacterBuilderTemplate;

namespace Builder.CharacterModels
{
    internal class BaldingGiantBuilder: CharacterBuilder
    {
        public BaldingGiantBuilder()
        {
            character = new Character("BaldingGiant");
        }

        public override void SetNickname()
        {
            Console.Write("Set your nickname: ");
            Character["nickname"] = Console.ReadLine();
        }
        public override void SetArmor()
        {
            Character["armor"] = "Cold sholders";
        }
        public override void SetWeapon()
        {
            Character["weapon"] = "Knife";
        }
        public override void SetMainPowerSkill()
        {
            Character["mainSkill"] = "Invisibility";
        }
    }
}
