using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace uygulama_15_
{
    public partial class Form1 : Form
    {
        int etiketFiyati;
        Double indirimliFiyat;
       
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            etiketFiyati = Convert.ToInt32(txtFiyat.Text);
            indirimliFiyat=etiketFiyati-etiketFiyati*0.10;
            MessageBox.Show(indirimliFiyat.ToString());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            etiketFiyati = Convert.ToInt32(txtFiyat.Text);
            indirimliFiyat = etiketFiyati - etiketFiyati * 0.25;
            MessageBox.Show(indirimliFiyat.ToString());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            etiketFiyati = Convert.ToInt32(txtFiyat.Text);
            indirimliFiyat = etiketFiyati - etiketFiyati * 0.50;
            MessageBox.Show(indirimliFiyat.ToString());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            etiketFiyati = Convert.ToInt32(txtFiyat.Text);
            indirimliFiyat = etiketFiyati - etiketFiyati * 0.75;











            MessageBox.Show(indirimliFiyat.ToString());
        }
    }
}
