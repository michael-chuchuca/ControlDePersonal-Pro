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
    public partial class AsignacionHorarios : Form
    {
        private static AsignacionHorarios instVentana = null;

        public AsignacionHorarios()
        {
            InitializeComponent();
        }

        public static AsignacionHorarios UnaVentana()
        {
            if (instVentana == null)
            {
                instVentana = new AsignacionHorarios();
                return instVentana;
            }
            return instVentana;
        }

        private void AsignacionHorarios_Load(object sender, EventArgs e)
        {

        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }
    }
}
