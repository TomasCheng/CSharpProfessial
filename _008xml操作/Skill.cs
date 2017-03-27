namespace _008xml操作
{
    public class Skill
    {
        public int Id;
        public string Name;
        public string Lang;
        public int Damage;

        

        public override string ToString()
        {
            return $"Id: {Id}, Name: {Name}, Lang: {Lang}, Damage: {Damage}";
        }

       
    }
}