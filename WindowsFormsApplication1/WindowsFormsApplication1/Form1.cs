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

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
       private readonly string @namespace = "WindowsFormsApplication1.Fornitori";
       private readonly Type interfaccia = typeof(Interface1);
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var q = from t in Assembly.GetExecutingAssembly().GetTypes()
                    where t.IsClass && t.Namespace == @namespace
                    select t;
          
           checkedListBox1.Items.AddRange(q.ToArray());

        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            textBox1.Text = openFileDialog1.FileName;

            var q = from type in Assembly.LoadFile(@openFileDialog1.FileName).GetExportedTypes()
                    where type.IsClass && type.GetInterface(interfaccia.Name) != null &&
                                                                            //  these controls are not necessary if the interface in the
                                                                            //dll is the same of that this program : secuirty check
                    isCorrectInterface(type)
                    select type;



            Type tipo = typeof(Interface1);
            // potrebbe essere meglio creare una classe che faccia il confronto

           

            // methodClasse.GetParameters
            bool bol = typeof(Interface1).IsAssignableFrom(q.ToArray()[0]);
            bool bol1 = q.ToArray()[0] is Interface1;
            MessageBox.Show(bol + " "+bol1);


            checkedListBox1.Items.AddRange(q.ToArray());
        }

        private bool isCorrectInterface(Type tipo)
        {   
            //controllo se ci sono gli stessi metodi
            //controllo se ritornano la stessa cosa
            //controllo se prendono gli stessi parametri
            var l = from methodClasse in tipo.GetMethods()
                    from methodInterfaccia in interfaccia.GetMethods()
                    where methodClasse.Name == methodInterfaccia.Name &&
                    methodClasse.ReturnType == methodClasse.ReturnType
                    select methodClasse;
            return false;
        }

        private void fine_Click(object sender, EventArgs e)
        {
            List<Type> selected = checkedListBox1.CheckedItems.;
            FactoryGetstoreInformazioni.getGestore(checkedListBox1.CheckedItems);
        }
    }
}
