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
    public partial class clientsCity_form : Form
    {
        public clientsCity_form()
        {
            InitializeComponent();
        }

        private void clientsСity_tableBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.clientsСity_tableBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this._PaymentForLong_distanceCallsDataSet);

        }

        private void clientsCity_form_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_PaymentForLong_distanceCallsDataSet.ClientsСity_table". При необходимости она может быть перемещена или удалена.
            this.clientsСity_tableTableAdapter.Fill(this._PaymentForLong_distanceCallsDataSet.ClientsСity_table);

        }
    }
}
