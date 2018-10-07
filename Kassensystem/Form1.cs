using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kassensystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public static List<Tuple<string, int>> produkte = new List<Tuple<string, int>>();
        public static List<float> preisListe = new List<float>();
        private float price = 0.00f;
        private int id = 0;





        private void button1_Click(object sender, EventArgs e)
        {
            Control.SelectedIndex = 1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Control.SelectedIndex = 0;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Control.Size = new Size(1075, 741);
        }

        private void Brezel_Click(object sender, EventArgs e)
        {
            addProd("Brezel", "1.20€", 1.20f);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            addProd("Brötchen", "0.60€", 0.60f);
        }


        private void updatePreis() {
            PreiseValue.Text = price.ToString("0.00") + "€";
            PreisLabel2.Text = price.ToString("0.00") + "€";
        }



        private void addProd(string name, string preis, float fpreis) {
            id += 1;
            produkte.Add(new Tuple<string, int>(name, id));
            price += fpreis;
            preisListe.Add(fpreis);
            updatePreis();
            string leer;
            if (id >= 10) {
                leer = "    ";
            } else {
                leer = "      ";
            }
            ProdukteBox.AppendText("\r\n " + id + "." + leer + name + " - " + preis);
            ProdukteBox.ScrollToCaret();
            ProdukteBox.Refresh();
        }

        private void prodIDRemoveBtn_Click(object sender, EventArgs e)
        {
            if (!(prodIDremoveText.Text == "")) {
                int outParse;
                if (int.TryParse(prodIDremoveText.Text, out outParse)) {
                    int prodIDremoveInt = int.Parse(prodIDremoveText.Text);


                    if (!(produkte.Count < prodIDremoveInt) && !(ProdukteBox.Lines.Length < prodIDremoveInt))
                    {
                        prodIDremoveText.Text = "";
                        IDErrorLabel.Visible = false;
                        //produkte.RemoveAt(prodIDremoveInt);
                        //ProdukteBox.Text.Remove(prodIDremoveInt, ProdukteBox.Lines.GetLength(prodIDremoveInt));

                        /*ProdukteBox.Lines = ProdukteBox.Lines.Where(line => !line.Contains(prodIDremoveInt.ToString())).ToArray();
                        String newText = String.Empty;
                        List<String> lines = ProdukteBox.Text.Split(new String[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries).ToList();
                        lines.RemoveAll(str => str.Contains(prodIDremoveInt.ToString()));
                        lines.ForEach(str => newText += str + Environment.NewLine);
                        ProdukteBox.Text = newText;*/

                        DeleteLine(prodIDremoveInt);


                        //var lines = (from item in ProdukteBox.Text.Split('\n') select item.Trim());
                        //lines = lines.Skip(prodIDremoveInt);
                        //ProdukteBox.Text = string.Join("\r\n", lines.ToArray());
                    }
                    else
                    {
                        IDErrorLabel.Visible = true;
                    }
                }
            }
        }

        private void DeleteLine(int a_line)
        {
            try{
                int start_index = ProdukteBox.GetFirstCharIndexFromLine(a_line);
                int count = ProdukteBox.Lines[a_line].Length;

                // Eat new line chars
                if (a_line < ProdukteBox.Lines.Length - 1)
                {
                    count += ProdukteBox.GetFirstCharIndexFromLine(a_line + 1) -
                        ((start_index + count - 1) + 1);
                }
                string lastPart = ProdukteBox.Lines[a_line].Split('-').Last();
                if (lastPart != null)
                {
                    IDErrorLabel.Visible = false;
                    lastPart = lastPart.Remove(lastPart.Length - 1);
                    price -= float.Parse(lastPart, System.Globalization.CultureInfo.InvariantCulture);
                    updatePreis();

                    ProdukteBox.Text = ProdukteBox.Text.Remove(start_index, count);
                    ProdukteBox.Refresh();
                    IDErrorLabel.Visible = false;
                }
                else
                {
                    IDErrorLabel.Visible = true;
                }
            }
            catch {
                IDErrorLabel.Visible = true;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ProdukteBox.Text = "";
            price = 0.00f;
            updatePreis();
            prodIDremoveText.Text = "";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Control.SelectedIndex = 2;
            setPreisFloatValue();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        float preis;

        private void setPreisFloatValue() {
            preis = price;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            price = preis;
            int outParse;
            if (int.TryParse(textBox1.Text, out outParse))
            {
                price -= float.Parse(textBox1.Text, System.Globalization.CultureInfo.InvariantCulture);
                RückgeldLabel.Text = price.ToString("0.00") + "€";
            }
        }

        private void LBrötchen_Click(object sender, EventArgs e)
        {
            addProd("Laugenbrötchen", "0.80€", 0.80f);
        }
    }
}
