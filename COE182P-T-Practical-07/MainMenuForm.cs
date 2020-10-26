using System;
using System.Windows.Forms;

namespace COE182P_T_Practical_07
{
    public partial class MainMenuForm : Form
    {
        public MainMenuForm()
        {
            InitializeComponent();
        }

        private void buttonView_Click(object sender, EventArgs e)
        {

        }
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            SelectionForm SF = new SelectionForm();
            SF.state = 0;
            SF.ShowDialog();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {

        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            SelectionForm SF = new SelectionForm();
            SF.state = 1;
            SF.ShowDialog();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            SelectionForm SF = new SelectionForm();
            SF.state = 2;
            SF.ShowDialog();
        }
    }
}
