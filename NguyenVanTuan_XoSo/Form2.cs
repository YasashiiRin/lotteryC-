using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace NguyenVanTuan_XoSo
{
    public partial class Form2 : Form
    {
        private String gettgroll;
        public Form2()
        {
            InitializeComponent();
        }
        public Form2(String tgquay)
        {
            InitializeComponent();
            this.gettgroll=tgquay;
        }
        int demmls = 0, dotre = 2,demmls2 = 0,demmls3 = 0;
        int set_tg_roll=2;
        string line, ngayxo = "", daiso = "";
        Random rd
            = new Random();
        string tenfile = @"C:\Users\FPT SHOP\Documents\HK_I_N42022_2023\Lập trinfhh Window\ReadFile\Xoso.txt";
        private DateTime StartTime;
        private DateTime StartTime2;
        private DateTime StartTime3;
        private void button2_Click(object sender, EventArgs e)
        {
            new FrmTuan().Show();
            this.Hide();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            new Form1().Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            lbdbt1.Text = " ";
            lbg1b1.Text = " ";
            lbg2t1.Text = " ";
            lbg4b1.Text = " ";
            lbg5b1.Text = " ";
            lbg6t1.Text = " ";
            lbg7n1.Text = " ";
            lbg8n1.Text = " ";
            timer1.Stop();
            timer1.Start();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button47_Click_1(object sender, EventArgs e)
        {
            string tendai = ccbnamedai.Text;

            string ngayxo = dtngayxo.Text;

            string MB = "\n" +tendai+ "," + ngayxo + "," + lbdbt1.Text.Replace(" ", "") + "," + lbg1t1.Text.Replace(" ", "") + "," + lbg2t1.Text.Replace(" ", "") +"," + lbg3b2.Text.Replace(" ", "") +"," + lbg3n2.Text.Replace(" ", "") + "," + lbg4b1.Text.Replace(" ", "") + "," + lbg4b3.Text.Replace(" ", "") + "," + lbg4t1.Text.Replace(" ", "") + "," + lbg4t2.Text.Replace(" ", "") + "," + lbg4t3.Text.Replace(" ", "") + "," + lbg4n1.Text.Replace(" ", "") + "," + lbg4n3.Text.Replace(" ", "") + "," + lbg5t1.Text.Replace(" ", "") + "," + lbg6b1.Text.Replace(" ", "") + "," + lbg6t1.Text.Replace(" ", "") + "," + lbg6n1.Text.Replace(" ", "") + "," + lbg7t1.Text.Replace(" ", "") + "," + lbg8t1.Text.Replace(" ", "");

            File.AppendAllText(tenfile, MB);

            String[] a = File.ReadAllLines(tenfile);
            for (int i = 0; i < a.Length; ++i)
            {
                Console.Write(i + ". ");
                Console.WriteLine(a[i]);
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            timer1.Enabled = !timer1.Enabled;
            btnStart.Text = timer1.Enabled ? "Stop" : "Start";
            StartTime = DateTime.Now;
        }
        string get_tg;
        private void Form2_Load(object sender, EventArgs e)
        {
            get_tg = gettgroll;
            if (get_tg == null)
            {
                gettg.Text = "thời gian quay trễ mặc định";
                set_tg_roll = 2;
            }
            else if (get_tg != null)
            {
                gettg.Text = "thời gian quay trễ là :" + gettgroll;
                set_tg_roll = int.Parse(get_tg);
            }
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            new CauHinh().Show();
            this.Hide();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            get_tg = gettgroll;
            set_tg_roll = int.Parse(get_tg);
        }

        private void button9_Click_1(object sender, EventArgs e)
        {
            timer2.Start();
            StartTime2 = DateTime.Now;
        }
        private void timer3_Tick(object sender, EventArgs e)
        {
            demmls3 = demmls3 + timer2.Interval;
            int giay = demmls3 / 1000;
            if (giay <= set_tg_roll)
            {
                lbg8t1.Text = Quayso(2);

            }
            else if (giay <= set_tg_roll * 2)
            {
                lbg7t1.Text = Quayso(3);
            }
            else if (giay <= set_tg_roll * 3)
            {
                lbg6b1.Text = Quayso(4);
            }
            else if (giay <= set_tg_roll * 4)
            {
                lbg6t1.Text = Quayso(4);
            }
            else if (giay <= set_tg_roll * 5)
            {
                lbg6n1.Text = Quayso(4);

            }
            else if (giay <= set_tg_roll * 6)
            {
                lbg5t1.Text = Quayso(4);
            }
            else if (giay <= set_tg_roll * 7)
            {
                lbg4b1.Text = Quayso(5);
            }
            else if (giay <= set_tg_roll * 8)
            {
                lbg4b3.Text = Quayso(5);
            }
            else if (giay <= set_tg_roll * 9)
            {
                lbg4t1.Text = Quayso(5);
            }
            else if (giay <= set_tg_roll * 10)
            {
                lbg4t2.Text = Quayso(5);
            }
            else if (giay <= set_tg_roll * 11)
            {
                lbg4t3.Text = Quayso(5);
            }
            else if (giay <= set_tg_roll * 12)
            {
                lbg4n1.Text = Quayso(5);
            }
            else if (giay <= set_tg_roll * 13)
            {
                lbg4n3.Text = Quayso(5);
            }
            else if (giay <= set_tg_roll * 14)
            {
                lbg3b2.Text = Quayso(5);
                lbg3n2.Text = Quayso(5);
            }
            else if (giay <= set_tg_roll * 15)
            {
                lbg2t1.Text = Quayso(5);
            }
            else if (giay <= set_tg_roll * 16)
            {
                lbg1t1.Text = Quayso(5);
                lbdbt1.Text = Quayso(6);
            }
            else if (giay <= set_tg_roll * 17)
            {
                timer3.Stop();
                string tendai = ccbnamedai.Text;

                string ngayxo = dtngayxo.Text;

                string MB = "\n" + tendai + "," + ngayxo + "," + lbdbt1.Text.Replace(" ", "") + "," + lbg1t1.Text.Replace(" ", "") + "," + lbg2t1.Text.Replace(" ", "") + "," + lbg3b2.Text.Replace(" ", "") + "," + lbg3n2.Text.Replace(" ", "") + "," + lbg4b1.Text.Replace(" ", "") + "," + lbg4b3.Text.Replace(" ", "") + "," + lbg4t1.Text.Replace(" ", "") + "," + lbg4t2.Text.Replace(" ", "") + "," + lbg4t3.Text.Replace(" ", "") + "," + lbg4n1.Text.Replace(" ", "") + "," + lbg4n3.Text.Replace(" ", "") + "," + lbg5t1.Text.Replace(" ", "") + "," + lbg6b1.Text.Replace(" ", "") + "," + lbg6t1.Text.Replace(" ", "") + "," + lbg6n1.Text.Replace(" ", "") + "," + lbg7t1.Text.Replace(" ", "") + "," + lbg8t1.Text.Replace(" ", "");

                File.AppendAllText(tenfile, MB);
            }
        }
        int count;
        private void timer2_Tick(object sender, EventArgs e)
        {
            TimeSpan elapsed = DateTime.Now - StartTime2;

            string text = "";
            if (elapsed.Days > 0)
                text += elapsed.Days.ToString() + ".";

            int tenths = elapsed.Milliseconds;

            text += elapsed.Seconds.ToString("00");
            string time = text;
            count = int.Parse(time);
            demmls2 = demmls2 + timer1.Interval;
            int check = 1;
            int s = demmls2 / 1000;
           
            if (s==5) {
                timer3.Start();           
            }
        }


        string Quayso(int sochuso)
        {
            if (sochuso == 2)
            {
                return (rd.Next(10) + " " + rd.Next(10));
            }
            if (sochuso == 3)
            {
                return (rd.Next(10) + " " + rd.Next(10) + " " + rd.Next(10));

            }
            if (sochuso == 4)
            {
                return (rd.Next(10) + " " + rd.Next(10) + " " + rd.Next(10) + " " + rd.Next(10));

            }
            if (sochuso == 5)
            {
                return (rd.Next(10) + " " + rd.Next(10) + " " + rd.Next(10) + " " + rd.Next(10) + " " + rd.Next(10));

            }
            if (sochuso == 6)
            {
                return (rd.Next(10) + " " + rd.Next(10) + " " + rd.Next(10) + " " + rd.Next(10) + " " + rd.Next(10) + " " + rd.Next(10));

            }
            return null;

        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            demmls = demmls + timer1.Interval;
            int giay = demmls / 1000;
    
            if (giay <= set_tg_roll)
            {
                lbg8t1.Text = Quayso(2);

            }
            else if (giay <= set_tg_roll * 2)
            {
                lbg7t1.Text = Quayso(3);
            }
            else if (giay <= set_tg_roll * 3)
            {
                lbg6b1.Text = Quayso(4);
            }
            else if (giay <= set_tg_roll * 4)
            {
                lbg6t1.Text = Quayso(4);
            }
            else if (giay <= set_tg_roll * 5)
            {
                lbg6n1.Text = Quayso(4);

            }
            else if (giay <= set_tg_roll * 6)
            {
                lbg5t1.Text = Quayso(4);
            }
            else if (giay <= set_tg_roll * 7)
            {
                lbg4b1.Text = Quayso(5);
            }
            else if (giay <= set_tg_roll * 8)
            {
                lbg4b3.Text = Quayso(5);
            }
            else if (giay <= set_tg_roll * 9)
            {
                lbg4t1.Text = Quayso(5);
            }
            else if (giay <= set_tg_roll * 10)
            {
                lbg4t2.Text = Quayso(5);
            }
            else if (giay <= set_tg_roll * 11)
            {
                lbg4t3.Text = Quayso(5);
            }
            else if (giay <= set_tg_roll * 12)
            {
                lbg4n1.Text = Quayso(5);
            }
            else if (giay <= set_tg_roll * 13)
            {
                lbg4n3.Text = Quayso(5);
            }
            else if (giay <= set_tg_roll * 14)
            {
                lbg3b2.Text = Quayso(5);
                lbg3n2.Text = Quayso(5);
            }
            else if (giay <= set_tg_roll * 15)
            {
                lbg2t1.Text = Quayso(5);
            }
            else if (giay <= set_tg_roll * 16)
            {
                lbg1t1.Text = Quayso(5);
                lbdbt1.Text = Quayso(6);
            }

        }

        internal void Sender(object text)
        {
            throw new NotImplementedException();
        }
    }
}
