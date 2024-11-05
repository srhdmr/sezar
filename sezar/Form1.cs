using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sezar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String veri = txtşifrelenecek.Text;
            String şifreli_veri = "";
            for (int i = 0; i < veri.Length; i++)
            {
                if (veri[i].ToString() == "A" || veri[i].ToString() == "a") { şifreli_veri += "Ç"; }
                else if (veri[i].ToString() == "B" || veri[i].ToString() == "b") { şifreli_veri += "D"; }
                else if (veri[i].ToString() == "C" || veri[i].ToString() == "c") { şifreli_veri += "E"; }
                else if (veri[i].ToString() == "Ç" || veri[i].ToString() == "ç") { şifreli_veri += "F"; }
                else if (veri[i].ToString() == "D" || veri[i].ToString() == "d") { şifreli_veri += "G"; }
                else if (veri[i].ToString() == "E" || veri[i].ToString() == "e") { şifreli_veri += "Ğ"; }
                else if (veri[i].ToString() == "F" || veri[i].ToString() == "f") { şifreli_veri += "H"; }
                else if (veri[i].ToString() == "G" || veri[i].ToString() == "g") { şifreli_veri += "I"; }
                else if (veri[i].ToString() == "Ğ" || veri[i].ToString() == "ğ") { şifreli_veri += "İ"; }
                else if (veri[i].ToString() == "H" || veri[i].ToString() == "h") { şifreli_veri += "J"; }
                else if (veri[i].ToString() == "I" || veri[i].ToString() == "ı") { şifreli_veri += "K"; }
                else if (veri[i].ToString() == "İ" || veri[i].ToString() == "i") { şifreli_veri += "L"; }
                else if (veri[i].ToString() == "J" || veri[i].ToString() == "j") { şifreli_veri += "M"; }
                else if (veri[i].ToString() == "K" || veri[i].ToString() == "k") { şifreli_veri += "N"; }
                else if (veri[i].ToString() == "L" || veri[i].ToString() == "l") { şifreli_veri += "O"; }
                else if (veri[i].ToString() == "M" || veri[i].ToString() == "m") { şifreli_veri += "Ö"; }
                else if (veri[i].ToString() == "N" || veri[i].ToString() == "n") { şifreli_veri += "P"; }
                else if (veri[i].ToString() == "O" || veri[i].ToString() == "o") { şifreli_veri += "R"; }
                else if (veri[i].ToString() == "Ö" || veri[i].ToString() == "ö") { şifreli_veri += "S"; }
                else if (veri[i].ToString() == "P" || veri[i].ToString() == "p") { şifreli_veri += "Ş"; }
                else if (veri[i].ToString() == "R" || veri[i].ToString() == "r") { şifreli_veri += "T"; }
                else if (veri[i].ToString() == "S" || veri[i].ToString() == "s") { şifreli_veri += "U"; }
                else if (veri[i].ToString() == "Ş" || veri[i].ToString() == "ş") { şifreli_veri += "Ü"; }
                else if (veri[i].ToString() == "T" || veri[i].ToString() == "t") { şifreli_veri += "V"; }
                else if (veri[i].ToString() == "U" || veri[i].ToString() == "u") { şifreli_veri += "Y"; }
                else if (veri[i].ToString() == "Ü" || veri[i].ToString() == "ü") { şifreli_veri += "Z"; }
                else if (veri[i].ToString() == "V" || veri[i].ToString() == "v") { şifreli_veri += "A"; }
                else if (veri[i].ToString() == "Y" || veri[i].ToString() == "y") { şifreli_veri += "B"; }
                else if (veri[i].ToString() == "Z" || veri[i].ToString() == "z") { şifreli_veri += "C"; }
                else
                {
                    şifreli_veri = veri[i].ToString();
                }

            }
            txtveri.Text = şifreli_veri;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
