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

        }

        private void ItemForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            varSelectionForm.Close();
        }
    }
}
