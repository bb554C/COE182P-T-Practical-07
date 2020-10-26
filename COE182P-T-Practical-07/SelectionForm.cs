using System;
using System.Linq.Expressions;
using System.Windows.Forms;

namespace COE182P_T_Practical_07
{
    public partial class SelectionForm : Form
    {
        public int state;
        public SelectionForm()
        {
            InitializeComponent();
        }
        private void SelectionForm_Load(object sender, EventArgs e)
        {
            if (state == 1)
            {
                buttonItem.Text = "Update Item";
                buttonCategory.Text = "Update Category";
                buttonStall.Text = "Update Stall";
            }
            else if(state == 2)
            {
                buttonItem.Text = "Delete Item";
                buttonCategory.Text = "Delete Category";
                buttonStall.Text = "Delete Stall";
            }
        }
        private void Error()
        {
            MessageBox.Show("An unkown error has occured.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            this.Close();
        }
        private void buttonStall_Click(object sender, EventArgs e)
        {
            switch(state)
            {
                case 0:
                    break;
                case 1:
                    break;
                case 2:
                    break;
                default:
                    Error();
                    break;
            }
        }

        private void buttonCategory_Click(object sender, EventArgs e)
        {
            switch (state)
            {
                case 0:
                    break;
                case 1:
                    break;
                case 2:
                    break;
                default:
                    Error();
                    break;
            }
        }

        private void buttonItem_Click(object sender, EventArgs e)
        {
            switch (state)
            {
                case 0:
                    break;
                case 1:
                    break;
                case 2:
                    break;
                default:
                    Error();
                    break;
            }
        }
    }
}
