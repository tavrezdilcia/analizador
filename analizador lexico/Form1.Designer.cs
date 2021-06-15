namespace analizador_lexico
{
    partial class Form1
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
            this.codigo = new System.Windows.Forms.TextBox();
            this.TOKEN_LEXEMA = new System.Windows.Forms.DataGridView();
            this.Token = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Lexema = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.analisis = new System.Windows.Forms.Button();
            this.salir = new System.Windows.Forms.Button();
            this.limpiar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.TOKEN_LEXEMA)).BeginInit();
            this.SuspendLayout();
            // 
            // codigo
            // 
            this.codigo.Location = new System.Drawing.Point(28, 65);
            this.codigo.Multiline = true;
            this.codigo.Name = "codigo";
            this.codigo.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.codigo.Size = new System.Drawing.Size(318, 257);
            this.codigo.TabIndex = 0;
            this.codigo.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // TOKEN_LEXEMA
            // 
            this.TOKEN_LEXEMA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TOKEN_LEXEMA.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Token,
            this.Lexema});
            this.TOKEN_LEXEMA.Location = new System.Drawing.Point(352, 65);
            this.TOKEN_LEXEMA.Name = "TOKEN_LEXEMA";
            this.TOKEN_LEXEMA.Size = new System.Drawing.Size(248, 257);
            this.TOKEN_LEXEMA.TabIndex = 1;
            this.TOKEN_LEXEMA.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Token
            // 
            this.Token.HeaderText = "Token";
            this.Token.Name = "Token";
            // 
            // Lexema
            // 
            this.Lexema.HeaderText = "Lexema";
            this.Lexema.Name = "Lexema";
            // 
            // analisis
            // 
            this.analisis.Location = new System.Drawing.Point(606, 216);
            this.analisis.Name = "analisis";
            this.analisis.Size = new System.Drawing.Size(102, 23);
            this.analisis.TabIndex = 2;
            this.analisis.Text = "Analisis Léxico";
            this.analisis.UseVisualStyleBackColor = true;
            this.analisis.Click += new System.EventHandler(this.analisis_Click);
            // 
            // salir
            // 
            this.salir.Location = new System.Drawing.Point(606, 300);
            this.salir.Name = "salir";
            this.salir.Size = new System.Drawing.Size(102, 23);
            this.salir.TabIndex = 3;
            this.salir.Text = "Salir";
            this.salir.UseVisualStyleBackColor = true;
            this.salir.Click += new System.EventHandler(this.salir_Click);
            // 
            // limpiar
            // 
            this.limpiar.Location = new System.Drawing.Point(606, 259);
            this.limpiar.Name = "limpiar";
            this.limpiar.Size = new System.Drawing.Size(102, 23);
            this.limpiar.TabIndex = 4;
            this.limpiar.Text = "Limpiar Tabla";
            this.limpiar.UseVisualStyleBackColor = true;
            this.limpiar.Click += new System.EventHandler(this.limpiar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(31, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(253, 33);
            this.label1.TabIndex = 5;
            this.label1.Text = "Código a Analizar ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(716, 336);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.limpiar);
            this.Controls.Add(this.salir);
            this.Controls.Add(this.analisis);
            this.Controls.Add(this.TOKEN_LEXEMA);
            this.Controls.Add(this.codigo);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.TOKEN_LEXEMA)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox codigo;
        private System.Windows.Forms.DataGridView TOKEN_LEXEMA;
        private System.Windows.Forms.DataGridViewTextBoxColumn Token;
        private System.Windows.Forms.DataGridViewTextBoxColumn Lexema;
        private System.Windows.Forms.Button analisis;
        private System.Windows.Forms.Button salir;
        private System.Windows.Forms.Button limpiar;
        private System.Windows.Forms.Label label1;
    }
}

