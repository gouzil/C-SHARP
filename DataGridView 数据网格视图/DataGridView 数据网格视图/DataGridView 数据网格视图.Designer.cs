namespace DataGridView_数据网格视图
{
    partial class 数据网格视图
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.学号DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.名字DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.地址DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.学生书籍收货地址BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._19jy2_y1906040212_tcDataSet = new DataGridView_数据网格视图._19jy2_y1906040212_tcDataSet();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button_jiazai = new System.Windows.Forms.Button();
            this.textBox_pwd = new System.Windows.Forms.TextBox();
            this.textBox_name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_jiami = new System.Windows.Forms.TextBox();
            this.学生书籍收货地址TableAdapter = new DataGridView_数据网格视图._19jy2_y1906040212_tcDataSetTableAdapters.学生书籍收货地址TableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.学生书籍收货地址BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._19jy2_y1906040212_tcDataSet)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.学号DataGridViewTextBoxColumn,
            this.名字DataGridViewTextBoxColumn,
            this.地址DataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.学生书籍收货地址BindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(52, 31);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(462, 251);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.Visible = false;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // 学号DataGridViewTextBoxColumn
            // 
            this.学号DataGridViewTextBoxColumn.DataPropertyName = "学号";
            this.学号DataGridViewTextBoxColumn.HeaderText = "学号";
            this.学号DataGridViewTextBoxColumn.Name = "学号DataGridViewTextBoxColumn";
            this.学号DataGridViewTextBoxColumn.ReadOnly = true;
            this.学号DataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // 名字DataGridViewTextBoxColumn
            // 
            this.名字DataGridViewTextBoxColumn.DataPropertyName = "名字";
            this.名字DataGridViewTextBoxColumn.HeaderText = "名字";
            this.名字DataGridViewTextBoxColumn.Name = "名字DataGridViewTextBoxColumn";
            this.名字DataGridViewTextBoxColumn.ReadOnly = true;
            this.名字DataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // 地址DataGridViewTextBoxColumn
            // 
            this.地址DataGridViewTextBoxColumn.DataPropertyName = "地址";
            this.地址DataGridViewTextBoxColumn.HeaderText = "地址";
            this.地址DataGridViewTextBoxColumn.Name = "地址DataGridViewTextBoxColumn";
            this.地址DataGridViewTextBoxColumn.ReadOnly = true;
            this.地址DataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // 学生书籍收货地址BindingSource
            // 
            this.学生书籍收货地址BindingSource.DataMember = "学生书籍收货地址";
            this.学生书籍收货地址BindingSource.DataSource = this._19jy2_y1906040212_tcDataSet;
            // 
            // _19jy2_y1906040212_tcDataSet
            // 
            this._19jy2_y1906040212_tcDataSet.DataSetName = "_19jy2_y1906040212_tcDataSet";
            this._19jy2_y1906040212_tcDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button_jiazai);
            this.groupBox1.Controls.Add(this.textBox_pwd);
            this.groupBox1.Controls.Add(this.textBox_name);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(52, 345);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(462, 117);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "详细信息";
            // 
            // button_jiazai
            // 
            this.button_jiazai.Location = new System.Drawing.Point(270, 43);
            this.button_jiazai.Name = "button_jiazai";
            this.button_jiazai.Size = new System.Drawing.Size(75, 23);
            this.button_jiazai.TabIndex = 4;
            this.button_jiazai.Text = "加载数据";
            this.button_jiazai.UseVisualStyleBackColor = true;
            this.button_jiazai.Click += new System.EventHandler(this.button_jiazai_Click);
            // 
            // textBox_pwd
            // 
            this.textBox_pwd.Location = new System.Drawing.Point(88, 64);
            this.textBox_pwd.Name = "textBox_pwd";
            this.textBox_pwd.Size = new System.Drawing.Size(144, 21);
            this.textBox_pwd.TabIndex = 3;
            this.textBox_pwd.UseSystemPasswordChar = true;
            // 
            // textBox_name
            // 
            this.textBox_name.Location = new System.Drawing.Point(88, 32);
            this.textBox_name.Name = "textBox_name";
            this.textBox_name.Size = new System.Drawing.Size(144, 21);
            this.textBox_name.TabIndex = 2;
            this.textBox_name.Text = "（用户名随意，密码123）";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "密码：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "用户名：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(81, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(390, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "请输入正确的用户名密码查看";
            // 
            // textBox_jiami
            // 
            this.textBox_jiami.Location = new System.Drawing.Point(140, 492);
            this.textBox_jiami.Name = "textBox_jiami";
            this.textBox_jiami.ReadOnly = true;
            this.textBox_jiami.Size = new System.Drawing.Size(100, 21);
            this.textBox_jiami.TabIndex = 3;
            this.textBox_jiami.Visible = false;
            // 
            // 学生书籍收货地址TableAdapter
            // 
            this.学生书籍收货地址TableAdapter.ClearBeforeFill = true;
            // 
            // 数据网格视图
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(605, 550);
            this.Controls.Add(this.textBox_jiami);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "数据网格视图";
            this.ShowIcon = false;
            this.Text = "DataGridView 数据网格视图";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.学生书籍收货地址BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._19jy2_y1906040212_tcDataSet)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button_jiazai;
        private System.Windows.Forms.TextBox textBox_name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_pwd;
        private System.Windows.Forms.TextBox textBox_jiami;
        private _19jy2_y1906040212_tcDataSet _19jy2_y1906040212_tcDataSet;
        private System.Windows.Forms.BindingSource 学生书籍收货地址BindingSource;
        private _19jy2_y1906040212_tcDataSetTableAdapters.学生书籍收货地址TableAdapter 学生书籍收货地址TableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn 学号DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 名字DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 地址DataGridViewTextBoxColumn;
    }
}

