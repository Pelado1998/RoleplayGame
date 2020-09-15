using System;

namespace Program
{
    class Item
    {
        private String name;
        private int attack;
        private int defense;
        private String type;
        private String description;
        private int force;
        private int resistence;
        private int magic;

        public String Name { get; set; }
        public String Type { get; set; }
        public int Attack { get; set; }
        public int Defense { get; set; }
        public String Description { get; set; }
        public int Force { get; set; }
        public int Resistence { get; set;}

        public int Magic { get; set; }

        public Item(String name, String type, int attack, int defense,int force,int resistence,int magic)
        {
            this.Name = name;
            this.Type = type;
            this.Attack = attack;
            this.Defense = defense;
            this.Force=force;
            this.Resistence=resistence;
            this.Magic=Magic;
        }
    }
}
