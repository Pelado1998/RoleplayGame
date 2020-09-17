using System;
using System.Collections.Generic;

namespace Program
{
    public class Character
    {
        private String Name { get; }
        private TypeCharacter Type { get; }
        private int Life { get; set; }
        public Body Body { get; }
        private List<Item> Inventory { get; }
        public Character(String name, String type, List<Item> inventory)
        {
            this.Name = name;
            this.Type = new TypeCharacter(type);
            this.Life = Type.MaxLife;
            this.Body = new Body(inventory);
        }
        public Character(String name, String type)
        {
            this.Name = name;
            this.Type = new TypeCharacter(type);
            this.Life = Type.MaxLife;
            this.Body = new Body(new List<Item> { });
        }

        public void Heal()
        // Cura al personaje al 100% de la vida
        {
            this.Life = this.Type.MaxLife;
        }
        public void RecieveAttack(int attack)

        {
            if (this.Life <= attack)
            {
                this.Life = 0;
            }
            else
            {
                this.Life = this.Life - attack;
            }
        }
        public int AttackCalculator()
        // Calcula el ataque del personaje segun los atributos e items del mismo
        {
            int res = this.Type.Attack;
            List<Item> inventory = Body.EquippedItems(this.Body);
            foreach (Item item in inventory)
            {
                res += (item.Attack + item.Magic) * item.Force;
            }
            return res;
        }

        public int DefenceCalculator()
        // Calcula la defensa del personaje segun los atributos e items del mismo
        {
            int res = this.Type.Defense;
            List<Item> inventory = Body.EquippedItems(this.Body);
            foreach (Item item in inventory)
            {
                res += item.Defense + item.Resistence;
            }
            return res;
        }
        public void AddItem(Item item)
        // Equipa al personaje con el item pasado por parametro, de existir un item se cambia el viejo por el nuevo
        {
            switch (item.Type.ToLower())
            {
                case ("head"):
                    if (item.CharacterType == this.Type.Name)
                    {
                        this.Body.Head = item;
                    }
                    break;
                case ("chest"):
                    if (item.CharacterType == this.Type.Name)
                    {
                        this.Body.Chest = item;
                    }
                    break;
                case ("mainweapon"):
                    if (item.CharacterType == this.Type.Name)
                    {
                        this.Body.MainWeapon = item;
                    }
                    break;
                case ("secondaryweapon"):
                    if (item.CharacterType == this.Type.Name)
                    {
                        this.Body.SecondaryWeapon = item;
                    }
                    break;
                case ("legs"):
                    if (item.CharacterType == this.Type.Name)
                    {
                        this.Body.Legs = item;
                    }
                    break;
                case ("feet"):
                    if (item.CharacterType == this.Type.Name)
                    {
                        this.Body.Feet = item;
                    }
                    break;
            }
        }

        public void RemoveItem(Item item)
        // Quita un item pasado por parametro del personaje
        {
            switch (item.Type.ToLower())
            {
                case ("head"):
                    this.Body.Head = null;
                    break;
                case ("chest"):
                    this.Body.Chest = null;
                    break;
                case ("mainweapon"):
                    this.Body.MainWeapon = null;
                    break;
                case ("secondaryweapon"):
                    this.Body.SecondaryWeapon = null;
                    break;
                case ("legs"):
                    this.Body.Legs = null;
                    break;
                case ("feet"):
                    this.Body.Feet = null;
                    break;
            }
        }
    }
}