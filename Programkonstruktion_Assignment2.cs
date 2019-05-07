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
    public partial class Programkonstruktion_Assignment2 : Form
    {
        public Programkonstruktion_Assignment2()
        {
            InitializeComponent();
        }

        private void StartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StartMenu temp = new StartMenu();
            temp.Show();
            this.Hide();

        }

        private void ProgramkonstruktionUppgift1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Programkonstruktion_Assignment1 temp = new Programkonstruktion_Assignment1();
            temp.Show();
            this.Hide();

        }

        private void WebServiceUppgift1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Web_Service_Assignment1 temp = new Web_Service_Assignment1();
            temp.Show();
            this.Hide();

        }

        private void WebServiceUppgift2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Web_Service_Assignment2 temp = new Web_Service_Assignment2();
            temp.Show();
            this.Hide();

        }

        private void ERPIntegreringUppgift1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ERP_Integrering_Assignment1 temp = new ERP_Integrering_Assignment1();
            temp.Show();
            this.Hide();

        }

        private void ERPIntegreringUppgift2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ERP_Integrering__Assignment2 temp = new ERP_Integrering__Assignment2();
            temp.Show();
            this.Hide();

        }
    }
}
