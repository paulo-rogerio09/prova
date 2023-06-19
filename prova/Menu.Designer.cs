namespace prova
{
    partial class Menu
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
            this.computador = new System.Windows.Forms.TextBox();
            this.tipo_pagamento = new System.Windows.Forms.ComboBox();
            this.servico = new System.Windows.Forms.ComboBox();
            this.cliente = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.salvar = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.lb_invisivel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // computador
            // 
            this.computador.Location = new System.Drawing.Point(356, 53);
            this.computador.Name = "computador";
            this.computador.Size = new System.Drawing.Size(121, 20);
            this.computador.TabIndex = 0;
            this.computador.TextChanged += new System.EventHandler(this.computador_TextChanged);
            // 
            // tipo_pagamento
            // 
            this.tipo_pagamento.FormattingEnabled = true;
            this.tipo_pagamento.Items.AddRange(new object[] {
            "dinheiro",
            "pix",
            "cartão"});
            this.tipo_pagamento.Location = new System.Drawing.Point(356, 183);
            this.tipo_pagamento.Name = "tipo_pagamento";
            this.tipo_pagamento.Size = new System.Drawing.Size(121, 21);
            this.tipo_pagamento.TabIndex = 2;
            this.tipo_pagamento.SelectedIndexChanged += new System.EventHandler(this.tipo_pagamento_SelectedIndexChanged);
            // 
            // servico
            // 
            this.servico.FormattingEnabled = true;
            this.servico.Items.AddRange(new object[] {
            "formatação",
            "limpeza",
            "troca de peça"});
            this.servico.Location = new System.Drawing.Point(356, 144);
            this.servico.Name = "servico";
            this.servico.Size = new System.Drawing.Size(121, 21);
            this.servico.TabIndex = 3;
            this.servico.SelectedIndexChanged += new System.EventHandler(this.serviço_SelectedIndexChanged);
            // 
            // cliente
            // 
            this.cliente.Location = new System.Drawing.Point(356, 96);
            this.cliente.Name = "cliente";
            this.cliente.Size = new System.Drawing.Size(121, 20);
            this.cliente.TabIndex = 4;
            this.cliente.TextChanged += new System.EventHandler(this.cliente_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(268, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "computador";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(293, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "serviço";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(239, 191);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "tipo de pagamento";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(293, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "cliente";
            // 
            // salvar
            // 
            this.salvar.Location = new System.Drawing.Point(296, 265);
            this.salvar.Name = "salvar";
            this.salvar.Size = new System.Drawing.Size(75, 23);
            this.salvar.TabIndex = 9;
            this.salvar.Text = "salvar";
            this.salvar.UseVisualStyleBackColor = true;
            this.salvar.Click += new System.EventHandler(this.salvar_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(505, 264);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 10;
            this.button2.Text = "cancelar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // lb_invisivel
            // 
            this.lb_invisivel.AutoSize = true;
            this.lb_invisivel.Location = new System.Drawing.Point(306, 232);
            this.lb_invisivel.Name = "lb_invisivel";
            this.lb_invisivel.Size = new System.Drawing.Size(53, 13);
            this.lb_invisivel.TabIndex = 11;
            this.lb_invisivel.Text = "valor total";
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lb_invisivel);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.salvar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cliente);
            this.Controls.Add(this.servico);
            this.Controls.Add(this.tipo_pagamento);
            this.Controls.Add(this.computador);
            this.Name = "Menu";
            this.Text = "Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox computador;
        private System.Windows.Forms.ComboBox tipo_pagamento;
        private System.Windows.Forms.ComboBox servico;
        private System.Windows.Forms.TextBox cliente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button salvar;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lb_invisivel;
    }
}