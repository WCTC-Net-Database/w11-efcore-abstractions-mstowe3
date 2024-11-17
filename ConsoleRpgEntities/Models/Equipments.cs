namespace ConsoleRpgEntities.Models
{
    public class Equipments
    {
        public int Id {get;set;}
        public int? WeaponId {get;set;}
        public int? ArmorId {get;set;}

        // Navigation Properties
        public virtual Item? Weapon {get;set;}
        public virtual Item? Armor {get;set;}
    }
}