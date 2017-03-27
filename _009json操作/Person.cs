using System.Collections.Generic;
using System.Text;

namespace _009json操作
{
    public class Person
    {
        public int age;
        public int id;
        public int level;
        public string name;
        public List<Skill> skillList;

        public override string ToString()
        {
            return $"Name: {name}, Id: {id}, Level: {level}, Age: {age}, SkillList:" + skillListToString();
        }

        public string skillListToString()
        {
            var sb = new StringBuilder();
            foreach (var skill in skillList)
            {
                sb.Append(skill + " ");
            }


            return sb.ToString();
        }
    }
}