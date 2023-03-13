using MySql.Data.MySqlClient;
using Mysqlx.Session;
using System.Data;

namespace zeamart
{
    public partial class Form1 : Form
    {
        int i = 0;

        MySqlConnection koneksi = connections.getConnection();
        DataTable dataTable = new DataTable();

        public Form1()
        {
            InitializeComponent();
        }

        public void resetIncrement()
        {
            MySqlScript script = new MySqlScript(koneksi, "SET @id := 0; UPDATE barang SET id = @id := (@id+1); " +
                "ALTER TABLE barang AUTO_INCREMENT = 1;");

            script.Execute();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            filldataTable();
        }

        public DataTable getDataBarang()
        {
            dataTable.Reset();
            dataTable = new DataTable();
            using (MySqlCommand cmd = new MySqlCommand("SELECT * FROM barang", koneksi))
            {
                koneksi.Open();
                MySqlDataReader reader = cmd.ExecuteReader();
                dataTable.Load(reader);
            }
            return dataTable;

        }

        public void filldataTable()
        {
            dataGridView1.DataSource = getDataBarang();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            MySqlCommand cmd;
            // mengecek apakah ada field yang kosong
            if ((tb_id.Text == string.Empty || tb_id.Text == string.Empty || tb_namabarang.Text == string.Empty || tb_kategori.Text == string.Empty || tb_harga.Text == string.Empty || tb_stok.Text == string.Empty))
            {
                MessageBox.Show("Tolong isi semua field !", "CRUD", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                cmd = koneksi.CreateCommand();
                cmd.CommandText = "UPDATE barang SET id=@id, nama_barang=@nama_barang, kategori=@kategori, harga=@harga, stok=@stok where id=@id";
                cmd.Parameters.AddWithValue("@id", tb_id.Text);
                cmd.Parameters.AddWithValue("@nama_barang", tb_namabarang.Text);
                cmd.Parameters.AddWithValue("@kategori", tb_kategori.Text);
                cmd.Parameters.AddWithValue("@harga", tb_harga.Text);
                cmd.Parameters.AddWithValue("@stok", tb_stok.Text);
                cmd.ExecuteNonQuery();

                i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    MessageBox.Show(" Data berhasil diupdate", "CRUD", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Data belum berhasil diupdate", "CRUD", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                koneksi.Close();
                filldataTable();
            }
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            MySqlCommand cmd;

            try
            {
                resetIncrement();

                cmd = koneksi.CreateCommand();
                cmd.CommandText = "insert into barang (id,nama_barang, kategori, harga, stok) VALUE (@id, @nama_barang, @kategori, @harga, @stok)";
                cmd.Parameters.AddWithValue("@id", tb_id.Text);
                cmd.Parameters.AddWithValue("@nama_barang", tb_namabarang.Text);
                cmd.Parameters.AddWithValue("@kategori", tb_kategori.Text);
                cmd.Parameters.AddWithValue("@harga", tb_harga.Text);
                cmd.Parameters.AddWithValue("@stok", tb_stok.Text);

                cmd.ExecuteNonQuery();
                koneksi.Close();
                dataTable.Clear();
                filldataTable();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error karena = " + ex);
            }
        }

        public void searchData(string ValueToFind)
        {
            string searchQuery = "SELECT * FROM barang WHERE CONCAT (id, nama_barang, kategori, harga, stok) LIKE '%" + ValueToFind + "%'";
            MySqlDataAdapter adapter = new MySqlDataAdapter(searchQuery, koneksi);
            DataTable table = new DataTable();
            adapter.Fill(table);
            dataGridView1.DataSource = table;
        }

        private void tb_search_TextChanged(object sender, EventArgs e)
        {
            searchData(tb_search.Text);
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            resetIncrement();
            int id = Convert.ToInt32(dataGridView1.CurrentCell.RowIndex.ToString());

            MySqlCommand cmd;
            cmd = koneksi.CreateCommand();
            cmd.CommandText = "DELETE FROM `barang` WHERE id=@id";
            cmd.Parameters.AddWithValue("@id", tb_id.Text);
            i = cmd.ExecuteNonQuery();
            if (i > 0)
            {
                MessageBox.Show("Data berhasil dihapus", "CRUD", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Data belum berhasil dihapus", "CRUD", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            koneksi.Close();
            filldataTable();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = Convert.ToInt32(dataGridView1.CurrentCell.RowIndex.ToString());
            tb_id.Text = dataGridView1.Rows[id].Cells[0].Value.ToString();
            tb_namabarang.Text = dataGridView1.Rows[id].Cells[1].Value.ToString();
            tb_kategori.Text = dataGridView1.Rows[id].Cells[2].Value.ToString();
            tb_harga.Text = dataGridView1.Rows[id].Cells[4].Value.ToString();
            tb_stok.Text = dataGridView1.Rows[id].Cells[5].Value.ToString();


        }
    }
}