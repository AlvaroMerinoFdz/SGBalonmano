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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void sALIRToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void abrirEquipos()
        {
            FrmEquipos frmEquipos = new FrmEquipos();
            frmEquipos.MdiParent = this;
            frmEquipos.Dock = DockStyle.Fill;
            frmEquipos.Show();
        }

        private void equiposToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //comprobamos si hay algo abierto
            if (this.MdiChildren.Length > 0)
            {
                if (this.MdiChildren[0].Name != "FrmEquipos")
                {
                    if (MessageBox.Show("¿Quiere cerrar el formulario actual?", "Información", MessageBoxButtons.YesNo).Equals("Yes"))
                    {
                        //cerramos el hijo y abrimos el nuevo
                        abrirEquipos();
                    }
                }
            }
            else abrirEquipos();
            
        }
    }
}
