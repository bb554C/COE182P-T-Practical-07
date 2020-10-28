using COE182P_T_Practical_07.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace COE182P_T_Practical_07
{
    public partial class ItemForm : Form
    {
        public int state;
        public SelectionForm varSelectionForm;
        public List<StallList> SL = new List<StallList>();
        public List<TypeList> TL = new List<TypeList>();
        public List<ItemList> IL = new List<ItemList>();
        public ItemForm()
        {
            InitializeComponent();
        }

        private void ItemForm_Load(object sender, EventArgs e)
        {
            switch(state)
            {
                case 0:
                    comboBoxStallName.Enabled = true;
                    textBoxFoodName.Enabled = true;
                    comboBoxFoodType.Enabled = true;
                    textBoxFoodDescription.Enabled = true;
                    textBoxPrice.Enabled = true;
                    SL = SQLServerConnection.GetStallList();
                    TL = SQLServerConnection.GetFoodTypeList();
                    foreach (TypeList tempList in TL)
                    {
                        comboBoxFoodType.Items.Add(tempList.FoodType);
                    }
                    foreach (StallList tempList in SL)
                    {
                        comboBoxStallName.Items.Add(tempList.StallName);
                    }
                    buttonItem.Text = "Add Item";
                    break;
                case 1:
                    SL = SQLServerConnection.GetStallList();
                    TL = SQLServerConnection.GetFoodTypeList();
                    IL = SQLServerConnection.GetItemList();
                    foreach (TypeList tempList in TL)
                    {
                        comboBoxFoodType.Items.Add(tempList.FoodType);
                    }
                    foreach (StallList tempList in SL)
                    {
                        comboBoxStallName.Items.Add(tempList.StallName);
                    }
                    foreach (ItemList tempList in IL)
                    {
                        comboBoxFoodID.Items.Add(tempList.FoodID);
                    }
                    comboBoxFoodID.Enabled = true;
                    buttonItem.Text = "Update Item";
                    break;
                case 2:
                    SL = SQLServerConnection.GetStallList();
                    TL = SQLServerConnection.GetFoodTypeList();
                    IL = SQLServerConnection.GetItemList();
                    foreach (TypeList tempList in TL)
                    {
                        comboBoxFoodType.Items.Add(tempList.FoodType);
                    }
                    foreach (StallList tempList in SL)
                    {
                        comboBoxStallName.Items.Add(tempList.StallName);
                    }
                    foreach (ItemList tempList in IL)
                    {
                        comboBoxFoodID.Items.Add(tempList.FoodID);
                    }
                    comboBoxFoodID.Enabled = true;
                    buttonItem.Text = "Delete Item";
                    break;
                default:
                    Error("Unkown Error");
                    break;
            }
        }

        private void ItemForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            varSelectionForm.Close();
        }

        private void buttonItem_Click(object sender, EventArgs e)
        {
            SQLServerConnection.IF = this;
            switch (state)
            {
                case 0:
                    if (comboBoxStallName.Text == "" || textBoxFoodName.Text == "" || comboBoxFoodType.Text == "" || textBoxPrice.Text == "")
                    {
                        MessageBox.Show("Error: Empty items", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        try
                        {
                            SQLServerConnection.AddItem(Convert.ToInt32(textBoxStallID.Text), Convert.ToInt32(textBoxFoodTypeID.Text), textBoxFoodName.Text, textBoxFoodDescription.Text, Convert.ToDecimal(textBoxPrice.Text));
                        }
                        catch (Exception ex)
                        {
                            Error(ex.ToString());
                        }
                        MessageBox.Show("Item with name: " + textBoxFoodName.Text + " has been successfully added to the database.", "New Item Added", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    break;
                case 1:
                    try
                    {
                        if (comboBoxFoodID.Text != "")
                        {
                            SQLServerConnection.UpdateItem(Convert.ToInt32(comboBoxFoodID.Text), Convert.ToInt32(textBoxStallID.Text), Convert.ToInt32(textBoxFoodTypeID.Text), textBoxFoodName.Text, textBoxFoodDescription.Text, Convert.ToDecimal(textBoxPrice.Text));
                        }
                        else
                        {
                            Error("No selected item to update");
                        }
                        MessageBox.Show("Item with ID: " + comboBoxFoodID.Text + " has been successfully updated.", "Item Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        Error(ex.ToString());
                    }
                    break;
                case 2:
                    try
                    {
                        if (comboBoxFoodID.Text != "")
                        {
                            SQLServerConnection.DeleteItem(Convert.ToInt32(comboBoxFoodID.Text));
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
                    MessageBox.Show("Item with ID: " + comboBoxFoodID.Text + " has been successfully deleted.", "Item Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                default:
                    Error("Unkown Error");
                    break;
            }
            this.Close();
        }
        private void comboBoxFoodID_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (state)
            {
                case 1:
                    comboBoxStallName.Enabled = true;
                    textBoxFoodName.Enabled = true;
                    comboBoxFoodType.Enabled = true;
                    textBoxFoodDescription.Enabled = true;
                    textBoxPrice.Enabled = true;
                    textBoxStallID.Text = IL[comboBoxFoodID.SelectedIndex].StallID.ToString();
                    textBoxFoodTypeID.Text = IL[comboBoxFoodID.SelectedIndex].FoodTypeID.ToString();
                    SL.Clear();
                    TL.Clear();
                    SL = SQLServerConnection.GetStallList();
                    TL = SQLServerConnection.GetFoodTypeList();
                    int x = 0;
                    foreach(StallList tempList in SL)
                    {
                        if (tempList.StallID == Convert.ToInt32(textBoxStallID.Text))
                            comboBoxStallName.SelectedIndex = x;
                        x++;
                    }
                    textBoxFoodName.Text = IL[comboBoxFoodID.SelectedIndex].FoodName;
                    x = 0;
                    foreach (TypeList tempList in TL)
                    {
                        if (tempList.FoodTypeID == Convert.ToInt32(textBoxFoodTypeID.Text))
                            comboBoxFoodType.SelectedIndex = x;
                        x++;
                    }
                    textBoxFoodDescription.Text = IL[comboBoxFoodID.SelectedIndex].FoodDescription;
                    textBoxPrice.Text = IL[comboBoxFoodID.SelectedIndex].FoodPrice.ToString("0.00");
                    break;
                case 2:
                    textBoxStallID.Text = IL[comboBoxFoodID.SelectedIndex].StallID.ToString();
                    textBoxFoodTypeID.Text = IL[comboBoxFoodID.SelectedIndex].FoodTypeID.ToString();
                    SL.Clear();
                    TL.Clear();
                    SL = SQLServerConnection.GetStallList();
                    TL = SQLServerConnection.GetFoodTypeList();
                    int y = 0;
                    foreach (StallList tempList in SL)
                    {
                        if (tempList.StallID == Convert.ToInt32(textBoxStallID.Text))
                            comboBoxStallName.SelectedIndex = y;
                        y++;
                    }
                    textBoxFoodName.Text = IL[comboBoxFoodID.SelectedIndex].FoodName;
                    y = 0;
                    foreach (TypeList tempList in TL)
                    {
                        if (tempList.FoodTypeID == Convert.ToInt32(textBoxFoodTypeID.Text))
                            comboBoxFoodType.SelectedIndex = y;
                        y++;
                    }
                    textBoxFoodDescription.Text = IL[comboBoxFoodID.SelectedIndex].FoodDescription;
                    textBoxPrice.Text = IL[comboBoxFoodID.SelectedIndex].FoodPrice.ToString("0.00");
                    break;
                default:
                    Error("Unkown Error");
                    break;
            }
        }

        private void comboBoxStallName_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBoxStallID.Text = SL[comboBoxStallName.SelectedIndex].StallID.ToString();
        }

        private void comboBoxFoodType_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBoxFoodTypeID.Text = TL[comboBoxFoodType.SelectedIndex].FoodTypeID.ToString();
        }

        private void Error(string ex)
        {
            MessageBox.Show("Error Code: " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            this.Close();
        }
    }
}
