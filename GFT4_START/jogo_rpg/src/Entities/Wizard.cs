namespace jogo_rpg.src.Entities
{
    public class Wizard : Hero
    {
        public Wizard(string Name, int Level, string HeroType) : base(Name, Level, HeroType)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
        }

        public override string Attack()
        {
            return this.Name + " Lançou Mágia";
        }

        public string Attack(int Bonus){
            if (Bonus > 6){
            return this.Name + " Laçou Mágia super efetiva com bonus de "+ Bonus;
            }else{
                return this.Name + " Laçou Mágia com força fraca de "+ Bonus;
            }
        }
    }
}