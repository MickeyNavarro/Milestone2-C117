using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Almicke "Mickey" Navarro 
//CST117 
//Date: April 20, 2018 
//This is my own work. 

namespace Milestone2_REDO
{
    class ClothingItem
    {
        public string Category { set; get; }
        public string Type { set; get; }
        public string Material { set; get; }
        public string Color { set; get; }
        public int Quantity { set; get; }
        public string Comments { set; get; }
        public string MarkedAs { set; get; }

        //constructor is almost always public 
        public ClothingItem() { }

        public override string ToString()
        {
            return this.Quantity + " " + this.Color + " " + this.Type + " " + this.Category + " (" + this.Comments + ")" + " : " + this.MarkedAs;
        }
    }
}
