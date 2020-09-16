using System;

namespace Program
{
    public class TypeCharacter
    {
        public int Attack { get; set; }
        public int Defense { get; set; }
        public int Magia { get; set; }
        public int MaxLife { get; set; }

        public TypeCharacter(String type)
        {
            type = type.ToLower();
            switch (type.ToLower())
            {
                case "mago":
                    {
                        this.Attack = 0;
                        this.Defense = 5;
                        this.Magia = 15;
                        this.MaxLife = 100;
                        break;
                    }
                case "enano":
                    {
                        this.Attack = 10;
                        this.Defense = 10;
                        this.Magia = 0;
                        this.MaxLife = 150;
                        break;
                    }
                case "elfo":
                    {
                        this.Attack = 5;
                        this.Defense = 5;
                        this.Magia = 5;
                        this.MaxLife = 120;
                        break;
                    }
                default:
                    {
                        break;
                    }

            }
        }
    }
}