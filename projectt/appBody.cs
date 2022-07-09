using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projectt
{
    public partial class appBody : Form
    {
        public appBody()
        {
            InitializeComponent();
        }

        private void crossIcon_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void movieButton_Click(object sender, EventArgs e)
        {
            if (!contentPanel.Controls.Contains(movies_UserControl.Instance))
            {
                contentPanel.Controls.Add(movies_UserControl.Instance);
                movies_UserControl.Instance.Dock = DockStyle.Fill;
                movies_UserControl.Instance.BringToFront();
            }
            else
            {
                movies_UserControl.Instance.BringToFront();
            }
            
        }

        private void ticketButton_Click(object sender, EventArgs e)
        {
            if (!contentPanel.Controls.Contains(ticket_UserControl.Instance))
            {
                contentPanel.Controls.Add(ticket_UserControl.Instance);
                ticket_UserControl.Instance.Dock = DockStyle.Fill;
                ticket_UserControl.Instance.BringToFront();
            }
            else
            {
               ticket_UserControl.Instance.BringToFront();
            }


        }

        private void SeatsButton_Click(object sender, EventArgs e)
        {
            if (!contentPanel.Controls.Contains(seats_UserControl.Instance))
            {
                contentPanel.Controls.Add(seats_UserControl.Instance);
                seats_UserControl.Instance.Dock = DockStyle.Fill;
                seats_UserControl.Instance.BringToFront();
            }
            else
            {
                seats_UserControl.Instance.BringToFront();
            }

        }

        private void bookButton_Click(object sender, EventArgs e)
        {
            if (!contentPanel.Controls.Contains(booking_UserControl.Instance))
            {
                contentPanel.Controls.Add(booking_UserControl.Instance);
                booking_UserControl.Instance.Dock = DockStyle.Fill;
                booking_UserControl.Instance.BringToFront();
            }
            else
            {
                booking_UserControl.Instance.BringToFront();
            }


        }
    }
}
