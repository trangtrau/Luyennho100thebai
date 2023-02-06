using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Nho_The_Bai
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            int so2 = RandomNumber(00, 100);
            labSo.Text = so2.ToString().PadLeft(2,'0');

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void labSo_Click(object sender, EventArgs e)
        {

        }
        public int RandomNumber(int min, int max)
        {
            Random random = new Random();
            return random.Next(min, max);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string[] boso = { "cái khiên", "cái móc", "cái hộc bàn", "cái bàn", "cái quạt", "cái nón", "cái sọt", "cái ly", "cái tivi", "cái chuông", "máy khoan", "máy may", "máy hút", "máy bay", "máy quạt", "máy nén", "máy xay", "máy lạnh", "máy tính", "máy chiếu", "hộp khăn giấy", "hộp mứt", "hộp hoa", "hộp bánh", "hộp quà", "hộp nuôi", "hộp sữa", "hộp ly", "hộp tăm", "hộp chia thuốc", "bánh khọt", "bánh mì", "bánh hỏi", "bánh bao", "bánh quy", "bánh nếp", "bánh xe", "bánh lăng", "bánh tét", "bánh chưng", "quả khế", "quả me", "quả hồng", "quả bóng", "quả quýt", "quả nho", "quả sầu riêng", "quả lê", "quả tạ", "quả chuối", "nồi kho", "nồi men", "nồi hơi", "nồi buffe", "nồi quánh bột", "nồi nướng", "nồi siêu tốc", "nồi lẩu", "nồi tiệt trùng", "nồi chiên", "xe khách", "xe máy","xe hơi" , "xe ben", "xe quân sự","xe nâng", "xe xúc", "xe lu", "xe tăng", "xe chữa cháy", "lá khoai", "lá mầm", "lá hành", "lá bài", "lá quất", "lá nếp", "lá su hào", "lá lốt", "lá thư", "lá chuối", "tàu không gian", "tàu mộc", "tàu hũ", "tàu bè", "tàu quân sự", "tàu ngầm", "tàu sắt", "tàu lửa", "tàu titanic", "tàu chuối", "con khỉ", "con mèo", "con heo", "con bò", "con quay", "con nai", "con sâu", "con lật đật", "con tôm", "con chuột" };
            int so;
            Int32.TryParse(labSo.Text, out so);
            string hangChuc = Convert.ToString(so % 100 / 10);
            string hangDonVi = Convert.ToString(so % 10);
            txtNhap.Focus();

            string data = txtNhap.Text;
            Thread newThread = new Thread(ketqua);

            if(string.Compare(data , boso[so],true) == 0)
            {
                txtNhap.Text = "";
                labKetQua.Text = "Bạn đã Đúng";
                labNoiDung.Text = "";


            }
            else
            {
                labKetQua.Text = "Bạn đã Sai";
                labNoiDung.Text = Convert.ToString(so) + " Là " + boso[so];
                txtNhap.Text = "";
            }

            int so2 = RandomNumber(0, 100);
            labSo.Text = so2.ToString();

        }

        private void ketqua()
        {
           
                labKetQua.Text = "Bạn đã Đúng";
                Thread.Sleep(800);
                labKetQua.Text = "";
           
        }

        private void txtNhap_TextChanged(object sender, EventArgs e)
        {
            labKetQua.Text = "";
        }
    }
}
