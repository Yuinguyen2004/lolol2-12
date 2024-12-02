using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static BTVN_2_12_2024.Form1;

namespace BTVN_2_12_2024
{
    public partial class Form2 : Form
    {
        public string MSNV { get; set; }
        public string Name { get; set; }
        public string Luong { get; set; }

        private UpdateNhanVienDelegate _updateNhanVienDelegate;
        public Form2(UpdateNhanVienDelegate updateNhanVienDelegate)
        {
            InitializeComponent();
            _updateNhanVienDelegate = updateNhanVienDelegate;
        }

        public Form2(UpdateNhanVienDelegate updateNhanVienDelegate, string msnv, string name, string luong) 
        {
            InitializeComponent();
            _updateNhanVienDelegate = updateNhanVienDelegate;
            MSNV = msnv;
            Name = name;
            Luong = luong;

            txt_msnv.Text = msnv;
            txt_name.Text = name;
            txt_luong.Text = luong;
        }
        private void Form2_Load(object sender, EventArgs e)
        {
 
        }

        private void btn_yes_Click(object sender, EventArgs e)
        {
            MSNV = txt_msnv.Text;
            Name = txt_name.Text;
            Luong = txt_luong.Text;

            _updateNhanVienDelegate(MSNV, Name, Luong);

            DialogResult = DialogResult.OK;
            Close();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
