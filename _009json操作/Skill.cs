namespace _009json操作
{
    public class Skill
    {
        public int id;
        public int damage;
        public string name;

        public override string ToString()
        {
            return $"Id: {id}, Damage: {damage}, Name: {name}";
        }
    }
}