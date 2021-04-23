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
    public partial class FrmEquipos : Form
    {
        public FrmEquipos()
        {
            InitializeComponent();
        }

        private void eQUIPOSBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.eQUIPOSBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dsBd);

        }

        private void FrmEquipos_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dsBd.EQUIPOS' Puede moverla o quitarla según sea necesario.
            this.eQUIPOSTableAdapter.Fill(this.dsBd.EQUIPOS);

        }

        private void eQUIPOSDataGridView_DoubleClick(object sender, EventArgs e)
        {
            ModificarCelda();
        }
        private void ModificarCelda()
        {

        }

        private void btnAñadir_Click(object sender, EventArgs e)
        {

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            ModificarCelda();
        }
    }
}
