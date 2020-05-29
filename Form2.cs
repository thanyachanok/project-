using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form2 : Form
    {
        Form opener;
        public Form2(Form parentForm)
        {
            InitializeComponent();
            opener = parentForm;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void open_Click(object sender, EventArgs e)
        {
            Form3 frm = new Form3();
            frm.Show();
            this.Visible = false;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            frm.Show();
            this.Visible = false;
        }

        private void save_Click(object sender, EventArgs e)
        {
            รายการฝากเงิน frm = new รายการฝากเงิน();
            frm.Show();
            this.Visible = false;
        }

        private void look_Click(object sender, EventArgs e)
        {
            การเคลื่อนไหวภายในบัญชี frm = new การเคลื่อนไหวภายในบัญชี();
            frm.Show();
            this.Visible = false;
        }

        private void withdraw_Click(object sender, EventArgs e)
        {
            รายการถอน frm = new รายการถอน();
            frm.Show();
            this.Visible = false;
        }

        private void logo2_Click(object sender, EventArgs e)
        {

        }
    }
}
