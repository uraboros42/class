using System;

namespace RPG
{
    public class Weapon
    {
        public string Name { get; }
        public int MinDamage { get; private set; }
        public int MaxDamage { get; private set; }
        public float Durability { get; }

        public Weapon(string name)
        {
            Name = name;
            Durability = 1f;
        }

        public Weapon(string name, int minDamage, int maxDamage) : this(name)
        {
            SetDamageParams(minDamage, maxDamage);
        }

        public void SetDamageParams(int minDamage, int maxDamage)
        {
            if (minDamage > maxDamage)
            {
                Console.WriteLine($"[Warning] Некорректные входные данные для оружия '{Name}': minDamage > maxDamage. Меняю местами.");
                int tmp = minDamage;
                minDamage = maxDamage;
                maxDamage = tmp;
            }

            if (minDamage < 1)
            {
                Console.WriteLine($"[Info] Для оружия '{Name}' минимальный урон меньше 1. Форсированная установка MinDamage = 1.");
                minDamage = 1;
            }

            if (maxDamage <= 1)
            {
                Console.WriteLine($"[Info] Для оружия '{Name}' максимальный урон <= 1. Устанавливаю MaxDamage = 10.");
                maxDamage = 10;
            }

            MinDamage = minDamage;
            MaxDamage = maxDamage;
        }

        public int GetDamage()
        {
            return (MinDamage + MaxDamage) / 2;
        }
    }
}
