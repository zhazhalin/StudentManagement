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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO:  这行代码将数据加载到表“学生管理系统DataSet5.ZJLStudent”中。您可以根据需要移动或删除它。
            this.zJLStudentTableAdapter2.Fill(this.学生管理系统DataSet5.ZJLStudent);

        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnfanhui_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnchaxun_Click(object sender, EventArgs e)
        {
            
            
        }

        private void btnchaxun_Click_1(object sender, EventArgs e)
        {
            string connString = @"Data Source=(local);Initial Catalog=学生管理系统;User ID=sa;Password=123456";
            string show_str = string.Empty;
            string id = textBox1.Text;
            SqlConnection conn = new SqlConnection(connString);
            conn.Open();
            string sql = @"select Sno as Sno,Sname as Sname,Ssex as 性别,Smajor as 专业,Sdept as 院系,Sage as 年龄,Tel as 手机号,EMAIL as 邮箱 from ZJLStudent where Sno='" + id + "'";
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader dr = cmd.ExecuteReader() ;
            if (!dr.Read())
                MessageBox.Show("该学号不存在！");
            else
            {
                show_str = string.Format("{0}{1}  {2}{3}{4}{5}  {6}{7}", dr[0].ToString(), dr[1].ToString(), dr[2].ToString(),
                              dr[3].ToString(), dr[4].ToString(), dr[5].ToString(), dr[6].ToString(), dr[7].ToString());
                dr.Close();
                dr.Dispose();
                textBox2.Text = show_str;//显示
            }
            
        }

        
    }
}
