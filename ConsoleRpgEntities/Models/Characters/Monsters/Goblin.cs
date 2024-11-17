using ConsoleRpgEntities.Models.Attributes;

namespace ConsoleRpgEntities.Models.Characters.Monsters
{
    public class Goblin : Monster
    {
        public int Sneakiness { get; set; }

        public override void Attack(ITargetable target)
        {
            // Goblin-specific attack logic
            int damage = Sneakiness * AggressionLevel / 2;
            Console.WriteLine($"{Name} sneaks up and attacks {target.Name} dealing {damage} damage!");
            if (target is Player player)
            {
                int durability = player.Equipments.Armor.Durability;
                damage = damage - durability;
                Console.WriteLine($"Player has {player.Equipments.Armor.Name}, so player loses {damage} health points.");
                player.Health -= damage;
            }
        }
    }
}
