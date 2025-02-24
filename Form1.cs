using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai13_TinhCanChi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] canArr = { "Canh ", "Tân ", "Nhâm ", "Qúy ", "Giáp ", "Ất ", "Bính ", "Đinh ", "Mậu ", "Kỵ " };
            string[] chiArr = { "Thân", "Dậu", "Tuất", "Hợi", "Tý", "Sửu", "Dần", "Mảo", "Thìn", "Tý", "Ngọ", "Mùi" };

            string giatritrave = canArr[Convert.ToInt32(txtNam.Text) % 10] + chiArr[Convert.ToInt32(txtNam.Text) % 12];
            txtKQ.Text = giatritrave;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
