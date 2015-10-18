﻿
using SmartGarden.Control;
using System;
using System.Windows.Forms;
using System.Xml.XPath;

namespace SmartGarden
{
    public partial class MainWindow : Form
    {
        private Controller _controller;

        public MainWindow()
        {
            InitializeComponent();
            _provinceComboBox.SelectedIndexChanged += CambiaProvincia;
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            GestioneGiardino gestoreGiardino = new GestioneGiardino();
            _controller = new Controller(gestoreGiardino);

            bool loginOk = _controller.CreateLoginForm();
            if (!loginOk)
                this.Close();
            
            _pannelloDestra.GestoreGiardino = gestoreGiardino; //set del model
            _pannelloDestra.Controller = _controller; //set del controller
            _treeView.GestoreGiardino = gestoreGiardino;
            _treeView.Controller = _controller;

            _dateStatusBar.Text = DateTime.Now.ToShortDateString();

            _controller.SettaTimer();

            _controller.CaricaTreeView();

            _controller.CaricaInfoGiardino();

            CaricaProvince();

        }

        private void toolStripMenuItem11_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        
        private void CaricaProvince()
        {
            XPathDocument doc = new XPathDocument("ProvinceItaliane.xml");
            XPathNavigator nav = doc.CreateNavigator();

            XPathExpression expr = nav.Compile("./italia/provincia");
            XPathNodeIterator iterator = nav.Select(expr);


            while (iterator.MoveNext())
            {
                _provinceComboBox.ComboBox.Items.Add(iterator.Current.Value);
            }
        }


        private void CambiaProvincia(object sender, EventArgs e)
        {
            _controller.CambiaProvincia(_provinceComboBox.SelectedItem.ToString());
        }

        private void _resetToolStrip_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Sei sicuro di voler procedere?", "Avviso", MessageBoxButtons.YesNo);

            if(result == DialogResult.Yes)
            {
                //*TO DO* cancella giardino
            }
        }
    }
}
