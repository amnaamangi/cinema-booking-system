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
    public partial class seats_UserControl : UserControl
    {
        private static seats_UserControl _instance;
        public static seats_UserControl Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new seats_UserControl();
                }
                return _instance;
            }
        }
        public seats_UserControl()
        {
            InitializeComponent();
        }
        SqlConnection connection = new SqlConnection(@"Data Source=AMNAA;Initial Catalog=newdatabaseProject;Integrated Security=True");

        private void refresh_DataGrid2()
        {
            try
            {
                SqlCommand cmd = new SqlCommand("ShowAllMovies", connection);
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

                dataGridView2.DataSource = ds.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }
        }

        private void seats_UserControl_Load(object sender, EventArgs e)
        {
            refresh_DataGrid2();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            refresh_DataGrid2();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
             
        }

        private void Bookbutton1_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("selectSeatFirst", connection);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@seatNoH1", comboBox1.Text);
                SqlDataAdapter sqlData = new SqlDataAdapter(cmd);             

                connection.Open();
                try
                {
                    int i = cmd.ExecuteNonQuery();
                    if (i != 0)
                          MessageBox.Show("Booked Successfully!");
                     
                } 
                catch (Exception ex)
                {
                    MessageBox.Show("        <<<INVALID SQL OPERATION>>>: \n" + ex);
                }
               
               MessageBox.Show("Failed to book.");
               connection.Close();          

        }  catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void Bookbutton2_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("selectSeatSecond", connection);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@seatNoH2", comboBox2.Text);

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

        }
    }
}
