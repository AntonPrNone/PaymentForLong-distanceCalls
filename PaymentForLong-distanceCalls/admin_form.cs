using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PaymentForLong_distanceCalls
{
    public partial class admin_form : Form
    {
        public admin_form()
        {
            InitializeComponent();
        }

        private void Initial_form_Load(object sender, EventArgs e)
        {
            service_button.FlatAppearance.BorderSize = 0;
            service_button.FlatStyle = FlatStyle.Flat;

            client_button.FlatAppearance.BorderSize = 0;
            client_button.FlatStyle = FlatStyle.Flat;

            receipt_button.FlatAppearance.BorderSize = 0;
            receipt_button.FlatStyle = FlatStyle.Flat;

            clientsСity_button.FlatAppearance.BorderSize = 0;
            clientsСity_button.FlatStyle = FlatStyle.Flat;

            localityOfTheInterlocutor_button.FlatAppearance.BorderSize = 0;
            localityOfTheInterlocutor_button.FlatStyle = FlatStyle.Flat;
        }

        private void service_button_Click(object sender, EventArgs e)
        {
            var f1 = new service_form();
            f1.ShowDialog();
        }

        private void receipt_button_Click(object sender, EventArgs e)
        {
            var f2 = new receipt_form();
            f2.ShowDialog();
        }

        private void client_button_Click(object sender, EventArgs e)
        {
            var f3 = new client_form();
            f3.ShowDialog();
        }

        private void clientsСity_button_Click(object sender, EventArgs e)
        {
            var f4 = new clientsCity_form();
            f4.ShowDialog();
        }

        private void localityOfTheInterlocutor_button_Click(object sender, EventArgs e)
        {
            var f5 = new localityOfTheInterlocutor_form();
            f5.ShowDialog();
        }
    }
}
