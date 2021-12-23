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
    public partial class localityOfTheInterlocutor_form : Form
    {
        public localityOfTheInterlocutor_form()
        {
            InitializeComponent();
        }

        private void localityOfTheInterlocutor_tableBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.localityOfTheInterlocutor_tableBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this._PaymentForLong_distanceCallsDataSet);

        }

        private void localityOfTheInterlocutor_form_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_PaymentForLong_distanceCallsDataSet.LocalityOfTheInterlocutor_table". При необходимости она может быть перемещена или удалена.
            this.localityOfTheInterlocutor_tableTableAdapter.Fill(this._PaymentForLong_distanceCallsDataSet.LocalityOfTheInterlocutor_table);

        }
    }
}
