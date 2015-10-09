using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security;
using System.DirectoryServices.AccountManagement;

namespace SmartGarden2._0
{
    public partial class LoginForm : Form
    {
        private bool _isValid;

        public LoginForm()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            _username.Text = Environment.UserName;
        }

        private void _loginButton_Click(object sender, EventArgs e)
        {
            string password = _passwordBox.Text;


            using (PrincipalContext pc = new PrincipalContext(ContextType.Machine))
            {
                _isValid = pc.ValidateCredentials(Environment.UserName, password);
            }

            if (_isValid)
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Password non corretta!");
                _passwordBox.Clear();
            }

        }



        private void _resetButton_Click(object sender, EventArgs e)
        {
            _passwordBox.Clear();
        }
    }
}
