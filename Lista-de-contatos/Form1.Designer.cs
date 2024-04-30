namespace Lista_de_contatos
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
            this.textboxnome = new System.Windows.Forms.TextBox();
            this.textboxsobrenome = new System.Windows.Forms.TextBox();
            this.textboxtelefone = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonincluir = new System.Windows.Forms.Button();
            this.listboxcontatos = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textboxnome
            // 
            this.textboxnome.Location = new System.Drawing.Point(81, 12);
            this.textboxnome.Name = "textboxnome";
            this.textboxnome.Size = new System.Drawing.Size(207, 20);
            this.textboxnome.TabIndex = 1;
            this.textboxnome.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textboxsobrenome
            // 
            this.textboxsobrenome.Location = new System.Drawing.Point(81, 61);
            this.textboxsobrenome.Name = "textboxsobrenome";
            this.textboxsobrenome.Size = new System.Drawing.Size(207, 20);
            this.textboxsobrenome.TabIndex = 2;
            // 
            // textboxtelefone
            // 
            this.textboxtelefone.Location = new System.Drawing.Point(81, 103);
            this.textboxtelefone.Name = "textboxtelefone";
            this.textboxtelefone.Size = new System.Drawing.Size(207, 20);
            this.textboxtelefone.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nome";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Sobrenome";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Telefone";
            // 
            // buttonincluir
            // 
            this.buttonincluir.BackColor = System.Drawing.Color.Yellow;
            this.buttonincluir.Location = new System.Drawing.Point(12, 141);
            this.buttonincluir.Name = "buttonincluir";
            this.buttonincluir.Size = new System.Drawing.Size(163, 130);
            this.buttonincluir.TabIndex = 7;
            this.buttonincluir.Text = "Incluir";
            this.buttonincluir.UseVisualStyleBackColor = false;
            this.buttonincluir.Click += new System.EventHandler(this.buttonincluir_Click);
            // 
            // listboxcontatos
            // 
            this.listboxcontatos.FormattingEnabled = true;
            this.listboxcontatos.Location = new System.Drawing.Point(355, 12);
            this.listboxcontatos.Name = "listboxcontatos";
            this.listboxcontatos.Size = new System.Drawing.Size(308, 264);
            this.listboxcontatos.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Yellow;
            this.button1.Location = new System.Drawing.Point(181, 141);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(163, 130);
            this.button1.TabIndex = 9;
            this.button1.Text = "organizar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cyan;
            this.ClientSize = new System.Drawing.Size(670, 283);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listboxcontatos);
            this.Controls.Add(this.buttonincluir);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textboxtelefone);
            this.Controls.Add(this.textboxsobrenome);
            this.Controls.Add(this.textboxnome);
            this.Name = "Form1";
            this.Text = "ListaDeContatos";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textboxnome;
        private System.Windows.Forms.TextBox textboxsobrenome;
        private System.Windows.Forms.TextBox textboxtelefone;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonincluir;
        private System.Windows.Forms.ListBox listboxcontatos;
        private System.Windows.Forms.Button button1;
    }
}

