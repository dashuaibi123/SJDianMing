using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.IO;


namespace WindowsFormsApp1
{
    public partial class Form2 : MaterialForm
    {
        public Form2()
        {
            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = false;//不检查异线程操作控件
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
        }

        public void creatForm3()
        {
            Form3 form3 = new Form3();
            form3.ShowDialog();

        }
        public void creatForm1()
        {
            Form1 form1 = new Form1();
            form1.Show();
        }
        public void jianChaXingMing()
        {
            String su;//数据文件内容
            int studentsNumber = 0;//学生总数
            
            if (File.Exists("dianming.txt"))//查看是否存在名单记录文件
            {
                StreamReader streamReader = new StreamReader("dianming.txt",Encoding.UTF8);
                if((su = streamReader.ReadToEnd()) == null)
                {
                    MessageBox.Show("名字信息不存在或没有数据！", "请检查是否存在名字数据");
                    materialLabel1.Text = "没有数据！";
                }
                else
                {
                    streamReader.BaseStream.Seek(0, SeekOrigin.Begin);//指针指向第一行
                    while ((su=streamReader.ReadLine())!=null)
                       {
                        studentsNumber = studentsNumber+1;
                       }
                    materialLabel1.Text = "数据已定位，总学生数："+studentsNumber;
                }
             
            }//查找数据文件
            else
            {
                
                if (MessageBox.Show("没有检测到名单文件，是否创建？","无名单文件",MessageBoxButtons.YesNo)==DialogResult.Yes)
                {

                    if (this.InvokeRequired)//使用委托创建窗口
                    {
                        this.Invoke(new MethodInvoker(delegate { creatForm3(); }));
                        return;
                    }
                    
                }
                else
                {
                    if (this.InvokeRequired)//使用委托创建窗口
                    {
                        this.Invoke(new MethodInvoker(delegate { creatForm1(); }));
                        return;
                    }
                    Form1 form1 = new Form1();
                    form1.ShowDialog();
                    this.Hide();

                }
            }
            
        }
        private void Form2_Load(object sender, EventArgs e)
        {

            ThreadStart threadStart = new ThreadStart(jianChaXingMing);//设置子线程
            Thread thread = new Thread(threadStart);
            thread.Start();//子线程启动
                           //   thread.Abort();
            ThreadStart threadStart1 = new ThreadStart(StartDianMing);
            thread1 = new Thread(threadStart1);
            
          
        }
        public static Thread thread1;
        private void materialFlatButton1_Click(object sender, EventArgs e)
        {

            ThreadStart threadStart = new ThreadStart(StartDianMing);

            if (materialFlatButton1.Text == "开始")
            {
                thread1 = new Thread(threadStart);
                thread1.Start();
                materialFlatButton1.Text = "停止";
            }
            else
            {
                thread1.Abort();
                materialFlatButton1.Text = "开始";
            }
        }

        public void StartDianMing()
        {
            String su;//数据文件内容
            int studentsNumber =0;//学生总数
            object[] studentName = new object[1000];

        StreamReader streamReader = new StreamReader("dianming.txt");
            streamReader.BaseStream.Seek(0, SeekOrigin.Begin);//指针指向第一行
            while ((su = streamReader.ReadLine()) != null)
            {
               studentName[studentsNumber] = su.Replace(" ","");//去掉所有空格
               studentsNumber = studentsNumber+1;//读取学生数据，置于数组
            }
            Image[] images = { WindowsFormsApp1.Properties.Resources.jiangxia, WindowsFormsApp1.Properties.Resources.hh, WindowsFormsApp1.Properties.Resources.hecha, WindowsFormsApp1.Properties.Resources.hala, WindowsFormsApp1.Properties.Resources.ciya, WindowsFormsApp1.Properties.Resources.duzui, WindowsFormsApp1.Properties.Resources.weisuo, WindowsFormsApp1.Properties.Resources.diaoyan, WindowsFormsApp1.Properties.Resources.pei, WindowsFormsApp1.Properties.Resources.wunai };//这里写图片地址
            Random random = new Random();
            
            while (materialFlatButton1.Text == "停止")
            {
                
                int dianhao=random.Next(studentsNumber);
                label1.Text = studentName[dianhao].ToString();
                pictureBox1.Image =images[random.Next(images.Length)];//随机图片
                Thread.Sleep(50);//休眠
            }

        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (thread1.IsAlive)
            {
            thread1.Abort();

            }
        }
    }
}
