namespace 学生管理系统
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.snoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.snameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ssexDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.smajorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sdeptDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eMAILDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zJLStudentBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.学生管理系统DataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.学生管理系统DataSet = new 学生管理系统.学生管理系统DataSet();
            this.zJLStudentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.zJLCourseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.zJLCourseTableAdapter = new 学生管理系统.学生管理系统DataSetTableAdapters.ZJLCourseTableAdapter();
            this.zJLStudentTableAdapter = new 学生管理系统.学生管理系统DataSetTableAdapters.ZJLStudentTableAdapter();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnchaxun = new System.Windows.Forms.Button();
            this.btnfanhui = new System.Windows.Forms.Button();
            this.学生管理系统DataSet1 = new 学生管理系统.学生管理系统DataSet1();
            this.zJLStudentBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.zJLStudentTableAdapter1 = new 学生管理系统.学生管理系统DataSet1TableAdapters.ZJLStudentTableAdapter();
            this.zJLStudentBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.学生管理系统DataSet5 = new 学生管理系统.学生管理系统DataSet5();
            this.zJLStudentBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.zJLStudentTableAdapter2 = new 学生管理系统.学生管理系统DataSet5TableAdapters.ZJLStudentTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zJLStudentBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.学生管理系统DataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.学生管理系统DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zJLStudentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zJLCourseBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.学生管理系统DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zJLStudentBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zJLStudentBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.学生管理系统DataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zJLStudentBindingSource4)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.snoDataGridViewTextBoxColumn,
            this.snameDataGridViewTextBoxColumn,
            this.ssexDataGridViewTextBoxColumn,
            this.smajorDataGridViewTextBoxColumn,
            this.sdeptDataGridViewTextBoxColumn,
            this.sageDataGridViewTextBoxColumn,
            this.telDataGridViewTextBoxColumn,
            this.eMAILDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.zJLStudentBindingSource4;
            this.dataGridView1.Location = new System.Drawing.Point(12, 38);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(627, 314);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // snoDataGridViewTextBoxColumn
            // 
            this.snoDataGridViewTextBoxColumn.DataPropertyName = "Sno";
            this.snoDataGridViewTextBoxColumn.HeaderText = "Sno";
            this.snoDataGridViewTextBoxColumn.Name = "snoDataGridViewTextBoxColumn";
            this.snoDataGridViewTextBoxColumn.Width = 80;
            // 
            // snameDataGridViewTextBoxColumn
            // 
            this.snameDataGridViewTextBoxColumn.DataPropertyName = "Sname";
            this.snameDataGridViewTextBoxColumn.HeaderText = "Sname";
            this.snameDataGridViewTextBoxColumn.Name = "snameDataGridViewTextBoxColumn";
            this.snameDataGridViewTextBoxColumn.Width = 60;
            // 
            // ssexDataGridViewTextBoxColumn
            // 
            this.ssexDataGridViewTextBoxColumn.DataPropertyName = "Ssex";
            this.ssexDataGridViewTextBoxColumn.HeaderText = "Ssex";
            this.ssexDataGridViewTextBoxColumn.Name = "ssexDataGridViewTextBoxColumn";
            this.ssexDataGridViewTextBoxColumn.Width = 35;
            // 
            // smajorDataGridViewTextBoxColumn
            // 
            this.smajorDataGridViewTextBoxColumn.DataPropertyName = "Smajor";
            this.smajorDataGridViewTextBoxColumn.HeaderText = "Smajor";
            this.smajorDataGridViewTextBoxColumn.Name = "smajorDataGridViewTextBoxColumn";
            // 
            // sdeptDataGridViewTextBoxColumn
            // 
            this.sdeptDataGridViewTextBoxColumn.DataPropertyName = "Sdept";
            this.sdeptDataGridViewTextBoxColumn.HeaderText = "Sdept";
            this.sdeptDataGridViewTextBoxColumn.Name = "sdeptDataGridViewTextBoxColumn";
            // 
            // sageDataGridViewTextBoxColumn
            // 
            this.sageDataGridViewTextBoxColumn.DataPropertyName = "Sage";
            this.sageDataGridViewTextBoxColumn.HeaderText = "Sage";
            this.sageDataGridViewTextBoxColumn.Name = "sageDataGridViewTextBoxColumn";
            this.sageDataGridViewTextBoxColumn.Width = 35;
            // 
            // telDataGridViewTextBoxColumn
            // 
            this.telDataGridViewTextBoxColumn.DataPropertyName = "Tel";
            this.telDataGridViewTextBoxColumn.HeaderText = "Tel";
            this.telDataGridViewTextBoxColumn.Name = "telDataGridViewTextBoxColumn";
            // 
            // eMAILDataGridViewTextBoxColumn
            // 
            this.eMAILDataGridViewTextBoxColumn.DataPropertyName = "EMAIL";
            this.eMAILDataGridViewTextBoxColumn.HeaderText = "EMAIL";
            this.eMAILDataGridViewTextBoxColumn.Name = "eMAILDataGridViewTextBoxColumn";
            // 
            // zJLStudentBindingSource2
            // 
            this.zJLStudentBindingSource2.DataMember = "ZJLStudent";
            this.zJLStudentBindingSource2.DataSource = this.学生管理系统DataSetBindingSource;
            // 
            // 学生管理系统DataSetBindingSource
            // 
            this.学生管理系统DataSetBindingSource.DataSource = this.学生管理系统DataSet;
            this.学生管理系统DataSetBindingSource.Position = 0;
            // 
            // 学生管理系统DataSet
            // 
            this.学生管理系统DataSet.DataSetName = "学生管理系统DataSet";
            this.学生管理系统DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // zJLStudentBindingSource
            // 
            this.zJLStudentBindingSource.DataMember = "ZJLStudent";
            this.zJLStudentBindingSource.DataSource = this.学生管理系统DataSetBindingSource;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(8, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "请输入要查询的学号：";
            // 
            // zJLCourseBindingSource
            // 
            this.zJLCourseBindingSource.DataMember = "ZJLCourse";
            this.zJLCourseBindingSource.DataSource = this.学生管理系统DataSetBindingSource;
            // 
            // zJLCourseTableAdapter
            // 
            this.zJLCourseTableAdapter.ClearBeforeFill = true;
            // 
            // zJLStudentTableAdapter
            // 
            this.zJLStudentTableAdapter.ClearBeforeFill = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(205, 9);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(161, 21);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnchaxun
            // 
            this.btnchaxun.Location = new System.Drawing.Point(390, 9);
            this.btnchaxun.Name = "btnchaxun";
            this.btnchaxun.Size = new System.Drawing.Size(75, 23);
            this.btnchaxun.TabIndex = 3;
            this.btnchaxun.Text = "查询";
            this.btnchaxun.UseVisualStyleBackColor = true;
            this.btnchaxun.Click += new System.EventHandler(this.btnchaxun_Click_1);
            // 
            // btnfanhui
            // 
            this.btnfanhui.Location = new System.Drawing.Point(518, 9);
            this.btnfanhui.Name = "btnfanhui";
            this.btnfanhui.Size = new System.Drawing.Size(75, 23);
            this.btnfanhui.TabIndex = 3;
            this.btnfanhui.Text = "返回";
            this.btnfanhui.UseVisualStyleBackColor = true;
            this.btnfanhui.Click += new System.EventHandler(this.btnfanhui_Click);
            // 
            // 学生管理系统DataSet1
            // 
            this.学生管理系统DataSet1.DataSetName = "学生管理系统DataSet1";
            this.学生管理系统DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // zJLStudentBindingSource1
            // 
            this.zJLStudentBindingSource1.DataMember = "ZJLStudent";
            this.zJLStudentBindingSource1.DataSource = this.学生管理系统DataSet1;
            // 
            // zJLStudentTableAdapter1
            // 
            this.zJLStudentTableAdapter1.ClearBeforeFill = true;
            // 
            // zJLStudentBindingSource3
            // 
            this.zJLStudentBindingSource3.DataMember = "ZJLStudent";
            this.zJLStudentBindingSource3.DataSource = this.学生管理系统DataSetBindingSource;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.textBox2.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox2.Location = new System.Drawing.Point(12, 374);
            this.textBox2.Name = "textBox2";
            this.textBox2.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.textBox2.Size = new System.Drawing.Size(627, 26);
            this.textBox2.TabIndex = 4;
            // 
            // 学生管理系统DataSet5
            // 
            this.学生管理系统DataSet5.DataSetName = "学生管理系统DataSet5";
            this.学生管理系统DataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // zJLStudentBindingSource4
            // 
            this.zJLStudentBindingSource4.DataMember = "ZJLStudent";
            this.zJLStudentBindingSource4.DataSource = this.学生管理系统DataSet5;
            // 
            // zJLStudentTableAdapter2
            // 
            this.zJLStudentTableAdapter2.ClearBeforeFill = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(651, 412);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.btnfanhui);
            this.Controls.Add(this.btnchaxun);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form2";
            this.Text = "学生基本信息查询";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form2_FormClosing);
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zJLStudentBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.学生管理系统DataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.学生管理系统DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zJLStudentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zJLCourseBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.学生管理系统DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zJLStudentBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zJLStudentBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.学生管理系统DataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zJLStudentBindingSource4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource 学生管理系统DataSetBindingSource;
        private 学生管理系统DataSet 学生管理系统DataSet;
        private System.Windows.Forms.BindingSource zJLCourseBindingSource;
        private 学生管理系统DataSetTableAdapters.ZJLCourseTableAdapter zJLCourseTableAdapter;
        private System.Windows.Forms.BindingSource zJLStudentBindingSource;
        private 学生管理系统DataSetTableAdapters.ZJLStudentTableAdapter zJLStudentTableAdapter;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnchaxun;
        private System.Windows.Forms.Button btnfanhui;
        private 学生管理系统DataSet1 学生管理系统DataSet1;
        private System.Windows.Forms.BindingSource zJLStudentBindingSource1;
        private 学生管理系统DataSet1TableAdapters.ZJLStudentTableAdapter zJLStudentTableAdapter1;
        private System.Windows.Forms.BindingSource zJLStudentBindingSource2;
        private System.Windows.Forms.DataGridViewTextBoxColumn snoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn snameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ssexDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn smajorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sdeptDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sageDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eMAILDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource zJLStudentBindingSource3;
        private System.Windows.Forms.TextBox textBox2;
        private 学生管理系统DataSet5 学生管理系统DataSet5;
        private System.Windows.Forms.BindingSource zJLStudentBindingSource4;
        private 学生管理系统DataSet5TableAdapters.ZJLStudentTableAdapter zJLStudentTableAdapter2;
    }
}