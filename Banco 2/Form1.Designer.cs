﻿namespace Banco_2
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.textoTitular = new System.Windows.Forms.TextBox();
            this.textoSaldo = new System.Windows.Forms.TextBox();
            this.textoNumero = new System.Windows.Forms.TextBox();
            this.textoValor = new System.Windows.Forms.TextBox();
            this.botaoDeposita = new System.Windows.Forms.Button();
            this.botaoSaque = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Conta = new System.Windows.Forms.GroupBox();
            this.botaoNovaConta = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.botaoBusca = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboContas = new System.Windows.Forms.ComboBox();
            this.botaoImpostos = new System.Windows.Forms.Button();
            this.Conta.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textoTitular
            // 
            this.textoTitular.Location = new System.Drawing.Point(100, 37);
            this.textoTitular.Name = "textoTitular";
            this.textoTitular.Size = new System.Drawing.Size(117, 20);
            this.textoTitular.TabIndex = 0;
            this.textoTitular.TextChanged += new System.EventHandler(this.textoTitular_TextChanged);
            // 
            // textoSaldo
            // 
            this.textoSaldo.Location = new System.Drawing.Point(100, 145);
            this.textoSaldo.Name = "textoSaldo";
            this.textoSaldo.Size = new System.Drawing.Size(117, 20);
            this.textoSaldo.TabIndex = 1;
            this.textoSaldo.TextChanged += new System.EventHandler(this.textoSaldo_TextChanged);
            // 
            // textoNumero
            // 
            this.textoNumero.Location = new System.Drawing.Point(100, 90);
            this.textoNumero.Name = "textoNumero";
            this.textoNumero.Size = new System.Drawing.Size(117, 20);
            this.textoNumero.TabIndex = 2;
            this.textoNumero.TextChanged += new System.EventHandler(this.textoNumero_TextChanged);
            // 
            // textoValor
            // 
            this.textoValor.Location = new System.Drawing.Point(100, 194);
            this.textoValor.Name = "textoValor";
            this.textoValor.Size = new System.Drawing.Size(117, 20);
            this.textoValor.TabIndex = 3;
            // 
            // botaoDeposita
            // 
            this.botaoDeposita.Location = new System.Drawing.Point(160, 236);
            this.botaoDeposita.Name = "botaoDeposita";
            this.botaoDeposita.Size = new System.Drawing.Size(75, 23);
            this.botaoDeposita.TabIndex = 4;
            this.botaoDeposita.Text = "Depositar";
            this.botaoDeposita.UseVisualStyleBackColor = true;
            this.botaoDeposita.Click += new System.EventHandler(this.botaoDeposita_Click);
            // 
            // botaoSaque
            // 
            this.botaoSaque.Location = new System.Drawing.Point(84, 236);
            this.botaoSaque.Name = "botaoSaque";
            this.botaoSaque.Size = new System.Drawing.Size(75, 23);
            this.botaoSaque.TabIndex = 5;
            this.botaoSaque.Text = "Sacar";
            this.botaoSaque.UseVisualStyleBackColor = true;
            this.botaoSaque.Click += new System.EventHandler(this.botaoSaque_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Titular";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Número";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Saldo";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 197);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Valor";
            // 
            // Conta
            // 
            this.Conta.Controls.Add(this.botaoImpostos);
            this.Conta.Controls.Add(this.botaoNovaConta);
            this.Conta.Controls.Add(this.textoSaldo);
            this.Conta.Controls.Add(this.label4);
            this.Conta.Controls.Add(this.textoTitular);
            this.Conta.Controls.Add(this.label3);
            this.Conta.Controls.Add(this.textoNumero);
            this.Conta.Controls.Add(this.label2);
            this.Conta.Controls.Add(this.textoValor);
            this.Conta.Controls.Add(this.label1);
            this.Conta.Controls.Add(this.botaoDeposita);
            this.Conta.Controls.Add(this.botaoSaque);
            this.Conta.Location = new System.Drawing.Point(12, 91);
            this.Conta.Name = "Conta";
            this.Conta.Size = new System.Drawing.Size(316, 265);
            this.Conta.TabIndex = 11;
            this.Conta.TabStop = false;
            this.Conta.Text = "Conta";
            // 
            // botaoNovaConta
            // 
            this.botaoNovaConta.Location = new System.Drawing.Point(235, 236);
            this.botaoNovaConta.Name = "botaoNovaConta";
            this.botaoNovaConta.Size = new System.Drawing.Size(75, 23);
            this.botaoNovaConta.TabIndex = 11;
            this.botaoNovaConta.Text = "Nova Conta";
            this.botaoNovaConta.UseVisualStyleBackColor = true;
            this.botaoNovaConta.Click += new System.EventHandler(this.botaoNovaConta_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 45);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Escolha a conta";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // botaoBusca
            // 
            this.botaoBusca.Location = new System.Drawing.Point(235, 40);
            this.botaoBusca.Name = "botaoBusca";
            this.botaoBusca.Size = new System.Drawing.Size(75, 23);
            this.botaoBusca.TabIndex = 13;
            this.botaoBusca.Text = "Atualizar";
            this.botaoBusca.UseVisualStyleBackColor = true;
            this.botaoBusca.Click += new System.EventHandler(this.botaoBusca_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboContas);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.botaoBusca);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(316, 73);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Busca de conta";
            // 
            // comboContas
            // 
            this.comboContas.FormattingEnabled = true;
            this.comboContas.Location = new System.Drawing.Point(100, 42);
            this.comboContas.Name = "comboContas";
            this.comboContas.Size = new System.Drawing.Size(121, 21);
            this.comboContas.TabIndex = 14;
            this.comboContas.SelectedIndexChanged += new System.EventHandler(this.comboContas_SelectedIndexChanged);
            // 
            // botaoImpostos
            // 
            this.botaoImpostos.Location = new System.Drawing.Point(9, 236);
            this.botaoImpostos.Name = "botaoImpostos";
            this.botaoImpostos.Size = new System.Drawing.Size(75, 23);
            this.botaoImpostos.TabIndex = 12;
            this.botaoImpostos.Text = "Impostos";
            this.botaoImpostos.UseVisualStyleBackColor = true;
            this.botaoImpostos.Click += new System.EventHandler(this.botaoImpostos_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 359);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Conta);
            this.Name = "Form1";
            this.Text = "Conta";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Conta.ResumeLayout(false);
            this.Conta.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox textoTitular;
        private System.Windows.Forms.TextBox textoSaldo;
        private System.Windows.Forms.TextBox textoNumero;
        private System.Windows.Forms.TextBox textoValor;
        private System.Windows.Forms.Button botaoDeposita;
        private System.Windows.Forms.Button botaoSaque;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox Conta;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button botaoBusca;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboContas;
        private System.Windows.Forms.Button botaoNovaConta;
        private System.Windows.Forms.Button botaoImpostos;
    }
}

