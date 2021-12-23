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
    public partial class service_form : Form
    {
        public service_form()
        {
            InitializeComponent();
        }

        private void service_tableBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.service_tableBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this._PaymentForLong_distanceCallsDataSet);

        }

        private void service_form_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_PaymentForLong_distanceCallsDataSet.Service_table". При необходимости она может быть перемещена или удалена.
            this.service_tableTableAdapter.Fill(this._PaymentForLong_distanceCallsDataSet.Service_table);

        }
    }
}
