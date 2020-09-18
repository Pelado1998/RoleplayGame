using NUnit.Framework;
using System;
using System.Collections.Generic;
namespace Program
{
    public class ExampleTest
    {

        [Test]
        public void RecieveAttack()
        {
            #region Personaje Rafael
           //Creación de items
            Item head1 = new Item("Casco1", "mago", "head", 15, 15, 2, 20, 5);
            Item chest1 = new Item("Armadura1", "mago", "chest", 15, 15, 2, 20, 5);
            Item primary1 = new Item("Espada1", "mago", "PrimaryWeapon", 15, 15, 2, 20, 5);
            Item secundary1 = new Item("Arco1", "mago", "SecundaryWeapon", 15, 15, 2, 20, 5);
            Item legs1 = new Item("Pantalones1", "mago", "legs", 15, 15, 2, 20, 5);
            Item feet1 = new Item("Botas1", "mago", "feet", 15, 15, 2, 20, 5);

            //Creación de inventario
            Inventory inventario = new Inventory(new List<Item>{head1,chest1,primary1,secundary1,legs1,feet1});
            
            //Creación de personaje
            Character MagoLoco = new Character("Mago Loco 🧙🏻‍♂️","mago",inventario,new Body());
            MagoLoco.EquipItem(head1);
            MagoLoco.EquipItem(chest1);
            MagoLoco.EquipItem(primary1);
            MagoLoco.EquipItem(secundary1);
            MagoLoco.EquipItem(legs1);
            MagoLoco.EquipItem(feet1);
            #endregion
            MagoLoco.RecieveAttack(10);
            Assert.True(MagoLoco.Life==90);
        }
        [Test]
        public void HealTest()
        {
            #region Personaje Rafael
           //Creación de items
            Item head1 = new Item("Casco1", "mago", "head", 15, 15, 2, 20, 5);
            Item chest1 = new Item("Armadura1", "mago", "chest", 15, 15, 2, 20, 5);
            Item primary1 = new Item("Espada1", "mago", "PrimaryWeapon", 15, 15, 2, 20, 5);
            Item secundary1 = new Item("Arco1", "mago", "SecundaryWeapon", 15, 15, 2, 20, 5);
            Item legs1 = new Item("Pantalones1", "mago", "legs", 15, 15, 2, 20, 5);
            Item feet1 = new Item("Botas1", "mago", "feet", 15, 15, 2, 20, 5);

            //Creación de inventario
            Inventory inventario = new Inventory(new List<Item>{head1,chest1,primary1,secundary1,legs1,feet1});
            
            //Creación de personaje
            Character MagoLoco = new Character("Mago Loco 🧙🏻‍♂️","mago",inventario,new Body());
            MagoLoco.EquipItem(head1);
            MagoLoco.EquipItem(chest1);
            MagoLoco.EquipItem(primary1);
            MagoLoco.EquipItem(secundary1);
            MagoLoco.EquipItem(legs1);
            MagoLoco.EquipItem(feet1);
            #endregion
            MagoLoco.RecieveAttack(10);
            MagoLoco.Heal();
            Assert.True(MagoLoco.Life==100);
        }
    }
}