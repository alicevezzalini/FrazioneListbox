using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrazioneListbox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Add_Click(object sender, EventArgs e)
        {
            Fraction f = Fraction.Parse(textBox1.Text);
            listBox1.Items.Add(f);
        }

        private void RemoveAll_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        private void Somma_Click(object sender, EventArgs e)
        {
            Fraction somma = Fraction.Parse("0/1");
            foreach (Fraction f in listBox1.Items)
            {
                somma = somma.Somma(f);
            }
            label1.Text = somma.ToString();
        }
    }
}
