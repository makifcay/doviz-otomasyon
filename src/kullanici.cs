using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DovizOtomasyon
{
    public partial class kullanici : Form
    {
        public kullanici()
        {
            InitializeComponent();
        }

        bool goster = false;
        private void sifreGosterButton_Click(object sender, EventArgs e)
        {


            if (goster == false)
            {
                sifreGosterButton.IconChar = FontAwesome.Sharp.IconChar.Eye;
                goster = true;
                sifreTextBox.PasswordChar = '*';
            }

            else
            {
                sifreGosterButton.IconChar = FontAwesome.Sharp.IconChar.EyeSlash;
                goster = false;
                sifreTextBox.PasswordChar = '\0';
            }

        }

        

    }
}
