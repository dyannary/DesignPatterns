using Builder.CharacterCustomize;

namespace Builder.CharacterBuilderTemplate
{
    abstract class CharacterBuilder
    {
        protected Character? character;

        public Character Character
        {
            get => character;
            set { }
        }

        public abstract void SetNickname();
        public abstract void SetArmor();
        public abstract void SetWeapon();
        public abstract void SetMainPowerSkill();

        private readonly CharacterFeatures _characterFeatures = new CharacterFeatures();
    }
}
