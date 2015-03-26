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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        Form2 f2 = new Form2();
        public void yenile()
        {

            OleDbConnection baglan = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=db.accdb");
            OleDbDataAdapter getir = new OleDbDataAdapter("SELECT * FROM veriler", baglan);
            DataSet ds = new DataSet();
            baglan.Open();
            getir.Fill(ds, "veriler");
            dataGridView1.DataSource = ds.Tables["veriler"];
            baglan.Close();
            getir.Dispose();
        }

        void hesapla()
        {


            string[] parcala;

            parcala = turkcebox.Text.Split('-');
            turkced.Text = parcala[0];
            try
            {
                turkcey.Text = parcala[1];
                turkcen.Text = Convert.ToString(Convert.ToDouble(turkced.Text) - (Convert.ToInt16(turkcey.Text) / 3));
            }
            catch 
            {
                turkcey.Text = "0";
                turkcen.Text = turkced.Text; 
            }


            parcala = matematikbox.Text.Split('-');
            matd.Text = parcala[0];
            try
            {
                maty.Text = parcala[1];
                matn.Text = Convert.ToString(Convert.ToDouble(matd.Text) - (Convert.ToInt16(maty.Text) / 3));
            }
            catch
            {
                maty.Text = "0";
                matn.Text = matd.Text; 
            }





            parcala = sosyalbox.Text.Split('-');
            sosyald.Text = parcala[0];
            try
            {
                sosyaly.Text = parcala[1];
                sosyaln.Text = Convert.ToString(Convert.ToDouble(sosyald.Text) - (Convert.ToInt16(sosyaly.Text) / 3));
            }
            catch
            {
                sosyaly.Text = "0";
                sosyaln.Text = sosyald.Text; 
            }





            parcala = fenbox.Text.Split('-');
            fend.Text = parcala[0];
            try
            {
                feny.Text = parcala[1];
                fenn.Text = Convert.ToString(Convert.ToDouble(fend.Text) - (Convert.ToInt16(feny.Text) / 3));
            }
            catch
            {
                feny.Text = "0";
                fenn.Text = fend.Text; 
            }

            if (Convert.ToInt16(turkcen.Text) < Convert.ToInt16(0)) { turkcen.Text = "0"; }
            if (Convert.ToInt16(sosyaln.Text) < Convert.ToInt16(0)) { sosyaln.Text = "0"; }
            if (Convert.ToInt16(fenn.Text) < Convert.ToInt16(0)) { fenn.Text = "0"; }
            if (Convert.ToInt16(matn.Text) < Convert.ToInt16(0)) { matn.Text = "0"; }

            try
            {
                YGS1.Text = Convert.ToString((Convert.ToDouble(turkcen.Text) * 2 + Convert.ToDouble(sosyaln.Text) * 1 + Convert.ToDouble(matn.Text) * 4 + Convert.ToDouble(fenn.Text) * 3) + 100);
                YGS2.Text = Convert.ToString((Convert.ToDouble(turkcen.Text) * 2 + Convert.ToDouble(sosyaln.Text) * 1 + Convert.ToDouble(matn.Text) * 3 + Convert.ToDouble(fenn.Text) * 4) + 100);
                YGS3.Text = Convert.ToString((Convert.ToDouble(turkcen.Text) * 4 + Convert.ToDouble(sosyaln.Text) * 3 + Convert.ToDouble(matn.Text) * 2 + Convert.ToDouble(fenn.Text) * 1) + 100);
                YGS4.Text = Convert.ToString((Convert.ToDouble(turkcen.Text) * 3 + Convert.ToDouble(sosyaln.Text) * 4 + Convert.ToDouble(matn.Text) * 2 + Convert.ToDouble(fenn.Text) * 1) + 100);
                YGS5.Text = Convert.ToString((Convert.ToDouble(turkcen.Text) * 3.7 + Convert.ToDouble(sosyaln.Text) * 2 + Convert.ToDouble(matn.Text) * 3.3 + Convert.ToDouble(fenn.Text) * 1) + 100);
                YGS6.Text = Convert.ToString((Convert.ToDouble(turkcen.Text) * 3.3 + Convert.ToDouble(sosyaln.Text) * 1 + Convert.ToDouble(matn.Text) * 3.7 + Convert.ToDouble(fenn.Text) * 2) + 100);
            }
            catch 
            {
                MessageBox.Show("Sadece sayı veya 30-9 (Doğru-Yanlış) şeklinde giriniz.");
            }


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            yenile();
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].HeaderText = "Okul No";
            dataGridView1.Columns[2].HeaderText = "Adı Soyadı";
            dataGridView1.Columns[3].HeaderText = "Türkçe";
            dataGridView1.Columns[4].HeaderText = "Matematik";
            dataGridView1.Columns[5].HeaderText = "Sosyal";
            dataGridView1.Columns[6].HeaderText = "Fen Bilgisi";
            dataGridView1.Columns[7].HeaderText = "Tarih";
            temizle();
        }

        void temizle()
        {
            YGS1.Text = ""; YGS2.Text = ""; YGS3.Text = ""; YGS4.Text = ""; YGS5.Text = ""; YGS6.Text = "";
            ygs1ortalama.Text = ""; ygs2ortalama.Text = ""; ygs3ortalama.Text = ""; ygs4ortalama.Text = ""; ygs5ortalama.Text = ""; ygs6ortalama.Text = "";
            turkcen.Text = "0"; matn.Text = "0"; sosyaln.Text = "0"; fenn.Text = "0";
            idlabel.Text = ""; nobox.Text = ""; adsoyadbox.Text = ""; matematikbox.Text = ""; turkcebox.Text = ""; fenbox.Text = ""; sosyalbox.Text = "";
        }




        private void kaydetbutton_Click(object sender, EventArgs e)
        {
            if (nobox.Text == "")
            {
                MessageBox.Show("Kaydetmek istediğiniz öğrencinin okul no'sunu girin");
            }
            else
            {
                try
                {
                    OleDbCommand cmd = new OleDbCommand();
                    OleDbConnection baglan = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=db.accdb");
                    baglan.Open();
                    cmd.Connection = baglan;
                    cmd.CommandText = "insert into veriler (numara,adsoyad,turkce,matematik,sosyal,fen,tarih) values ('" + nobox.Text + "','" + adsoyadbox.Text + "','" + turkcebox.Text + "','" + matematikbox.Text + "','" + sosyalbox.Text + "','" + fenbox.Text + "','" + tarih.Text + "')";
                    cmd.ExecuteNonQuery();
                    baglan.Close();
                    yenile();
                } catch{}

            }
        }
        private void silbutton_Click(object sender, EventArgs e)
        {
          gridviewvericek();
          DialogResult dialogResult = MessageBox.Show(nobox.Text +" numaralı "+ adsoyadbox.Text + " kişisini silmek istediğinize emin misiniz.", "Sil", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
          if (dialogResult == DialogResult.Yes)
          {
              OleDbConnection baglan = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=db.accdb");
              baglan.Open();
              OleDbCommand cmd = new OleDbCommand("DELETE FROM veriler WHERE id=" + idlabel.Text + "", baglan);
              DataTable dt = new DataTable();
              cmd.ExecuteNonQuery();
              cmd.Dispose();
              baglan.Close();
              yenile();
          }
        }

        private void guncellebutton_Click(object sender, EventArgs e)
        {
            
            f2.idlabel.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            f2.nobox.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            f2.adsoyadbox.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            f2.turkcebox.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            f2.matematikbox.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            f2.sosyalbox.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            f2.fenbox.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            f2.tarih.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            f2.ShowDialog();
            yenile();
        }






        private void listedbutton_Click_1(object sender, EventArgs e)
        {
            listeninortalamasi();
        }


        void listeninortalamasi()
        {
            int sayi = 0;
            idlabel.Text = ""; nobox.Text = ""; adsoyadbox.Text = ""; ygs1ortalama.Text = "0"; ygs2ortalama.Text = "0"; ygs3ortalama.Text = "0"; ygs4ortalama.Text = "0"; ygs5ortalama.Text = "0"; ygs6ortalama.Text = "0";
            for (int i = 0; i < 99999; i++)
            {
                try
                {
                    turkcebox.Text = dataGridView1.Rows[i].Cells[3].Value.ToString();
                    matematikbox.Text = dataGridView1.Rows[i].Cells[4].Value.ToString();
                    sosyalbox.Text = dataGridView1.Rows[i].Cells[5].Value.ToString();
                    fenbox.Text = dataGridView1.Rows[i].Cells[6].Value.ToString();
                    hesapla();
                    ygs1ortalama.Text = Convert.ToString(Convert.ToDouble(ygs1ortalama.Text) + Convert.ToDouble(YGS1.Text));
                    ygs2ortalama.Text = Convert.ToString(Convert.ToDouble(ygs2ortalama.Text) + Convert.ToDouble(YGS2.Text));
                    ygs3ortalama.Text = Convert.ToString(Convert.ToDouble(ygs3ortalama.Text) + Convert.ToDouble(YGS3.Text));
                    ygs4ortalama.Text = Convert.ToString(Convert.ToDouble(ygs4ortalama.Text) + Convert.ToDouble(YGS4.Text));
                    ygs5ortalama.Text = Convert.ToString(Convert.ToDouble(ygs5ortalama.Text) + Convert.ToDouble(YGS5.Text));
                    ygs6ortalama.Text = Convert.ToString(Convert.ToDouble(ygs6ortalama.Text) + Convert.ToDouble(YGS6.Text));
                    sayi++;
                }
                catch
                {
                    break;
                }
            }
            ygs1ortalama.Text = Convert.ToString(Convert.ToInt16(Convert.ToDouble(ygs1ortalama.Text) / sayi));
            ygs2ortalama.Text = Convert.ToString(Convert.ToInt16(Convert.ToDouble(ygs2ortalama.Text) / sayi));
            ygs3ortalama.Text = Convert.ToString(Convert.ToInt16(Convert.ToDouble(ygs3ortalama.Text) / sayi));
            ygs4ortalama.Text = Convert.ToString(Convert.ToInt16(Convert.ToDouble(ygs4ortalama.Text) / sayi));
            ygs5ortalama.Text = Convert.ToString(Convert.ToInt16(Convert.ToDouble(ygs5ortalama.Text) / sayi));
            ygs6ortalama.Text = Convert.ToString(Convert.ToInt16(Convert.ToDouble(ygs6ortalama.Text) / sayi));
            idlabel.Text = ""; nobox.Text = ""; adsoyadbox.Text = ""; matematikbox.Text = ""; turkcebox.Text = ""; fenbox.Text = ""; sosyalbox.Text = ""; turkcen.Text = "0"; sosyaln.Text = "0"; matn.Text = "0"; fenn.Text = "0"; YGS1.Text = ""; YGS2.Text = ""; YGS3.Text = ""; YGS4.Text = ""; YGS5.Text = ""; YGS6.Text = "";
        }



        private void hesaplabutton_Click(object sender, EventArgs e)
        {
            gridviewvericek();
            hesapla();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            temizle();
            yenile();
        }

        private void arabutton_Click(object sender, EventArgs e)
        {
            if (nobox.Text != "")
            {
                OleDbConnection baglan = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=db.accdb");
                OleDbDataAdapter getir = new OleDbDataAdapter("SElect *from veriler where numara like '" + nobox.Text + "'", baglan);
                DataSet ds = new DataSet();
                baglan.Open();
                getir.Fill(ds, "veriler");
                dataGridView1.DataSource = ds.Tables["veriler"];
                baglan.Close();
            }
            else { yenile(); }
        }

        private void arabutton2_Click(object sender, EventArgs e)
        {
            if (adsoyadbox.Text != "")
            {
                OleDbConnection baglan = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=db.accdb");
                OleDbDataAdapter getir = new OleDbDataAdapter("SElect *from veriler where adsoyad like '" + adsoyadbox.Text + "%'", baglan);
                DataSet ds = new DataSet();
                baglan.Open();
                getir.Fill(ds, "veriler");
                dataGridView1.DataSource = ds.Tables["veriler"];
                baglan.Close();
            }
            else { yenile(); }
        }




        void gridviewvericek()
        {
            idlabel.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            nobox.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            adsoyadbox.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            turkcebox.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            matematikbox.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            sosyalbox.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            fenbox.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            tarih.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            gridviewvericek();
            hesapla();
        }

        private void tarihara_Click(object sender, EventArgs e)
        {
            OleDbConnection baglan = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=db.accdb");
            OleDbDataAdapter getir = new OleDbDataAdapter("SElect *from veriler where tarih like '" + tarih.Text + "%'", baglan);
            DataSet ds = new DataSet();
            baglan.Open();
            getir.Fill(ds, "veriler");
            dataGridView1.DataSource = ds.Tables["veriler"];
            baglan.Close();
        }

        private void nobox_TextChanged(object sender, EventArgs e)
        {
            this.AcceptButton = arabutton;
        }

        private void adsoyadbox_TextChanged(object sender, EventArgs e)
        {
            this.AcceptButton = arabutton2;
        }

        private void tarih_ValueChanged(object sender, EventArgs e)
        {
            this.AcceptButton = tarihara;
        }

        private void excelcikti_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();
            excel.Visible = true; 
            Microsoft.Office.Interop.Excel.Workbook workbook = excel.Workbooks.Add(System.Reflection.Missing.Value);
            Microsoft.Office.Interop.Excel.Worksheet sheet1 = (Microsoft.Office.Interop.Excel.Worksheet)workbook.Sheets[1];
            int yanagec=1 , assain=1;
            string[] baslik = { "Okul No", "Adı Soyadı", "YGS1", "YGS2", "YGS3", "YGS4", "YGS5", "YGS6" };
            foreach (string basliky in baslik)
            {
                Microsoft.Office.Interop.Excel.Range excely = (Microsoft.Office.Interop.Excel.Range)sheet1.Cells[assain, yanagec];
                excely.Value2 = basliky;
                yanagec++;
            }
            assain++;
            //***************************************************************************************

            
            for (int i = 0; i < 99999; i++)
            {
                try
                {
                    nobox.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
                    adsoyadbox.Text = dataGridView1.Rows[i].Cells[2].Value.ToString();
                    turkcebox.Text = dataGridView1.Rows[i].Cells[3].Value.ToString();
                    matematikbox.Text = dataGridView1.Rows[i].Cells[4].Value.ToString();
                    sosyalbox.Text = dataGridView1.Rows[i].Cells[5].Value.ToString();
                    fenbox.Text = dataGridView1.Rows[i].Cells[6].Value.ToString();
                    hesapla();


                    Microsoft.Office.Interop.Excel.Range excely1 = (Microsoft.Office.Interop.Excel.Range)sheet1.Cells[assain, 1];
                    excely1.Value2 = nobox.Text;
                    Microsoft.Office.Interop.Excel.Range excely2 = (Microsoft.Office.Interop.Excel.Range)sheet1.Cells[assain, 2];
                    excely2.Value2 = adsoyadbox.Text;
                    Microsoft.Office.Interop.Excel.Range excely3 = (Microsoft.Office.Interop.Excel.Range)sheet1.Cells[assain, 3];
                    excely3.Value2 = YGS1.Text;
                    Microsoft.Office.Interop.Excel.Range excely4 = (Microsoft.Office.Interop.Excel.Range)sheet1.Cells[assain, 4];
                    excely4.Value2 = YGS2.Text;
                    Microsoft.Office.Interop.Excel.Range excely5 = (Microsoft.Office.Interop.Excel.Range)sheet1.Cells[assain, 5];
                    excely5.Value2 = YGS3.Text;
                    Microsoft.Office.Interop.Excel.Range excely6 = (Microsoft.Office.Interop.Excel.Range)sheet1.Cells[assain, 6];
                    excely6.Value2 = YGS4.Text;
                    Microsoft.Office.Interop.Excel.Range excely7 = (Microsoft.Office.Interop.Excel.Range)sheet1.Cells[assain, 7];
                    excely7.Value2 = YGS5.Text;
                    Microsoft.Office.Interop.Excel.Range excely8 = (Microsoft.Office.Interop.Excel.Range)sheet1.Cells[assain, 8];
                    excely8.Value2 = YGS6.Text;
                    assain++;
                }
                catch { break; }
            }
            assain++;
            //*************************************************************************************
            listeninortalamasi();
            Microsoft.Office.Interop.Excel.Range excely9 = (Microsoft.Office.Interop.Excel.Range)sheet1.Cells[assain, 2];
            excely9.Value2 = "Genel Ortalama:";
            Microsoft.Office.Interop.Excel.Range excely10 = (Microsoft.Office.Interop.Excel.Range)sheet1.Cells[assain, 3];
            excely10.Value2 = ygs1ortalama.Text;
            Microsoft.Office.Interop.Excel.Range excely11 = (Microsoft.Office.Interop.Excel.Range)sheet1.Cells[assain, 4];
            excely11.Value2 = ygs2ortalama.Text;
            Microsoft.Office.Interop.Excel.Range excely12 = (Microsoft.Office.Interop.Excel.Range)sheet1.Cells[assain, 5];
            excely12.Value2 = ygs3ortalama.Text;
            Microsoft.Office.Interop.Excel.Range excely13 = (Microsoft.Office.Interop.Excel.Range)sheet1.Cells[assain, 6];
            excely13.Value2 = ygs4ortalama.Text;
            Microsoft.Office.Interop.Excel.Range excely14 = (Microsoft.Office.Interop.Excel.Range)sheet1.Cells[assain, 7];
            excely14.Value2 = ygs5ortalama.Text;
            Microsoft.Office.Interop.Excel.Range excely15 = (Microsoft.Office.Interop.Excel.Range)sheet1.Cells[assain, 8];
            excely15.Value2 = ygs6ortalama.Text;

        }





    }
}
