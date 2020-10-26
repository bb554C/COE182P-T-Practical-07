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
        public SelectionForm varStallForm;
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
            varStallForm.Close();
        }

        private void buttonStall_Click(object sender, EventArgs e)
        {
            try
            {
                switch (state)
                {
                    case 0:
                        //insert stall add procedure
                        break;
                    case 1:
                        //insert stall update procedure
                        break;
                    case 2:
                        //insert stall delete procedure
                        break;
                    default:
                        Error("Unkown Error");
                        break;
                }
            }
            catch(Exception ex)
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
