using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabRabBD
{
    public partial class Zakazy : Form
    {
        public Zakazy()
        {
            InitializeComponent();
        }

        private void Zakazy_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "стол_заказовDataSet.Заказы". При необходимости она может быть перемещена или удалена.
            this.заказыTableAdapter.Fill(this.стол_заказовDataSet.Заказы);

        }
    }
}
