using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UC12_App1
{
    public partial class Form_PRINCIPAL : Form
    {
        public Form_PRINCIPAL()
        {
            InitializeComponent();
            MessageBox.Show(Class_VARIAVEIS.usuario);

            if (Class_VARIAVEIS.adm != "adm")
            {
                cadastroToolStripMenuItem.Visible = false;
            } else
            {
                cadastroToolStripMenuItem.Visible = true;
            }
        }

        private void cadastroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form telaCADASTRO = new Form_CADASTRO();
            telaCADASTRO.MdiParent = this;
            telaCADASTRO.WindowState = FormWindowState.Maximized;
            telaCADASTRO.Show();
           

        }

        private void relatorioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form telaRELATORIO = new Form_RELATORIO();
            telaRELATORIO.MdiParent = this;
            telaRELATORIO.WindowState = FormWindowState.Maximized;
            telaRELATORIO.Show();
        }

        private void Form_PRINCIPAL_FormClosed(object sender, FormClosedEventArgs e)
        {
            Class_VARIAVEIS.adm = "";
            
        }
    }
}
