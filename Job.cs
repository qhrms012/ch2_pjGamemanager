namespace Job1
{
    public class Job
    {
        public string Name { get; private set; }
        public int Health { get; private set; }
        public int AttackPower { get; private set; }
        public int DefensePower { get; private set; }

        private Job(string name, int health, int attackPower, int defensePower)
        {
            Name = name;
            Health = health;
            AttackPower = attackPower;
            DefensePower = defensePower;
        }

        public static Job Warrior { get { return new Job("전사", 100, 10, 5); } }
        public static Job Mage { get { return new Job("마법사", 80, 12, 5); } }
        public static Job Archer { get { return new Job("궁수", 90, 13, 4); } }

        public static Job SelectedJob { get; private set; }

        public static void SelectJob(Job job)
        {
            SelectedJob = job;
        }
    }
}
