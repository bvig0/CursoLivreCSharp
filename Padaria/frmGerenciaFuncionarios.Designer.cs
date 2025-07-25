﻿namespace Padaria
{
    partial class frmGerenciaFuncionarios
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGerenciaFuncionarios));
            this.gpbgerenciaFuncionarios = new System.Windows.Forms.GroupBox();
            this.cbbEstado = new System.Windows.Forms.ComboBox();
            this.mskCEP = new System.Windows.Forms.MaskedTextBox();
            this.mskCPF = new System.Windows.Forms.MaskedTextBox();
            this.mskTelefone = new System.Windows.Forms.MaskedTextBox();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.txtComplemento = new System.Windows.Forms.TextBox();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.gpbgerenciaFuncionarios.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpbgerenciaFuncionarios
            // 
            this.gpbgerenciaFuncionarios.Controls.Add(this.cbbEstado);
            this.gpbgerenciaFuncionarios.Controls.Add(this.mskCEP);
            this.gpbgerenciaFuncionarios.Controls.Add(this.mskCPF);
            this.gpbgerenciaFuncionarios.Controls.Add(this.mskTelefone);
            this.gpbgerenciaFuncionarios.Controls.Add(this.txtCidade);
            this.gpbgerenciaFuncionarios.Controls.Add(this.txtComplemento);
            this.gpbgerenciaFuncionarios.Controls.Add(this.txtNumero);
            this.gpbgerenciaFuncionarios.Controls.Add(this.txtEndereco);
            this.gpbgerenciaFuncionarios.Controls.Add(this.txtEmail);
            this.gpbgerenciaFuncionarios.Controls.Add(this.label10);
            this.gpbgerenciaFuncionarios.Controls.Add(this.label9);
            this.gpbgerenciaFuncionarios.Controls.Add(this.label8);
            this.gpbgerenciaFuncionarios.Controls.Add(this.label7);
            this.gpbgerenciaFuncionarios.Controls.Add(this.label6);
            this.gpbgerenciaFuncionarios.Controls.Add(this.label5);
            this.gpbgerenciaFuncionarios.Controls.Add(this.label4);
            this.gpbgerenciaFuncionarios.Controls.Add(this.label3);
            this.gpbgerenciaFuncionarios.Controls.Add(this.label2);
            this.gpbgerenciaFuncionarios.Controls.Add(this.txtNome);
            this.gpbgerenciaFuncionarios.Controls.Add(this.label1);
            this.gpbgerenciaFuncionarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbgerenciaFuncionarios.Location = new System.Drawing.Point(1, 12);
            this.gpbgerenciaFuncionarios.Name = "gpbgerenciaFuncionarios";
            this.gpbgerenciaFuncionarios.Size = new System.Drawing.Size(784, 441);
            this.gpbgerenciaFuncionarios.TabIndex = 0;
            this.gpbgerenciaFuncionarios.TabStop = false;
            this.gpbgerenciaFuncionarios.Text = "Dados pessoais";
            // 
            // cbbEstado
            // 
            this.cbbEstado.FormattingEnabled = true;
            this.cbbEstado.Location = new System.Drawing.Point(605, 261);
            this.cbbEstado.Name = "cbbEstado";
            this.cbbEstado.Size = new System.Drawing.Size(121, 28);
            this.cbbEstado.TabIndex = 10;
            // 
            // mskCEP
            // 
            this.mskCEP.Location = new System.Drawing.Point(607, 186);
            this.mskCEP.Mask = "99999-999";
            this.mskCEP.Name = "mskCEP";
            this.mskCEP.Size = new System.Drawing.Size(88, 26);
            this.mskCEP.TabIndex = 7;
            // 
            // mskCPF
            // 
            this.mskCPF.Location = new System.Drawing.Point(219, 125);
            this.mskCPF.Mask = "999,999,999-00";
            this.mskCPF.Name = "mskCPF";
            this.mskCPF.Size = new System.Drawing.Size(122, 26);
            this.mskCPF.TabIndex = 4;
            // 
            // mskTelefone
            // 
            this.mskTelefone.Location = new System.Drawing.Point(33, 125);
            this.mskTelefone.Mask = "(00) 99999-9999";
            this.mskTelefone.Name = "mskTelefone";
            this.mskTelefone.Size = new System.Drawing.Size(127, 26);
            this.mskTelefone.TabIndex = 3;
            // 
            // txtCidade
            // 
            this.txtCidade.Location = new System.Drawing.Point(405, 263);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(126, 26);
            this.txtCidade.TabIndex = 9;
            // 
            // txtComplemento
            // 
            this.txtComplemento.Location = new System.Drawing.Point(33, 263);
            this.txtComplemento.Name = "txtComplemento";
            this.txtComplemento.Size = new System.Drawing.Size(313, 26);
            this.txtComplemento.TabIndex = 8;
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(405, 186);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(126, 26);
            this.txtNumero.TabIndex = 6;
            // 
            // txtEndereco
            // 
            this.txtEndereco.Location = new System.Drawing.Point(33, 186);
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(308, 26);
            this.txtEndereco.TabIndex = 5;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(456, 61);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(270, 26);
            this.txtEmail.TabIndex = 2;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(622, 240);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(60, 20);
            this.label10.TabIndex = 0;
            this.label10.Text = "Estado";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(399, 240);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 20);
            this.label9.TabIndex = 0;
            this.label9.Text = "Cidade";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(34, 240);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(108, 20);
            this.label8.TabIndex = 0;
            this.label8.Text = "Complemento";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(622, 163);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 20);
            this.label7.TabIndex = 0;
            this.label7.Text = "CEP";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(401, 163);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "Número";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 163);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Endereço";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(215, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "CPF";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Telefone";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(452, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "E-mail";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(33, 61);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(308, 26);
            this.txtNome.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome";
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnVoltar);
            this.panel1.Controls.Add(this.btnLimpar);
            this.panel1.Controls.Add(this.btnPesquisar);
            this.panel1.Controls.Add(this.btnExcluir);
            this.panel1.Controls.Add(this.btnAlterar);
            this.panel1.Controls.Add(this.btnCadastrar);
            this.panel1.Controls.Add(this.btnNovo);
            this.panel1.Location = new System.Drawing.Point(1, 459);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(784, 103);
            this.panel1.TabIndex = 11;
            // 
            // btnVoltar
            // 
            this.btnVoltar.Image = ((System.Drawing.Image)(resources.GetObject("btnVoltar.Image")));
            this.btnVoltar.Location = new System.Drawing.Point(672, 46);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(104, 44);
            this.btnVoltar.TabIndex = 18;
            this.btnVoltar.Text = "&Voltar";
            this.btnVoltar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnVoltar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Image = ((System.Drawing.Image)(resources.GetObject("btnLimpar.Image")));
            this.btnLimpar.Location = new System.Drawing.Point(562, 46);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(104, 44);
            this.btnLimpar.TabIndex = 17;
            this.btnLimpar.Text = "&Limpar";
            this.btnLimpar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLimpar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Image = ((System.Drawing.Image)(resources.GetObject("btnPesquisar.Image")));
            this.btnPesquisar.Location = new System.Drawing.Point(452, 46);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(104, 44);
            this.btnPesquisar.TabIndex = 16;
            this.btnPesquisar.Text = "&Pesquisar";
            this.btnPesquisar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPesquisar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Image = ((System.Drawing.Image)(resources.GetObject("btnExcluir.Image")));
            this.btnExcluir.Location = new System.Drawing.Point(342, 46);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(104, 44);
            this.btnExcluir.TabIndex = 15;
            this.btnExcluir.Text = "&Excluir";
            this.btnExcluir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExcluir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.Image = ((System.Drawing.Image)(resources.GetObject("btnAlterar.Image")));
            this.btnAlterar.Location = new System.Drawing.Point(232, 46);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(104, 44);
            this.btnAlterar.TabIndex = 14;
            this.btnAlterar.Text = "&Alterar";
            this.btnAlterar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAlterar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCadastrar.Image")));
            this.btnCadastrar.Location = new System.Drawing.Point(122, 46);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(104, 44);
            this.btnCadastrar.TabIndex = 13;
            this.btnCadastrar.Text = "&Cadastrar";
            this.btnCadastrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCadastrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // btnNovo
            // 
            this.btnNovo.Image = ((System.Drawing.Image)(resources.GetObject("btnNovo.Image")));
            this.btnNovo.Location = new System.Drawing.Point(12, 46);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(104, 44);
            this.btnNovo.TabIndex = 12;
            this.btnNovo.Text = "&Novo";
            this.btnNovo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNovo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // frmGerenciaFuncionarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.gpbgerenciaFuncionarios);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmGerenciaFuncionarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gerencia Funcionários";
            this.Load += new System.EventHandler(this.frmGerenciaFuncionarios_Load);
            this.gpbgerenciaFuncionarios.ResumeLayout(false);
            this.gpbgerenciaFuncionarios.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbgerenciaFuncionarios;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.MaskedTextBox mskCEP;
        private System.Windows.Forms.MaskedTextBox mskCPF;
        private System.Windows.Forms.MaskedTextBox mskTelefone;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.TextBox txtComplemento;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.TextBox txtEndereco;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbbEstado;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Button btnNovo;
    }
}