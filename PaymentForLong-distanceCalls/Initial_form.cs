using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace PaymentForLong_distanceCalls
{
    public partial class Initial_form : Form
    {
        public Initial_form()
        {
            InitializeComponent();

        }

        private void Initial_form_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_PaymentForLong_distanceCallsDataSet.avt_table". При необходимости она может быть перемещена или удалена.
            this.avt_tableTableAdapter.Fill(this._PaymentForLong_distanceCallsDataSet.avt_table);

            enter_button.FlatAppearance.BorderSize = 0;
            enter_button.FlatStyle = FlatStyle.Flat;

            // sqlConnection = new SqlConnection(ConfigurationManager)

        }

        private void enter_button_Click(object sender, EventArgs e)
        {
            if (login_textBox.Text != loginTextBox.Text)
            {
                avt_label.Text = "Неверный логин";
                avt_label.ForeColor = Color.Red;
            }

            if (login_textBox.Text == loginTextBox.Text && password_textBox.Text != passwordTextBox.Text)
            {
                avt_label.Text = "Неверный пароль";
                avt_label.ForeColor = Color.Red;
            }

            if (login_textBox.Text == loginTextBox.Text && password_textBox.Text == passwordTextBox.Text)
            {
                avt_label.Text = "Авторизация";
                avt_label.ForeColor = Color.Lime;

                var f1 = new admin_form();
                f1.ShowDialog();
            }
            }

        private void enter1_button_Click(object sender, EventArgs e)
        {
            var f2 = new client_vh_form();
            f2.ShowDialog();
        }

        private void avt_tableBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.avt_tableBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this._PaymentForLong_distanceCallsDataSet);

        }
    }
}
