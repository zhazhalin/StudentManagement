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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            //连接数据库
            string connString = @"Data Source =(local); Initial Catalog = 学生管理系统; User ID = sa; Password = 123456";
            //查找数据：
            string Sno = textBox9.Text;
            SqlConnection conn = new SqlConnection(connString);
            conn.Open();
            string sql = @"SELECT * FROM ZJLStudent WHERE Sno='" +textBox9.Text + "'";
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            if (!dr.Read())
            {
                MessageBox.Show(Sno + "号学生不存在！");
                return;
            }
            textBox2.Text = dr["Sname"].ToString();
            textBox3.Text = dr["Ssex"].ToString();
            textBox4.Text = dr["Smajor"].ToString();
            textBox5.Text = dr["Sdept"].ToString();
            textBox6.Text = dr["Sage"].ToString();
            textBox7.Text = dr["Tel"].ToString();
            textBox8.Text = dr["EMAIL"].ToString();
            conn.Close();
            textBox1.Text = textBox9.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string connString = @"Data Source =(local); Initial Catalog = 学生管理系统; User ID = sa; Password = 123456";
            SqlConnection conn = new SqlConnection(connString);
            conn.Open();
            string sql = @"update ZJLStudent set [Sno]='"+textBox1.Text+"',[Sname]='"+textBox2.Text+"',[Ssex]='"+textBox3.Text+"',[Smajor]='"+textBox4.Text+"',[Sdept]='"+textBox5.Text+"',[Sage]='"+textBox6.Text+"',[Tel]='"+textBox7.Text+"',[EMAIL]='"+textBox8.Text+"' WHERE Sno='" + textBox9.Text + "'";
            SqlCommand cmd = new SqlCommand(sql, conn);
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show(textBox9.Text + "号学生修改成功！");
            }
            catch(Exception ex)
            {
                MessageBox.Show("更新出错！"+ex.Message);
            }
            conn.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
     }
 }

