using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Öğrenci_Takip
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        private void guncellebutton_Click(object sender, EventArgs e)
        {
            if (nobox.Text == "")
            {
                MessageBox.Show("Kaydını değiştirmek istediğiniz öğrencinin okul no'sunu girin");
            }
            else
            {
                OleDbCommand cmd = new OleDbCommand();
                OleDbConnection baglan = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=db.accdb");
                baglan.Open();
                cmd.Connection = baglan;
                cmd.CommandText = "update veriler set fen='" + fenbox.Text + "',numara='" + nobox.Text + "',tarih='" + tarih.Text + "',adsoyad='" + adsoyadbox.Text + "',turkce='" + turkcebox.Text + "',matematik='" + matematikbox.Text + "',sosyal='" + sosyalbox.Text + "' where id=" + idlabel.Text + "";//idlabel rakamsa tırnak kullanılmaz
                cmd.ExecuteNonQuery();
                baglan.Close();
                cmd.Dispose();
                idlabel.Text = "";
                nobox.Text = "";
                adsoyadbox.Text = "";
                turkcebox.Text = "";
                matematikbox.Text = "";
                sosyalbox.Text = "";
                fenbox.Text = "";
                Close();
            }
        }
        
        void yenile()
        {
            OleDbConnection baglan = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=db.accdb");
            OleDbDataAdapter getir = new OleDbDataAdapter("SELECT * FROM veriler", baglan);
            DataSet ds = new DataSet();
            baglan.Open();
            getir.Fill(ds, "veriler");
            baglan.Close();
            getir.Dispose();
        }

            private void Form2_Load(object sender, EventArgs e)
            {
                yenile();
            }


    }
}
