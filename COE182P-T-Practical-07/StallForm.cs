using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace COE182P_T_Practical_07
{
    public partial class StallForm : Form
    {
        public int state;
        public SelectionForm varSelectionForm;
        public StallForm()
        {
            InitializeComponent();
        }

        private void StallForm_Load(object sender, EventArgs e)
        {
            switch(state)
            {
                case 0:
                    textBoxName.Enabled = true;
                    textBoxDescription.Enabled = true;
                    buttonStall.Text = "Add Stall";
                    break;
                case 1:
                    comboBoxID.Enabled = true;
                    buttonStall.Text = "Update Stall";
                    break;
                case 2:
                    comboBoxID.Enabled = true;
                    buttonStall.Text = "Delete Stall";
                    break;
                default:
                    Error("Unkown Error");
                    break;
            }
        }
        private void StallForm_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (state)
            {
                case 1:
                    //insert get stall name and description procedure
                    //textBoxName.Text = Name;
                    //textBoxDescription.Text = Description;
                    textBoxName.Enabled = true;
                    textBoxDescription.Enabled = true;
                    break;
                case 2:
                    //insert get stall name and description procedure
                    break;
                default:
                    Error("Unkown Error");
                    break;
            }
        }

        private void StallForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            varSelectionForm.Close();
        }

        private void buttonStall_Click(object sender, EventArgs e)
        {
            switch (state)
            {
                case 0:
                    if (textBoxName.Text == "")
                    {
                        MessageBox.Show("Error: Empty Name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        try
                        {
                            //insert stall add procedure
                            MessageBox.Show("Stall with name: " + textBoxName.Text + " has been successfully added to the database.", "New Stall Added", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch (Exception ex)
                        {
                            Error(ex.ToString());
                        }
                    }
                    break;
                case 1:
                    try
                    {
                        if(textBoxName.Text != "")
                        {
                            //insert stall update procedure
                            MessageBox.Show("Stall with ID: " + comboBoxID.Text + " has been successfully updated.", "Stall Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            Error("No selected item to update");
                        }
                    }
                    catch (Exception ex)
                    {
                        Error(ex.ToString());
                    }
                    break;
                case 2:
                    try
                    {
                        if (textBoxName.Text != "")
                        {
                            //insert stall delete procedure
                            MessageBox.Show("Stall with ID: " + comboBoxID.Text + " has been successfully deleted.", "Stall Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            Error("No selected item to update");
                        }
                    }
                    catch (Exception ex)
                    {
                        Error(ex.ToString());
                    }
                    break;
                default:
                    Error("Unkown Error");
                    break;
            }
        }
        private void Error(string ex)
        {
            MessageBox.Show("Error Code: " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            this.Close();
        }
    }
}
