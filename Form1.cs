using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharp_tinhcangchi1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btntinh_Click(object sender, EventArgs e)
        {
            string can = "";
            switch (Convert.ToInt32(txtduonglich.Text) % 10)
            {
                case 0:
                    can = "canh";
                    break;
                case 1:
                    can = "Tân";
                    break;
                case 2:
                    can = "nhân";
                    break;
                case 3:
                    can = "Quý";
                    break;
                case 4:
                    can = "Giấp";
                    break;
                case 5:
                    can = "ất";
                    break;
                case 6:
                    can = "Bính";
                    break;
                case 7:
                    can = "Binh";
                    break;
                case 8:
                    can = "hậu";
                    break;
                case 9:
                    can = "kỷ";
                    break;
             }
            string chi = "";
            switch (Convert.ToInt32(txtduonglich.Text) % 12)
            {
                case 0:
                    chi = "Thân";
                    break;
                case 1:
                    chi = "Dậu";
                    break;
                case 2:
                    chi = "Tuất";
                    break;
                case 3:
                    chi = "Hợi";
                    break;
                case 4:
                    chi = "Tý";
                    break;
                case 5:
                    chi = "Sửu";
                    break;
                case 6:
                    chi = "Dần";
                    break;
                case 7:
                    chi = "Mảo";
                    break;
                case 8:
                    chi = "Thìn";
                    break;
                case 9:
                    chi = "tỵ";
                    break;
                case 10:
                    chi = "Ngọ";
                    break;
                case 11:
                    chi = "Mùi";
                    break;
            }
            txtkp.Text = can + " " + chi;
        }
    }
}
