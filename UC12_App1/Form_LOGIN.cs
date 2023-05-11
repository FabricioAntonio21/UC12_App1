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
    public partial class Form_LOGIN : Form
    {
        public Form_LOGIN()
        {
            InitializeComponent();
        }

        private void button_ENTRAR_Click(object sender, EventArgs e)
        {
            Class_VARIAVEIS.usuario = textBox_USUARIO.Text;

            Form telaPRINCIPAL = new Form_PRINCIPAL();
            telaPRINCIPAL.Show();

            checkBox_ADM.Checked = false;
            
        }

        private void checkBox_ADM_CheckedChanged(object sender, EventArgs e)
        {
            Class_VARIAVEIS.adm = "adm";
        }
    }
}
