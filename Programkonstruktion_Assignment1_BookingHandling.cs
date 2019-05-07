using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SYSA14_Biljettbokning
{
    public partial class Programkonstruktion_Assignment1_BookingHandling : Form
    {
        public Programkonstruktion_Assignment1_BookingHandling()
        {
            InitializeComponent();
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            Programkonstruktion_Assignment1 temp = new Programkonstruktion_Assignment1();
            temp.Show();
            this.Hide();

        }
    }
}
