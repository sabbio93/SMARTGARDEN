using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SmartGarden2._0.Control;

namespace SmartGarden2._0.View
{
    public partial class View : UserControl
    {
        private GestioneGiardino _gestoreGiardino;
        private Controller _controller;

        public View()
        {
            InitializeComponent();
        }

        public GestioneGiardino GestoreGiardino
        {
            get { return _gestoreGiardino; }
            set
            {
                if (value != _gestoreGiardino)
                {
                    _gestoreGiardino = value;

                    if (_gestoreGiardino != null)
                    {
                        _gestoreGiardino.Changed += OnModelChanged; //registrazione al model
                        OnModelChanged(_gestoreGiardino, EventArgs.Empty);
                    }
                }
            }
        }

        public Controller Controller
        {
            get { return _controller; }
            set { _controller = value; }
        }

        protected virtual void OnModelChanged(object sender, EventArgs e)
        {
        }
    }
}
