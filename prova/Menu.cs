using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prova
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void salvar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(computador.Text + cliente.Text + servico.Text + tipo_pagamento);
        }

        private void computador_TextChanged(object sender, EventArgs e)
        {

        }

        private void cliente_TextChanged(object sender, EventArgs e)
        {

        }

        private void serviço_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tipo_pagamento_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
