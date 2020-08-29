using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.Text.RegularExpressions;
using MaterialSkin.Controls;
using MaterialSkin;

namespace WindowsFormsApp1
{
    public partial class Form7 : MaterialForm
    {
        public Form7()
        {
            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = false;//不检查异线程操作控件
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("当该组人数和其他组不统一时，便算入例外\n没有例外的话，请不要勾选","例外",MessageBoxButtons.OK);
        }

        public void threadNew()//子线程
        {
            Image[] images = { WindowsFormsApp1.Properties.Resources.jiangxia, WindowsFormsApp1.Properties.Resources.hh, WindowsFormsApp1.Properties.Resources.hecha, WindowsFormsApp1.Properties.Resources.hala, WindowsFormsApp1.Properties.Resources.ciya, WindowsFormsApp1.Properties.Resources.duzui, WindowsFormsApp1.Properties.Resources.weisuo, WindowsFormsApp1.Properties.Resources.diaoyan, WindowsFormsApp1.Properties.Resources.pei, WindowsFormsApp1.Properties.Resources.wunai };//这里写图片地址
            int[] group = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 32, 33, 34, 35, 36, 37, 38, 39, 40, 41, 42, 43, 44, 45, 46, 47, 48, 49, 50 };
            int[] groupAcc = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 32, 33, 34, 35, 36, 37, 38, 39, 40, 41, 42, 43, 44, 45, 46, 47, 48, 49, 50 };
            int[] zuHaoLiwai = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 32, 33, 34, 35, 36, 37, 38, 39, 40, 41, 42, 43, 44, 45, 46, 47, 48, 49, 50 }; 
            int groupNumber = (int)numericUpDown1.Value;//强制转换类型，十进制数-int 组名
            int groupAc = (int)numericUpDown2.Value;//强制转换类型   这里是组成员

            String jian = textBox3.Text;
            int shuX = textBox3.Text.Length - jian.Replace("|", "").Length;//计算一共分割了多少次
            //MessageBox.Show(shuX.ToString());//输出一共分割了多少次
            String fenge = jian.Replace("|", " ");//文本分割
            String[] array = Regex.Split(fenge, " ", RegexOptions.IgnoreCase);//文本合成数组  (组)
            //  int groupN = (int)groupNumber;//强制转换类型 double-int
            // int groupA = (int)groupAc;
           
            while (this.button1.Text=="停止")//循环开始
            {
               // if (this.button1.Text == "开始")
                //{
                 //   buttonZhuangTai = false;
                //}
                
                Random random = new Random();
                int zuName= random.Next(groupNumber);//生成随机组号
                Random random1 = new Random();
                int i=random1.Next(10);//随即图片编号
                Random acc = new Random();
                int zuAcc = random.Next(groupAc);//随机号
                int[] liwaiZu = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 32, 33, 34, 35, 36, 37, 38, 39, 40, 41, 42, 43, 44, 45, 46, 47, 48, 49, 50 };
                int[] liwaiZuCy = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 32, 33, 34, 35, 36, 37, 38, 39, 40, 41, 42, 43, 44, 45, 46, 47, 48, 49, 50 };
                int[] c= { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 32, 33, 34, 35, 36, 37, 38, 39, 40, 41, 42, 43, 44, 45, 46, 47, 48, 49, 50 };
                if (checkBox1.Checked == true)
                {
                    MessageBox.Show("请等待1.1版本更新", "暂未开放");
                  /*  while (r<=shuX)//等待更新
                    {
                       // MessageBox.Show("进入到了循环");
                        String fengeCy = array[r].Replace(",", " ");//成员分割
                        String[] arrayCy = Regex.Split(fengeCy," ", RegexOptions.IgnoreCase);//成员数组  （组成员）
                        int liWaiZuM = Convert.ToInt16(arrayCy[a]);
                        int liWaiZuCyM = Convert.ToInt16(arrayCy[a+1]);
                        liwaiZu[r]= Convert.ToInt16(arrayCy[a]);
                       // liwaiZuCy[r] = Convert.ToInt16(arrayCy[a+1]);
                        if (group[zuName] == liwaiZu[r])
                        {
                            Random zuSuiAcc = new Random();
                            //zuAcc= zuSuiAcc.Next(liwaiZuCy[r]);
                            zuAcc=zuSuiAcc.Next(Convert.ToInt16(arrayCy[a + 1]));
                            Thread.Sleep(1000);
                           MessageBox.Show(c[d].ToString());
                        
                        }
                        // MessageBox.Show(array[r]+"\n"+arrayCy[a]+"\n"+arrayCy[a+1] );
                       // MessageBox.Show(liwaiZuCy[r].ToString(), zuAcc.ToString()+"    "+ groupAcc[zuAcc].ToString());
                        r++;
                        d++;

                     // MessageBox.Show(liwaiZu[r].ToString()+"     "+liwaiZuCy[r].ToString()+"       "+zuName.ToString());
                    }

                    if (group[zuName] == liwaiZu[0])
                    {

                    }*/
                }
                this.pictureBox1.Image = images[i];
                this.label1.Text = group[zuName].ToString() + "组" + groupAcc[zuAcc].ToString()+ "号";//这里输出的不知道为什么，0个组0个人，能输出1，1.一个组一个人却也是输出1，1
                Thread.Sleep(50);//应该是数据类型转换造成的
            }
           

        }

            private void button1_Click(object sender, EventArgs e)//主线程
            {
            Button button1 = new Button();
            ThreadStart threadStart = new ThreadStart(threadNew);
            Thread thread = new Thread(threadStart);
            PictureBox pictureBox1 = new PictureBox();
            Label label1 = new Label();
            Label label2 = new Label();
            thread.IsBackground = true;

            if (this.button1.Text == "停止")
            {
                //                 
                thread.Abort();
                this.button1.Text = "开始";//转到等待开始状态
                                         //  this.label1.Text = "点击开始";
                //Thread.Sleep(100);
            }
            else
            {
                thread.Start();//启动子线程
                this.button1.Text = "停止";//转为等待停止状态
                                         //  this.label1.Text = "点击停止";

              //  Thread.Sleep(100);

            }

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
            if (MessageBox.Show("时间关系，这里还没有写完，Release1.1会写上", "略略略", MessageBoxButtons.OK)==DialogResult.OK)
            {
                checkBox1.Checked = false;
            }
            }
            
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_Enter(object sender, EventArgs e)
        {
            if(textBox3.Text== "（例外情况填写）哪组人数不统一 多个组号用\" | \"分开.\n格式:7,11|8,12")
            {
                textBox3.Text = "";
            }
        }

        private void textBox3_Leave(object sender, EventArgs e)
        {
            if (textBox3.Text == "")
            {
                textBox3.Text = "（例外情况填写）哪组人数不统一 多个组号用\" | \"分开.\n格式:7,11|8,12";
            }
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            this.textBox3.Text = "（例外情况填写）哪组人数不统一 多个组号用\" | \"分开.\n格式:7,11|8,12";
        }
    }
}//越看越乱了
