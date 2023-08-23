using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlDePersonal_Pro
{
    public partial class FormIngresoPersonal : Form
    {
        public FormIngresoPersonal()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form.ActiveForm.Visible = false;
            Form2 frmIngreso = new  Form2();
            frmIngreso.Show();
        }
    }
}
