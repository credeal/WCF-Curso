using Consumindo.ServiceCliente;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Consumindo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string nome = txtNome.Text;

            try
            {
                ClienteServiceClient servico = new ClienteServiceClient();
                Cliente resultado = servico.Buscar(nome);
                txtCpf.Text = resultado.Cpf;
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            string nome = txtNome.Text;
            string cpf = txtCpf.Text;

            try
            {
                ClienteServiceClient servico = new ClienteServiceClient();
                Cliente clienteCadastro = new Cliente();
                clienteCadastro.Nome = nome;
                clienteCadastro.Cpf = cpf;

                servico.Add(clienteCadastro);

                MessageBox.Show("Cliente cadastrado com sucesso.");
            }
            catch (Exception)
            {
                //Log
                throw;
            }
        }
    }
}
