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
using System.IO;

namespace SmartGarden
{
    public partial class Form1 : Form
    {
        FactoryGestoreInformazioni fac;
        TypeProviders type;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            fac = FactoryGestoreInformazioni.GetFactory();
            type = new TypeProviders();
            ProviderVisitorInspector insp = ProviderVisitorInspector.Get() ;
            comboBox1.Items.AddRange(insp.GetListProvider().ToArray());
            comboBox2.Items.AddRange(insp.GetListVisitor().ToArray());
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        //se ho già un gestore lo devo caricare
        private void button1_Click(object sender, EventArgs e)
        {
            type.AddTypeProvider((Type)comboBox1.SelectedItem, (Type)comboBox2.SelectedItem);
            textBox1.Text = textBox1.Text + type.GetCoppiaToString((Type)comboBox1.SelectedItem);
            
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
