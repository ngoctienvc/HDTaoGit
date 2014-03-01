using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Baitap2
{
    public partial class Form1 : Form
    {
        class PhanSo
        {
            private int _tuso;
            public int TuSo
            {
                get { return _tuso; }
                set { _tuso = value; }
            }
            private int _mauso;
            public int MauSo
            {
                get { return _mauso; }
                set { _mauso = value; }
            }
            public PhanSo()
            {
                _tuso = 0;
                _mauso = 1;
            }
            public PhanSo(string chuoi)
            {
                string[] mang = chuoi.Split('/');
                _tuso = int.Parse(mang[0]);
                _mauso = int.Parse(mang[1]);
            }
            public static bool KiemTraChuoiPhanSo(string chuoi)
            {
                string[] mang = chuoi.Split('/');
                if (mang.Length != 2) return false;
                int number;
                if (int.TryParse(mang[0], out number) == false) return false;
                if (int.TryParse(mang[1], out number) == false) return false;
                return true;
            }
            public override string ToString()
            {
                string chuoi = TuSo.ToString() + "/" + MauSo.ToString();
                return chuoi;
            }
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonThem_Click(object sender, EventArgs e)
        {
            string chuoi = textBoxGiaTri.Text;
            PhanSo phanso1;
            if (PhanSo.KiemTraChuoiPhanSo(chuoi) == true)
            {
                phanso1 = new PhanSo(chuoi);
                comboBoxMang.Items.Add(phanso1);
            }
            else
            {
                MessageBox.Show("Sai du lieu nhap", "Thong bao");
            }
        }

        private void buttonXoa_Click(object sender, EventArgs e)
        {
            if (comboBoxMang.SelectedIndex != -1)
            {
                comboBoxMang.Items.RemoveAt(comboBoxMang.SelectedIndex);
            }
            else
            {
                MessageBox.Show("Ban chua chon phan tu can xoa", "Thong bao");
            }
        }

        private void buttonSua_Click(object sender, EventArgs e)
        {
            if (comboBoxMang.SelectedIndex != -1)
            {
                string str1 = textBoxGiaTri.Text;
                PhanSo ps = new PhanSo(str1);
                comboBoxMang.Items[comboBoxMang.SelectedIndex] = ps;
            }
            else
            {
                MessageBox.Show("Ban chua chon phan tu can sua", "Thong bao");
            }
        }

        private void buttonGhifile_Click(object sender, EventArgs e)
        {
            // hien thi dialog ghi file
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "Ghi tap tin txt|*.txt";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                // lay duong dan file can ghi
                string duongdan = dialog.FileName;
                // ghi mang xuong file
                StreamWriter ghi = new StreamWriter(duongdan);
                for (int i = 0; i < comboBoxMang.Items.Count; i++)
                {

                }
                for (int i = 0; i < comboBoxMang.Items.Count; i++)
                {
                    ghi.WriteLine(comboBoxMang.Items[i]);
                }
                ghi.Close();
            }
        }

        private void buttonDocfile_Click(object sender, EventArgs e)
        {
            // xoa het cac phan tu dang co combobox
            comboBoxMang.Items.Clear();
            // hien thi dialog doc file
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Doc tap tin txt|*.txt";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                // lay duong dan file can doc
                string duongdan = dialog.FileName;
                // doc mang tu file
                StreamReader doc = new StreamReader(duongdan);
                PhanSo phanso1;
                while (!doc.EndOfStream)
                {
                    string str = doc.ReadLine();
                    phanso1 = new PhanSo(str);
                    comboBoxMang.Items.Add(str);
                }

                doc.Close();
            }
        }

       
    }
}
