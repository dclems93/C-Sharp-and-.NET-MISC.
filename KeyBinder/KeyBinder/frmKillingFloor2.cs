using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KeyBinder
{
    public partial class frmKillingFloor2 : Form
    {
        List<ComboBox> cbox_list = new List<ComboBox>();
        //Create a Dictionary of assignable keys to assign actions to
        Dictionary<string, string> activeKeys = new Dictionary<string, string>();
        string directoryPath;
        string writing_template = Properties.Resources.KillingFloor2Template;
        List<string> keys;
        List<string> maps;
        Dictionary<string, string> possibleKeys = new Dictionary<string, string>();
        public frmKillingFloor2()
        {
            InitializeComponent();
        }

        private void ofdSelectConfigFileKFloor2_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void btnSelectFile_Click(object sender, EventArgs e)
        {
            Stream fstream = null;
            List<string> list_keys = new List<string>();
            List<string> list_key_maps = new List<string>();
            



            OpenFileDialog ofdSelectConfigFileKFloor2 = new OpenFileDialog();
            ofdSelectConfigFileKFloor2.InitialDirectory = "c:\\";
            ofdSelectConfigFileKFloor2.Title = "Please select your KFInput.ini file";

            // set an x and y axis to begin generating buttons at runtime
            int x = 18;
            int y = 280;
            if (ofdSelectConfigFileKFloor2.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if ((fstream = ofdSelectConfigFileKFloor2.OpenFile()) != null)
                    {
                        // Toggle visibility of open and select file
                        btnApplyBindings.Visible = true;
                        btnSelectFile.Visible = false;
                        directoryPath = ofdSelectConfigFileKFloor2.FileName;
                        //Import possible actions for the game from resources folder
                        string possible_actions = Properties.Resources.KillingFloor2Actions;
                        //Import possible keys from the Resources folder
                        string possible_keys = Properties.Resources.KillingFloor2PossibleKeys;
                        // Import strings that we will use to compare against the config file.
                        // This is because the config file is fairly complicated and would be too complicated to parse without risking 
                        // having errors.
                        string possible_keys_map = Properties.Resources.KillingFloor2PossibleKeysMap;
                        
                        //create a list of strings to categorize the button configurations by category for easier editing
                        string[] categories = new string[] { "== Combat ==", "== Basic Controls ==", "== Various ==" };

                        // import file in resources that contains all of the possible game settings that can be assigned
                        List<string> actions = possible_actions.Split(new[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries).ToList();
                        keys = possible_keys.Split(new[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries).ToList();
                        maps = possible_keys_map.Split(new[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries).ToList();
                        // loop through two possible key lists to map them together for easier access
                        for (int i = 0; i < keys.Count - 1; i++)
                        {
                            possibleKeys.Add(maps[i].ToString(), keys[i + 1].ToString());
                            //possibleKeys.Add(keys[i+1].ToString(), maps[i].ToString());
                            Console.WriteLine("Key= " + keys[i+1].ToString() + "Map= " + maps[i].ToString());
                        }

                        //In this foreach we are going to be dynamically creating combo boxes based on the configuration files stored in
                        // resources. By making the options dynamically, it makes adding another game to the application much easier, as 
                        // a majority of the way the game is being configured os decided by configuration files that store the Actions and the PossibleKeys.
                        foreach (string str in actions)
                        {
                            // Check if the current string within the file is one of the categories (defined and stored in string[] categories)
                            // if it is a category, make a label instead of a combo box. This makes the interface
                            // a bit easier to navigate
                            if (categories.Contains(str))
                            {
                                string cur_category = null;

                                //  quick modification to the strings to allow me to name the label buttons properly 
                                if (str.Equals("== Combat =="))
                                {
                                    cur_category = "Combat";
                                }
                                if (str.Equals("== Basic Controls =="))
                                {
                                    cur_category = "BasicControls";
                                }
                                if (str.Equals("== Various =="))
                                {
                                    cur_category = "Various";
                                }
                                // Create a label for each catagory so they appear in an ordered fashion on the form
                                Label label = new Label();
                                label.Name = "lbl" + cur_category;
                                label.Text = str;
                                label.Location = new Point(x, y);
                                label.AutoSize = true;
                                this.Controls.Add(label);
                                // Incriment y down 30px to apply next button 
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
                                // Add a new ComboBox  to the form to allow user to select a key for for the current action
                                ComboBox cbox = new ComboBox();
                                cbox.BindingContext = new BindingContext();
                                cbox.DropDownStyle = ComboBoxStyle.DropDownList;
                                cbox.Location = new Point(x + 120, y - 5);
                                cbox.DataSource = keys;
                                cbox.Name = "cbx" + str;
                                cbox_list.Add(cbox);
                                cbox.FormatString = str;
                                this.Controls.Add(cbox);
                                y += 30;

                            }
                        }
                    }
                    ofdSelectConfigFileKFloor2.Dispose();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                }
            }
            ofdSelectConfigFileKFloor2.Dispose();
            fstream.Dispose();
        }

        private void btnApplyBindings_Click(object sender, EventArgs e)
        {
            Console.WriteLine("You pushed it!");
            List<string> template = writing_template.Split(new[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries).ToList();
            try
            {
                foreach (ComboBox cbox in cbox_list)
                {
                    // if unassinged, do nothing with current block
                    if (!cbox.SelectedValue.Equals("--Unassigned--"))
                    {
                        // check dictionary and see if key has assignment
                        if (activeKeys.ContainsKey(cbox.SelectedValue.ToString()))
                        {
                            // if there user attempts to assign a duplicate, throw an error and ask user to fix it, keep settings
                            MessageBox.Show("The keys assigned contained at least one duplicate. Please correct this. Duplicate keys will cause errors within the game.", "ERROR: Assignment contains duplicate keys", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                // Open a stream with the file the user selected in ofSelectConfigFileKillingFloor2
                using (StreamWriter sr = new StreamWriter(directoryPath))
                {
                    // run a loop through all of the strings that were generated from the template.
                    // Each string is a line from the template that will be written to the actual config file for the game
                    foreach (string line in template)
                    {
                        // check if the current line in the config file matches with one of the assignable 
                        // keys that was defined in the KillingFloor2PossibleKeys. The template has a lot of
                        // data on it that cannot be modified, so if it is not in the list we pre-defined, just write
                        // it as is to the file.
                        if (possibleKeys.ContainsKey(line))
                        {
                            // grab the value for that key (this will be an actual keyboard character we mapped earlier)
                            string assignable_key = possibleKeys[line];
                            // NOTE: Below, when I write Key, I am only reffering to Keyboard Characters. It is coincidental that
                            //  dictionaries also contain keys in this case.

                            // Check if the assignable_key belongs to activeKeys dictionary.
                            // activeKeys is another dictionary that contains the keys that the user selected to be assigned
                            if (activeKeys.ContainsKey(assignable_key))
                            {
                                // Assign the value from the dictionary. The value from the dictionary of activeKeys
                                // represents the action the user selected to assign to that specific key
                                string assigned_action = activeKeys[assignable_key];

                                // Key bindings are hard to pars in KillingFloor2 Config Files, so I manually 
                                // went in and replaced all of the spaces that could be assigned an action with a "?", a character
                                // that did not exist in the file.
                                // the lines look something like (Binding(Value=C,Action="ShootGun", .....)
                                // In the template I am comparing them to it looks like: (Binding(Value=C,Action="?", .....)

                                // Replace the value of line where "?" with the user assigned action
                                string new_line = line.Replace("?", assigned_action);
                                // write this newly modified line to the final file
                                sr.WriteLine(new_line);
                            }
                            else
                            {
                                // if the user did not specify an action for this key, we need to get rid
                                // of the ? I added to the template, so replace that with an empty space and write it to the file
                                string new_line = line.Replace("?", " ");
                                sr.WriteLine(new_line);
                            }
                        }
                        else
                        {
                            // if this block is reached, that means we are on a string that cannot be modified by the user without causing
                            // problems in the game. Simply write the current line from the template to the config file
                            sr.WriteLine(line);
                        }
                    }
                }
                MessageBox.Show("Configuration file has successfully been modified!", "KeyBinder", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                //Clear the active keys to prevent errors if user retries applying settings
                activeKeys.Clear();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: There was a problem with your bindings :  " + ex.Message);
            }
        }

    }
}