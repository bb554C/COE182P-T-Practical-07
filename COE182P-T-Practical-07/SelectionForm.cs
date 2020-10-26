using System;
using System.Linq.Expressions;
using System.Windows.Forms;

namespace COE182P_T_Practical_07
{
    public partial class SelectionForm : Form
    {
        public int state;
        private StallForm SF = new StallForm();
        public SelectionForm()
        {
            InitializeComponent();
        }
        private void SelectionForm_Load(object sender, EventArgs e)
        {
            SF.state = state;
            switch(state)
            {
                case 1:
                    buttonItem.Text = "Update Item";
                    buttonCategory.Text = "Update Category";
                    buttonStall.Text = "Update Stall";
                    break;
                case 2:
                    buttonItem.Text = "Delete Item";
                    buttonCategory.Text = "Delete Category";
                    buttonStall.Text = "Delete Stall";
                    break;
            }
        }
        private void buttonStall_Click(object sender, EventArgs e)
        {
            try
            {
                SF.varStallForm = this;
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
