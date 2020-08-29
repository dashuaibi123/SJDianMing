using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : MaterialForm
    {
        public Form1(MenuStrip menuStrip)
        {
           
        }
        public Form1()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            FileStream fileStream = new FileStream("Confident.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            StreamWriter streamWriter = new StreamWriter(fileStream);
            streamWriter.WriteLine("FirstOpen=false");//写入文本
            streamWriter.Close();//关闭输入
            fileStream.Close();//关闭文件读写   

        }
        

        

        private void 关于作者ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //materialContextMenuStrip1.Show(264, 156);
            MessageBox.Show("QQ1791286695","关于作者",MessageBoxButtons.OK);
        }

        private void 检查更新ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("版本1.1", "暂时还没有更新", MessageBoxButtons.OKCancel);
        }

        private void 更新日志ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("2019-11-21 向下兼容到net3.0，修复不能多次点名的bug\n2019-11-5 beta1.1发布。添加名字点名模式\n2019-10.9 Release1.0发布。修复bug，添加新的逻辑\n2019-10.3 beta1.0发布", "更新日志", MessageBoxButtons.OK);
        }

        private void 帮助文档ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form6 f6 = new Form6();//新建对象
            //this.Hide();//隐藏该布局
            f6.ShowDialog();//打开布局
        }

       

        private void materialFlatButton1_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();//新建对象
            this.Hide();//隐藏该布局
            f2.ShowDialog();//打开布局
            Application.ExitThread();//退出线程
        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            Form5 f5 = new Form5();//新建对象
            this.Hide();//隐藏该布局
            f5.ShowDialog();//打开布局
            Application.ExitThread();//退出线程
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void materialFlatButton2_Click(object sender, EventArgs e)
        {
            Form7 f7 = new Form7();//新建对象
            this.Hide();//隐藏该布局
            f7.ShowDialog();//打开布局
            Application.ExitThread();//退出线程
        }

        private void materialFlatButton3_Click(object sender, EventArgs e)
        {

        }
    }
}
