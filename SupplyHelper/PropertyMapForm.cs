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
    public partial class PropertyMapForm : Form
    {
        public PropertyMapForm(Dictionary<string, string> semPropValues)
        {
            InitializeComponent();
            semPropGrid.DataSource = semPropGrid;
            //foreach (var item in semPropValues)
            //{
            //    semPropGrid.Rows.Add(item.Key, item.Value)
            //}
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
