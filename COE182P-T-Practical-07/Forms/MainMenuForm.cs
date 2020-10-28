using System;
using System.Data;
using System.Data.SqlClient;
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
            SqlConnection SQLconn = SQLServerConnection.SQLConnection();
            using (SqlDataAdapter dataAdapter = new SqlDataAdapter("dbo.ViewMenu", SQLconn))
            {
                var command = new SqlCommandBuilder(dataAdapter);
                var ds = new DataSet();
                dataAdapter.Fill(ds);
                dataGridView.DataSource = ds.Tables[0];
            }
            SQLServerConnection.CloseSQLConnection(SQLconn);
        }
        private void buttonSearch_Click(object sender, EventArgs e)
        {
            SearchForm SF = new SearchForm();
            SF.MMF = this;
            SF.Show();
        }
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            SelectionForm SF = new SelectionForm();
            SF.state = 0;
            SF.ShowDialog();
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
