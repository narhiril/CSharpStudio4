using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studio4
{
    internal class MenuItem
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }
        public decimal Price { get; set; }
        public bool IsNew { get; set; }
        public MenuItem(string name, string description, string category, decimal price, bool isNew = true)
        {
            Name = name;
            Description = description;
            Price = price;
            if (Enum.IsDefined(typeof(Menu.Categories), category))
            {
                Category = category;
            }
            else
            {
                throw new ArgumentOutOfRangeException("Invalid category.");
            }
            IsNew = isNew;
        }

        public override string ToString()
        {
            return $"{this.Name} ({this.Category})" + Environment.NewLine +
                   $"{this.Description}" + Environment.NewLine +
                   $"${this.Price}";
        }

        public override bool Equals(object obj)
        {
            if (obj == this)
            {
                return true;
            }
            else if (obj == null || obj.GetType() != this.GetType())
            {
                return false;
            }
            else
            {
                MenuItem other = obj as MenuItem;
                return other.Name == this.Name && other.Category == this.Category;
            }
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int hash = 6563 * Name.GetHashCode();
                hash = hash * 29 * Category.GetHashCode();
                return hash;
            }
        }
    }
}
