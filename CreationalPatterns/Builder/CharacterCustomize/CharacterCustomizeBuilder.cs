using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace Builder.CharacterCustomize
{
    class CharacterCustomizeBuilder
    {
        private readonly CharacterFeatures _characterFeatures = new CharacterFeatures();

        public CharacterCustomizeBuilder SetNickname(string nickname)
        {
            _characterFeatures.Nickname = nickname;
            return this;
        }

        public CharacterCustomizeBuilder SetArmor(string armor)
        {
            _characterFeatures.Armor = armor;
            return this;
        }

        public CharacterCustomizeBuilder SetWeapon(string weapon)
        {
            _characterFeatures.Weapon = weapon;
            return this;
        }
        public CharacterCustomizeBuilder SetMainSkill(string mainSkill)
        {
            _characterFeatures.MainSkill = mainSkill;
            return this;
        }
        public CharacterFeatures Build()
        {
            return _characterFeatures;
        }
    }
}
