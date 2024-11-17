using ConsoleRpgEntities.Models.Abilities.PlayerAbilities;
using ConsoleRpgEntities.Models.Attributes;
using ConsoleRpgEntities.Models.Characters.Monsters;

namespace ConsoleRpgEntities.Models.Characters
{
    public class Player : ITargetable, IPlayer
    {
        public int Experience { get; set; }

        public int Id { get; set; }
        public string Name { get; set; }
        public int Health { get; set; }
        public virtual ICollection<Ability> Abilities { get; set; }
        public virtual Equipments? Equipments {get;set;}

        public void Attack(ITargetable target)
        {
            
            Console.WriteLine($"{Name} attacks {target.Name} with a {Equipments.Weapon.Name} and inflicts {Equipments.Weapon.Attack} damage!");

            if (this is Player && target is Goblin goblin)
            {
                goblin.Health -= Equipments.Weapon.Attack;

            }   
        }

        public void UseAbility(IAbility ability, ITargetable target)
        {
            if (Abilities.Contains(ability))
            {
                ability.Activate(this, target);
            }
            else
            {
                Console.WriteLine($"{Name} does not have the ability {ability.Name}!");
            }
        }
    }
}