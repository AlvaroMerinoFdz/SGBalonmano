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
    public partial class FrmAgregarEquipo : Form
    {
        public FrmAgregarEquipo()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofdImagen = new OpenFileDialog();
            ofdImagen.Filter = "image files| *.jpg;*.png;*.gif;*.ico;";
            DialogResult resultado = ofdImagen.ShowDialog();
            if (resultado == DialogResult.Abort) return;
            if (resultado == DialogResult.Cancel) return;
            //Mostramos la imagen en el picturebox directamente de la ruta devuelta por el openFileDialog
            pcbImagen.Image = Image.FromFile(ofdImagen.FileName);
        }

        private void FrmAgregarEquipo_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dsBd.EQUIPOS' Puede moverla o quitarla según sea necesario.
            this.eQUIPOSTableAdapter.Fill(this.dsBd.EQUIPOS);

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            //nombre, pabellon, categoria, escudo
            var nombre = txtNombre.Text.ToUpper().Trim();
            var pabellon = txtPabellon.Text.Trim();
            var categoria = cmbCategoria.SelectedItem;
            var escudo = pcbImagen.Image;

            using(dsBd dsBd = new dsBd())
            {
                if(nombre.Equals(String.Empty) || pabellon.Equals(String.Empty))
                {
                    MessageBox.Show("No puede haber campos vacíos.");
                }
            }

        }
    }
}
