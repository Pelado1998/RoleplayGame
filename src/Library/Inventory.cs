using System;
using System.Collections.Generic;

namespace Program
{
    // Clase que contendra todos los items equipados del personaje
    public class Inventory
    {
        #region Campo de clase
        List<Item> InventoryItems {get;set;}
        #endregion
        #region Constructor
        public Inventory(List<Item> inventory)
        {
            this.InventoryItems=inventory;
        }
        public Inventory()
        {
            this.InventoryItems= new List<Item>{};
        }
        #endregion
        #region Metodos
        public void AddItem(Item item)
        {
            this.InventoryItems.Add(item);
        }
        public void RemoveItem(Item item)
        {
            this.InventoryItems.Remove(item);
        }
        public bool Contains(Item item)
        {
            bool res = false;
            foreach (Item searchedValue in this.InventoryItems)
            {
                res = (item==searchedValue) || res;
            }
            return res;
        }
        #endregion
    }
  
}