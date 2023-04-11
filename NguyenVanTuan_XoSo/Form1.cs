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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string tenfile = @"C:\Users\FPT SHOP\Documents\HK_I_N42022_2023\Lập trinfhh Window\ReadFile\Xoso.txt";
        private void button1_Click(object sender, EventArgs e)
        {

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
                            displaymien.Text = "bạn đã truy vấn dò kết quả xổ số :" + "\n" + searchdai + " vào ngày :" + datesearch;
                            Displaynum.Text = "dãy số của bạn là :" + num;
                            giai = (j - 2).ToString();
                            if (giai == "0") giai = "Đặc biệt";
                            if (giai == "1") giai = "Giải Nhất";
                            if (giai == "2") giai = "Giải Nhì";
                            if (giai == "3" || giai == "4") giai = "Giải Ba";
                            if (giai == "5" || giai == "6" || giai == "7" || giai == "8" || giai == "9" || giai == "10" || giai == "11") giai = "Giai Bốn";
                            if (giai == "12") giai = "Giải năm";
                            if (giai == "13" || giai == "14" || giai == "15") giai = "Giải Sáu";
                            if (giai == "16") giai = "Giải Bảy";
                            if (giai == "17") giai = "Giải Tám";
                            Displayrs.Text = "chúc mừng bạn da trung giai :" + giai;
                            break;
                        }

                        else if (tach[j] != num)
                        {
                            displaymien.Text = "bạn đã truy vấn dò kết quả xổ số :" + "\n" + searchdai + " vào ngày :" + datesearch;
                            Displaynum.Text = "dãy số của bạn là :" + num;
                            Displayrs.Text = "chúc bạn may mắn lần sau số bn chọn ko có";
                        }
                        lbdbt1.Text=tach[2];
                        lbg1t1.Text=tach[3];
                        lbg2t1.Text=tach[4];
                        lbg3b2.Text = tach[5];
                        lbg3n2.Text = tach[6];
                        lbg4b1.Text = tach[7];
                        lbg4b3.Text = tach[8];
                        lbg4t1.Text = tach[9];
                        lbg4t2.Text = tach[10];
                        lbg4t3.Text = tach[11];
                        lbg4n1.Text = tach[12];
                        lbg4n3.Text = tach[13];
                        lbg5t1.Text = tach[14];
                        lbg6b1.Text = tach[15];
                        lbg6t1.Text = tach[16];
                        lbg6n1.Text = tach[17];
                        lbg7t1.Text = tach[18];
                        lbg8t1.Text = tach[19];

                    }
                    int dem = 0;
                    char[] arrSove = num.ToCharArray();
                    char[] arrKQDB = tach[2].ToCharArray();
                    if (arrSove[0] != arrKQDB[0])
                    {
                        label3.Text = "____________________";
                        break;
                    }
                    for (int y = 1; y < arrSove.Length; y++)
                    {
                        if (arrSove[y] == arrKQDB[y])
                        {
                            dem++;
                        }
                       
                    }
                    if (dem == 4)
                    {
                        label3.Text = "chúc mừng bạn được giải khuyến khích ";
                    }
                    else { label3.Text = "______________"; ; }
                }

            }
        }
        /*private bool DoKK(string soVeSo)
        {
            int dem = 0;
            char[] arrSove = soVeSo.ToCharArray();
            char[] arrKQDB = arrKQ[19].ToCharArray();
            if (arrSove[0] != arrKQDB[0]) return false;
            for (int i = 0; i < arrSove.Length; i++)
            {
                if (arrSove[i] == arrKQDB[i])
                {
                    dem++;
                }
                if (dem == 4)
                {
                    return true;
                }
                else { return false; }
            }
        }*/
        private void button4_Click(object sender, EventArgs e)
        {
            new Form2().Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            new FrmTuan().Show();
            this.Hide();
        }
    }
}
