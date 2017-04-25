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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            _zakazy = new Zakazy();
            _zakazy.MdiParent = this;
            _zakazy.Show();
        }
        private Zakazy _zakazy;
        private void списокСотрудниковToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
