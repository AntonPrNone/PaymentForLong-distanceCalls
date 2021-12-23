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
    public partial class client_form : Form
    {
        public client_form()
        {
            InitializeComponent();
        }

        private void client_tableBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.client_tableBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this._PaymentForLong_distanceCallsDataSet);

        }

        private void client_form_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_PaymentForLong_distanceCallsDataSet.Client_table". При необходимости она может быть перемещена или удалена.
            this.client_tableTableAdapter.Fill(this._PaymentForLong_distanceCallsDataSet.Client_table);

        }
    }
}
