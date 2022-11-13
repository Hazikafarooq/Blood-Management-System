using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Blood_management_sys
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            comboBox1.Items.Insert(0, "O+");
            comboBox1.Items.Insert(1, "O-");
            comboBox1.Items.Insert(2, "B+");
            comboBox1.Items.Insert(3, "B-");
            comboBox1.Items.Insert(4, "A+");
            comboBox1.Items.Insert(5, "A-");
            comboBox1.Items.Insert(6, "AB+");
            comboBox1.Items.Insert(7, "AB-");
       

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
