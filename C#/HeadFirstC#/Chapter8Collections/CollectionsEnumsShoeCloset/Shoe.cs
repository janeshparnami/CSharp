using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsEnumsShoeCloset
{
    enum TypeShoe
    {
        Sneakers,
        FlipFlop,
        Mountain,
        Boots,
        Party,
    }

    internal class Shoe : IComparable<Shoe>
    {
        private int size;
        public int Size
        {
            get { return size; }
            set { size = value; }
        }

        private string color;
        public string Color
        { get { return color; } set { color = value; } }

        public string Description
        {
            get
            { return $"A {Color} of {typeShoe}"; }
        }

        public TypeShoe typeShoe;

        public Shoe(TypeShoe typeShoe, int size, string color) 
        {
            this.typeShoe = typeShoe;
            this.Size = size;
            this.Color = color;
        }

        public Shoe()
        {
        }

        public int CompareTo(Shoe? other)
        {
            //if(this.size > other.size)
            //    return 1;
            //else if (this.size < other.size) return -1;
            //else return 0;

            //if((int)this.typeShoe > (int)other.typeShoe)
            //    return 1;
            //else if ((int)this.typeShoe < (int)other.typeShoe)
            //    return -1;
            //else
            //{ return 0; }

            return this.Color.CompareTo(other.Color);
        }
    }
}
