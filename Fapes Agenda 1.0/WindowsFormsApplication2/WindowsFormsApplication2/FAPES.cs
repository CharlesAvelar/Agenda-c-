using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class FAPES : Form
    {
        public FAPES()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void agendaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.agendaBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.database1DataSet);

        }

        private void FAPES_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet.Agenda' table. You can move, or remove it, as needed.
            this.agendaTableAdapter.Fill(this.database1DataSet.Agenda);

        }

        private void telefoneLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
