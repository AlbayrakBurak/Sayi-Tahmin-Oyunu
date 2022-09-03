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

namespace Gorsel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string sayi;
        string birinci, ikinci, ucuncu, dorduncu;
        int sayac = 1;
        

        private void button2_Click(object sender, EventArgs e)
        {
            String tahmin_et = textBox1.Text;

            birinci_tahmin = tahmin_et.Substring(0, 1);
            ikinci_tahmin = tahmin_et.Substring(1, 1);
            ucuncu_tahmin = tahmin_et.Substring(2, 1);
            dorduncu_tahmin = tahmin_et.Substring(3, 1);

            if (birinci_tahmin == ikinci_tahmin)
                MessageBox.Show("Lütfen Rakamları Farklı Sayı Giriniz");
            else if (birinci_tahmin == ucuncu_tahmin)
                MessageBox.Show("Lütfen Rakamları Farklı Sayı Giriniz"); 
            else if (birinci_tahmin == dorduncu_tahmin)
                MessageBox.Show("Lütfen Rakamları Farklı Sayı Giriniz");
            else if (ikinci_tahmin == ucuncu_tahmin)
                MessageBox.Show("Lütfen Rakamları Farklı Sayı Giriniz");
            else if (ikinci_tahmin == dorduncu_tahmin)
                MessageBox.Show("Lütfen Rakamları Farklı Sayı Giriniz");
            if (ucuncu_tahmin == dorduncu_tahmin)
                MessageBox.Show("Lütfen Rakamları Farklı Sayı Giriniz");
        else
            {
                string a = sayi;
                string b = tahmin_et;
                int artiPuan = 0;
                int eksiPuan = 0;

                sayac++;

                for(int k=0; k<4; k++)
                {
                    if (a.Substring(k, 1) == b.Substring(k, 1))
                        artiPuan += 1;

                    if ((a.IndexOf(b.Substring(k, 1)) > -1) && ((a.IndexOf(b.Substring(k, 1)) != k)))
                        eksiPuan++;
                }
                if(artiPuan !=4)
                {
                    label3.Text = Convert.ToString("+" + artiPuan + " - " + eksiPuan);
                }
                else if (artiPuan == 4)
                {
                    label3.Text = "+4-0";
                    MessageBox.Show(sayac + ". Denemede Sayıyı buldun. Tebrikler!");
                    button2.Enabled = false;
                    button1.Enabled = true;
                    button3.Enabled = false;
                }
            }
        
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label4.Visible = true;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        string birinci_tahmin, ikinci_tahmin, ucuncu_tahmin, dorduncu_tahmin;

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Burak ALBAYRAK İyi şanslar diler...");
            Random rastgeleSayi = new Random();
            button2.Enabled = true;
            button1.Enabled = true;
            button3.Enabled = true;
            label4.Visible = false;
            textBox1.Enabled = true;

            sayac = 0;
           
            for (int k = 0; k < 500; k++)
            {
                sayi = rastgeleSayi.Next(1023, 9876).ToString();
                birinci = sayi.Substring(0, 1);
                ikinci = sayi.Substring(1, 1);
                ucuncu = sayi.Substring(2, 1);
                dorduncu = sayi.Substring(3, 1);
            }
            if (birinci != ikinci && birinci != ucuncu && birinci != dorduncu && ikinci != ucuncu && ikinci != dorduncu && ucuncu != dorduncu)
            {
                label4.Text = sayi;
            }
            else
                for (int k = 0; k < 500; k++)
                {
                    sayi = rastgeleSayi.Next(1023, 9876).ToString();
                    birinci = sayi.Substring(0, 1);
                    ikinci = sayi.Substring(1, 1);
                    ucuncu = sayi.Substring(2, 1);
                    dorduncu = sayi.Substring(3, 1);
                }
            if (birinci != ikinci && birinci != ucuncu && birinci != dorduncu && ikinci != ucuncu && ikinci != dorduncu && ucuncu != dorduncu)
            {
                label4.Text = sayi;
            }
            else
                for (int k = 0; k < 500; k++)
                {
                    sayi = rastgeleSayi.Next(1023, 9876).ToString();
                    birinci = sayi.Substring(0, 1);
                    ikinci = sayi.Substring(1, 1);
                    ucuncu = sayi.Substring(2, 1);
                    dorduncu = sayi.Substring(3, 1);
                }
            if (birinci != ikinci && birinci != ucuncu && birinci != dorduncu && ikinci != ucuncu && ikinci != dorduncu && ucuncu != dorduncu)
            {
                label4.Text = sayi;
            }
            else
                for (int k = 0; k < 500; k++)
                {
                    sayi = rastgeleSayi.Next(1023, 9876).ToString();
                    birinci = sayi.Substring(0, 1);
                    ikinci = sayi.Substring(1, 1);
                    ucuncu = sayi.Substring(2, 1);
                    dorduncu = sayi.Substring(3, 1);
                }
        }
    }
}
