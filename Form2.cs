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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {

        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Form2.ActiveForm.Visible = false;
            FormIngresoPersonal frmIngreso = new FormIngresoPersonal();
            frmIngreso.Show();
        }

        private void IngresoUsuario_Click(object sender, EventArgs e)
        {
            //IngresoPersonal frmIngreso = IngresoPersonal.UnaVentana();
            IngresoPersonal frmIngreso = new IngresoPersonal();
            frmIngreso.MdiParent= this;
            frmIngreso.Show();
        }

        private void AsignarHorarios_Click(object sender, EventArgs e)
        {
            AsignacionHorarios frmAsignacion = AsignacionHorarios.UnaVentana();
            frmAsignacion.MdiParent = this;
            frmAsignacion.Show();
        }

        private void reportesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void rEPORTEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Reportes frm = new Frm_Reportes();
            frm.MdiParent = this;
            frm.Show();
        }
    }
}
