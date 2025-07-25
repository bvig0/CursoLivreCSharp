﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Padaria
{
    public partial class frmGerenciaFuncionarios : Form
    {
        //Criando variáveis para controle do menu
        const int MF_BYCOMMAND = 0X400;
        [DllImport("user32")]
        static extern int RemoveMenu(IntPtr hMenu, int nPosition, int wFlags);
        [DllImport("user32")]
        static extern IntPtr GetSystemMenu(IntPtr hWnd, bool bRevert);
        [DllImport("user32")]
        static extern int GetMenuItemCount(IntPtr hWnd);

        public frmGerenciaFuncionarios()
        {
            InitializeComponent();
            desabilitarCampos();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            frmMenuPrincipal abrir = new frmMenuPrincipal();
            abrir.Show();
            this.Hide();    
        }

        private void frmGerenciaFuncionarios_Load(object sender, EventArgs e)
        {
            IntPtr hMenu = GetSystemMenu(this.Handle, false);
            int MenuCount = GetMenuItemCount(hMenu) - 1;
            RemoveMenu(hMenu, MenuCount, MF_BYCOMMAND);
        }

        public void desabilitarCampos()
        {
            // Campos de texto
            txtNome.Enabled = false;
            txtEmail.Enabled = false;
            txtEndereco.Enabled = false;
            txtNumero.Enabled = false;
            txtCidade.Enabled = false;
            txtComplemento.Enabled = false;
            mskTelefone.Enabled = false;
            mskCPF.Enabled = false;
            mskCEP.Enabled = false;
            cbbEstado.Enabled = false;

            // botões
            btnAlterar.Enabled = false;
            btnCadastrar.Enabled = false;
            btnExcluir.Enabled = false;
            btnLimpar.Enabled = false;

            btnNovo.Enabled = true;
            btnPesquisar.Enabled = true;
            btnVoltar.Enabled = true;
        }

        public void habilitarCamposNovo()
        {
            // Campos de texto
            txtNome.Enabled = true;
            txtEmail.Enabled = true;
            txtEndereco.Enabled = true;
            txtNumero.Enabled = true;
            txtCidade.Enabled = true;
            txtComplemento.Enabled = true;
            mskTelefone.Enabled = true;
            mskCPF.Enabled = true;
            mskCEP.Enabled = true;
            cbbEstado.Enabled = true;

            // botões
            btnAlterar.Enabled = false;
            btnCadastrar.Enabled = true;
            btnExcluir.Enabled = false;
            btnLimpar.Enabled = true;

            btnNovo.Enabled = false;
            btnPesquisar.Enabled = true;
            btnVoltar.Enabled = true;

            txtNome.Focus();
        }

        public void habilitarCamposPesquisar()
        {
            // Campos de texto
            txtNome.Enabled = true;
            txtEmail.Enabled = true;
            txtEndereco.Enabled = true;
            txtNumero.Enabled = true;
            txtCidade.Enabled = true;
            txtComplemento.Enabled = true;
            mskTelefone.Enabled = true;
            mskCPF.Enabled = true;
            mskCEP.Enabled = true;
            cbbEstado.Enabled = true;

            // botões
            btnAlterar.Enabled = true;
            btnCadastrar.Enabled = false;
            btnExcluir.Enabled = true;
            btnLimpar.Enabled = true;

            btnNovo.Enabled = false;
            btnPesquisar.Enabled = true;
            btnVoltar.Enabled = true;

            txtNome.Focus();
        }

        public void limparCampos()
        {
            // Campos de texto
            txtNome.Clear();
            txtEmail.Clear();
            txtEndereco.Clear();
            txtNumero.Clear();
            txtCidade.Clear();
            txtComplemento.Clear();
            mskTelefone.Text = "";
            mskCPF.Text = "";
            mskCEP.Text = "";
            cbbEstado.Text = "";

        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            habilitarCamposNovo();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {

            if (txtNome.Text.Equals("") ||
                txtEmail.Text.Equals("") ||
                txtEndereco.Text.Equals("") ||
                txtNumero.Text.Equals("") ||
                txtCidade.Text.Equals("") ||
                txtComplemento.Text.Equals("") ||
                cbbEstado.Text.Equals("") ||
                mskTelefone.Text.Equals("(  )      -") ||
                mskCPF.Text.Equals("   .   .   -") ||
                mskCEP.Text.Equals("     -") )
            {
                MessageBox.Show("Por favor, preencer os campos!");
            }

            else
            {
            MessageBox.Show("Cadastrado com sucesso!!");
            desabilitarCampos();
            limparCampos();
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            limparCampos();
            txtNome.Focus();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            habilitarCamposPesquisar();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Deseja excluir?",
                "Mensagem do Sistema", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            if (dr == DialogResult.Yes)
            {
                MessageBox.Show("Excluido com sucesso!!",
                "Mensagem do Sistema", MessageBoxButtons.OK,
                MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                desabilitarCampos();
                limparCampos();
            }
        else
            {
                txtNome.Focus();
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Alterado com sucesso!!",
                "Mensagem do Sistema", MessageBoxButtons.OK,
                MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            desabilitarCampos();
            limparCampos();
        }
    }
}
