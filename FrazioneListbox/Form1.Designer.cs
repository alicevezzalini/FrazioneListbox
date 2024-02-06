namespace FrazioneListbox
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.Add = new System.Windows.Forms.Button();
            this.RemoveAll = new System.Windows.Forms.Button();
            this.Somma = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(350, 126);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(117, 147);
            this.listBox1.TabIndex = 0;
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(523, 173);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(62, 24);
            this.Add.TabIndex = 1;
            this.Add.Text = "button1";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // RemoveAll
            // 
            this.RemoveAll.Location = new System.Drawing.Point(521, 203);
            this.RemoveAll.Name = "RemoveAll";
            this.RemoveAll.Size = new System.Drawing.Size(61, 24);
            this.RemoveAll.TabIndex = 2;
            this.RemoveAll.Text = "button1";
            this.RemoveAll.UseVisualStyleBackColor = true;
            this.RemoveAll.Click += new System.EventHandler(this.RemoveAll_Click);
            // 
            // Somma
            // 
            this.Somma.Location = new System.Drawing.Point(521, 233);
            this.Somma.Name = "Somma";
            this.Somma.Size = new System.Drawing.Size(64, 27);
            this.Somma.TabIndex = 3;
            this.Somma.Text = "button1";
            this.Somma.UseVisualStyleBackColor = true;
            this.Somma.Click += new System.EventHandler(this.Somma_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(359, 312);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "label1";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(510, 131);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(123, 20);
            this.textBox1.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Somma);
            this.Controls.Add(this.RemoveAll);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.listBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Button RemoveAll;
        private System.Windows.Forms.Button Somma;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
    }
}

