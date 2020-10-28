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
        public List<TypeList> TL;
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
                    TL = SQLServerConnection.GetFoodTypeList();
                    foreach (TypeList tempList in TL)
                    {
                        comboBoxID.Items.Add(tempList.FoodTypeID);
                    }
                    comboBoxID.Enabled = true;
                    buttonType.Text = "Update Food Type";
                    break;
                case 2:
                    TL = SQLServerConnection.GetFoodTypeList();
                    foreach (TypeList tempList in TL)
                    {
                        comboBoxID.Items.Add(tempList.FoodTypeID);
                    }
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
                    textBoxName.Text = TL[comboBoxID.SelectedIndex].FoodType;
                    textBoxDescription.Text = TL[comboBoxID.SelectedIndex].TypeDescription;
                    textBoxName.Enabled = true;
                    textBoxDescription.Enabled = true;
                    break;
                case 2:
                    textBoxName.Text = TL[comboBoxID.SelectedIndex].FoodType;
                    textBoxDescription.Text = TL[comboBoxID.SelectedIndex].TypeDescription;
                    break;
                default:
                    Error("Unkown Error");
                    break;
            }
        }
        private void buttonType_Click(object sender, EventArgs e)
        {
            SQLServerConnection.FTF = this;
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
                            SQLServerConnection.AddFoodType(textBoxName.Text, textBoxDescription.Text);
                        }
                        catch (Exception ex)
                        {
                            Error(ex.ToString());
                        }
                        MessageBox.Show("Food Type with name: " + textBoxName.Text + " has been successfully added to the database.", "New Food Type Added", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    break;
                case 1:
                    try
                    {
                        if (textBoxName.Text != "")
                        {
                            SQLServerConnection.UpdateFoodType(Convert.ToInt32(comboBoxID.Text), textBoxName.Text, textBoxDescription.Text);
                        }
                        else
                        {
                            Error("No selected item to update");
                        }
                        MessageBox.Show("Food Type with ID: " + comboBoxID.Text + " has been successfully updated.", "Food Type Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                            SQLServerConnection.DeleteFoodType(Convert.ToInt32(comboBoxID.Text));
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
                    MessageBox.Show("Food Type with ID: " + comboBoxID.Text + " has been successfully deleted.", "Food Type Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                default:
                    Error("Unkown Error");
                    break;
            }
            this.Close();
        }

        private void FoodTypeForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            varSelectionForm.Close();
        }
        private void Error(string ex)
        {
            MessageBox.Show("Error Code: " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            this.Close();
        }
    }
}
