namespace RPG
{
    public class Shell
    {
        public string Name { get; }
        public float Defense { get; }
        public float Durability { get; }

        public Shell(string name, float defense)
        {
            Name = name;
            Defense = defense;
            Durability = 1f;
        }

        public override string ToString() => $"Shell: {Name}, Defense:{Defense}, Durability:{Durability}";
    }
}
