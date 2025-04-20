using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SupplyHelper
{
    public partial class InitConnectForm: Form
    {
        public InitConnectForm()
        {
            InitializeComponent();
            


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private async void checkConnectionButton_Click(object sender, EventArgs e)
        {
            var url = urlTextBox.Text;
            var login = loginTextBox.Text;
            var password = passwordTextBox.Text;

            var res = await HttpRequester.CheckConnection(url);

            if (res == System.Net.HttpStatusCode.OK)
            {
                MessageBox.Show("Успешно");
            }
            else 
            {
                MessageBox.Show("Ошибка");
            }
        }
    }
}
