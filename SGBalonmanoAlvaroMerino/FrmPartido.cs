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
    public partial class FrmPartido : Form
    {
        public FrmPartido()
        {
            InitializeComponent();
        }

        private void FrmPartido_Load(object sender, EventArgs e)
        {

        }

        private void cmbCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbLocal.Enabled = true;
            cmbVisitante.Enabled = true;


        }
    }
}
