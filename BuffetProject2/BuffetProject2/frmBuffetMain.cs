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
    public partial class frmBuffetMain : Form
    {
        public frmBuffetMain()
        {
            InitializeComponent();
        }
        const bool defPromptOnExit = true;
        bool blnPromptOnExit = defPromptOnExit;

        //declare boolean for border drawn box checked
        const bool defBorderDrawn = true;
        //set blnBorderDrawn to previous declared bool
        bool blnBorderDrawn = defBorderDrawn;
        private Point? _Previous = null;
        //initialize pen color to black
        private String pen_color = "Black";
        private Pen _Pen = new Pen(Color.FromName("Black"));
    

        //Declare image width and height for later use in aspect ratio calculation
        private int image_width;
        private int image_height;
        private string aspect_ratio;
        private double ratio_percentage_new_image;
        private int new_image_width;
        

        private void btnQuitApplication_Click(object sender, EventArgs e)
        {
            //If box is checked, display a dialog with Yes/No buttons that asks "Close
            //the Buffet Program?,
            //uses the "?" icon, and has the caption "Confirm Exit"
            //If the user selects "Yes", then close it
            if (blnPromptOnExit)
            {

                //Modified if statement given in class. The e.close wouldnt work so I changed
                //the if statement to close on 'Yes'
                if (MessageBox.Show("Close the Buffet Program?",
                "Confirm Exit", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    //Exit entire application
                    Close();
                }
                
            }

            
            
        }


        private void btnSelectPicture_Click(object sender, EventArgs e)
        {
            //Show the open file dialog box
            if (ofdSelectPicture.ShowDialog() == DialogResult.OK)
            {

                //Get newly imported image height and width
                image_width = Image.FromFile(ofdSelectPicture.FileName).Width;
                image_height = Image.FromFile(ofdSelectPicture.FileName).Height;
                //
                if (image_height < image_width)
                {
                    //set a ratio for resizing
                    ratio_percentage_new_image = ((double)image_width / (double)image_height);
                    //set an aspect ratio so we can do some resizing math later
                    aspect_ratio = "landscape";
                }
                else
                {
                    //set ratio for resizing
                    ratio_percentage_new_image = ((double)image_width / (double)image_height);
                    //record aspcet ratio for later use
                    aspect_ratio = "portrait";
                }
                //Make sure the aspect ratio isn't null
                if (aspect_ratio != null)
                {
                    //First store what the image width will be after it has been resized to fit
                    //inside of out open window (this method keeps the height of the window consistent)
                    new_image_width = System.Convert.ToInt16(picShowPicture.Height * ratio_percentage_new_image);
                    //Check what aspect ratio the image is
                    if (aspect_ratio == "landscape")
                    {
                        //Widen the form to fit the wide image
                        frmBuffetMain.ActiveForm.Width = frmBuffetMain.ActiveForm.Width + (new_image_width - picShowPicture.Height);
                    }
                    else if(aspect_ratio == "portrait")
                    {
                        //Shrink the width of the form to fit the new aspect ratio
                        frmBuffetMain.ActiveForm.Width = frmBuffetMain.ActiveForm.Width - (picShowPicture.Height - new_image_width);
                    }
                    //Adjust picShowPicture window to fit the image. The image itself is stretched.
                    picShowPicture.Size = new Size(new_image_width , picShowPicture.Height);
                    
                }
                // Load the picture into the picture box
                picShowPicture.Image = Image.FromFile(ofdSelectPicture.FileName);
                // Show the name of the file in the form’s caption
                Text = string.Concat("A290 Buffet(" + ofdSelectPicture.FileName + ")");
            }
        }

        private void btnEnlargeWindow_Click(object sender, EventArgs e)
        {
            //Button enlarges picture by incriments of 20 on height and width.
            Width = Width + 20;
            Height = Height + 20;
        }

        private void btnShrinkWindow_Click(object sender, EventArgs e)
        {
            //Button shrinks picture by incriments of 20 on height and width.
            Width = Width - 20;
            Height = Height - 20;
        }

        private void btnDrawBorder_Click(object sender, EventArgs e)
        {
            // On Click, Draw a border around the picture box.   
            Graphics objDrawBorder = null;
            objDrawBorder = CreateGraphics();


            objDrawBorder.Clear(SystemColors.Control);

            objDrawBorder.DrawRectangle(Pens.Blue,
                picShowPicture.Left - 1, picShowPicture.Top - 1,
                    picShowPicture.Width + 1, picShowPicture.Height + 1);

            objDrawBorder.Dispose();
        }

        private void picShowPicture_MouseMove(object sender, MouseEventArgs e)
        {
            lblXPosn.Text = "X: " + e.X.ToString();
            lblYPosn.Text = "Y: " + e.Y.ToString();
            //check for a previous position for drawing feature
            if (_Previous != null)
            {
                if (picShowPicture.Image == null)
                {
                    //Fill in the image if the background has no image
                    Bitmap bmap = new Bitmap(picShowPicture.Width, picShowPicture.Height);
                    using (Graphics g = Graphics.FromImage(bmap))
                    {
                        g.Clear(Color.White);
                    }
                    picShowPicture.Image = bmap;
                }
                //draw on picture at mouse point
                using (Graphics g = Graphics.FromImage(picShowPicture.Image))
                {
                    g.DrawLine(_Pen, _Previous.Value.X, _Previous.Value.Y, e.X, e.Y);
                }
                picShowPicture.Invalidate();
                _Previous = new Point(e.X, e.Y);
            }
        }


        private void picShowPicture_MouseLeave(object sender, EventArgs e)
        {          
            // On Mouse Leave of Picture Box, Reset the values for the X and Y cordinates.
            lblXPosn.Text = "";
            lblYPosn.Text = "";
        }

        private void frmBuffetMain_Load(object sender, EventArgs e)
        {
            chkPromptExit.Checked = blnPromptOnExit;
            //On load, set X and Y cordinates to blank.
            lblXPosn.Text = "";
            lblYPosn.Text = "";
        }

        private void btnOptions_Click(object sender, EventArgs e)
        {
            //create new instance of Options Form
            frmBuffetOptions frmBuffetOptionsDialog = new frmBuffetOptions();
            frmBuffetOptionsDialog.Show();
        }

        private void btnCollection_Click(object sender, EventArgs e)
        {
            //create new instance of Collection Form
            frmBuffetCollection frmBuffetCollectionDialog = new frmBuffetCollection();
            frmBuffetCollectionDialog.Show();

        }

        private void chkPromptExit_CheckedChanged(object sender, EventArgs e)
        {
            //When state of check changes, change boolean
            blnPromptOnExit = (chkPromptExit.Checked);
        }
        private void chkDrawBorder_CheckedChanged(object sender, EventArgs e)
        {
            //When state of check changes, change boolean
            blnBorderDrawn = (chkDrawBorder.Checked);
        }


        private void picShowPicture_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void picShowPicture_MouseDown(object sender, MouseEventArgs e)
        {

            //set _previous variable to current point
            //call _MouseMove on this location with current event
            _Previous = new Point(e.X, e.Y);
            picShowPicture_MouseMove(sender, e);
        }

        private void picShowPicture_MouseUp(object sender, MouseEventArgs e)
        {

            //if the mouse_up event triggers, return null to end mouse_down event
            _Previous = null;
        }

        private void lblPenColor_Click(object sender, EventArgs e)
        {

        }

        private void cboPenColor_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cboPenColor.Text)
            {
                case "Red":
                    _Pen.Color = Color.FromName("Red");
                    break;

                case "Green":
                    _Pen.Color = Color.FromName("Green");
                    break;

                case "Blue":
                    _Pen.Color = Color.FromName("Blue");
                    break;

                default:
                    _Pen.Color = Color.FromName("Black");
                    break;
            }
        }

        private void picShowPicture_SizeChanged(object sender, EventArgs e)
        {
            
            
            //If the blnBorderDrawn has been changed and the window is resized
            if (blnBorderDrawn)
            {
                //Redraw the border to fit the window size.
                Graphics objDrawBorder = null;
                objDrawBorder = CreateGraphics();


                objDrawBorder.Clear(SystemColors.Control);

                objDrawBorder.DrawRectangle(Pens.Blue,
                    picShowPicture.Left - 1, picShowPicture.Top - 1,
                        picShowPicture.Width + 1, picShowPicture.Height + 1);

                objDrawBorder.Dispose();


            }
        }

        
    }
}
