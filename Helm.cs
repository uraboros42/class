namespace RPG
{
    public class Helm
    {
        public string Name { get; }
        public float Defense { get; }
        public float Durability { get; }

        public Helm(string name, float defense)
        {
            Name = name;
            Defense = defense;
            Durability = 1f;
        }

        public override string ToString() => $"Helm: {Name}, Defense:{Defense}, Durability:{Durability}";
    }
}
