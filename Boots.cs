namespace RPG
{
    public class Boots
    {
        public string Name { get; }
        public float Defense { get; }
        public float Durability { get; }

        public Boots(string name, float defense)
        {
            Name = name;
            Defense = defense;
            Durability = 1f;
        }

        public override string ToString() => $"Boots: {Name}, Defense:{Defense}, Durability:{Durability}";
    }
}
