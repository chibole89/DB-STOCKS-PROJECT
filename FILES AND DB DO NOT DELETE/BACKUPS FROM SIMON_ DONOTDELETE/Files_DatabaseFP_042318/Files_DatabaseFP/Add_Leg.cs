using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Files_DatabaseFP
{
    public partial class Add_Leg : Form
    {
        public Add_Leg()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddLeg_Add_Leg_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Leg has been added to database", "Leg Added", MessageBoxButtons.OK,MessageBoxIcon.Asterisk);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
