using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA191125
{
    public partial class FrmMain : Form
    {
        SqlConnection conn;
        DateTime most;
        public FrmMain()
        {
            conn = new SqlConnection(@"Server=(localdb)\MSSQLLocalDB;Database=konyvt");
            most = new DateTime(2018, 12, 10);
            InitializeComponent();
            FillDgv();
        }

        private void FillDgv()
        {
            dgvKonyvek.Rows.Clear();
            conn.Open();
            var cmd = new SqlCommand("SELECT * FROM konyvek", conn);
            var r = cmd.ExecuteReader();

            while (r.Read())
            {
                dgvKonyvek.Rows.Add(r[0], r[1], r[2], r.GetDateTime(3).ToString("yyyy"));
            }
            conn.Close();
        }

        private void dgvKonyvek_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            lblIsbn.Text = dgvKonyvek[0, e.RowIndex].Value.ToString();
            lblSzerzo.Text = dgvKonyvek[1, e.RowIndex].Value.ToString();
            lblCim.Text = dgvKonyvek[2, e.RowIndex].Value.ToString();
            conn.Open();
            var cmd = new SqlCommand(
                $"SELECT konyv FROM kolcsonzesek " +
                $"WHERE konyv = {lblIsbn.Text} " +
                $"AND hatarido < '{most.ToString("yyyy-MM-dd")}';", conn);
            lblKolcs.Text = cmd.ExecuteReader().Read() ? "IGEN" : "NEM";
            conn.Close();
        }

        private void dgvKonyvek_SelectionChanged(object sender, EventArgs e)
        {
            btnKolcsonzes.Enabled = (dgvKonyvek.SelectedRows.Count != 0);
        }

        private void btnHozzaadas_Click(object sender, EventArgs e)
        {
            if (long.TryParse(tbIsbn.Text, out _)
                && tbCim.Text != ""
                && tbSzerzo.Text != ""
                && int.TryParse(tbMegjelens.Text, out _))
            {
                conn.Open();
                var a = new SqlDataAdapter()
                {
                    InsertCommand = new SqlCommand("INSERT INTO konyvek VALUES " +
                    $"({tbIsbn.Text}, '{tbSzerzo.Text}', '{tbCim.Text}', '{tbMegjelens.Text}')", conn),
                };
                a.InsertCommand.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Új könyv sikeresen rögzítve!");
                FillDgv();
            }
            else MessageBox.Show("Töltsd ki b+!");
        }
    }
}
