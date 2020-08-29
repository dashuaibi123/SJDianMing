using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Threading;
using Microsoft.Win32;
using MaterialSkin.Controls;
using MaterialSkin;

namespace WindowsFormsApp1
{
    public partial class Form5 : MaterialForm
    {
        public double VersionNum = 1.0;
        public String Release = "beta";
        public Form5()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextAlignChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            TextBox textBox1 = new TextBox();

            if (this.textBox1.Text == "文件地址，后缀为.txt")
            {
                this.textBox1.Text = "";
            }
            
        }

      
        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (this.textBox1.Text == "")
            {
                this.textBox1.Text = "文件地址，后缀为.txt";
            }
          
        }


        private void materialFlatButton1_Click(object sender, EventArgs e)
        {
            String name;
            if (textBox1.Text== "文件地址，后缀为.txt"){
                MessageBox.Show("请选择文件地址！");
            }
            else
            {
                FileStream fileStream = new FileStream("dianming.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
                StreamWriter streamWriter = new StreamWriter(fileStream);
                StreamReader streamReader = new StreamReader(textBox1.Text,Encoding.Default);
                while ((name=streamReader.ReadLine())!= null)
                {
                    streamWriter.WriteLine(name);//写入文本
                }
                streamReader.Close();
                streamWriter.Close();
                fileStream.Close();
                MessageBox.Show("重启程序就可以使用了！", "添加成功");
            }
        }

        private void materialFlatButton2_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Multiselect = false;//是否允许选择多个文件
            dialog.Title = "请选择文件";
            dialog.Filter = "txt文本文档(*.txt*)|*.txt*";//格式
           // dialog.ShowDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                string[] names = dialog.FileNames;

                foreach (string file in names)
                {
                 //   MessageBox.Show("已选择文件:" + file, "选择文件提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                   this.textBox1.Text = file;
                }
                

            }
        }

        private void materialFlatButton3_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
            this.Hide();
        }
    }
}
