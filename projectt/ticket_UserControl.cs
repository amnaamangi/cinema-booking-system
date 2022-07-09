using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace projectt
{
    public partial class ticket_UserControl : UserControl
    {
        private static ticket_UserControl _instance;
        public static ticket_UserControl Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new ticket_UserControl();
                }
                return _instance;
            }
        }
        public ticket_UserControl()
        {
            InitializeComponent();
        }

        SqlConnection connection = new SqlConnection(@"Data Source=AMNAA;Initial Catalog=newdatabaseProject;Integrated Security=True");
        private void refresh_DataGrid()
        {
            try
            {
                SqlCommand cmd = new SqlCommand("show_payment", connection);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter dataAdapt = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                dataAdapt.Fill(ds);

                connection.Open();
                try
                {
                    cmd.ExecuteNonQuery();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("        <<<INVALID SQL OPERATION>>>: \n" + ex);
                }
                connection.Close();

                dataGridView3.DataSource = ds.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }
        }

        private void ticket_UserControl_Load(object sender, EventArgs e)
        {
            refresh_DataGrid();
        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            refresh_DataGrid();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("add_payment", connection);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@payID", payIDBox.Text);
            cmd.Parameters.AddWithValue("@transID", transIDBox.Text); 
            cmd.Parameters.AddWithValue("@bookID", bookIDBox.Text);
            cmd.Parameters.AddWithValue("@payAmount ", payBox.Text);
           

            connection.Open();
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("             <<< INVALID SQL OPERTION>>>: \n" + ex);
            }
            connection.Close();

            refresh_DataGrid();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
