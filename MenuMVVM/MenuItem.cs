using MaterialDesignThemes.Wpf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuMVVM
{
    public class MenuItem
    {
        public String Name { get; private set; }
        public PackIconKind Icon { get; private set; }
        public ItemCount Count { get; private set; }

        public MenuItem(String name, PackIconKind icon, ItemCount count)
        {
            Name = name;
            Icon = icon;
            Count = count;
        }
    }
}
