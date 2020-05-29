using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void insert_Click(object sender, EventArgs e)
        {
            string Sql = "select * from banktable01";
            Sql = "insert into banktable01 (ID,NAME,save,withdraw,now) values('" + idbox.Text +"','"+ namebox.Text + "','"+0+"','"+0+ "','" + 0 + "')";

            MySqlConnection con = new MySqlConnection("host=localhost;user=bank;password=123456;database=bankdata");
            MySqlCommand cmd = new MySqlCommand(Sql, con);
            con.Open();

           
            cmd.ExecuteNonQuery();
            con.Close();
            
            MessageBox.Show("ลงทะเบียนเรียบร้อยแล้ว");
            /*string Sql = "CREATE DATABASE mydb ON bankdata";
            Sql = "CREATE TABLE myTable" +
            "(myId INTEGER CONSTRAINT PKeyMyId PRIMARY KEY," +
             "myName CHAR(50), myAddress CHAR(255), myBalance FLOAT)";


            MySqlConnection con = new MySqlConnection("host=localhost;user=bank;password=123456");
            MySqlCommand cmd = new MySqlCommand(Sql, con);
            con.Open();

            //cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("สร้างเรียบร้อยแล้ว");*/

        }

        private void save_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Sql = "select * from bankdata01";
            Sql = "delete from banktable01 where ID= '"+idbox.Text+"'";

            MySqlConnection con = new MySqlConnection("host=localhost;user=bank;password=123456;database=bankdata");
            MySqlCommand cmd = new MySqlCommand(Sql, con);
            con.Open();


            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("ลบข้อมูลเรียบร้อยแล้ว");
        }

        private void process1_Exited(object sender, EventArgs e)
        {

        }

        private void back_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2(this);
            frm.Show();
            this.Visible = false;
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
