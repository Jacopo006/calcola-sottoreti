namespace calcola_sottoreti
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.sottoreti = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.host = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.Indirizzoprivato = new System.Windows.Forms.TextBox();
            this.Classe = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // sottoreti
            // 
            this.sottoreti.Location = new System.Drawing.Point(34, 29);
            this.sottoreti.Name = "sottoreti";
            this.sottoreti.Size = new System.Drawing.Size(100, 20);
            this.sottoreti.TabIndex = 0;
            this.sottoreti.TextChanged += new System.EventHandler(this.sottoreti_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "INSERISCI IL NUMERO DI SOTTORETI";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(170, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "INSERISCI IL NUMERO DI HOST";
            // 
            // host
            // 
            this.host.Location = new System.Drawing.Point(34, 68);
            this.host.Name = "host";
            this.host.Size = new System.Drawing.Size(100, 20);
            this.host.TabIndex = 2;
            this.host.TextChanged += new System.EventHandler(this.host_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(239, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 75);
            this.button1.TabIndex = 4;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Indirizzoprivato
            // 
            this.Indirizzoprivato.Location = new System.Drawing.Point(345, 40);
            this.Indirizzoprivato.Name = "Indirizzoprivato";
            this.Indirizzoprivato.Size = new System.Drawing.Size(100, 20);
            this.Indirizzoprivato.TabIndex = 5;
            // 
            // Classe
            // 
            this.Classe.Location = new System.Drawing.Point(345, 68);
            this.Classe.Name = "Classe";
            this.Classe.Size = new System.Drawing.Size(100, 20);
            this.Classe.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Classe);
            this.Controls.Add(this.Indirizzoprivato);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.host);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sottoreti);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox sottoreti;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox host;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox Indirizzoprivato;
        private System.Windows.Forms.TextBox Classe;
    }
}

