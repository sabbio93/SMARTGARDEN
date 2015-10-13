using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartGarden2._0.View
{
    public partial class PannelloSinistra : View
    {
        public PannelloSinistra()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            _treeView.AfterSelect += ChangeSettore;
        }

        private void ChangeSettore(object sender, TreeViewEventArgs e)
        {
            if(e.Node.Level <= 1)
                Controller.CambiaViewSettore(_treeView.SelectedNode.Text);
        }

        protected override void OnModelChanged(object sender, EventArgs e)
        {
            Giardino giardino = GestoreGiardino.Giardino;
            int index = 0;

            _treeView.BeginUpdate();
            _treeView.Nodes.Add("Giardino: " + giardino.Luogo);
            _treeView.EndUpdate();

            foreach(Settore settore in giardino.Settori.ListaSettori)
            {
                _treeView.Nodes[0].Nodes.Add("Settore: " + settore.Nome);
                _treeView.Nodes[0].Nodes[index].Nodes.Add("Fabbisogno totale giornaliero: " + settore.Piante.GetFabbisognoTotale() + " mm");
                _treeView.Nodes[0].Nodes[index].Nodes.Add("Numero piante: " + settore.Piante.ListaPiante.Count);
                
                index++;
            }

            _treeView.ExpandAll();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        
    }
}
