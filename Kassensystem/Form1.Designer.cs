namespace Kassensystem
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.Control = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.IDErrorLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.prodIDRemoveBtn = new System.Windows.Forms.Button();
            this.prodIDremoveText = new System.Windows.Forms.TextBox();
            this.PreiseValue = new System.Windows.Forms.Label();
            this.Preis = new System.Windows.Forms.Label();
            this.ProdukteBox = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button3 = new System.Windows.Forms.Button();
            this.Brezel = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.button6 = new System.Windows.Forms.Button();
            this.RückgeldLabel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.PreisLabel2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.LBrötchen = new System.Windows.Forms.Button();
            this.Control.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // Control
            // 
            this.Control.Controls.Add(this.tabPage1);
            this.Control.Controls.Add(this.tabPage2);
            this.Control.Controls.Add(this.tabPage3);
            this.Control.Location = new System.Drawing.Point(-4, -3);
            this.Control.Multiline = true;
            this.Control.Name = "Control";
            this.Control.SelectedIndex = 0;
            this.Control.Size = new System.Drawing.Size(1075, 720);
            this.Control.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(73)))), ((int)(((byte)(81)))));
            this.tabPage1.Controls.Add(this.button5);
            this.tabPage1.Controls.Add(this.button4);
            this.tabPage1.Controls.Add(this.IDErrorLabel);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.prodIDRemoveBtn);
            this.tabPage1.Controls.Add(this.prodIDremoveText);
            this.tabPage1.Controls.Add(this.PreiseValue);
            this.tabPage1.Controls.Add(this.Preis);
            this.tabPage1.Controls.Add(this.ProdukteBox);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1067, 694);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Kasse";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(856, 636);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(95, 44);
            this.button5.TabIndex = 12;
            this.button5.Text = "Fertig";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(957, 636);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(95, 44);
            this.button4.TabIndex = 11;
            this.button4.Text = "Abbrechen";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // IDErrorLabel
            // 
            this.IDErrorLabel.AutoSize = true;
            this.IDErrorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IDErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.IDErrorLabel.Location = new System.Drawing.Point(578, 488);
            this.IDErrorLabel.Name = "IDErrorLabel";
            this.IDErrorLabel.Size = new System.Drawing.Size(103, 15);
            this.IDErrorLabel.TabIndex = 10;
            this.IDErrorLabel.Text = "ID nicht gefunden";
            this.IDErrorLabel.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(577, 447);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 15);
            this.label1.TabIndex = 9;
            this.label1.Text = "Produkt entfernen";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // prodIDRemoveBtn
            // 
            this.prodIDRemoveBtn.Location = new System.Drawing.Point(580, 516);
            this.prodIDRemoveBtn.Name = "prodIDRemoveBtn";
            this.prodIDRemoveBtn.Size = new System.Drawing.Size(100, 23);
            this.prodIDRemoveBtn.TabIndex = 8;
            this.prodIDRemoveBtn.Text = "Entfernen";
            this.prodIDRemoveBtn.UseVisualStyleBackColor = true;
            this.prodIDRemoveBtn.Click += new System.EventHandler(this.prodIDRemoveBtn_Click);
            // 
            // prodIDremoveText
            // 
            this.prodIDremoveText.Location = new System.Drawing.Point(580, 465);
            this.prodIDremoveText.Name = "prodIDremoveText";
            this.prodIDremoveText.Size = new System.Drawing.Size(100, 20);
            this.prodIDremoveText.TabIndex = 7;
            // 
            // PreiseValue
            // 
            this.PreiseValue.AutoSize = true;
            this.PreiseValue.Font = new System.Drawing.Font("Consolas", 14.25F);
            this.PreiseValue.ForeColor = System.Drawing.Color.White;
            this.PreiseValue.Location = new System.Drawing.Point(79, 575);
            this.PreiseValue.Name = "PreiseValue";
            this.PreiseValue.Size = new System.Drawing.Size(60, 22);
            this.PreiseValue.TabIndex = 6;
            this.PreiseValue.Text = "0.00€";
            // 
            // Preis
            // 
            this.Preis.AutoSize = true;
            this.Preis.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Preis.ForeColor = System.Drawing.Color.White;
            this.Preis.Location = new System.Drawing.Point(12, 574);
            this.Preis.Name = "Preis";
            this.Preis.Size = new System.Drawing.Size(70, 22);
            this.Preis.TabIndex = 5;
            this.Preis.Text = "Preis:";
            // 
            // ProdukteBox
            // 
            this.ProdukteBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(143)))), ((int)(((byte)(155)))));
            this.ProdukteBox.Location = new System.Drawing.Point(12, 41);
            this.ProdukteBox.Name = "ProdukteBox";
            this.ProdukteBox.Size = new System.Drawing.Size(550, 498);
            this.ProdukteBox.TabIndex = 4;
            this.ProdukteBox.Text = "";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(186)))), ((int)(((byte)(193)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(580, 41);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(472, 72);
            this.button1.TabIndex = 2;
            this.button1.Text = "Produkte";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(73)))), ((int)(((byte)(81)))));
            this.tabPage2.Controls.Add(this.LBrötchen);
            this.tabPage2.Controls.Add(this.button3);
            this.tabPage2.Controls.Add(this.Brezel);
            this.tabPage2.Controls.Add(this.button2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1067, 694);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Produkte";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(160, 67);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(122, 48);
            this.button3.TabIndex = 2;
            this.button3.Text = "Brötchen (0.60€)";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Brezel
            // 
            this.Brezel.Location = new System.Drawing.Point(6, 67);
            this.Brezel.Name = "Brezel";
            this.Brezel.Size = new System.Drawing.Size(122, 48);
            this.Brezel.TabIndex = 1;
            this.Brezel.Text = "Brezel (1,20€)";
            this.Brezel.UseVisualStyleBackColor = true;
            this.Brezel.Click += new System.EventHandler(this.Brezel_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(186)))), ((int)(((byte)(193)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(6, 6);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(91, 30);
            this.button2.TabIndex = 0;
            this.button2.Text = "Zurück";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(73)))), ((int)(((byte)(81)))));
            this.tabPage3.Controls.Add(this.button6);
            this.tabPage3.Controls.Add(this.RückgeldLabel);
            this.tabPage3.Controls.Add(this.label6);
            this.tabPage3.Controls.Add(this.textBox1);
            this.tabPage3.Controls.Add(this.label4);
            this.tabPage3.Controls.Add(this.PreisLabel2);
            this.tabPage3.Controls.Add(this.label3);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1067, 694);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Rechnung";
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(426, 254);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(252, 23);
            this.button6.TabIndex = 13;
            this.button6.Text = "Abrechnung";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // RückgeldLabel
            // 
            this.RückgeldLabel.AutoSize = true;
            this.RückgeldLabel.Font = new System.Drawing.Font("Consolas", 14.25F);
            this.RückgeldLabel.ForeColor = System.Drawing.Color.White;
            this.RückgeldLabel.Location = new System.Drawing.Point(519, 186);
            this.RückgeldLabel.Name = "RückgeldLabel";
            this.RückgeldLabel.Size = new System.Drawing.Size(60, 22);
            this.RückgeldLabel.TabIndex = 12;
            this.RückgeldLabel.Text = "0.00€";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(422, 186);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 22);
            this.label6.TabIndex = 11;
            this.label6.Text = "Rückgeld:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(523, 133);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(83, 20);
            this.textBox1.TabIndex = 10;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Consolas", 14.25F);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(432, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 22);
            this.label4.TabIndex = 9;
            this.label4.Text = "Gegeben:";
            // 
            // PreisLabel2
            // 
            this.PreisLabel2.AutoSize = true;
            this.PreisLabel2.Font = new System.Drawing.Font("Consolas", 14.25F);
            this.PreisLabel2.ForeColor = System.Drawing.Color.White;
            this.PreisLabel2.Location = new System.Drawing.Point(519, 83);
            this.PreisLabel2.Name = "PreisLabel2";
            this.PreisLabel2.Size = new System.Drawing.Size(60, 22);
            this.PreisLabel2.TabIndex = 8;
            this.PreisLabel2.Text = "0.00€";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(432, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 22);
            this.label3.TabIndex = 7;
            this.label3.Text = "Preis:";
            // 
            // LBrötchen
            // 
            this.LBrötchen.Location = new System.Drawing.Point(315, 67);
            this.LBrötchen.Name = "LBrötchen";
            this.LBrötchen.Size = new System.Drawing.Size(122, 48);
            this.LBrötchen.TabIndex = 3;
            this.LBrötchen.Text = "Laugenbrötchen (0.80€)";
            this.LBrötchen.UseVisualStyleBackColor = true;
            this.LBrötchen.Click += new System.EventHandler(this.LBrötchen_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1064, 711);
            this.Controls.Add(this.Control);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kassensystem";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Control.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl Control;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button Brezel;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.RichTextBox ProdukteBox;
        private System.Windows.Forms.Label Preis;
        private System.Windows.Forms.Label PreiseValue;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button prodIDRemoveBtn;
        private System.Windows.Forms.TextBox prodIDremoveText;
        private System.Windows.Forms.Label IDErrorLabel;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label PreisLabel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label RückgeldLabel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button LBrötchen;
    }
}

