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
    public partial class frmBuffetOptions : Form
    {
        public frmBuffetOptions()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }


        private void optBackgroundRed_CheckedChanged(object sender, EventArgs e)
        {
            BackColor = Color.LightSalmon;
        }

        private void optBackgroundGrey_CheckedChanged(object sender, EventArgs e)
        {
            BackColor = Color.LightGray;
        }

        private void optBackgroundBlue_CheckedChanged(object sender, EventArgs e)
        {
            BackColor = Color.LightBlue;
        }

        private void optBackgroundYellow_CheckedChanged(object sender, EventArgs e)
        {
            BackColor = Color.LightGoldenrodYellow;
        }

        private void cboBorderColors_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cboBorderColors.Text)
            {
                case "Cyan":
                    MessageBox.Show("Cyan was chosen");
                    Graphics objGraphicsCyan = null;
                    objGraphicsCyan = CreateGraphics();
                    objGraphicsCyan.Clear(SystemColors.Control);
                    objGraphicsCyan.DrawRectangle(Pens.Blue, 1, 1, 281, 263);
                    objGraphicsCyan.Dispose();
                    break;

                case "Red":
                    MessageBox.Show("Red was chosen");
                    Graphics objGraphicsRed = null;
                    objGraphicsRed = CreateGraphics();
                    objGraphicsRed.Clear(SystemColors.Control);
                    objGraphicsRed.DrawRectangle(Pens.Red, 1, 1, 281, 263);
                    objGraphicsRed.Dispose();
                    break;

                case "Green":
                    MessageBox.Show("Green was chosen");
                    Graphics objGraphicsGreen = null;
                    objGraphicsGreen = CreateGraphics();
                    objGraphicsGreen.Clear(SystemColors.Control);
                    objGraphicsGreen.DrawRectangle(Pens.Green, 1, 1, 281, 263);
                    objGraphicsGreen.Dispose();
                    break;

                case "Yellow":
                    MessageBox.Show("Yellow was chosen");
                    Graphics objGraphicsYellow = null;
                    objGraphicsYellow = CreateGraphics();
                    objGraphicsYellow.Clear(SystemColors.Control);
                    objGraphicsYellow.DrawRectangle(Pens.Yellow, 1, 1, 281, 263);
                    objGraphicsYellow.Dispose();
                    break;

                case "Orange":
                    MessageBox.Show("Orange was chosen");
                    Graphics objGraphicsOrange = null;
                    objGraphicsOrange = CreateGraphics();
                    objGraphicsOrange.Clear(SystemColors.Control);
                    objGraphicsOrange.DrawRectangle(Pens.Orange, 1, 1, 281, 263);
                    objGraphicsOrange.Dispose();
                    break;



                default:
                    MessageBox.Show("Back to the Default");
                    Graphics objGraphicsDefault = null;
                    objGraphicsDefault = CreateGraphics();
                    objGraphicsDefault.Clear(SystemColors.Control);
                    objGraphicsDefault.DrawRectangle(Pens.Blue, 1, 1, 281, 263);
                    objGraphicsDefault.Dispose();
                    break;
            }
        }

        private void frmBuffetOptions_Load(object sender, EventArgs e)
        {

        }

        private void lblPassword_Click(object sender, EventArgs e)
        {

        }
    }
}
