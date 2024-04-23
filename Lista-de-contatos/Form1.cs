using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lista_de_contatos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonincluir_Click(object sender, EventArgs e)
        {
            Class1 contato = new Class1();
            contato.Nome = textboxnome.Text;
            contato.Sobrenome = textboxsobrenome.Text;
            contato.Telefone = textboxtelefone.Text;

            listboxcontatos.Items.Add(contato.ToString());

        }
    }
}
