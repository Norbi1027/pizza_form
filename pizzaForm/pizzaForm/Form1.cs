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
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "valami|*.txt";
            saveFileDialog.InitialDirectory = Environment.CurrentDirectory;
            saveFileDialog.FileName = "rendeles.txt";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string eredmenyFajl = saveFileDialog.FileName;
                try
                {
                    using (StreamWriter sw = new StreamWriter(eredmenyFajl))
                    {
                        sw.WriteLine(comboBox_pizza.Text);
                        sw.WriteLine(textBox_darab.Text);
                        
                    }
                }
                catch (Exception)
                {

                    throw;
                }
            }
        }
    }
    }
