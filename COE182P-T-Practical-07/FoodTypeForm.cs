using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace COE182P_T_Practical_07
{
    public partial class FoodTypeForm : Form
    {
        public int state;
        public SelectionForm varSelectionForm;
        public FoodTypeForm()
        {
            InitializeComponent();
        }

        private void FoodTypeForm_Load(object sender, EventArgs e)
        {
            switch (state)
            {
                case 0:
                    textBoxName.Enabled = true;
                    textBoxDescription.Enabled = true;
                    buttonType.Text = "Add Food Type";
                    break;
                case 1:
                    comboBoxID.Enabled = true;
                    buttonType.Text = "Update Food Type";
                    break;
                case 2:
                    comboBoxID.Enabled = true;
                    buttonType.Text = "Delete Food Type";
                    break;
                default:
                    Error("Unkown Error");
                    break;
            }
        }

        private void FoodTypeForm_SelectionIndexedChanged(object sender, EventArgs e)
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
        private void Error(string ex)
        {
            MessageBox.Show("Error Code: " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            this.Close();
        }

        private void buttonType_Click(object sender, EventArgs e)
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
                            MessageBox.Show("Food Type with name: " + textBoxName.Text + " has been successfully added to the database.", "New Food Type Added", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                        if (textBoxName.Text != "")
                        {
                            //insert stall update procedure
                            MessageBox.Show("Food Type with ID: " + comboBoxID.Text + " has been successfully updated.", "Food Type Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                            MessageBox.Show("Food Type with ID: " + comboBoxID.Text + " has been successfully deleted.", "Food Type Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void FoodTypeForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            varSelectionForm.Close();
        }
    }
}
