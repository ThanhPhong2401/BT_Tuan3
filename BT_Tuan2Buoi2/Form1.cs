using System;

namespace BT_Tuan2Buoi2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string hoTen = txtHoTen.Text.Trim();

            string ngaySinh = dtpNgaySinh.Value.ToString("dd/MM/yyyy"); 

            string gioiTinh = "";
            if (radNam.Checked) 
            {
                gioiTinh = "Nam";
            }
            else if (radNu.Checked) 
            {
                gioiTinh = "Nu";
            }

       
            List<string> soThich = new List<string>();
            if (chkTheThao.Checked) soThich.Add("The thao"); 
            if (chkPhimAnh.Checked) soThich.Add("Phim anh"); 
            if (chkDuLich.Checked) soThich.Add("Du lich");  
            string chuoiSoThich = soThich.Count > 0 ? string.Join(", ", soThich) : "Khong co";


            string thongTin = $"Ho ten: {hoTen}\n" +
                              $"Ngay sinh: {ngaySinh}\n" +
                              $"Gioi tinh: {gioiTinh}\n" +
                              $"So thich: {chuoiSoThich}";

            MessageBox.Show(thongTin, "Thong tin nguoi dung", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
    