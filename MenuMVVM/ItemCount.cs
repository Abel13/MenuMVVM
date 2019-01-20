using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace MenuMVVM
{
    public class ItemCount
    {
        public Brush Color { get; private set; }
        public int Value { get; private set; }

        public ItemCount(Brush color, int value)
        {
            Color = color;
            Value = value;
        }
    }
}
