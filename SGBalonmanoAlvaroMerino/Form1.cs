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

       private void abrirJugadores()
        {
            FrmJugadores formulario = new FrmJugadores();
            formulario.MdiParent = this;
            formulario.Dock = DockStyle.Fill;
            formulario.Show();
        }

        private void abrirPartido()
        {
            FrmPartido formulario = new FrmPartido();
            formulario.MdiParent = this;
            formulario.Dock = DockStyle.Fill;
            formulario.Show();
        }

        private void abrirInformes()
        {
            FrmInformes formulario = new FrmInformes();
            formulario.MdiParent = this;
            formulario.Dock = DockStyle.Fill;
            formulario.Show();
        }
        private void abrirBusqueda()
        {
            FrmBusqueda formulario = new FrmBusqueda();
            formulario.MdiParent = this;
            formulario.Dock = DockStyle.Fill;
            formulario.Show();
        }


        private void equiposToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult resultado = DialogResult.Yes;
            //comprobamos si hay algo abierto
            if (this.MdiChildren.Length > 0)
            {
                if (this.MdiChildren[0].Name != "FrmEquipos")
                {
                    if (MessageBox.Show("¿Quiere cerrar el formulario actual?", "Información", MessageBoxButtons.YesNo).Equals(resultado))
                    {
                        //cerramos el hijo y abrimos el nuevo
                        abrirEquipos();
                    }
                }
            }
            else abrirEquipos();
            
        }

        private void jugadoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult resultado = DialogResult.Yes;
            //comprobamos si hay algo abierto
            if (this.MdiChildren.Length > 0)
            {
                if (this.MdiChildren[0].Name != "FrmJugadores")
                {
                    if (MessageBox.Show("¿Quiere cerrar el formulario actual?", "Información", MessageBoxButtons.YesNo).Equals(resultado))
                    {
                        //cerramos el hijo y abrimos el nuevo
                        abrirJugadores();
                    }
                }
            }
            else abrirJugadores();
        }

        private void pARTIDOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult resultado = DialogResult.Yes;
            //comprobamos si hay algo abierto
            if (this.MdiChildren.Length > 0)
            {
                if (this.MdiChildren[0].Name != "FrmPartido")
                {
                    if (MessageBox.Show("¿Quiere cerrar el formulario actual?", "Información", MessageBoxButtons.YesNo).Equals(resultado))
                    {
                        //cerramos el hijo y abrimos el nuevo
                        abrirPartido();
                    }
                }
            }
            else abrirPartido();
        }

        private void iNFORMESToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult resultado = DialogResult.Yes;
            //comprobamos si hay algo abierto
            if (this.MdiChildren.Length > 0)
            {
                if (this.MdiChildren[0].Name != "FrmInformes")
                {
                    if (MessageBox.Show("¿Quiere cerrar el formulario actual?", "Información", MessageBoxButtons.YesNo).Equals(resultado))
                    {
                        //cerramos el hijo y abrimos el nuevo
                        abrirInformes();
                    }
                }
            }
            else abrirInformes();
        }

        private void búsquedaPartidosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void informesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            DialogResult resultado = DialogResult.Yes;
            //comprobamos si hay algo abierto
            if (this.MdiChildren.Length > 0)
            {
                if (this.MdiChildren[0].Name != "FrmInformes")
                {
                    if (MessageBox.Show("¿Quiere cerrar el formulario actual?", "Información", MessageBoxButtons.YesNo).Equals(resultado))
                    {
                        //cerramos el hijo y abrimos el nuevo
                        abrirInformes();
                    }
                }
            }
            else abrirInformes();
        }

        private void búsquedaPartidosToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            DialogResult resultado = DialogResult.Yes;
            //comprobamos si hay algo abierto
            if (this.MdiChildren.Length > 0)
            {
                if (this.MdiChildren[0].Name != "FrmInformes")
                {
                    if (MessageBox.Show("¿Quiere cerrar el formulario actual?", "Información", MessageBoxButtons.YesNo).Equals(resultado))
                    {
                        //cerramos el hijo y abrimos el nuevo
                        abrirBusqueda();
                    }
                }
            }
            else abrirBusqueda();
        }

        private void informesToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            DialogResult resultado = DialogResult.Yes;
            //comprobamos si hay algo abierto
            if (this.MdiChildren.Length > 0)
            {
                if (this.MdiChildren[0].Name != "FrmInformes")
                {
                    if (MessageBox.Show("¿Quiere cerrar el formulario actual?", "Información", MessageBoxButtons.YesNo).Equals(resultado))
                    {
                        //cerramos el hijo y abrimos el nuevo
                        abrirInformes();
                    }
                }
            }
            else abrirInformes();
        }
    }
}
