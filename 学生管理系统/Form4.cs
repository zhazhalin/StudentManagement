using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using 学生管理系统;

namespace 学生管理系统
{
    public partial class Form4 : Form
    {
       
        public Form4()
        {
            InitializeComponent();
        }

        private void FormGuanli_Load(object sender, EventArgs e)
        {

        }

        private void 添加学生信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (this.Text == "学生登录管理平台")
            {
                MessageBox.Show("您没有权限！请从管理员登录！");
            }
            else
            {
                Form3 F3 = new Form3();
                F3.ShowDialog();
            }


        }





       

        private void Form4_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void 课程删除ToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (this.Text == "学生登录管理平台")
            {
                MessageBox.Show("您没有权限！请从管理员登录！");
            }
            else
            {
                MessageBox.Show("该功能正在开发，请先行体验学生表查询功能！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void 学生查询ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form2 F2 = new Form2();
            F2.ShowDialog();
            
        }

        private void 学生信息删除ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.Text == "学生登录管理平台")
            {
                MessageBox.Show("您没有权限！请从管理员登录！");
            }
            else
            {
                Form5 F5 = new Form5();
                F5.ShowDialog();
            }

        }

        private void 学生信息修改ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.Text == "学生登录管理平台")
            {
                MessageBox.Show("您没有权限！请从管理员登录！");
            }
            else
            {
                Form6 F6 = new Form6();
                F6.ShowDialog();
            }
        }

        private void 选课信息查询ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("该功能正在开发，请先行体验学生表查询功能！","提示", MessageBoxButtons.OK,MessageBoxIcon.Warning);
        }

        private void 教师信息查询ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("该功能正在开发，请先行体验学生表查询功能！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void 课程表查询ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("该功能正在开发，请先行体验学生表查询功能！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void 添加选课信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.Text == "学生登录管理平台")
            {
                MessageBox.Show("您没有权限！请从管理员登录！");
            }
            else
            {
                MessageBox.Show("该功能正在开发，请先行体验学生信息增加功能！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void 添加教师信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (this.Text == "学生登录管理平台")
            {
                MessageBox.Show("您没有权限！请从管理员登录！");
            }
            else
            {
                MessageBox.Show("该功能正在开发，请先行体验学生信息增加功能！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void 课程增加ToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (this.Text == "学生登录管理平台")
            {
                MessageBox.Show("您没有权限！请从管理员登录！");
            }
            else
            {
                MessageBox.Show("该功能正在开发，请先行体验学生信息增加功能！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void 选课信息删除ToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (this.Text == "学生登录管理平台")
            {
                MessageBox.Show("您没有权限！请从管理员登录！");
            }
            else
            {
                MessageBox.Show("该功能正在开发，请先行体验学生信息删除功能！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void 教师信息删除ToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (this.Text == "学生登录管理平台")
            {
                MessageBox.Show("您没有权限！请从管理员登录！");
            }
            else
            {
                MessageBox.Show("该功能正在开发，请先行体验学生信息删除功能！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void 选课信息修改ToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (this.Text == "学生登录管理平台")
            {
                MessageBox.Show("您没有权限！请从管理员登录！");
            }
            else
            {
                MessageBox.Show("该功能正在开发，请先行体验学生信息删除功能！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void 教师信息查询ToolStripMenuItem2_Click(object sender, EventArgs e)
        {

            if (this.Text == "学生登录管理平台")
            {
                MessageBox.Show("您没有权限！请从管理员登录！");
            }
            else
            {
                MessageBox.Show("该功能正在开发，请先行体验学生表查询功能！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void 课程信息修改ToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (this.Text == "学生登录管理平台")
            {
                MessageBox.Show("您没有权限！请从管理员登录！");
            }
            else
            {
                MessageBox.Show("该功能正在开发，请先行体验学生信息修改功能！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
