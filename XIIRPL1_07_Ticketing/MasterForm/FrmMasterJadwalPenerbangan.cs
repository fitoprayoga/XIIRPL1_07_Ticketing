using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace XIIRPL1_07_Ticketing.MasterForm
{
    public partial class FrmMasterJadwalPenerbangan : Form
    {
        ComboBoxFunction cb = new ComboBoxFunction();
        public NpgsqlCommand cmd;
        public NpgsqlDataReader dr;
        public FrmMasterJadwalPenerbangan()
        {
            InitializeComponent();
        }

        private void FrmMasterJadwalPenerbangan_Load(object sender, EventArgs e)
        {
            view_data();
            nomor_urut();

            string negaraQuery = "SELECT * FROM db_ticket_xii_rpl_1_07.tbl_negara";
            //ComboBoxFunction.Set_ComboBox(negaraQuery, "nama", txtDari);
            //ComboBoxFunction.Set_ComboBox(negaraQuery, "nama", txtKe);
            txtDari.DataSource = cb.getData(negaraQuery);
            txtDari.DisplayMember = "nama";
            txtDari.ValueMember = "id";
            txtKe.DataSource = cb.getData(negaraQuery);
            txtKe.DisplayMember = "nama";
            txtKe.ValueMember = "id";

            string maskapaiQuery = "SELECT * FROM db_ticket_xii_rpl_1_07.tbl_maskapai";
            //ComboBoxFunction.Set_ComboBox(maskapaiQuery, "nama", txtMaskapai);
            txtMaskapai.DataSource = cb.getData(maskapaiQuery);
            txtMaskapai.DisplayMember = "nama";
            txtMaskapai.ValueMember = "id";
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            try
            {
                Koneksi.conn.Open();
                String sql = "INSERT INTO db_ticket_xii_rpl_1_07.tbl_jadwal_penerbangan" +
                    "(id,kode_penerbangan,bandara_keberangkatan_id,bandara_tujuan_id,maskapai_id,tanggal_keberangkatan,waktu_keberangkatan,durasi_penerbangan,harga_per_tiket)" +
                    "VALUES" +
                    "('" + id.Text + "'," +
                    "'" + txtKodePenerbangan.Text + "'," +
                    "'" + txtDari.SelectedValue + "'," +
                    "'" + txtKe.SelectedValue + "'," +
                    "'" + txtMaskapai.SelectedValue + "'," +
                    "'" + txtTanggal.Text + "'," +
                    "'" + txtWaktuKeberangkatan.Text + "'," +
                    "'" + txtDurasiPenerbangan.Text + "'," +
                    "'" + txtHargaPerTiket.Text + "')";
                cmd = new NpgsqlCommand(sql, Koneksi.conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Berhasil Simpan Data Jadwal Penerbangan");
                view_data();
                Koneksi.conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void view_data()
        {
            string sql = "SELECT " +
             "db_ticket_xii_rpl_1_07.tbl_jadwal_penerbangan.id, " +
             "db_ticket_xii_rpl_1_07.tbl_jadwal_penerbangan.kode_penerbangan, " +
             "db_ticket_xii_rpl_1_07.tbl_jadwal_penerbangan.bandara_keberangkatan_id, " +
             "db_ticket_xii_rpl_1_07.tbl_jadwal_penerbangan.bandara_tujuan_id, " +
             "db_ticket_xii_rpl_1_07.tbl_maskapai.nama, " +
             "db_ticket_xii_rpl_1_07.tbl_jadwal_penerbangan.tanggal_keberangkatan " +
             "FROM db_ticket_xii_rpl_1_07.tbl_jadwal_penerbangan " +
             "INNER JOIN db_ticket_xii_rpl_1_07.tbl_maskapai " +
             "ON db_ticket_xii_rpl_1_07.tbl_jadwal_penerbangan.maskapai_id = db_ticket_xii_rpl_1_07.tbl_maskapai.id";


            NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(sql, Koneksi.conn);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.Columns[2].HeaderText = "ID";
            dataGridView1.Columns[3].HeaderText = "Kode Penerbangan";
            dataGridView1.Columns[4].HeaderText = "Bandara Keberangkatan";
            dataGridView1.Columns[5].HeaderText = "Bandara Tujuan";
            dataGridView1.Columns[6].HeaderText = "Maskapai";
            dataGridView1.Columns[7].HeaderText = "Tanggal Keberangkatan";
        }

        public void nomor_urut()
        {
            int hitung, nomor;
            Koneksi.conn.Open();
            string sql = "SELECT id FROM db_ticket_xii_rpl_1_07.tbl_jadwal_penerbangan where id in(select max(id) FROM db_ticket_xii_rpl_1_07.tbl_jadwal_penerbangan) order by id desc";
            cmd = new NpgsqlCommand(sql, Koneksi.conn);
            dr = cmd.ExecuteReader();
            dr.Read();
            if (dr.HasRows)
            {
                nomor = Convert.ToInt32(dr[0]);
                hitung = nomor + 1;
            }
            else
            {
                hitung = 1;
            }
            dr.Close();
            id.Text = Convert.ToString(hitung);
            Koneksi.conn.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].HeaderText == "Delete")
            {
                int id;
                id = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["id"].Value);
                try
                {
                    Koneksi.conn.Open();
                    String sql = "DELETE FROM db_ticket_xii_rpl_1_07.tbl_jadwal_penerbangan WHERE id=@id";
                    cmd = new NpgsqlCommand(sql, Koneksi.conn);
                    cmd.Parameters.AddWithValue("@id", id);
                    int result = cmd.ExecuteNonQuery();
                    if (result > 0)
                    {
                        MessageBox.Show("Data Berhasil Dihapus");
                        view_data();
                    }
                    else
                    {
                        MessageBox.Show("Data Tidak Berhasil Dihapus");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    Koneksi.conn.Close();
                }
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
