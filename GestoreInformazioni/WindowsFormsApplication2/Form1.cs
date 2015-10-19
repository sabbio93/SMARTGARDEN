using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            String filename = openFileDialog1.FileName;
            var q = from type in Assembly.LoadFile(@filename).GetExportedTypes()
                    where type.IsClass && type.GetInterface("interfaccia1") != null 
                     select type;
           Interface1 inter =(Interface1) Activator.CreateInstance(q.ToArray()[0]);
            textBox1.Text = inter.saluta();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
