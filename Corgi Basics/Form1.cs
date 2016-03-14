using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Corgi_Basics
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public string CalculateMD5Hash(string input) 
        {
            MD5 md5 = System.Security.Cryptography.MD5.Create();

            byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(input);

            byte[] hash = md5.ComputeHash(inputBytes);

            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < hash.Length; i++)
            {
                sb.Append(hash[i].ToString("X2"));
            }

            return sb.ToString();
        }

        string HexFromID(int ID)
        {
            return ID.ToString("X");
        }

        private void txtConvertMD5_Click(object sender, EventArgs e)
        {
            try
            {
                txtHex.Text = HexFromID(Convert.ToInt16(txtInt.Text));

                txtMD5.Text = CalculateMD5Hash(txtIntToMD5.Text);

                MessageBox.Show(HexFromID(Convert.ToInt16(txtIntToMD5.Text)));
            }
            catch (Exception)
            {
 
            }

        }
    }
}
