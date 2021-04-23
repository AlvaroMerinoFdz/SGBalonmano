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
    public partial class FrmJugadores : Form
    {
        public FrmJugadores()
        {
            InitializeComponent();
        }

        private void jUGADORESBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.jUGADORESBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dsBd);

        }

        private void FrmJugadores_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dsBd.EQUIPOS' Puede moverla o quitarla según sea necesario.
            this.eQUIPOSTableAdapter.Fill(this.dsBd.EQUIPOS);
            // TODO: esta línea de código carga datos en la tabla 'dsBd.JUGADORES' Puede moverla o quitarla según sea necesario.
            this.jUGADORESTableAdapter.Fill(this.dsBd.JUGADORES);

        }

        private void btnImagen_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofdImagen = new OpenFileDialog();
            ofdImagen.Filter = "image files| *.jpg;*.png;*.gif;*.ico;";
            DialogResult resultado = ofdImagen.ShowDialog();
            if (resultado == DialogResult.Abort) return;
            if (resultado == DialogResult.Cancel) return;
            //Mostramos la imagen en el picturebox directamente de la ruta devuelta por el openFileDialog
            fotoPictureBox.Image = Image.FromFile(ofdImagen.FileName);
        }
    }
}
