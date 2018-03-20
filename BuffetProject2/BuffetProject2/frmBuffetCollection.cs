using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BuffetProject2
{
    public partial class frmBuffetCollection : Form
    {
        public frmBuffetCollection()
        {
            InitializeComponent();
        }

        private void btnOkay_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnControlNames_Click(object sender, EventArgs e)
        {
            //Go through Controls and display a message box 
            for (int intIndex = 0; intIndex < Controls.Count; intIndex++)
            {
                MessageBox.Show("Control #" + intIndex.ToString() + " has the name " + Controls[intIndex].Name);
            }
        }
    }
}
