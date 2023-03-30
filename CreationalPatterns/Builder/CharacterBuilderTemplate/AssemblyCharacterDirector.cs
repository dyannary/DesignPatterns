using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Builder.CharacterBuilderTemplate
{
    class AssemblyCharacterDirector
    {
        public void Assemble(CharacterBuilder characterBuilder)
        {
            characterBuilder.SetNickname();

            characterBuilder.SetArmor();

            characterBuilder.SetWeapon();

            characterBuilder.SetMainPowerSkill();
        }
    }
}
