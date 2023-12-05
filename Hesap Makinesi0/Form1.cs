using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace Hesap_Makinesi0
{
    public partial class Form1 : Form
    {

        private bool sil;
        double x, y;
        string islem;
        List<string> history = new List<string>();
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (sil)
            {
                textBox1.Text = "";
                sil = false;
            }

            if (textBox1.Text == "0")
            {
                textBox1.Text = "1";
            }
            else
            {
                textBox1.Text += "1";
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (sil)
            {
                textBox1.Text = "";
                sil = false;
            }

            if (textBox1.Text == "0")
            {
                textBox1.Text = "2";
            }
            else
            {
                textBox1.Text += "2";
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (sil)
            {
                textBox1.Text = "";
                sil = false;
            }
            if (textBox1.Text == "0")
            {
                textBox1.Text = "3";
            }
            else
            {
                textBox1.Text += "3";
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (sil)
            {
                textBox1.Text = "";
                sil = false;
            }
            if (textBox1.Text == "0")
            {
                textBox1.Text = "4";
            }
            else
            {
                textBox1.Text += "4";
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (sil)
            {
                textBox1.Text = "";
                sil = false;
            }
            if (textBox1.Text == "0")
            {
                textBox1.Text = "5";
            }
            else
            {
                textBox1.Text += "5";
            }

        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (sil)
            {
                textBox1.Text = "";
                sil = false;
            }
            if (textBox1.Text == "0")
            {
                textBox1.Text = "6";
            }
            else
            {
                textBox1.Text += "6";
            }

        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (sil)
            {
                textBox1.Text = "";
                sil = false;
            }
            if (textBox1.Text == "0")
            {
                textBox1.Text = "7";
            }
            else
            {
                textBox1.Text += "7";
            }

        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (sil)
            {
                textBox1.Text = "";
                sil = false;
            }
            if (textBox1.Text == "0")
            {
                textBox1.Text = "8";
            }
            else
            {
                textBox1.Text += "8";
            }

        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (sil)
            {
                textBox1.Text = "";
                sil = false;
            }
            if (textBox1.Text == "0")
            {
                textBox1.Text = "9";
            }
            else
            {
                textBox1.Text += "9";
            }

        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (sil)
            {
                textBox1.Text = "";
                sil = false;
            }
            if (textBox1.Text == "0")
            {
                textBox1.Text = "0";
            }
            else
            {
                textBox1.Text += "0";
            }

        }
        //Karakterleri tek tek silmekk için kullanılan kod
        private void button17_Click(object sender, EventArgs e)
        {
            if (Convert.ToDouble(textBox1.Text) > 0)
            {
                textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1, 1);
                if (textBox1.Text.Length == 0)
                {
                    textBox1.Text = "0";
                }
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            x = Convert.ToDouble(textBox1.Text);
            islem = "+";
            label1.Text = textBox1.Text + "+";
            textBox1.Text = "0";
        }
        //Eşittir butonunun içinde olacak işlemler

        private void button25_Click(object sender, EventArgs e)
        {

            y = Convert.ToDouble(textBox1.Text);
            if (islem == "+")
            {
                textBox1.Text = Convert.ToString(x + y);
                label1.Text = "";
            }
            if (islem == "-")
            {
                textBox1.Text = Convert.ToString(x - y);
                label1.Text = "";
            }
            if (islem == "*")
            {
                textBox1.Text = Convert.ToString(x * y);
                label1.Text = "";
            }
            if (islem == "/")
            {
                textBox1.Text = Convert.ToString(x / y);
                label1.Text = "";
            }
            if (islem == "mod")
            {
                textBox1.Text = Convert.ToString(x % y);
                label1.Text = "";
            }
            if (label1.Text.EndsWith("(ebob)"))
            {

                y = Convert.ToDouble(textBox1.Text);

                while (y != 0)
                {
                    double temp = y;
                    y = x % y;
                    x = temp;
                }

                textBox1.Text = x.ToString();
                label1.Text = "";
            }
            if (label1.Text.EndsWith("(ekok)"))
            {
                y = Convert.ToDouble(textBox1.Text);

                double largerNum = Math.Max(x, y);

                double ekok = largerNum;
                while (ekok % x != 0 || ekok % y != 0)
                {
                    ekok += largerNum;
                }

                textBox1.Text = ekok.ToString();
                label1.Text = "";
            }
            //Kullanıcı bir sayı girmeden işlem tuşlarından birine basıp eşittire basarsa ekranda hata mesajı alır            
            else if (textBox1.Text == "0")
            {
                MessageBox.Show("Hatalı işlem yapıldı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            //Romen rakamları işlemi
            string resultText = textBox1.Text;
            if (double.TryParse(resultText, out double result))
            {
                label1.Text = "";
                textBox1.Text = resultText + " (" + ConvertToRoman((int)result) + ")";
            }

            //ikinci işlemi girerken ilkini sil
            if (sil)
            {
                textBox1.Text = "";
                sil = false;
            }

            if (textBox1.Text == "0") textBox1.Text = "";
            textBox1.Text += "";
            sil = true;

        }
        
        private void ResetOperation()
        {
            x = 0;
            y = 0;
            islem = "";
            label1.Text = "";
        }

        //İşlem Butonlarına basınca neler vereceğini gösteren kodlar
        private void button13_Click(object sender, EventArgs e)
        {

            x = Convert.ToDouble(textBox1.Text);
            islem = "-";
            label1.Text = textBox1.Text + "-";
            textBox1.Text = "0";
        }


        private void button16_Click(object sender, EventArgs e)
        {
            x = Convert.ToDouble(textBox1.Text);
            islem = "*";
            label1.Text = textBox1.Text + "*";
            textBox1.Text = "0";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            x = Convert.ToDouble(textBox1.Text);
            islem = "/";
            label1.Text = textBox1.Text + "/";
            textBox1.Text = "0";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = ",";
            }
            else
            {
                textBox1.Text += ",";
            }
        }

        private void button20_Click(object sender, EventArgs e)
        {
            double kare = Convert.ToDouble(textBox1.Text);
            kare = Math.Pow(kare, 2);
            textBox1.Text = Convert.ToString(kare);
        }

        private void button23_Click(object sender, EventArgs e)
        {
            x = Convert.ToDouble(textBox1.Text);
            islem = "mod";
            label1.Text = textBox1.Text + "(mod)";
            textBox1.Text = "0";
        }

        private void button24_Click(object sender, EventArgs e)
        {
            double karekok = Convert.ToDouble(textBox1.Text);
            karekok = Math.Sqrt(karekok);
            textBox1.Text = Convert.ToString(karekok);
        }

        
        private void button21_Click(object sender, EventArgs e)
        {
            x = Convert.ToDouble(textBox1.Text);
            label1.Text = textBox1.Text + "(ebob)";
            textBox1.Text = "0";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button22_Click(object sender, EventArgs e)
        {
            x = Convert.ToDouble(textBox1.Text);
            label1.Text = textBox1.Text + "(ekok)";
            textBox1.Text = "0";
        }
       
        //buton15 e bir sayı girdikten sonra basınca sayının zıt işaretlisini verecek olan kod
        private void button15_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox1.Text) && textBox1.Text != "0")
            {
                double currentNumber = Convert.ToDouble(textBox1.Text);
                currentNumber = -currentNumber;
                textBox1.Text = currentNumber.ToString();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
               
        //Buton19 a basınca ekrandaki tüm işlemleri silecek olan kod
        private void button19_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            label1.Text = "";
        }
               
        //Romen rakamlarını tanımlar
        private string ConvertToRoman(int number)
        {
            if (number < 1 || number > 3999)
                return "Invalid input";

            string[] romanNumerals = { "I", "IV", "V", "IX", "X", "XL", "L", "XC", "C", "CD", "D", "CM", "M" };
            int[] values = { 1, 4, 5, 9, 10, 40, 50, 90, 100, 400, 500, 900, 1000 };

            StringBuilder result = new StringBuilder();

            for (int i = values.Length - 1; i >= 0; i--)
            {
                while (number >= values[i])
                {
                    result.Append(romanNumerals[i]);
                    number -= values[i];
                }
            }

            return result.ToString();
        }

    }
}



