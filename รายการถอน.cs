using MySql.Data.MySqlClient;
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
    public partial class รายการถอน : Form
    {
        public รายการถอน()
        {
            InitializeComponent();
        }

        private void back_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2(this);
            frm.Show();
            this.Visible = false;
        }

        private void save_Click(object sender, EventArgs e)
        {
            string Sql = "select * from banktable01";
            Sql = "insert into banktable01 (ID,withdraw,save,now) values('" + idbox.Text + "','" + '-'+(nbr.Value) + "','" + 0 + "','" + '-' + nbr.Value + "')";

            MySqlConnection con = new MySqlConnection("host=localhost;user=bank;password=123456;database=bankdata");
            con.Open();
            MySqlDataAdapter cmd = new MySqlDataAdapter(Sql, con);
            cmd.SelectCommand.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("ถอนเงินจำนวน '" + nbr.Value + "' บาท");
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void idbox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
