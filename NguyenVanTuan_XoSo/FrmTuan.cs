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

namespace NguyenVanTuan_XoSo
{
    public partial class FrmTuan : Form
    {
        private String gettgroll;
        public FrmTuan()
        {
            InitializeComponent();
        }
        public FrmTuan(String tgquay)
        {
            InitializeComponent();
            this.gettgroll = tgquay;
        }
        int demmls = 0, dotre = 2;
        int set_tg_roll = 2;
        Random rd
            = new Random();
        string tenfile = @"C:\Users\FPT SHOP\Documents\HK_I_N42022_2023\Lập trinfhh Window\ReadFile\Xoso.txt";

        private void button18_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            /*TimeSpan elapsed = DateTime.Now - StartTime;

            string text = "";
            int sc;
            if (elapsed.Days > 0)
                text += elapsed.Days.ToString() + ".";

            int tenths = elapsed.Milliseconds;

            text += elapsed.Seconds.ToString("00");
            counttime.Text = text;
            sc = int.Parse(counttime.Text);*/
            demmls = demmls + timer1.Interval;
            int giay = demmls / 1000;
            if (giay <= set_tg_roll)
            {
                lbg8b1.Text = Quayso(2);
                lbg8t1.Text=Quayso(2);
                lbg8n1.Text = Quayso(2);

            }
            else if (giay <= set_tg_roll * 2)
            {
                lbg7b1.Text = Quayso(3);
                lbg7t1.Text= Quayso(3);
                lbg7n1.Text= Quayso(3);
            }
            else if (giay <= set_tg_roll * 3)
            {
               
                lbg6b1.Text = Quayso(4);
                lbg6b2.Text = Quayso(4);
                lbg6b3.Text = Quayso(4);
                lbg6t1.Text = Quayso(4);
                lbg6t2.Text = Quayso(4);
                lbg6t3.Text = Quayso(4);
                lbg6n1.Text = Quayso(4);
                lbg6n2.Text = Quayso(4);
                lbg6n3.Text = Quayso(4);

            }
            else if (giay <= set_tg_roll * 4)
            {
                lbg5b1.Text = Quayso(4);
                lbg5t1.Text = Quayso(4);
                lbg5n1.Text = Quayso(4);
            }
            else if (giay <= set_tg_roll * 5)
            {
                lbg4b1.Text = Quayso(5);
                lbg4b2.Text = Quayso(5);
                lbg4b3.Text = Quayso(5);
                lbg4b4.Text = Quayso(5);
                lbg4b5.Text = Quayso(5);
                lbg4b6.Text = Quayso(5);
                lbg4b7.Text = Quayso(5);
                lbg4t1.Text = Quayso(5);
                lbg4t2.Text = Quayso(5);
                lbg4t3.Text = Quayso(5);
                lbg4t4.Text = Quayso(5);
                lbg4t5.Text = Quayso(5);
                lbg4t6.Text = Quayso(5);
                lbg4t7.Text = Quayso(5);
                lbg4n1.Text = Quayso(5);
                lbg4n2.Text = Quayso(5);
                lbg4n3.Text = Quayso(5);
                lbg4n4.Text = Quayso(5);
                lbg4n5.Text = Quayso(5);
                lbg4n6.Text = Quayso(5);
                lbg4n7.Text = Quayso(5);

            }
            else if (giay <= set_tg_roll * 6)
            {
                lbg3b1.Text = Quayso(5);
                lbg3t1.Text = Quayso(5);
                lbg3n1.Text = Quayso(5);
                lbg3b2.Text = Quayso(5);
                lbg3t2.Text = Quayso(5);
                lbg3n2.Text = Quayso(5);
            }
            else if (giay <= set_tg_roll * 7)
            {
                lbg2b1.Text = Quayso(5);
                lbg2t1.Text = Quayso(5);
                lbg2n1.Text = Quayso(5);
            }
            else if (giay <= set_tg_roll * 8)
            {
                lbg1b1.Text = Quayso(5);
                
            }
            else if (giay <= set_tg_roll * 9)
            {
                lbg1t1.Text = Quayso(5);
            }
            else if (giay <= set_tg_roll * 10)
            {
                lbg1n1.Text = Quayso(5);
            }
            else if (giay <= set_tg_roll * 11)
            {
                lbdbb1.Text = Quayso(6);
            }
            else if (giay <= set_tg_roll * 12)
            {
                lbdbt1.Text = Quayso(6);
            }
            else if (giay <= set_tg_roll * 13)
            {
                lbdbn1.Text = Quayso(6);
            }
            
        }
        private DateTime StartTime;

        private void button1_Click(object sender, EventArgs e)
        {/*

            string num = numsearch.Text;
            String[] a = File.ReadAllLines(tenfile);
            int i;
            bool m;
            bool n;
            string datesearch = dateTimePicker1.Text;
            string giai;
            for (i = 0; i < a.Length; i++)
            {
                string searchdai = ccbselect.SelectedItem.ToString();

                m = a[i].Contains(searchdai);
                n = a[i].Contains(datesearch);

                if (m && n)
                {
                    string[] tach = a[i].Split(',');
                    for (int j = 0; j < tach.Length; j++)
                    {
                        if (tach[j] == num)
                        {
                            label16.Text = "bạn đã truy vấn dò kết quả xổ số :" + "\n" + searchdai + " vào ngày :" + datesearch;
                            label15.Text = "dãy số của bạn là :" + num;
                            giai = (j - 2).ToString();
                            if (giai == "0") giai = "Đặc biệt";
                            label17.Text = "chúc mừng bạn da trung giai :" + giai;
                            break;
                        }

                        else if (tach[j] != num)
                        {
                            label16.Text = "bạn đã truy vấn dò kết quả xổ số :" + "\n" + searchdai + " vào ngày :" + datesearch;
                            label15.Text = "dãy số của bạn là :" + num;
                            label17.Text = "chúc bạn may mắn lần sau số bn chọn ko có";
                        }

                    }

                }

            }*/
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            new Form1().Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new Form2().Show();
            this.Hide();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            timer1.Enabled = !timer1.Enabled;
            btnStart.Text = timer1.Enabled ? "Stop" : "Start";
            StartTime = DateTime.Now;
        }

        private void button1kk_Click(object sender, EventArgs e)
        {

        }

        private void button29_Click(object sender, EventArgs e)
        {

        }

        private void button30_Click(object sender, EventArgs e)
        {

        }

        private void lbg8n1_Click(object sender, EventArgs e)
        {

        }

        private void lbg4b6_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            new CauHinh().Show();
            this.Hide();
        }

        private void button47_Click_1(object sender, EventArgs e)
        {
            string QuangBinh = XSMB.Text;
            string DaNang = XSMT.Text;
            string Quangnam = XSMN.Text;
            string ngayxo = dtngayxo.Text;

            string MB = "\n" + QuangBinh + "," + ngayxo + "," + lbdbb1.Text.Replace(" ", "") + "," + lbg1b1.Text.Replace(" ", "") + "," + lbg2b1.Text.Replace(" ", "") + "," + lbg3b1.Text.Replace(" ", "") + "," + lbg3b2.Text.Replace(" ", "") + "," + lbg4b1.Text.Replace(" ", "") + "," + lbg4b2.Text.Replace(" ", "") + "," + lbg4b3.Text.Replace(" ", "") + "," + lbg4b4.Text.Replace(" ", "") + "," + lbg4b5.Text.Replace(" ", "") + "," + lbg4b6.Text.Replace(" ", "") + "," + lbg4b7.Text.Replace(" ", "") + "," + lbg5b1.Text.Replace(" ", "") + "," + lbg6b1.Text.Replace(" ", "") + "," + lbg6b2.Text.Replace(" ", "") + "," + lbg6b3.Text.Replace(" ", "") + "," + lbg7b1.Text.Replace(" ", "") + "," + lbg8b1.Text.Replace(" ", "");
            string MT = "\n" + DaNang + "," + ngayxo + "," + lbdbt1.Text.Replace(" ", "") + "," + lbg1t1.Text.Replace(" ", "") + "," + lbg2t1.Text.Replace(" ", "") + "," + lbg3t1.Text.Replace(" ", "") + "," + lbg3t2.Text.Replace(" ", "") + "," + lbg4t1.Text.Replace(" ", "") + "," + lbg4t2.Text.Replace(" ", "") + "," + lbg4t3.Text.Replace(" ", "") + "," + lbg4t4.Text.Replace(" ", "") + "," + lbg4t5.Text.Replace(" ", "") + "," + lbg4t6.Text.Replace(" ", "") + "," + lbg4t7.Text.Replace(" ", "") + "," + lbg5t1.Text.Replace(" ", "") + "," + lbg6t1.Text.Replace(" ", "") + "," + lbg6t2.Text.Replace(" ", "") + "," + lbg6t3.Text.Replace(" ", "") + "," + lbg7t1.Text.Replace(" ", "") + "," + lbg8t1.Text.Replace(" ", "");
            string MN = "\n" + Quangnam + "," + ngayxo + "," + lbdbn1.Text.Replace(" ", "") + "," + lbg1n1.Text.Replace(" ", "") + "," + lbg2n1.Text.Replace(" ", "") + "," + lbg3n1.Text.Replace(" ", "") + "," + lbg3n2.Text.Replace(" ", "") + "," + lbg4n1.Text.Replace(" ", "") + "," + lbg4n2.Text.Replace(" ", "") + "," + lbg4n3.Text.Replace(" ", "") + "," + lbg4n4.Text.Replace(" ", "") + "," + lbg4n5.Text.Replace(" ", "") + "," + lbg4n6.Text.Replace(" ", "") + "," + lbg4n7.Text.Replace(" ", "") + "," + lbg5n1.Text.Replace(" ", "") + "," + lbg6n1.Text.Replace(" ", "") + "," + lbg6n2.Text.Replace(" ", "") + "," + lbg6n3.Text.Replace(" ", "") + "," + lbg7n1.Text.Replace(" ", "") + "," + lbg8n1.Text.Replace(" ", "");
            File.AppendAllText(tenfile, MB);
            File.AppendAllText(tenfile, MT);
            File.AppendAllText(tenfile, MN);
            String[] a = File.ReadAllLines(tenfile);
            for (int i = 0; i < a.Length; ++i)
            {
                Console.Write(i + ". ");
                Console.WriteLine(a[i]);
            }
        }

        private void button46_Click(object sender, EventArgs e)
        {
          
        }
        string get_tg;
        private void FrmTuan_Load(object sender, EventArgs e)
        {
            get_tg = gettgroll;
            if (get_tg==null)
            {
                gettg.Text = "thời gian quay trễ là mặc định";
                set_tg_roll = 2;
            }
            else if (get_tg!=null)
            {
                gettg.Text = "thời gian quay trễ là :"+gettgroll;
                set_tg_roll = int.Parse(get_tg);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {

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
    }
}
