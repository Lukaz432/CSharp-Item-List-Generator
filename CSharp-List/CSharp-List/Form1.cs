using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharp_List
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public List<Item> itemList = new List<Item>();

        private void CrtListBtn_Click(object sender, EventArgs e)
        {
            if(itemList.Count == 0)
            {
                itemList.Add(new Item("Dragonfire shield", "A heavy shield with a snarling, draconic visage"));
                itemList.Add(new Item("Zulrah's scales", "Flakes of toxic snakeskin."));
                itemList.Add(new Item("Abyssal whip", "A weapon from the abyss."));
                itemList.Add(new Item("Fire cape", "A cape of fire."));
                itemList.Add(new Item("Robin hood hat", "Endorsed by Robin Hood."));
                itemList.Add(new Item("Amulet of fury", "A very powerful onyx amulet."));
                itemList.Add(new Item("Ring of the gods", "An ancient ring said to bring you closer to the Gods."));
                itemList.Add(new Item("Dragon chainbody", "	A series of connected metal rings."));
            }
            else
            {
                //escape r with single \'s caused Unrecognized escape sequence error
                textBox1.AppendText("\\r\\itemList is empty");
            }
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            itemList.Add(new Item("New Item", "A new thing"));
        }

        private void RemBtn_Click(object sender, EventArgs e)
        {
            string searchname = NameBox.Text;
            for(int i = 0; i < itemList.Count; i++)
            {
                itemList.RemoveAt(i);
                textBox1.AppendText(searchname + " removed from itemList \r\n");
                break;
            }
        }

        private void ShowBtn_Click(object sender, EventArgs e)
        {
            string s = "~~~~~~~~~~~~~~~~~~~~~~~~~~Items~~~~~~~~~~~~~~~~~~~~~~~~~~\r\n";
            foreach (Item th in itemList)
            {
                s += String.Format("{0}: {1}\r\n", th.name, th.description);
            }
            textBox1.Text = s;
        }
    }

    public class Item
    {
        public string name;
        public string description;

        public Item(string aName, string aDescription)
        {
            name = aName;
            description = aDescription;
        }
    }
}
