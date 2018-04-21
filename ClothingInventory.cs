using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//Almicke "Mickey" Navarro 
//CST117 
//Date: April 20, 2018 
//This is my own work. 

namespace Milestone2_REDO
{
    public partial class Form1 : Form
    {
        List<ClothingItem> myClothes = new List<ClothingItem>();

        public Form1()
        {
            InitializeComponent();
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            try
            {
                //create clothing item  
                ClothingItem clothes = new ClothingItem();
                //get text from name box and update 
                clothes.Category = comboBox_category.Text;
                clothes.Type = comboBox_type.Text;
                clothes.Material = textBox_material.Text;
                clothes.Color = textBox_color.Text;
                clothes.Quantity = int.Parse(textBox_quantity.Text);
                clothes.Comments = textBox_comment.Text;
                clothes.MarkedAs = comboBox_mark.Text;
                //add clothes to list
                myClothes.Add(clothes);
                MessageBox.Show("Added: " + clothes.Quantity + " " + clothes.Color + " " + clothes.Type + " " + clothes.Category + " to the inventory");
                this.listBox_myClothes.DataSource = myClothes.ToArray();
                this.listBox_myClothes.Refresh();
            }
            catch
            {
                MessageBox.Show("ERROR! Must complete all fields or must insert a digit number for quantity!");
            }
        }
    }
}

