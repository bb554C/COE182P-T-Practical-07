using System;
using System.Linq.Expressions;
using System.Windows.Forms;

namespace COE182P_T_Practical_07
{
    public partial class SelectionForm : Form
    {
        public int state;
        private StallForm SF = new StallForm();
        private FoodTypeForm FTF = new FoodTypeForm();
        private ItemForm IF = new ItemForm();
        public SelectionForm()
        {
            InitializeComponent();
        }
        private void SelectionForm_Load(object sender, EventArgs e)
        {
            SF.state = state;
            FTF.state = state;
            IF.state = state;
            switch(state)
            {
                case 1:
                    buttonItem.Text = "Update Item";
                    buttonCategory.Text = "Update Food Type";
                    buttonStall.Text = "Update Stall";
                    break;
                case 2:
                    buttonItem.Text = "Delete Item";
                    buttonCategory.Text = "Delete Food Type";
                    buttonStall.Text = "Delete Stall";
                    break;
            }
        }
        private void buttonStall_Click(object sender, EventArgs e)
        {
            try
            {
                SF.varSelectionForm = this;
                this.Hide();
                SF.ShowDialog();
            }
            catch(Exception ex)
            {
                Error(ex.ToString());
            }
        }

        private void buttonCategory_Click(object sender, EventArgs e)
        {
            try
            {
                FTF.varSelectionForm = this;
                this.Hide();
                FTF.ShowDialog();
            }
            catch (Exception ex)
            {
                Error(ex.ToString());
            }
        }

        private void buttonItem_Click(object sender, EventArgs e)
        {
            try
            {
                IF.varSelectionForm = this;
                this.Hide();
                IF.ShowDialog();
            }
            catch (Exception ex)
            {
                Error(ex.ToString());
            }
        }
        private void Error(string ex)
        {
            MessageBox.Show("Error Code: " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            this.Close();
        }
    }
}
