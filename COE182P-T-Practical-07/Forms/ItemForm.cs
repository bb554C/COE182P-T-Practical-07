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
                    buttonItem.Text = "Add Item";
                    break;
                case 1:
                    buttonItem.Text = "Update Item";
                    break;
                case 2:
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
        private void Error(string ex)
        {
            MessageBox.Show("Error Code: " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            this.Close();
        }

        private void buttonItem_Click(object sender, EventArgs e)
        {

        }
    }
}
