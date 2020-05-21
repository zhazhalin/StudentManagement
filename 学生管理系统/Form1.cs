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
using System.IO;
using 学生管理系统;

namespace 学生管理系统
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnectionStringBuilder scsb = new SqlConnectionStringBuilder();
            scsb.DataSource = "(local)";
            scsb.UserID = "sa";
            scsb.Password = "123456";
            scsb.InitialCatalog = "登录";
            SqlConnection conn = new SqlConnection(scsb.ToString());
            if (conn.State == System.Data.ConnectionState.Closed)
            { 
                conn.Open();
            }
            string user_id = comboBox1.Text.Trim();
            string user_pwd = textBox1.Text.Trim();
            string strSQL = "select pwd from 登录 where [uid]='"+user_id+"'";
            SqlCommand comm = new SqlCommand(strSQL, conn);
            SqlDataReader dr = comm.ExecuteReader();
            if (dr.Read())
            {
                if (dr["pwd"].ToString() == user_pwd)
                {
                    if (checkBox1.Checked == true)
                    {
                        MessageBox.Show("学生登陆成功！");
                        this.Hide();
                        Form4 F4 = new Form4();
                        F4.Text = "学生登录管理平台";
                        F4.ShowDialog();
                        
                        
                    }
                    else
                    {
                        MessageBox.Show("管理员登陆成功！");
                        this.Hide();
                        Form4 F4 = new Form4();
                        F4.Text = "管理员登录管理平台";
                        F4.ShowDialog();
                        
                    }
                }
                else
                    MessageBox.Show("密码错误！");
            }
            else
                MessageBox.Show("该用户不存在");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            // TODO:  这行代码将数据加载到表“登录DataSet.登录”中。您可以根据需要移动或删除它。
            this.登录TableAdapter.Fill(this.登录DataSet.登录);

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
                button2_Click(sender, e);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
                checkBox1.Checked = true;
            else
                checkBox1.Checked = false;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
