using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SGBalonmanoAlvaroMerino
{
    public partial class FrmInformes : Form
    {
        public FrmInformes()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dgvDatos.DataSource = null;
            using (dsBd objBD = new dsBd())
            {
                dgvDatos.DataSource = null;
                var consulta = from equipos in objBD.EQUIPOS
                               select equipos;
                


                var consultaLocal = from local in objBD.PARTIDOS
                                    from visitante in objBD.PARTIDOS
                                    where local.Equipo_local == &&
                                    visitante.Equipo_visitante ==
                                    select new { local.Equipo_local, visitante.Equipo_visitante };
               

            }
        }
    }
}
