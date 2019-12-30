using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoCadastro
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.FixedDialog;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Cadastro chamarCadastro = new Cadastro();
            this.Hide();
            chamarCadastro.ShowDialog();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
