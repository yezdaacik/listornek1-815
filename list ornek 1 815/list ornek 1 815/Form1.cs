using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace list_ornek_1_815
{
    public partial class Form1 : Form
    {
        List<int> sayilar;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            sayilar = new List<int>();

            sayilar.Add(14);
            sayilar.Add(15);
            sayilar.Add(16);
            sayilar.Add(17);
            sayilar.Add(40);
            sayilar.Add(42);
            sayilar.Add(45);
            lbSayilar.DataSource = sayilar;
        }
    }
}
