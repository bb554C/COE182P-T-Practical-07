using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace COE182P_T_Practical_07
{
    public partial class SearchForm : Form
    {
        public MainMenuForm MMF;
        public SearchForm()
        {
            InitializeComponent();
        }

        private void buttonSearchFood_Click(object sender, System.EventArgs e)
        {
            string food = "%" + textBoxFoodName.Text + "%";
            SqlConnection SQLconn = SQLServerConnection.SQLConnection();
            using (SqlCommand command = new SqlCommand("dbo.SearchFood", SQLconn))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("@NameFood", SqlDbType.VarChar, 100).Value = food;
                var ds = new DataSet();
                SqlDataAdapter da = new SqlDataAdapter();
                SQLconn.Open();
                da.SelectCommand = command;
                da.Fill(ds);
                MMF.dataGridView.DataSource = ds.Tables[0];
            }
            SQLServerConnection.CloseSQLConnection(SQLconn);
        }

        private void buttonSearchType_Click(object sender, System.EventArgs e)
        {
            string type = "%" + textBoxFoodType.Text + "%";
            SqlConnection SQLconn = SQLServerConnection.SQLConnection();
            using (SqlCommand command = new SqlCommand("dbo.SearchFoodType", SQLconn))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("@TypeFood", SqlDbType.VarChar, 100).Value = type;
                var ds = new DataSet();
                SqlDataAdapter da = new SqlDataAdapter();
                SQLconn.Open();
                da.SelectCommand = command;
                da.Fill(ds);
                MMF.dataGridView.DataSource = ds.Tables[0];
            }
            SQLServerConnection.CloseSQLConnection(SQLconn);
        }

        private void buttonSearchStall_Click(object sender, System.EventArgs e)
        {
            string Stall = "%" + textBoxStallName.Text + "%";
            SqlConnection SQLconn = SQLServerConnection.SQLConnection();
            using (SqlCommand command = new SqlCommand("dbo.SearchStall", SQLconn))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("@NameStall", SqlDbType.VarChar, 100).Value = Stall;
                var ds = new DataSet();
                SqlDataAdapter da = new SqlDataAdapter();
                SQLconn.Open();
                da.SelectCommand = command;
                da.Fill(ds);
                MMF.dataGridView.DataSource = ds.Tables[0];
            }
            SQLServerConnection.CloseSQLConnection(SQLconn);
        }
    }
}
