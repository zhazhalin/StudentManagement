using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace 学生管理系统
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connString = @"Data Source=(local);Initial Catalog=学生管理系统;User ID=sa;Password=123456";
            string show_str = string.Empty;
            string id = textBox1.Text;
            SqlConnection conn = new SqlConnection(connString);
            conn.Open();
            string sql1 = @"select * from ZJLStudent where Sno='" + id + "'";
            SqlCommand cmd = new SqlCommand(sql1, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            if (!dr.Read())
                MessageBox.Show("该学号不存在！");
            else
            {
                dr.Close();
                string sql = @"delete from ZJLStudent where Sno='" + id + "'";
                SqlCommand cmd1 = new SqlCommand(sql, conn);
                try
                {
                    cmd1.ExecuteNonQuery();
                    MessageBox.Show(id + "同学删除成功！");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("删除出错！" + ex.Message);
                }
                conn.Close();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
                button1_Click(sender, e);
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            // TODO:  这行代码将数据加载到表“学生管理系统DataSet3.ZJLStudent”中。您可以根据需要移动或删除它。
            this.zJLStudentTableAdapter1.Fill(this.学生管理系统DataSet3.ZJLStudent);
           

        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            Form5 F5 = new Form5();
            F5.ShowDialog();
            this.Close();
            

        }
    }
}
