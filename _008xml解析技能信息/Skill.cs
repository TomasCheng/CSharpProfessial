namespace _008xml解析技能信息
{
    public class Skill
    {
        public int SkillId;
        public string Name;
        public string SkillEngName;
        public int TriggerType;
        public string ImageFile;
        public int AvailableRace;

        public override string ToString()
        {
            return $"SkillId: {SkillId}, Name: {Name}, SkillEngName: {SkillEngName}, TriggerType: {TriggerType}, ImageFile: {ImageFile}, AvailableRace: {AvailableRace}";
        }
    }
}