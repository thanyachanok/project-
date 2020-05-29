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
    public partial class การเคลื่อนไหวภายในบัญชี : Form

    {
        private object dataGridView1;

        public การเคลื่อนไหวภายในบัญชี()
        {
            InitializeComponent();
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btcheck_Click(object sender, EventArgs e)
        {
            string Sql = "SELECT ID,name,save,withdraw,now FROM `banktable01` WHERE ID = '"+ textBox1.Text.Trim()+"'";

            MySqlConnection con = new MySqlConnection("host=localhost;user=bank;password=123456;database=bankdata");
            MySqlCommand cmd = new MySqlCommand(Sql, con);
            con.Open();
            DataSet ds = new DataSet();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(ds);
            dataT.DataSource = ds.Tables[0].DefaultView;
            dataT.AutoResizeColumns();
            dataT.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataT.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;


            
            con.Close();

            //MessageBox.Show("ลงทะเบียนเรียบร้อยแล้ว");
        }

        private void dataT_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void back_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2(this);
            frm.Show();
            this.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dataT.RowCount > 0)
            {
                int sum_money = 0;
                for (int i = 0; i < dataT.Rows.Count - 1; i++)
                //textBox3.Text = "0";
                //foreach (DataGridViewRow item in dataT.Rows)
                {
                    //int i = item.Index;
                    sum_money = sum_money + Convert.ToInt32(dataT.Rows[i].Cells[4].Value.ToString());
                    textBox3.Text = sum_money.ToString();
                    //textBox3.Text = (Convert.ToString(textBox3.Text.ToString()) + int.Parse(dataT.Rows[i].Cells[4].Value.ToString()));

                }
            }
        }
    }
}
