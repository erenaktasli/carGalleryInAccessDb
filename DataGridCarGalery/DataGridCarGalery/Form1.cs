using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace DataGridCarGalery
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        OleDbConnection dbBaglan = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\\db\\CarGalery.mdb");
        public void verileriGetir(string veri)
        {
          //  dbBaglan.Open();
            OleDbDataAdapter dbBaglanAdapter = new OleDbDataAdapter(veri, dbBaglan);
            DataSet dbBaglanDataset = new DataSet();
            dbBaglanAdapter.Fill(dbBaglanDataset);
            dataGridViewCarList.DataSource = dbBaglanDataset.Tables[0];
            //dbBaglan.Close();
        }
        private void buttonEkle_Click(object sender, EventArgs e)
        {
            dbBaglan.Open();
            OleDbCommand ekleKomut = new OleDbCommand();
            ekleKomut.Connection = dbBaglan;
            ekleKomut.CommandText=("insert into CarGalery(Marka, Model,Tutar) values (@Marka,@Model,@Tutar)");

            ekleKomut.Parameters.AddWithValue("@Marka", textBoxMrk.Text);
            ekleKomut.Parameters.AddWithValue("@Model", textBoxMdl.Text);
            ekleKomut.Parameters.AddWithValue("@Tutar", textBoxTtr.Text);
            ekleKomut.ExecuteNonQuery();

            verileriGetir("select * from CarGalery");

            dbBaglan.Close();

        }

        private void buttonGtr_Click(object sender, EventArgs e)
        {
            verileriGetir("select * from CarGalery");
        }
    }
}
