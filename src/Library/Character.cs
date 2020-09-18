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
        private Inventory Inventory { get; }
        
        public Character(String name, String type, List<Item> inventory,Body body)
        {
            this.Name = name;
            this.Type = new TypeCharacter(type);
            this.Life = Type.MaxLife;
            this.Body = body;
        }
        public Character(String name, String type, List<Item> inventory,List<Item> bodyList)
        {
            this.Name = name;
            this.Type = new TypeCharacter(type);
            this.Life = Type.MaxLife;
            this.Body = new Body(bodyList);
        }
        public Character(String name, String type, List<Item> inventory)
        {
            this.Name = name;
            this.Type = new TypeCharacter(type);
            this.Life = Type.MaxLife;
            this.Inventory = new Inventory(inventory);
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
            foreach (Item item in this.Body.EquippedItems())
            {
                res += (item.Attack + item.Magic) * item.Force;
            }
            return res;
        }

        public int DefenceCalculator()
        // Calcula la defensa del personaje segun los atributos e items del mismo
        {
            int res = this.Type.Defense;
            List<Item> inventory = this.Body.EquippedItems();
            foreach (Item item in inventory)
            {
                res += item.Defense + item.Resistence;
            }
            return res;
        }
        public void EquipItem(Item item)
        // Equipa al personaje con el item pasado por parametro, de existir un item se cambia el viejo por el nuevo
        {
            if(this.Inventory.Contains(item))
            {
                switch (item.Type.ToLower())
                {
                    case ("head"):
                        if (item.CharacterType == this.Type)
                        {
                            if(this.Body.Head!=null)
                            {
                                this.AddItem(this.Body.Head);
                                this.Body.Head = item;
                            }
                            else
                            {
                                this.Body.Head = item;   
                            }    
                        }
                        break;
                    case ("chest"):
                        if (item.CharacterType == this.Type)
                        {
                            if(this.Body.Chest!=null)
                            {
                                this.AddItem(this.Body.Chest);
                                this.Body.Chest = item;
                            }
                            else
                            {
                                this.Body.Chest = item;   
                            } 
                        }
                        break;
                    case ("primaryweapon"):
                        if (item.CharacterType == this.Type)
                        {
                            if(this.Body.PrimaryWeapon!=null)
                            {
                                this.AddItem(this.Body.PrimaryWeapon);
                                this.Body.PrimaryWeapon = item;
                            }
                            else
                            {
                                this.Body.PrimaryWeapon = item;   
                            } 
                        }
                        break;
                    case ("secondaryweapon"):
                        if (item.CharacterType == this.Type)
                        {
                            if(this.Body.SecondaryWeapon!=null)
                            {
                                this.AddItem(this.Body.SecondaryWeapon);
                                this.Body.SecondaryWeapon = item;
                            }
                            else
                            {
                                this.Body.SecondaryWeapon = item;   
                            } 
                        }
                        break;
                    case ("legs"):
                        if (item.CharacterType == this.Type)
                        {
                            if(this.Body.Legs!=null)
                            {
                                this.AddItem(this.Body.Legs);
                                this.Body.Legs = item;
                            }
                            else
                            {
                                this.Body.Legs = item;   
                            } 
                        }
                        break;
                    case ("feet"):
                        if (item.CharacterType == this.Type)
                        {
                            if(this.Body.Feet!=null)
                            {
                                this.AddItem(this.Body.Feet);
                                this.Body.Feet = item;
                            }
                            else
                            {
                                this.Body.Feet = item;   
                            } 
                        }
                        break;
                }
                this.RemoveItem(item);
            }

        }

        public void DequipItem(Item item)
        // Quita un item pasado por parametro del personaje
        {
            switch (item.Type.ToLower())
            {
                case ("head"):
                    this.AddItem(this.Body.Head);
                    this.Body.Head = null;
                    break;
                case ("chest"):
                    this.AddItem(this.Body.Chest);
                    this.Body.Chest = null;
                    break;
                case ("primaryweapon"):
                    this.AddItem(this.Body.PrimaryWeapon);
                    this.Body.PrimaryWeapon = null;
                    break;
                case ("secondaryweapon"):
                    this.AddItem(this.Body.SecondaryWeapon);
                    this.Body.SecondaryWeapon = null;
                    break;
                case ("legs"):
                    this.AddItem(this.Body.Legs);
                    this.Body.Legs = null;
                    break;
                case ("feet"):
                    this.AddItem(this.Body.Feet);
                    this.Body.Feet = null;
                    break;
            }
        }
        public void AddItem(Item item)
        {
            this.Inventory.AddItem(item);
        }
        public void RemoveItem(Item item)
        {
            this.Inventory.RemoveItem(item);
        }
    }
}