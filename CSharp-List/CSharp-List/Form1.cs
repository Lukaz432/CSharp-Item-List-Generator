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
        //created objects
        public List<Item> itemList = new List<Item>();
        public Dictionary<string, Place> placeDictionary = new Dictionary<string, Place>();

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

        public class Place
        {
            public string description;

            public Place(string aDescription)
            {
                description = aDescription;
            }
        }

        private void CrtListBtn_Click(object sender, EventArgs e)
        {
            if (itemList.Count == 0) {
                //default items
                itemList.Add(new Item("Dragonfire shield", "A heavy shield with a snarling, draconic visage"));
                itemList.Add(new Item("Zulrah's scales", "Flakes of toxic snakeskin."));
                itemList.Add(new Item("Abyssal whip", "A weapon from the abyss."));
                itemList.Add(new Item("Fire cape", "A cape of fire."));
                itemList.Add(new Item("Robin hood hat", "Endorsed by Robin Hood."));
                itemList.Add(new Item("Amulet of fury", "A very powerful onyx amulet."));
                itemList.Add(new Item("Ring of the gods", "An ancient ring said to bring you closer to the Gods."));
                itemList.Add(new Item("Dragon chainbody", "	A series of connected metal rings."));
            }
            else {
                //escape r with single \'s caused Unrecognized escape sequence error
                textBox1.AppendText("\\r\\itemList is empty");
            }
        }

        private void CrtDictBtn_Click(object sender, EventArgs e)
        {
            if (placeDictionary.Count == 0) {
                //default places
                placeDictionary.Add("King Black Dragon Lair", new Place("A lair guarded by the three-headed King Black Dragon"));
                placeDictionary.Add("Grand Exchange", new Place("The biggest player market place in Oldschool Runescape"));
                placeDictionary.Add("Jaleustrophos Pyramid", new Place("An Agility training area located in the Kharidian Desert"));
                placeDictionary.Add("Draynor Village", new Place("Draynor Village is a small village located between Falador and Lumbridge"));
                placeDictionary.Add("Zulrah's Shrine", new Place("Zulrah's monument to the east of Zul-Andra"));
                placeDictionary.Add("Kraken Cove", new Place("Dungeon located south-west of the Piscatoris Fishing Colony"));
                placeDictionary.Add("Canifis", new Place("Canifis is a small town in Morytania"));
                placeDictionary.Add("Edgeville Monastery", new Place("A two-story building north-east of Falador"));
            }
            else {
                //escape r with single \'s caused Unrecognized escape sequence error
                textBox1.AppendText("\\r\\placeDictionary is empty");
            }
        }
        private void AddBtn_Click(object sender, EventArgs e)
        {
            itemList.Add(new Item("New Item", "A new thing"));
            placeDictionary.Add("New Place", new Place("A nice new place"));
        }

        private void RemBtn_Click(object sender, EventArgs e)
        {
            string searchname = NameBox.Text;
            if (placeDictionary.ContainsKey(searchname)) {
                placeDictionary.Remove(searchname);
                textBox1.AppendText(searchname + " removed from placeDictionary.\r\n");
            }
            else {
                textBox1.AppendText(searchname + " not found in placeDictionary.\r\n");
            }
            for (int i = 0; i < itemList.Count; i++) {
                if(itemList[i].name == searchname) {
                    itemList.RemoveAt(i);
                    textBox1.AppendText(searchname + " removed from itemList \r\n");
                    break;
                }
            }
        }

        private void ShowBtn_Click(object sender, EventArgs e)
        {
            string s = "~~~~~~~~~~~~~~~~~~~~~~~~~~~Items~~~~~~~~~~~~~~~~~~~~~~~~~~\r\n";
            foreach (Item th in itemList) {
                s += String.Format("{0}: {1}\r\n", th.name, th.description);
            }
            s += "~~~~~~~~~~~~~~~~~~~~~~~~~~Places~~~~~~~~~~~~~~~~~~~~~~~~~~\r\n";
            foreach(KeyValuePair<string,Place> keyvaluepair in placeDictionary) {
                s += String.Format("{0}: {1}\r\n", keyvaluepair.Key, keyvaluepair.Value.description);
            }
            textBox1.Text = s;
        }

        private void ClrTxtBtn_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }
    }
}