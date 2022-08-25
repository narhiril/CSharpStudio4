using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studio4
{
    internal class Menu
    {

        public readonly DateTime DateCreated;
        public DateTime LastModified { get; private set; }
        public List<MenuItem> MenuItems { get; private set; }

        public enum Categories
        {
            Appetizer,
            Side,
            Breakfast,
            Lunch, 
            Dinner, 
            Dessert,
            Drink,
            Kids,
            Special
        }

        public Menu()
        {
            MenuItems = new List<MenuItem>();
            DateCreated = DateTime.Now;
            LastModified = DateCreated;
        }
        public void AddMenuItem(MenuItem item)
        {
            MenuItems.Add(item);
            this.LastModified = DateTime.Now;
        }

        public void AddMenuItem(IEnumerable<MenuItem> items)
        {
            var list = items.ToList();
            foreach(MenuItem item in list)
            {
                MenuItems.Add(item);
            }
            this.LastModified = DateTime.Now;
        }

        public void RemoveMenuItem(MenuItem item)
        {
            if (MenuItems.Contains(item))
            {
                MenuItems.Remove(item);
                this.LastModified = DateTime.Now;
            }
        }

        public void RemoveMenuItem(string itemName)
        {
            bool found = false;
            foreach(MenuItem item in MenuItems)
            {
                if (item.Name == itemName)
                {
                    this.RemoveMenuItem(item);
                    found = true;
                }
            }
            if (found)
            {
                this.LastModified = DateTime.Now;
            }
        }
    }
}
