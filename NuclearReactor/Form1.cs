using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Media;

namespace NuclearReactor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            rizzColorLabel.BackColor = Color.Black;
            fanumColarLabel.BackColor = Color.Black;

            Refresh();
            Thread.Sleep(1000);

            rizzColorLabel.BackColor = Color.Indigo;
            fanumColarLabel.BackColor = Color.IndianRed;
            
            Refresh();
            Thread.Sleep(1000);

            rizzColorLabel.BackColor = Color.Red;
            fanumColarLabel.BackColor = Color.Red;
            
            rizzColorLabel.Location = new Point(1,1);

            lableLAble.Text = "Rizzin' XD";
            lableLAble.ForeColor = Color.OrangeRed;
            //Hello!
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
