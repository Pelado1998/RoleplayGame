using System;
using System.Collections.Generic;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            // Crear item (String name, String characterType, String type, int attack, int defense, int force, int resistence, int magic)
            // Item.type -> head, chest, mainWeapon, secondaryWeapon, pants, feet
            // Crear personaje (String name, String type, List<Item> inventory) || (String name, String type)
            Item item1 = new Item("Espada1", "mago", "mainWeapon", 15, 15, 2, 20, 5);
            Item item2 = new Item("Arco1", "mago", "mainWeapon", 15, 15, 2, 20, 5);
            Item item3 = new Item("Gorro1", "mago", "head", 15, 15, 2, 20, 5);
            Item item4 = new Item("Casco1", "mago", "head", 15, 15, 2, 20, 5);

            Item item5 = new Item("Espada2", "elfo", "mainWeapon", 15, 15, 2, 20, 5);
            Item item6 = new Item("Arco2", "elfo", "mainWeapon", 15, 15, 2, 20, 5);
            Item item7 = new Item("Gorro2", "elfo", "head", 15, 15, 2, 20, 5);
            Item item8 = new Item("Casco2", "elfo", "head", 15, 15, 2, 20, 5);

            Item item9 = new Item("Espada3", "enano", "mainWeapon", 15, 15, 2, 20, 5);
            Item item10 = new Item("Arco3", "enano", "mainWeapon", 15, 15, 2, 20, 5);
            Item item11 = new Item("Gorro3", "enano", "head", 15, 15, 2, 20, 5);
            Item item12 = new Item("Casco3", "enano", "head", 15, 15, 2, 20, 5);

            Character chr1 = new Character("Juan", "mago");
            Character chr2 = new Character("Pedro", "mago", new List<Item> { item1, item2, item3, item4 });
            Character chr3 = new Character("Sebastian", "elfo", new List<Item> { item5, item6, item7, item8 });
            //System.Console.WriteLine(chr2.Life);  
            //chr2.RecieveAttack(chr3.AttackCalculator());
            //System.Console.WriteLine(chr2.Life);

            // --------------------------> Cristian <--------------------------

            Item staff = new Item("Magic Staff", "mago", "mainWeapon", 10, 5, 20, 5, 20);
            Item hat = new Item("Grey Hat", "mago", "head", 5, 10, 1, 10, 15);
            Item robe = new Item("Grey Robe", "mago", "chest", 5, 13, 1, 10, 17);
            Item sandals = new Item("Ordinary Sandals", "mago", "feet", 1, 1, 1, 1, 1);
            Item magicBook = new Item("Magic Book", "mago", "secondaryWeapon", 10, 1, 20, 1, 30);
            var itemList1 = new List<Item> { staff, hat, robe, sandals, magicBook };

            Character gandalf = new Character("Gandalf", "mago", itemList1);

            Item axe = new Item("Iron Axe", "enano", "mainWeapon", 20, 5, 20, 5, 1);
            Item helm = new Item("Iron Helm", "enano", "head", 5, 15, 5, 15, 1);
            Item chest = new Item("Iron Chest", "enano", "chest", 5, 25, 5, 25, 1);
            Item pants = new Item("Iron Pants", "enano", "chest", 5, 20, 5, 20, 1);
            Item shoes = new Item("Iron Shoes", "enano", "chest", 5, 15, 5, 15, 1);
            var itemList2 = new List<Item> { axe, helm, chest, pants, shoes };

            Character gimli = new Character("Gimli", "enano", itemList2);
            // --------------------------> Cristian <--------------------------
        }
    }
}
