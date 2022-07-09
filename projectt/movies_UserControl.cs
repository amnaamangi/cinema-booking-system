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
    public partial class movies_UserControl : UserControl
    {
        private static movies_UserControl _instance;
        public static movies_UserControl Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new movies_UserControl();
                }
                return _instance;
            }

        }
        public movies_UserControl()
        {
            InitializeComponent();
        }

        SqlConnection connection = new SqlConnection(@"Data Source=AMNAA;Initial Catalog=newdatabaseProject;Integrated Security=True");

        private void searchButton_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("[dbo].SearchMovie", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@movieName", searchBox.Text);

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

        private void refresh_DataGrid()
        {
            try
            {
                SqlCommand cmd = new SqlCommand("[dbo].ShowAllMovies", connection);
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

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("[dbo].Add_movies", connection);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@movie_ID", movieIDbox.Text);
            cmd.Parameters.AddWithValue("@showID", showIDcomboBox.Text);
            cmd.Parameters.AddWithValue("@movieName", nameBox.Text);
            cmd.Parameters.AddWithValue("@length_minutes ", minBox.Text);
            cmd.Parameters.AddWithValue("@AgeLimit", ageBox.Text);
            cmd.Parameters.AddWithValue("@MovieGenre", genreBox.Text);
            cmd.Parameters.AddWithValue("@for_category", forBox.Text);

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

        private void movies_UserControl_Load(object sender, EventArgs e)
        {
            refresh_DataGrid();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            refresh_DataGrid();
        }

        private void deleteButton_Click(object sender, EventArgs e)
           {
             try
               {
                   SqlCommand cmd = new SqlCommand("[dbo].deleteMovies", connection);
                   cmd.CommandType = CommandType.StoredProcedure;

                   cmd.Parameters.AddWithValue("@movie_ID", movieIDbox.Text);

                connection.Open();
                try
                {
                    cmd.ExecuteNonQuery();
                } catch(Exception ex)
                {
                    MessageBox.Show("               <<<INVALID SQL OPERATION>>> : \n" + ex);
                }
                connection.Close();
               } catch(Exception ex)
            {
                MessageBox.Show("" + ex);
            }
            refresh_DataGrid();
           }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("updateMovie", connection);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@movie_ID", movieIDbox.Text);
            cmd.Parameters.AddWithValue("@movieName", nameBox.Text);
            cmd.Parameters.AddWithValue("@length_minutes ", minBox.Text);
            cmd.Parameters.AddWithValue("@AgeLimit", ageBox.Text);
            cmd.Parameters.AddWithValue("@MovieGenre", genreBox.Text);
            cmd.Parameters.AddWithValue("@for_category", forBox.Text);


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
    } 


    }

