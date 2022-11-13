
//using DarkUI.Forms;

namespace Blood_management_sys
{
   

    public partial class Form1 : Form
    {
        public static string x = "";
        public static string y = "";
        public static string z = "";
        public Form1()
        {

            InitializeComponent();
            comboBox1.Items.Insert(0, "Admin");
            comboBox1.Items.Insert(1, "Donor");
            comboBox1.Items.Insert(2, "Recipients");

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            y = textBox1.Text;
            z= textBox2.Text;
            //z = textBox3.Text;
            string categoryy = comboBox1.SelectedItem as string;
            if (categoryy == "Admin")
            {
                Form2 frm2 = new Form2();
                frm2.Show();

            }
            else if (categoryy == "Donor")
            {
                Form3 frm3 = new Form3();
                frm3.Show();
            }
            else if (categoryy == "Recipients")
            {
                Form4 frm4 = new Form4();
                frm4.Show();

            }
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form5 frm5 = new Form5();
            frm5.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Form5 frm5 = new Form5();
            frm5.Show();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            //textBox2.Text = "";
            textBox2.ForeColor = Color.Black;

            textBox2.PasswordChar = '●';
        }
    }
}