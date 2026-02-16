using System;

namespace RPG
{
    class Program
    {
        static void Main(string[] args)
        {
            var unit1 = new Unit();
            var unit2 = new Unit("Hero");

            Console.WriteLine($"Unit1: {unit1.Name}, Health: {unit1.Health}, Armor: {unit1.Armor}, Damage: {unit1.Damage}, RealHealth: {unit1.GetRealHealth()}");
            Console.WriteLine($"Unit2: {unit2.Name}, Health: {unit2.Health}, Armor: {unit2.Armor}, Damage: {unit2.Damage}");

            bool died = unit2.SetDamage(20f);
            Console.WriteLine($"{unit2.Name} получил(а) урон 20 * Armor => Новое здоровье: {unit2.Health}, Умер: {died}");

            var sword = new Weapon("Sword", 3, 8);
            Console.WriteLine($"Weapon: {sword.Name}, Min:{sword.MinDamage}, Max:{sword.MaxDamage}, Durability:{sword.Durability}, AvgDamage:{sword.GetDamage()}");

            var axe = new Weapon("Axe", 12, 6);
            Console.WriteLine($"Weapon Axe after params: Min:{axe.MinDamage}, Max:{axe.MaxDamage}, Avg:{axe.GetDamage()}");

            var stick = new Weapon("Stick", -2, 1);
            Console.WriteLine($"Weapon Stick after params: Min:{stick.MinDamage}, Max:{stick.MaxDamage}, Avg:{stick.GetDamage()}");

            // Экипировка
            var helm = new Helm("Iron Helm", 2.5f);
            var shell = new Shell("Steel Shell", 8.0f);
            var boots = new Boots("Leather Boots", 1.2f);

            Console.WriteLine(helm);
            Console.WriteLine(shell);
            Console.WriteLine(boots);

            Console.WriteLine("Готово.");
        }
    }
}
