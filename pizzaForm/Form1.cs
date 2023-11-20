using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pizzaForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_atlag_Click(object sender, EventArgs e)
        {
            double atlag = 0;
            foreach (Pizza item in listBox1.Items)
            {
                atlag += item.Par;
            }
            atlag = atlag / listBox1.Items.Count;
            textBox_atlag.Text = atlag.ToString();
        }
        public void adatbetoltes()
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "vesszövel tagolt csv|*.csv|txt files (*.txt)|*.txt|All files (*.*)|*.*";
            openFileDialog1.FilterIndex = 0;
            openFileDialog1.Title = "Adatfile neve";
            openFileDialog1.InitialDirectory = Environment.CurrentDirectory;
            
            if (openFileDialog1.ShowDialog(this) == DialogResult.OK)
            {
                using (StreamReader sr = new StreamReader(openFileDialog1.FileName))
                {
                    sr.ReadLine();
                    while (!sr.EndOfStream)
                    {
                        listBox1.Items.Add(new Pizza(sr.ReadLine()));
                    }
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox_pizza.SelectedIndex = 0;
            adatbetoltes();
        }

        private void textBox_darab_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void button_rendeles_Click(object sender, EventArgs e)
        {
            string kartyavkezpenz;
            if (radioButton_kartya.Checked)
            {
                kartyavkezpenz = "Kártyás";
            }
            else
            {
                kartyavkezpenz = "Kézpénzes";
            }
            string szamla;
            if (checkBox_szamla.Checked == true)
            {
                szamla = "Számlát kér!";
            }
            else
            {
                szamla = "Számlát nem kér!";
            }

                try
                {
                    using (StreamWriter sw = File.AppendText("rendeles.txt"))
                    {
                        sw.WriteLine($"{comboBox_pizza.Text} | {textBox_darab.Text} | {kartyavkezpenz} | {szamla}");
                        
                        
                    }
                MessageBox.Show("Sikeresen leadta a rendelést!");
                }
                catch (Exception)
                {

                    throw;
                }
            }
        }
    }
