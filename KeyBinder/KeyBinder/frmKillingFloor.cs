using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.Windows.Forms;
namespace KeyBinder
{
    public partial class frmKillingFloor : Form
    {
        List<ComboBox> cbox_list = new List<ComboBox>();
        //Create a Dictionary of assignable keys to assign actions to
        Dictionary<string, string> activeKeys = new Dictionary<string, string>();
        string directoryPath;
        string writing_template = Properties.Resources.KillingFloorTemplate;
        public frmKillingFloor()
        {

            InitializeComponent();
        }

        private void ofdSelectConfigFileKFloor_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void btnSelectFile_Click(object sender, EventArgs e)
        {
            Stream fstream = null;
            string cbox_name;
            string[] split_array;
            List<string> list_keys = new List<string>();
            


            OpenFileDialog ofdSelectConfigFileKFloor = new OpenFileDialog();
            ofdSelectConfigFileKFloor.InitialDirectory = "c:\\";
            ofdSelectConfigFileKFloor.Title = "Please select your User.ini file";
            
            // set an x and y axis to begin generating buttons at runtime
            int x = 18;
            int y = 280;
            if (ofdSelectConfigFileKFloor.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if ((fstream = ofdSelectConfigFileKFloor.OpenFile()) != null)
                    {
                        // Toggle visibility of open and select file
                        btnApplyBindings.Visible = true;
                        btnSelectFile.Visible = false;
                        directoryPath = ofdSelectConfigFileKFloor.FileName;
                        //var assembly = Assembly.GetExecutingAssembly();
                        //Import possible actions for the game from resources folder
                        string possible_actions = Properties.Resources.KillingFloorActions;
                        //Import possible keys from the Resources folder
                        string possible_keys = Properties.Resources.KillingFloorPossibleKeys;
                        //create a list of strings to categorize the button configurations by category for easier editing
                        string[] categories = new string[] { "== Combat ==", "== Basic Controls ==", "== Communication ==", "== Various ==" };




                        // import file in resources that contains all of the possible game settings that can be assigned
                        List<string> actions = possible_actions.Split(new[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries).ToList();
                        List<string> keys = possible_keys.Split(new[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries).ToList();
                        //Iterate through possible keys and add them to a dictionary with a null value
                        foreach (string st in keys)
                        {
                            list_keys.Add(st);
                        }

                        //Iterate through all possible actions and generate buttons for them
                        foreach (string str in actions)
                        {
                            // Check if the current string within the file is one of the categories
                            if (categories.Contains(str))
                            {
                                string cur_category = null;
                                if (str.Equals("== Combat =="))
                                {
                                    cur_category = "Combat";
                                }
                                if (str.Equals("== Basic Controls =="))
                                {
                                    cur_category = "BasicControls";
                                }
                                if (str.Equals("== Communication =="))
                                {
                                    cur_category = "Communication";
                                }
                                if (str.Equals("== Various =="))
                                {
                                    cur_category = "Various";
                                }

                                Label label = new Label();
                                label.Name = "lbl" + cur_category;
                                label.Text = str;
                                label.Location = new Point(x, y);
                                label.AutoSize = true;
                                this.Controls.Add(label);
                                y += 30;

                            }
                            else
                            {
                                // Add a label to the form so the user can see what key they are assigning
                                Label label = new Label();
                                label.Name = "lbl" + str;
                                label.Text = str;
                                label.ForeColor = System.Drawing.Color.White;
                                label.Location = new Point(x, y);
                                label.AutoSize = true;
                                this.Controls.Add(label);
                                // Add a combobox to the form so a user can select a key to apply to each action
                                ComboBox cbox = new ComboBox();
                                cbox.BindingContext = new BindingContext();
                                cbox.DropDownStyle = ComboBoxStyle.DropDownList;
                                cbox.Location = new Point(x + 120, y - 5);
                                cbox.DataSource = list_keys;
                                // A few of the actions in the KillingFloor config file contain spaces, like "Weapon 1", I am splitting them and taking the first string
                                // so I can apply a proper name
                                split_array = str.Split(' ');
                                cbox_name = split_array[0];
                                cbox.Name = "cbx" + cbox_name;
                                cbox_list.Add(cbox);
                                // Passing along the action that the box is assigning as a string in this unused variable for later reference
                                cbox.FormatString = str;
                                this.Controls.Add(cbox);
                                // add 30 to y so the next box or label appears lower
                                y += 30;

                            }
                        }
                    }
                    ofdSelectConfigFileKFloor.Dispose();
                }
                catch (Exception ex)
                {
                    // If the file does not read, throw error
                    MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                }
            }
            // Clean up any files left open
            ofdSelectConfigFileKFloor.Dispose();
            fstream.Dispose();


        }

        private void btnPreview_Click(object sender, EventArgs e)
        {
            
            foreach (ComboBox cbox in cbox_list)
            {
                Console.WriteLine("Cbox name = " + cbox.Name + "Cbox format string = " + cbox.FormatString + " Value= " + cbox.SelectedValue);
            }
        }

        private void btnApplyBindings_Click(object sender, EventArgs e)
        {
            // Open up the template and split it into a List<strings>. We will be using the template to get the text to overwrite the 
            // existing configuration file.
            List<string> template = writing_template.Split(new[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries).ToList();
            try
            {
                foreach (ComboBox cbox in cbox_list)
                {
                    // if unassinged, ignore this combobox as we will not need to change the template.
                    if (!cbox.SelectedValue.Equals("--Unassigned--"))
                    {
                        // check dictionary and see if key has assignment
                        if (activeKeys.ContainsKey(cbox.SelectedValue.ToString()))
                        {
                            // if there is a duplicate, throw an error and ask user to fix it, keep settings. Users are not permitted to assign the same key to 
                            // two actions as this could cause problems in the game
                            MessageBox.Show("The keys assigned contained at least one duplicate. Please correct this. Duplicate keys will cause errors within the game.", "ERROR: Assignment contains duplicate keys", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            // Clear the active keys. The user will have to fix the assignments and click "Apply Bindings" again
                            activeKeys.Clear();
                            break;
                        }
                        else
                        {
                            // If the key is not a duplicate, add it to the activeKeys dictionary. After iteration is conplete
                            // with no errors, we move on to the next action.
                            activeKeys.Add(cbox.SelectedValue.ToString(), cbox.FormatString.ToString());
                        }
                    }
                }
                // Open a stream with the file the user selected in ofSelectConfigFileKillingFloor
                using (StreamWriter sr = new StreamWriter(directoryPath))
                {
                    // run a loop through all of the strings that were generated from the template.
                    // Each string is a line from the template that will be written to the actual config file for the game
                    foreach (string line in template)
                    {
                        // split the string, separating by '='
                        string[] temp = line.Split('=');
                        // Every game has a different way of handling config files. This part of the code will have to be statically changed
                        // whenever I want to add a new game to the file. This program cannot overcome this issue because every game developer
                        // handles key assignments differently
                        if (activeKeys.ContainsKey(temp[0].ToString()))
                        {
                            // The way KillingFloor handles key bindings, the definitions are written as "W=MoveForward"
                            // To modify the file, we split the first element of current line (which is coming from the template), which in the example above woule return "W"
                            // now that we have the letter (the code for this is in the if statement we are currently in) We check it against the dictionary of keys that the 
                            // user assigned. If the user assigned "W", it is in that dictionary, and the Value of the dictionary pair contains the action that the user assinge "W" to.
                            // Now all we have to do is write this to the file.
                            string val = activeKeys[temp[0]];
                            sr.WriteLine(line + val);
                            // Was using this for error checking. Keeping it here as I want to be able to reference it if to check for bugs later.
                            Console.WriteLine("Value has been changed. line = " + line + " Value = " + val);
                        }
                        else
                        {
                            // If the user did not assign the key that is at the begginning of the current line, we do not need to modify the template.
                            // Simply write the current line from the template to the config file. We must still overwrite the config file or we risk a double-assignment of an action.
                            sr.WriteLine(line);
                        }
                    }
                    MessageBox.Show("Configuration file has successfully been modified!", "KeyBinder", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }

                //Clear the active keys to prevent errors if user tries changing the settings again in this same instance
                activeKeys.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: There was a problem with your bindings :  " + ex.Message);
            }
        }
    }
}
