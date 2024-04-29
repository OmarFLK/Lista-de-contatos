using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Lista_de_contatos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private Class1[] contatos = new Class1[1];

        private void Escrever(Class1 contato) 
        {
            StreamWriter escreveremarquivo = new StreamWriter("Contatos.txt");
            escreveremarquivo.WriteLine(contatos.Length + 1);
            escreveremarquivo.WriteLine(contato.Nome);
            escreveremarquivo.WriteLine(contato.Sobrenome);
            escreveremarquivo.WriteLine(contato.Telefone);

            for (int x = 0; x < contatos.Length; x++)
            {
                escreveremarquivo.WriteLine(contatos[x].Nome);
                escreveremarquivo.WriteLine(contatos[x].Sobrenome);
                escreveremarquivo.WriteLine(contatos[x].Telefone);
            }
            escreveremarquivo.Close();
        }

        private void ler() 
        {
            StreamReader lerarquivo = new StreamReader("Contatos.txt");
            contatos = new Class1[Convert.ToInt32(lerarquivo.ReadLine())];

            for (int x = 0; x < contatos.Length; x++)
            {
                contatos[x] = new Class1();
                contatos[x].Nome = lerarquivo.ReadLine();
                contatos[x].Sobrenome = lerarquivo.ReadLine();
                contatos[x].Telefone = lerarquivo.ReadLine();
            }
            lerarquivo.Close();
        }

        //atualiza a tela do programa com os contatos
        private void Exibir()
        {
            //limpa a lista de contatos
            listboxcontatos.Items.Clear();
            for (int x = 0; x < contatos.Length; x++)
            {
                listboxcontatos.Items.Add(contatos[x].ToString());
            }
        }

        private void limparformulario()
        {
            textboxnome.Text = String.Empty;
            textboxsobrenome.Text = String.Empty;   
            textboxtelefone.Text = String.Empty;
        }

       
         private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonincluir_Click(object sender, EventArgs e)
        {
            //cria um objeto da classe contato
            Class1 contato = new Class1();
            contato.Nome = textboxnome.Text;
            contato.Sobrenome = textboxsobrenome.Text;
            contato.Telefone = textboxtelefone.Text;

            //listboxcontatos.Items.Add(contato.ToString());

            Escrever(contato);
            ler();
            Exibir();
            limparformulario();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ler();
            Exibir();
        }
    }
}
