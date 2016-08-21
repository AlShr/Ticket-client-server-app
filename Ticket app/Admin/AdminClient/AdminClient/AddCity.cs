using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdminClient
{
    public partial class AddCity : Form
    {
        public AddCity()
        {
            InitializeComponent();
        }

        private void btOk_Click(object sender, EventArgs e)
        {

            this.DialogResult = DialogResult.OK;
            this.Close();

        }

        private void tbCity_KeyDown(object sender, KeyEventArgs e)
        {
            //if (e.KeyData == Keys.Enter) btOk_Click(btOk, EventArgs.Empty);
        }
    }
}
