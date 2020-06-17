using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataGridView_数据网格视图
{
    public partial class 数据网格视图 : Form
    {
        public 数据网格视图()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“_19jy2_y1906040212_tcDataSet.学生书籍收货地址”中。您可以根据需要移动或删除它。
            this.学生书籍收货地址TableAdapter.Fill(this._19jy2_y1906040212_tcDataSet.学生书籍收货地址);

            //设置宽度
            dataGridView1.Columns[0].Width = 70;
            dataGridView1.Columns[1].Width = 70;
            dataGridView1.Columns[2].Width = 90;

            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;//设置选择整行
            dataGridView1.DefaultCellStyle.SelectionBackColor = Color.BlueViolet;//设置颜色
            dataGridView1.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;//内容居中
            dataGridView1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;//标题居中
        }

        private void button_jiazai_Click(object sender, EventArgs e)
        {
            //把文本转换为数组变量
            byte[] vs = System.Text.Encoding.Default.GetBytes(textBox_pwd.Text);

            //哈希加密
            MD5 md5 = new MD5CryptoServiceProvider();
            byte[] md5date = md5.ComputeHash(vs);
            //返回密文
            string md5p = "";
            for (int i = 0; i < md5date.Length; i++)
            {
                //ToString()括号中输入x说明使用16进制表示
                md5p += md5date[i].ToString();
            }
            textBox_jiami.Text = md5p;

            if (textBox_jiami.Text == "3244185981728979115075721453575112")
            {
                label3.Visible = false;
                dataGridView1.Visible = true;
                SqlConnection conn = new SqlConnection("server=DESKTOP-NPQ8DIA;database=19jy2_y1906040212_tc;integrated security=true");//连接服务器
                SqlDataAdapter adapter = new SqlDataAdapter("select * from 学生书籍收货地址", conn);
                DataSet data = new DataSet();
                adapter.Fill(data, "学生书籍收货地址");
                dataGridView1.DataSource = data.Tables["学生书籍收货地址"];
            }
            else
            {
                label3.Text = "密码错误!";
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //放到加载窗体中了
            ////设置宽度
            //dataGridView1.Columns[0].Width = 70;
            //dataGridView1.Columns[1].Width = 70;
            //dataGridView1.Columns[2].Width = 90;
            
            //dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;//设置选择整行
            //dataGridView1.DefaultCellStyle.SelectionBackColor = Color.BlueViolet;
            //dataGridView1.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;//内容居中
            //dataGridView1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;//标题居中

        }
    }
}
