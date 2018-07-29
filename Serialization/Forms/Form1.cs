using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;
namespace Serialization
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //var type = Type.GetType("Worm.Game.Store");
            //richTextBox1.Text += type + "\n";
            //var types = Assembly.GetEntryAssembly().GetTypes();//.Where(x => x.Namespace == textBox1.Text);
            //foreach (var item in types)
            //{
            //    richTextBox1.Text += item + "\n";
            //}
            richTextBox1.Text = string.Empty;

            Type type = Type.GetType(classNameTxt.Text);
            if(type == null)
            {
                MessageBox.Show(string.Format("Класс {0} не найден.", classNameTxt.Text));
                //return;
            }
            //Game.Store.StoreData
            Assembly assembly = Assembly.GetAssembly(typeof(Game.Store.StoreData));
            
           var types = assembly.GetTypes();
            foreach (var item in types)
            {
                richTextBox1.Text += item + "\n";
            }


            richTextBox1.Text += "Сборки:" + "\n";
            foreach (var item in Assembly.GetExecutingAssembly().GetReferencedAssemblies())
            {
                richTextBox1.Text += item + "\n";
            }



        }
    }
}
