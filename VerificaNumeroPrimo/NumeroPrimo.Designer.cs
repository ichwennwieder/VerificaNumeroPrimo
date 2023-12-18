namespace VerificaNumeroPrimo
{
    partial class TxtNumero
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lbPrimo = new Label();
            txtPrimo = new TextBox();
            btnEnviar = new Button();
            lbSoma = new Label();
            btnSoma = new Button();
            txtSoma = new TextBox();
            SuspendLayout();
            // 
            // lbPrimo
            // 
            lbPrimo.AutoSize = true;
            lbPrimo.Location = new Point(26, 30);
            lbPrimo.Name = "lbPrimo";
            lbPrimo.Size = new Size(233, 15);
            lbPrimo.TabIndex = 0;
            lbPrimo.Text = "Insira um número para verificar se é primo:";
            // 
            // txtPrimo
            // 
            txtPrimo.Location = new Point(26, 62);
            txtPrimo.Name = "txtPrimo";
            txtPrimo.Size = new Size(218, 23);
            txtPrimo.TabIndex = 1;
            txtPrimo.TextChanged += textBox1_TextChanged;
            // 
            // btnEnviar
            // 
            btnEnviar.Location = new Point(263, 62);
            btnEnviar.Name = "btnEnviar";
            btnEnviar.Size = new Size(75, 23);
            btnEnviar.TabIndex = 2;
            btnEnviar.Text = "Enviar";
            btnEnviar.UseVisualStyleBackColor = true;
            btnEnviar.Click += btnEnviar_Click;
            // 
            // lbSoma
            // 
            lbSoma.AutoSize = true;
            lbSoma.Location = new Point(26, 105);
            lbSoma.Name = "lbSoma";
            lbSoma.Size = new Size(150, 15);
            lbSoma.TabIndex = 3;
            lbSoma.Text = "Digite um número superior";
            // 
            // btnSoma
            // 
            btnSoma.Location = new Point(263, 134);
            btnSoma.Name = "btnSoma";
            btnSoma.Size = new Size(75, 23);
            btnSoma.TabIndex = 5;
            btnSoma.Text = "Enviar";
            btnSoma.UseVisualStyleBackColor = true;
            btnSoma.Click += btnSoma_Click;
            // 
            // txtSoma
            // 
            txtSoma.Location = new Point(26, 134);
            txtSoma.Name = "txtSoma";
            txtSoma.Size = new Size(218, 23);
            txtSoma.TabIndex = 4;
            // 
            // TxtNumero
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSoma);
            Controls.Add(txtSoma);
            Controls.Add(lbSoma);
            Controls.Add(btnEnviar);
            Controls.Add(txtPrimo);
            Controls.Add(lbPrimo);
            Name = "TxtNumero";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbPrimo;
        private TextBox txtPrimo;
        private Button btnEnviar;
        private Label lbSoma;
        private Button btnSoma;
        private TextBox txtSoma;
    }
}
