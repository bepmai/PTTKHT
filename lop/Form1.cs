using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Modify modify;
        TTLop ttlophoc;
        SV sinhvien;

        private void Form1_Load(object sender, EventArgs e)
        {
            modify = new Modify();
            try
            {
                dataGridView1.DataSource = modify.getAllTTLop();
                //dataGridView2.DataSource = modify.getAllTTSinhVien();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Loi:" + ex.Message, "Loi:", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            //
            try
            {
                //dataGridView1.DataSource = modify.getAllTTLop();
                dataGridView2.DataSource = modify.getAllTTSinhVien();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Loi:" + ex.Message, "Loi:", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //
        }

        private void button_Them_Click(object sender, EventArgs e)
        {
            string id = this.text_idclass.Text;
            string nameclass = this.text_nameclass.Text;
            string namesubject = this.text_namesub.Text;
            string nameteacher = this.text_nameteacher.Text;
            string numbLe = this.text_numberLea.Text;
            DateTime datecreate = this.date_create.Value;

            string iduser = this.text_iduser.Text;
            string username = this.text_username.Text;

            ttlophoc = new TTLop(id, nameclass, namesubject, nameteacher, numbLe, datecreate);

            if (modify.insert(ttlophoc))
            {
                dataGridView1.DataSource = modify.getAllTTLop();
                //dataGridView2.DataSource = modify.getAllTTLop();
            }
            else
            {
                MessageBox.Show("Loi" + "Khong vao duoc", "Loi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            sinhvien = new SV(iduser, username);
            if (modify.insert1(sinhvien))
            {
                
                dataGridView2.DataSource = modify.getAllTTSinhVien();
            }
            else
            {
                MessageBox.Show("Loi" + "Khong vao duoc", "Loi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button_Sua_Click(object sender, EventArgs e)
        {

        }
    }
}
