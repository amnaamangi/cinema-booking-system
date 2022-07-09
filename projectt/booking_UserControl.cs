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
    public partial class booking_UserControl : UserControl
    {
        private static booking_UserControl _instance;
        public static booking_UserControl Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new booking_UserControl();
                }
                return _instance;
            }
        }
        public booking_UserControl()
        {
            InitializeComponent();
        }

        SqlConnection connection = new SqlConnection(@"Data Source=AMNAA;Initial Catalog=newdatabaseProject;Integrated Security=True");

        private void refresh_DataGrid()
        {
            try
            {
                SqlCommand cmd = new SqlCommand("ShowAllBookings", connection);
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

                dataGridView1.DataSource = ds.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }
        }

        private void booking_UserControl_Load(object sender, EventArgs e)
        {
            refresh_DataGrid();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            refresh_DataGrid();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("[dbo].Add_bookings", connection);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@bookID", bookBox.Text);      
            cmd.Parameters.AddWithValue("@showID", showcomboBox.Text);
            cmd.Parameters.AddWithValue("@firstName",firstnameBox.Text);
            cmd.Parameters.AddWithValue("@lastName", lastnameBox.Text);
            cmd.Parameters.AddWithValue("@DateOfBirth",birthBox.Text);
            cmd.Parameters.AddWithValue("@noOfTickets" ,noticketsBox.Text);
            cmd.Parameters.AddWithValue("@paid", paidBox.Text);

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

        private void button2_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("calculation", connection);
            cmd.CommandType = CommandType.StoredProcedure;

            SqlDataAdapter dataAdapt = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            dataAdapt.Fill(ds);


            //cmd.Parameters.AddWithValue(label10.Text, connection);

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
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("calculation", connection);
            cmd.CommandType = CommandType.StoredProcedure;

            SqlDataAdapter dataAdapt = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            dataAdapt.Fill(ds);


            //cmd.Parameters.AddWithValue(label10.Text, connection);

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
            dataGridView1.DataSource = ds.Tables[0];
        }
    }
}
