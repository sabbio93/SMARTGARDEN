﻿using System;
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
    public partial class TreeView : View
    {
        public TreeView()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
        }

        protected override void OnModelChanged(object sender, EventArgs e)
        {
            Giardino giardino = GestoreGiardino.Giardino;

            _treeView.BeginUpdate();
            _treeView.Nodes.Add(giardino.Luogo);
            _treeView.EndUpdate();

            /*foreach(Settore settore in giardino.Settori.ListaSettori)
            {
                _treeView.selected
            }*/
        }
    }
}
