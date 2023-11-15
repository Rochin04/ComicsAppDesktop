using System.Windows.Forms;

namespace ComicsAPPDesktop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void changeThemeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        //thems
        private void darToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Change the color of a label when a button is clicked
            label1.ForeColor = Color.White;
            label2.ForeColor = Color.White;
            label3.ForeColor = Color.White;
            label4.ForeColor = Color.White;
            label5.ForeColor = Color.White;
            label6.ForeColor = Color.White;
            button1.ForeColor = Color.White;
            button1.BackColor = Color.Black;
            button2.ForeColor = Color.White;
            button2.BackColor = Color.Black;
            this.BackColor = Color.Black;
            toolStrip1.ForeColor = Color.White;
            toolStrip1.BackColor = Color.Black;
        }
        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            label1.ForeColor = Color.Black;
            label2.ForeColor = Color.Black;
            label3.ForeColor = Color.Black;
            label4.ForeColor = Color.Black;
            label5.ForeColor = Color.Black;
            label6.ForeColor = Color.Black;
            button1.ForeColor = Color.Black;
            button1.BackColor = Color.White;
            button2.ForeColor = Color.Black;
            button2.BackColor = Color.White;
            this.BackColor = Color.White;
            toolStrip1.ForeColor = Color.Black;
            toolStrip1.BackColor = Color.White;
        }
        //labels
        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
        //checs buttons
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }
        //buttons
        //public void Cambiar = Application.Run(new Form2());
        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                Form2 form2 = new Form2();
                form2.Show();
                
                Form1 form1 = new Form1();
                form1.Close();
            }
            else if (radioButton2.Checked)
            {
                Form3 form3 = new Form3();
                form3.Show();
            }
            else if (radioButton2.Checked)
            {
                Form4 form4 = new Form4();
                form4.Show();
            }
            else if (radioButton2.Checked)
            {
                Form5 form5 = new Form5();
                form5.Show();
            }
            else
            {

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form6 form6 = new Form6();
            form6.Show();
        }
    }
}