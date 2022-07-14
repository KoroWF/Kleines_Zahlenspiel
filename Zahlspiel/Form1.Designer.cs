namespace Zahlspiel
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
            this.leingabe = new System.Windows.Forms.Label();
            this.lErgebnis = new System.Windows.Forms.Label();
            this.feingabe = new System.Windows.Forms.TextBox();
            this.testanzeige = new System.Windows.Forms.TextBox();
            this.fergebnis = new System.Windows.Forms.TextBox();
            this.deinezahl = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.versuchez = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.bereich1 = new System.Windows.Forms.TextBox();
            this.bereich2 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.tBereich1 = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.tBereich2 = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.ButtonbereichZahlen = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // leingabe
            // 
            this.leingabe.AutoSize = true;
            this.leingabe.Location = new System.Drawing.Point(12, 168);
            this.leingabe.Name = "leingabe";
            this.leingabe.Size = new System.Drawing.Size(54, 13);
            this.leingabe.TabIndex = 0;
            this.leingabe.Text = "Suchzahl:";
            // 
            // lErgebnis
            // 
            this.lErgebnis.AutoSize = true;
            this.lErgebnis.Location = new System.Drawing.Point(12, 269);
            this.lErgebnis.Name = "lErgebnis";
            this.lErgebnis.Size = new System.Drawing.Size(51, 13);
            this.lErgebnis.TabIndex = 1;
            this.lErgebnis.Text = "Ergebnis:";
            // 
            // feingabe
            // 
            this.feingabe.Location = new System.Drawing.Point(141, 161);
            this.feingabe.Name = "feingabe";
            this.feingabe.Size = new System.Drawing.Size(104, 20);
            this.feingabe.TabIndex = 4;
            this.feingabe.Text = "\r\n";
            this.feingabe.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CheckEnter);
            // 
            // testanzeige
            // 
            this.testanzeige.Location = new System.Drawing.Point(141, 375);
            this.testanzeige.Name = "testanzeige";
            this.testanzeige.ReadOnly = true;
            this.testanzeige.Size = new System.Drawing.Size(41, 20);
            this.testanzeige.TabIndex = 5;
            this.testanzeige.Visible = false;
            // 
            // fergebnis
            // 
            this.fergebnis.Location = new System.Drawing.Point(141, 269);
            this.fergebnis.Multiline = true;
            this.fergebnis.Name = "fergebnis";
            this.fergebnis.ReadOnly = true;
            this.fergebnis.Size = new System.Drawing.Size(190, 51);
            this.fergebnis.TabIndex = 7;
            // 
            // deinezahl
            // 
            this.deinezahl.Location = new System.Drawing.Point(256, 161);
            this.deinezahl.Name = "deinezahl";
            this.deinezahl.ReadOnly = true;
            this.deinezahl.Size = new System.Drawing.Size(75, 20);
            this.deinezahl.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 378);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Die gesuchte Zahl ist:";
            this.label2.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Bereichszahlen:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 203);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Versuch Nr.:";
            // 
            // versuchez
            // 
            this.versuchez.Location = new System.Drawing.Point(141, 200);
            this.versuchez.Name = "versuchez";
            this.versuchez.ReadOnly = true;
            this.versuchez.Size = new System.Drawing.Size(41, 20);
            this.versuchez.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(218, 203);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Du hast 20 Versuche! ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(188, 87);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(10, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "-";
            // 
            // bereich1
            // 
            this.bereich1.Location = new System.Drawing.Point(141, 84);
            this.bereich1.Name = "bereich1";
            this.bereich1.Size = new System.Drawing.Size(41, 20);
            this.bereich1.TabIndex = 1;
            this.bereich1.Text = "\r\n";
            // 
            // bereich2
            // 
            this.bereich2.Location = new System.Drawing.Point(204, 84);
            this.bereich2.Name = "bereich2";
            this.bereich2.Size = new System.Drawing.Size(41, 20);
            this.bereich2.TabIndex = 2;
            this.bereich2.Text = "\r\n";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(310, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "Als erstes wählst du deinen Bereich in dem du suchen möchtest.";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 61);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(136, 13);
            this.label9.TabIndex = 20;
            this.label9.Text = "-------------------------------------------";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 240);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(136, 13);
            this.label10.TabIndex = 21;
            this.label10.Text = "-------------------------------------------";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(12, 136);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(136, 13);
            this.label11.TabIndex = 22;
            this.label11.Text = "-------------------------------------------";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(12, 48);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(276, 13);
            this.label12.TabIndex = 23;
            this.label12.Text = "Danach gibst du die Suchzahl ein, bis du es erraten hast.";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(12, 117);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(113, 13);
            this.label13.TabIndex = 25;
            this.label13.Text = "Deine Bereichszahlen:";
            // 
            // tBereich1
            // 
            this.tBereich1.Location = new System.Drawing.Point(141, 114);
            this.tBereich1.Name = "tBereich1";
            this.tBereich1.ReadOnly = true;
            this.tBereich1.Size = new System.Drawing.Size(41, 20);
            this.tBereich1.TabIndex = 100;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(11, 332);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(274, 13);
            this.label14.TabIndex = 26;
            this.label14.Text = "---------------------------------------------------------------------------------" +
    "--------";
            // 
            // tBereich2
            // 
            this.tBereich2.Location = new System.Drawing.Point(204, 114);
            this.tBereich2.Name = "tBereich2";
            this.tBereich2.ReadOnly = true;
            this.tBereich2.Size = new System.Drawing.Size(41, 20);
            this.tBereich2.TabIndex = 27;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(188, 117);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(10, 13);
            this.label15.TabIndex = 28;
            this.label15.Text = "-";
            // 
            // ButtonbereichZahlen
            // 
            this.ButtonbereichZahlen.Location = new System.Drawing.Point(256, 82);
            this.ButtonbereichZahlen.Name = "ButtonbereichZahlen";
            this.ButtonbereichZahlen.Size = new System.Drawing.Size(75, 52);
            this.ButtonbereichZahlen.TabIndex = 3;
            this.ButtonbereichZahlen.Text = "Bereich Speichern";
            this.ButtonbereichZahlen.UseVisualStyleBackColor = true;
            this.ButtonbereichZahlen.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ButtonbereichZahlen_MouseClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(279, 373);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(52, 23);
            this.button1.TabIndex = 30;
            this.button1.Text = "Debug";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.button1_MouseClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(188, 13);
            this.label5.TabIndex = 101;
            this.label5.Text = "Die Bereichzahl beginnt ab der Zahl 1.";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(343, 410);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ButtonbereichZahlen);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.tBereich2);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.tBereich1);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.bereich2);
            this.Controls.Add(this.bereich1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.versuchez);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.deinezahl);
            this.Controls.Add(this.fergebnis);
            this.Controls.Add(this.testanzeige);
            this.Controls.Add(this.feingabe);
            this.Controls.Add(this.lErgebnis);
            this.Controls.Add(this.leingabe);
            this.Name = "Form1";
            this.Text = "Zahlenspiel";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label leingabe;
        private System.Windows.Forms.Label lErgebnis;
        private System.Windows.Forms.TextBox feingabe;
        private System.Windows.Forms.TextBox testanzeige;
        private System.Windows.Forms.TextBox fergebnis;
        private System.Windows.Forms.TextBox deinezahl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox versuchez;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox bereich1;
        private System.Windows.Forms.TextBox bereich2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox tBereich1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox tBereich2;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button ButtonbereichZahlen;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
    }
}

