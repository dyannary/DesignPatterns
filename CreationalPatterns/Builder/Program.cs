using Builder.CharacterBuilderTemplate;
using Builder.CharacterCustomize;
using Builder.CharacterModels;

namespace Builder
{
    public class Program
    {
        static void Main(string[] args)
        {
            CharacterBuilder builder;

            CharacterCustomizeBuilder customizeBuilder= new CharacterCustomizeBuilder();

            AssemblyCharacterDirector mainList = new AssemblyCharacterDirector();

            builder = new RainyDayBuilder();

            mainList.Assemble(builder);

            builder.Character.Show();

          //  Console.ReadKey();

            builder = new IcePickBuilder();
            mainList.Assemble(builder);
            builder.Character.Show();
        //    Console.ReadKey();

            CharacterFeatures characterFeatures = customizeBuilder
                .SetNickname("OnFire")
                .SetArmor("Heart of Steel")
                .SetWeapon("Gun")
                .SetMainSkill("Super Speed")
                .Build();


            Console.WriteLine(characterFeatures.Nickname);


            Console.ReadLine();

        }
    }
}