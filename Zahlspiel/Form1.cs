using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zahlspiel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            int count = 1;
            versuchez.Text = count.ToString();
        }

        private void ButtonbereichZahlen_MouseClick(object sender, MouseEventArgs e)
        {

            uint b1uint;
            uint b2uint;

            int utest;
            string Bereich1 = bereich1.Text;
            int.TryParse(Bereich1, out utest);
            uint.TryParse(Bereich1, out b1uint);
            uint.TryParse(bereich2.Text, out b2uint);

            int b1int = Convert.ToInt32(b1uint);
            int b2int = Convert.ToInt32(b2uint);

            tBereich1.Text = Convert.ToString(b1int);
            tBereich2.Text = Convert.ToString(b2int);


            String bereichtext1 = bereich1.Text;
            String bereichtext2 = bereich2.Text;
            string text = "";

            if (utest < 1 || bereichtext1 == text && bereichtext2 == text)
            {
                bereich1.Text = "1";
                bereich2.Text = "100";
                tBereich1.Text = "1";
                tBereich2.Text = "100";
                fergebnis.Text = "Nur Zahlen ab 1+ und keine Buchstaben!";
                Random myObject = new Random();
                int random = myObject.Next(1, 100);
                testanzeige.Text = random.ToString();
            }
            else if (b1int < b2int)
            {
                Random myObject = new Random();
                int random = myObject.Next(b1int, b2int);
                testanzeige.Text = random.ToString();
                bereich1.Clear();
                bereich2.Clear();
                feingabe.Text = "0";
                bereich1.Visible = false;
                bereich2.Visible = false;
                label3.Visible = false;
                label7.Visible = false;
                ButtonbereichZahlen.Visible = false;
            }
            else
            {

                DialogResult res = MessageBox.Show("Die linke Zahl muss immer kleiner als die rechte Zahl sein und darf kein Buchstabe sein!");
                bereich1.Clear();
                bereich2.Clear();
                tBereich1.Clear();
                tBereich2.Clear();
            }
        }

        private void CheckEnter(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                // Convertiert den Counter vom Main über die Textbox in den bereich
                int count = Convert.ToInt16(versuchez.Text);

                // Speichert die eingegebene Zahl zwischen und zeigt diese in deinezahl.Text an
                deinezahl.Text = feingabe.Text;
                String debugtext = feingabe.Text;
                string text = "";

                uint b1int;
                uint b2int;
                String b1 = tBereich1.Text;
                uint.TryParse(b1, out b1int);
                String b2 = tBereich2.Text;
                uint.TryParse(b2, out b2int);

                //Berechnungsabzeilung nimmt eingegeben Zahl, wandelt diese in Int um und vergleicht.
                //Speichert die eingegebene Zahl in extra Fenster und bereinigt nach eingabe das eingebefenster.
                int eingabe;
                int.TryParse(feingabe.Text, out eingabe);
                int random;
                string anzeige = testanzeige.Text;
                int.TryParse(anzeige, out random);

                if (b1int == 0 && b2int == 0)
                {
                    fergebnis.Text = "Gebe erst oben ein Bereich an!";
                    deinezahl.Clear();
                }
                else if (eingabe < b1int || eingabe > b2int || debugtext == text)
                {
                    fergebnis.Text = "Zahlen von " + b1int + " - " + b2int + ", keine Buchstaben!";
                    deinezahl.Clear();
                }
                else
                {
                    if (count <= 20)
                    {
                        if (count == 20)
                        {
                            DialogResult res = MessageBox.Show("Du hast alle 20 Versuche verbraucht. Du hast verloren");
                            Application.Restart();
                            Environment.Exit(0);
                        }

                        if (eingabe == random)
                        {


                            fergebnis.Text = ".~° Glücksstrumpf °~.";

                            lErgebnis.Visible = true;
                            fergebnis.Visible = true;
                            DialogResult res = MessageBox.Show("Du hast das Spiel gewonnen und brauchtest dazu " + versuchez.Text + " versuche.");

                            Application.Restart();
                            Environment.Exit(0);
                        }
                        else if (eingabe > random)
                        {

                            fergebnis.Text = "Das Ergebnis ist Kleiner";
                            lErgebnis.Visible = true;
                            fergebnis.Visible = true;
                            feingabe.Clear();

                        }
                        else if (eingabe < random)
                        {

                            fergebnis.Text = "Das Ergebnis ist Größer!";
                            lErgebnis.Visible = true;
                            fergebnis.Visible = true;
                            feingabe.Clear();
                        }


                        count++;

                        versuchez.Text = count.ToString();

                    }

                }

                feingabe.Clear();
            }

        }

        private void button1_MouseClick(object sender, MouseEventArgs e)
        {
            //Debug anfrage zum Anschalten und Auschalten der Ergebnissanzeige unten!

            if (testanzeige.Visible == false)
            {
                testanzeige.Visible = true;
                label2.Visible = true;
                bereich1.Visible = true;
                bereich2.Visible = true;
                label3.Visible = true;
                label7.Visible = true;
                ButtonbereichZahlen.Visible = true;
            }
            else if (testanzeige.Visible == true)
            {
                testanzeige.Visible = false;
                label2.Visible = false;
                bereich1.Visible = false;
                bereich2.Visible = false;
                label3.Visible = false;
                label7.Visible = false;
                ButtonbereichZahlen.Visible = false;
            }
        }
    }
}