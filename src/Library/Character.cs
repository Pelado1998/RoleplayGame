using System;
using System.Collections.Generic;

namespace Program
{
    public class Character
    {
        private String Name {get;}
        private TypeCharacter Type {get;}
        private int Life {get;set;}
        private List<Item> Inventory {get;}   
        public Character(String name,String type, List<Item> inventory)
        {
            this.Name = name;
            this.Type = new TypeCharacter(type);
            this.Life = Type.MaxLife;
            bool condition = true;
            
            foreach (Item item in inventory)
            {
                condition &= (item.Type == this.Type);
            }
            if (condition)
            {
                this.Inventory = inventory;
            }
            else
            {
                this.Inventory = new List<Item>{}; 
            }
            
        }
        public Character(String name,String type)
        {
            this.Name = name;
            this.Type = new TypeCharacter(type);
            this.Life = Type.MaxLife;
            this.Inventory = new List<Item>{};
        }
        
        public void Heal ()
        {
            this.Life = this.Type.MaxLife;
        }
        public void RecieveAttack(int attack)
        {
            if (this.Life <= attack)
            {
                this.Life =0;
            }
            else
            {
                this.Life = this.Life - attack;
            }
        }
        public int AttackCalculator()
        {
            int res=this.Type.Attack;
            foreach (Item item in this.Inventory)
            {
                res+=(item.Attack+item.Magic)*item.Force;
            }
            return res;
        }
        public int DefenceCalculator()
        {
            int res=this.Type.Defense;
            foreach (Item item in this.Inventory)
            {
                res+=item.Defense+item.Resistence;
            }
            return res;
        }
        public void AddItem(Item item)
        {
            this.Inventory.Add(item);
        }
        public void RemoveItem(Item item)
        {
            this.Inventory.Remove(item);
        }

    }
}