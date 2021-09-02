namespace CAIXAELETRÔNICO_Paloma
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lbl3 = new System.Windows.Forms.Label();
            this.lbl4 = new System.Windows.Forms.Label();
            this.lbl5 = new System.Windows.Forms.Label();
            this.lbl10 = new System.Windows.Forms.Label();
            this.lbl25 = new System.Windows.Forms.Label();
            this.lbl40 = new System.Windows.Forms.Label();
            this.lbl100 = new System.Windows.Forms.Label();
            this.lbl500 = new System.Windows.Forms.Label();
            this.lblNotas = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rBMaiorVariedade = new System.Windows.Forms.RadioButton();
            this.rBMenorQuantidade = new System.Windows.Forms.RadioButton();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.lblValor = new System.Windows.Forms.Label();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.Location = new System.Drawing.Point(383, 161);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(59, 13);
            this.lbl3.TabIndex = 23;
            this.lbl3.Text = "Notas de 3";
            // 
            // lbl4
            // 
            this.lbl4.AutoSize = true;
            this.lbl4.Location = new System.Drawing.Point(383, 110);
            this.lbl4.Name = "lbl4";
            this.lbl4.Size = new System.Drawing.Size(59, 13);
            this.lbl4.TabIndex = 22;
            this.lbl4.Text = "Notas de 4";
            // 
            // lbl5
            // 
            this.lbl5.AutoSize = true;
            this.lbl5.Location = new System.Drawing.Point(289, 161);
            this.lbl5.Name = "lbl5";
            this.lbl5.Size = new System.Drawing.Size(59, 13);
            this.lbl5.TabIndex = 21;
            this.lbl5.Text = "Notas de 5";
            // 
            // lbl10
            // 
            this.lbl10.AutoSize = true;
            this.lbl10.Location = new System.Drawing.Point(289, 110);
            this.lbl10.Name = "lbl10";
            this.lbl10.Size = new System.Drawing.Size(65, 13);
            this.lbl10.TabIndex = 20;
            this.lbl10.Text = "Notas de 10";
            // 
            // lbl25
            // 
            this.lbl25.AutoSize = true;
            this.lbl25.Location = new System.Drawing.Point(188, 161);
            this.lbl25.Name = "lbl25";
            this.lbl25.Size = new System.Drawing.Size(65, 13);
            this.lbl25.TabIndex = 19;
            this.lbl25.Text = "Notas de 25";
            // 
            // lbl40
            // 
            this.lbl40.AutoSize = true;
            this.lbl40.Location = new System.Drawing.Point(188, 110);
            this.lbl40.Name = "lbl40";
            this.lbl40.Size = new System.Drawing.Size(65, 13);
            this.lbl40.TabIndex = 18;
            this.lbl40.Text = "Notas de 40";
            // 
            // lbl100
            // 
            this.lbl100.AutoSize = true;
            this.lbl100.Location = new System.Drawing.Point(88, 161);
            this.lbl100.Name = "lbl100";
            this.lbl100.Size = new System.Drawing.Size(71, 13);
            this.lbl100.TabIndex = 17;
            this.lbl100.Text = "Notas de 100";
            // 
            // lbl500
            // 
            this.lbl500.AutoSize = true;
            this.lbl500.Location = new System.Drawing.Point(88, 110);
            this.lbl500.Name = "lbl500";
            this.lbl500.Size = new System.Drawing.Size(71, 13);
            this.lbl500.TabIndex = 16;
            this.lbl500.Text = "Notas de 500";
            // 
            // lblNotas
            // 
            this.lblNotas.AutoSize = true;
            this.lblNotas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNotas.Location = new System.Drawing.Point(12, 127);
            this.lblNotas.Name = "lblNotas";
            this.lblNotas.Size = new System.Drawing.Size(61, 20);
            this.lblNotas.TabIndex = 15;
            this.lblNotas.Text = "Notas:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rBMaiorVariedade);
            this.groupBox1.Controls.Add(this.rBMenorQuantidade);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 44);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(374, 52);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Qual a Preferência?";
            // 
            // rBMaiorVariedade
            // 
            this.rBMaiorVariedade.AutoSize = true;
            this.rBMaiorVariedade.Location = new System.Drawing.Point(241, 21);
            this.rBMaiorVariedade.Name = "rBMaiorVariedade";
            this.rBMaiorVariedade.Size = new System.Drawing.Size(127, 20);
            this.rBMaiorVariedade.TabIndex = 1;
            this.rBMaiorVariedade.TabStop = true;
            this.rBMaiorVariedade.Text = "Maior Variedade";
            this.rBMaiorVariedade.UseVisualStyleBackColor = true;
            this.rBMaiorVariedade.CheckedChanged += new System.EventHandler(this.rBMaiorVariedade_CheckedChanged);
            // 
            // rBMenorQuantidade
            // 
            this.rBMenorQuantidade.AutoSize = true;
            this.rBMenorQuantidade.Location = new System.Drawing.Point(98, 19);
            this.rBMenorQuantidade.Name = "rBMenorQuantidade";
            this.rBMenorQuantidade.Size = new System.Drawing.Size(137, 20);
            this.rBMenorQuantidade.TabIndex = 0;
            this.rBMenorQuantidade.TabStop = true;
            this.rBMenorQuantidade.Text = "Menor Quantidade";
            this.rBMenorQuantidade.UseVisualStyleBackColor = true;
            this.rBMenorQuantidade.CheckedChanged += new System.EventHandler(this.rBMenorQuantidade_CheckedChanged);
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(226, 10);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(226, 20);
            this.txtValor.TabIndex = 13;
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValor.Location = new System.Drawing.Point(12, 9);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(208, 18);
            this.lblValor.TabIndex = 12;
            this.lblValor.Text = "Informe um Valor para Saque: ";
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(392, 62);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(60, 23);
            this.btnLimpar.TabIndex = 24;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 188);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.lbl3);
            this.Controls.Add(this.lbl4);
            this.Controls.Add(this.lbl5);
            this.Controls.Add(this.lbl10);
            this.Controls.Add(this.lbl25);
            this.Controls.Add(this.lbl40);
            this.Controls.Add(this.lbl100);
            this.Controls.Add(this.lbl500);
            this.Controls.Add(this.lblNotas);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.lblValor);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Caixa Eletrônico";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.Label lbl4;
        private System.Windows.Forms.Label lbl5;
        private System.Windows.Forms.Label lbl10;
        private System.Windows.Forms.Label lbl25;
        private System.Windows.Forms.Label lbl40;
        private System.Windows.Forms.Label lbl100;
        private System.Windows.Forms.Label lbl500;
        private System.Windows.Forms.Label lblNotas;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rBMaiorVariedade;
        private System.Windows.Forms.RadioButton rBMenorQuantidade;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.Button btnLimpar;
    }
}

