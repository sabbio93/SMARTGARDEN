using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SmartGarden.View;

namespace SmartGarden2._0.View
{
    public partial class NuovoGiardinoView : MainView
    {
        public NuovoGiardinoView()
        {
            InitializeComponent();
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            Controller.CaricaProvinceComboBox(_provinceComboBox);
        }
    }
}
