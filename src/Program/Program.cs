using System;
using System.Collections.Generic;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            TypeCharacter mago = new TypeCharacter("mago");
            TypeCharacter elfo = new TypeCharacter("elfo");
            TypeCharacter enano = new TypeCharacter("enano");

            Item item1 = new Item("Espada1",mago,15,15,2,20,5);
            Item item2 = new Item("Arco1",mago,15,15,2,20,5);
            Item item3 = new Item("Gorro1",mago,15,15,2,20,5);
            Item item4 = new Item("Casco1",mago,15,15,2,20,5);

            Item item5 = new Item("Espada2",elfo,15,15,2,20,5);
            Item item6 = new Item("Arco2",elfo,15,15,2,20,5);
            Item item7 = new Item("Gorro2",elfo,15,15,2,20,5);
            Item item8 = new Item("Casco2",elfo,15,15,2,20,5);

            Item item9 = new Item("Espada3",enano,15,15,2,20,5);
            Item item10 = new Item("Arco3",enano,15,15,2,20,5);
            Item item11 = new Item("Gorro3",enano,15,15,2,20,5);
            Item item12 = new Item("Casco3",enano,15,15,2,20,5);

            Character chr1= new Character("Juan","mago");
            Character chr2= new Character("Pedro","mago",new List<Item>{item1,item2,item3,item4});
            Character chr3= new Character("Sebastian","elfo",new List<Item>{item5,item6,item7,item8});
            System.Console.WriteLine(chr2.Life);  
            chr2.RecieveAttack(chr3.AttackCalculator());
            System.Console.WriteLine(chr2.Life);  
        }
    }
}
