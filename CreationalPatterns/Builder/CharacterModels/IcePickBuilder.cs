using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Builder.CharacterBuilderTemplate;

namespace Builder.CharacterModels
{
    internal class IcePickBuilder: CharacterBuilder
    {
        public IcePickBuilder()
        {
            character = new Character("Ice Pick");
        }

        public override void SetNickname()
        {
            Console.Write("Set your nickname: ");
            Character["nickname"] = Console.ReadLine();
        }
        public override void SetArmor()
        {
            Character["armor"] = "The Resistance";
        }
        public override void SetWeapon()
        {
            Character["weapon"] = "Laser";
        }
        public override void SetMainPowerSkill()
        {
            Character["mainSkill"] = "Super speed";
        }
    }
}
