namespace _003LINQ
{
    public class Kongfu
    {
        public int KongfuId;
        public string KongfuName;
        public int Lethality;

        public int KongfuId1
        {
            get { return KongfuId; }
            set { KongfuId = value; }
        }

        public string KongfuName1
        {
            get { return KongfuName; }
            set { KongfuName = value; }
        }

        public int Lethality1
        {
            get { return Lethality; }
            set { Lethality = value; }
        }

        public override string ToString()
        {
            return $"KongfuId: {KongfuId}, KongfuName: {KongfuName}, Lethality: {Lethality}, KongfuId1: {KongfuId1}, KongfuName1: {KongfuName1}, Lethality1: {Lethality1}";
        }
    }
}