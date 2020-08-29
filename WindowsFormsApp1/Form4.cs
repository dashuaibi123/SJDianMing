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
using System.Threading;

namespace WindowsFormsApp1
{
    public partial class Form4 : MaterialForm
    {
        public Form4()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
        }
        public static FileStream fileStream;
        public static StreamWriter streamWriter;
        public static StreamReader streamReader;
        private void Form4_Load(object sender, EventArgs e)
        {
            fileStream = new FileStream("dianming.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            streamWriter = new StreamWriter(fileStream);
            streamReader = new StreamReader(fileStream);

        }
        public int StudentsNumber=0;
        private void materialFlatButton1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "学生名字"||textBox1.Text=="")
            {
                MessageBox.Show("麻烦你不要敷衍我好嘛", "谁叫这个名字..");
            }
            else
            {
            streamWriter.WriteLine(textBox1.Text);
            StudentsNumber++;
            textBox1.Text = "";
            label1.Text = "状态：完全ok！总人数："+StudentsNumber+"人";
                textBox1.Focus();
            }
            
            
            
        }
        public void tiaoZhengText()
        {
           if(label1.Text == "状态：完全ok！总人数：" + StudentsNumber + "人")
            {
            Thread.Sleep(500);
                label1.Text = "就绪！";
            }
        }

        private void materialFlatButton2_Click(object sender, EventArgs e)
        {
           streamWriter.Close();
            fileStream.Close();
            MessageBox.Show("重启软件生效", "完成！",MessageBoxButtons.OK);
            System.Environment.Exit(0);
        }
    }
}
