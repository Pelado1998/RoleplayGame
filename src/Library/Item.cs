using System;

namespace Program
{
    public class Item
    {
        public String Name { get; set; }
        public TypeCharacter Type { get; set; }
        public int Attack { get; set; }
        public int Defense { get; set; }
        public String Description { get; set; }
        public int Force { get; set; }
        public int Resistence { get; set;}

        public int Magic { get; set; }

        public Item(String name, String type, int attack, int defense,int force,int resistence,int magic)
        {
            this.Name = name;
            this.Type = new TypeCharacter(type);
            this.Attack = attack;
            this.Defense = defense;
            this.Force=force;
            this.Resistence=resistence;
            this.Magic=Magic;
            this.Description = "Just an ordinary item";
        }
        public Item(String name, String type, int attack, int defense,int force,int resistence,int magic, String description)
        {
            this.Name = name;
            this.Type = new TypeCharacter(type);
            this.Attack = attack;
            this.Defense = defense;
            this.Force=force;
            this.Resistence=resistence;
            this.Magic=Magic;
            this.Description = description;
        }
    }
}
