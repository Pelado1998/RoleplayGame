using System;
using System.Collections.Generic;

namespace Program
{
    // Clase que contendra todos los items equipados del personaje
    public class Body
    {
        public Item Head { get; set; }
        public Item Chest { get; set; }
        public Item PrimaryWeapon { get; set; }
        public Item SecondaryWeapon { get; set; }
        public Item Legs { get; set; }
        public Item Feet { get; set; }

        public Body(){}
        public Body(List<Item> items)
        {
            foreach (Item item in items)
            {
                switch (item.Type.ToLower())
                {
                    case ("head"):
                        this.Head = item;
                        break;
                    case ("chest"):
                        this.Chest = item;
                        break;
                    case ("primaryweapon"):
                        this.PrimaryWeapon = item;
                        break;
                    case ("secondaryweapon"):
                        this.SecondaryWeapon = item;
                        break;
                    case ("legs"):
                        this.Legs = item;
                        break;
                    case ("feet"):
                        this.Feet = item;
                        break;
                }
            }
        }

        public List<Item> EquippedItems()
        // Metodo que busca que items tiene equipado el personaje y los agrega a una lista
        {
            List<Item> equippedItems = new List<Item> { };
            if (this.Head != null)
            {
                equippedItems.Add(this.Head);
            }
            if (this.Chest != null)
            {
                equippedItems.Add(this.Chest);
            }
            if (this.PrimaryWeapon != null)
            {
                equippedItems.Add(this.PrimaryWeapon);
            }
            if (this.SecondaryWeapon != null)
            {
                equippedItems.Add(this.SecondaryWeapon);
            }
            if (this.Legs != null)
            {
                equippedItems.Add(this.Legs);
            }
            if (this.Feet != null)
            {
                equippedItems.Add(this.Feet);
            }
            return equippedItems;
        }
    }
}
