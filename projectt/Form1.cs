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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public string conString = "Data Source=AMNAA;Initial Catalog=newdatabaseProject;Integrated Security=True";


        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
            //login
        {
            if (txtuser.Text == "")
            {
                MessageBox.Show("Enter the username: ");
            }
            else if (txtPassword.Text == "")
            {

                MessageBox.Show("Enter the password: ");
            }
            else
            {
                try
                {
                    SqlConnection con = new SqlConnection(conString);
                    SqlCommand cmd = new SqlCommand("select * from Users where userID=@userID and userPassword=@userPassword",con);
                    cmd.Parameters.AddWithValue("@userID", txtuser.Text);
                    cmd.Parameters.AddWithValue("@userPassword", txtPassword.Text);
                    SqlDataAdapter sqlData = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();

                    sqlData.Fill(dt);

                    if(dt.Rows.Count > 0)
                    {              
                        MessageBox.Show("login successful.");
                        // appBody
                        appBody form2 = new appBody();
                        this.Hide();
                        form2.Show();
                    }
                    else
                    {
                        MessageBox.Show("invalid useername or password.");
                    }

                } catch (Exception ex)
                {
                    MessageBox.Show(" " + ex);
                }
            }


        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void txtuser_TextChanged(object sender, EventArgs e)
        {

        }
    }
}