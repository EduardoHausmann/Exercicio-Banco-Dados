﻿using System;
using System.Windows.Forms;

namespace Principal
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void btnPeixes_Click(object sender, EventArgs e)
        {
            frmPeixes peixes = new frmPeixes();
            peixes.ShowDialog();
        }

        private void btnColaboradores_Click(object sender, EventArgs e)
        {
            frmColaboradores colaboradores = new frmColaboradores();
            colaboradores.ShowDialog();
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            frmClientes clientes = new frmClientes();
            clientes.ShowDialog();
        }
    }
}
