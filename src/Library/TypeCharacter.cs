using System;

namespace Program
{
    public class TypeCharacter
    {
        #region Campos de clase
        public String Name { get; set; }
        public int Attack { get; set; }
        public int Defense { get; set; }
        public int Magia { get; set; }
        public int MaxLife { get; set; }
        #endregion
        #region Constructor
        public TypeCharacter(String type)
        {
            switch (type.ToLower())
            {
                case "mago":
                    {
                        this.Name = type;
                        this.Attack = 1;
                        this.Defense = 5;
                        this.Magia = 15;
                        this.MaxLife = 100;
                        break;
                    }
                case "enano":
                    {
                        this.Name = type;
                        this.Attack = 10;
                        this.Defense = 10;
                        this.Magia = 1;
                        this.MaxLife = 150;
                        break;
                    }
                case "elfo":
                    {
                        this.Name = type;
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
        #endregion
    }
}