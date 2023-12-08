using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp_Test1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            dtpNgaySinh.Value = DateTime.Now.AddYears(-20);

            rdoNam.Checked = true;

            cboTrinhDo.Items.Add("Tien si");
            cboTrinhDo.Items.Add("Thac sy");
            cboTrinhDo.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var HoTen = txtHoTen.Text.Trim();
            var NgaySinh = Convert.ToDateTime(dtpNgaySinh.Value).ToString("dd/MM/yy");
            var GioiTinh = "-1";
            if (rdoNam.Checked == true)
            {
                GioiTinh = "Nam";
            }
            else
            {
                GioiTinh = "Nu";
            }

            var TrinhDo = cboTrinhDo.Text.Trim();

            var DangKi = "";
            if (chkDangKi.Checked == true) 
            {
                DangKi = "Dang ki khoa hoc";
            }
            else
            {
                DangKi = "Khong dang ki khoa hoc";
            }

            string ThongBao = "Thi sinh:" + HoTen + " sinh ngay: " + NgaySinh + " Gioi tinh " + GioiTinh + " Co trinh do hoc van " + TrinhDo + DangKi;

            MessageBox.Show(ThongBao, "Thong bao");
        }
    }
}
