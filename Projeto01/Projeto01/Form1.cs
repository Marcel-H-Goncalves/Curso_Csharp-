using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto01
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            //Criar novo cliente
            HabilitarCampos();
            LimparCampos();
            txtNome.Focus(); //Ja vai para caixa para digitar nome
            HabilitarBotoes();
            btnNovo.Enabled = false;

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            //Salvar dados
            LimparCampos();
            DesabilitarCampos();
            DesabilitarBotoes();
            btnNovo.Enabled = true;

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            //Excluir Cliente
            LimparCampos();
            DesabilitarCampos();
            DesabilitarBotoes();
            btnNovo.Enabled = true;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            //Limpar tela
            DesabilitarBotoes();
            DesabilitarCampos();
            LimparCampos();
            btnNovo.Enabled = true;
            
        }

        //Metodo desabilita botões
        private void DesabilitarBotoes()
        {
            btnNovo.Enabled = false;
            btnSalvar.Enabled = false;
            btnExcluir.Enabled = false;
            btnCancelar.Enabled = false;
        }

        //Metodo habilita botões
        private void HabilitarBotoes()
        {
            btnNovo.Enabled = true;
            btnSalvar.Enabled = true;
            btnExcluir.Enabled = true;
            btnCancelar.Enabled = true;
        }

        //Metodo Habilitar os campos
        private void HabilitarCampos()
        {
            txtNome.Enabled = true; //Ativa para escrever
            txtEndereco.Enabled = true; //Ativa para escrever
            txtCpf.Enabled = true; //Ativa para escrever
            txtTelefone.Enabled = true; //Ativa para escrever
        }

        //Desabilitar Campos
        private void DesabilitarCampos()
        {
            txtNome.Enabled = false; //Desativa para escrever
            txtEndereco.Enabled = false; //Desativa para escrever
            txtCpf.Enabled = false; //Desativa para escrever
            txtTelefone.Enabled = false; //Desativa para escrever
        }

        //Limpa Campos
        private void LimparCampos()
        {
            txtNome.Text = "";
            txtEndereco.Text = "";
            txtCpf.Text = "";
            txtTelefone.Text = "";
        }

    }//FIM
}
