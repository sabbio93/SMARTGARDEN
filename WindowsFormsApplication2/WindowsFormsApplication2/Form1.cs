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
using MasterInterface;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void fileSystemWatcher1_Changed(object sender, System.IO.FileSystemEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {/*
            openFileDialog1.ShowDialog();
            String filename = openFileDialog1.FileName;
            MessageBox.Show(filename);
            var q = from type in Assembly.LoadFile(@filename).GetExportedTypes()
                    where type.IsClass && type.GetInterface("BossInterface") != null
                    select type;

            foreach(Type t in q)
            {
                MessageBox.Show(t.Name);
            }
            MessageBox.Show(q.ToArray().Length+"");
            MessageBox.Show(q.ToArray()[0].Name);
            Type ty = q.ToArray()[0];

            BossInterface inter =(BossInterface) Activator.CreateInstance(q.ToArray()[0]);
            MessageBox.Show(inter.ToString());
            MessageBox.Show("aslu" + inter.saluta());
            //q.ToArray()[0].
            //MessageBox.Show(inter.saluta());
            //textBox1.Text = inter.saluta();
            */
            Random ran = new Random();
            List<int> list = new List<int>();
            for(int i=0;i<100;i++)
            {
                list.Add(ran.Next(30)+1);
            }

            list.Sort();
            for (int i = 0; i < 100; i++)
            {
                textBox1.Text = textBox1.Text + list[i]+" ";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(Guid.NewGuid().ToString());
            //Random ran = new Random();
            //DateTime date = new DateTime(0);
            //date=date.AddMilliseconds(1000*5);
            //MessageBox.Show(date.ToLongTimeString());
            DateTime data = DateTime.Now;
            TimeSpan ts = new TimeSpan(1,11, 0, 0);
            data = data.Date + ts;
            MessageBox.Show(data.ToShortDateString()+" "+data.ToShortTimeString());
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
