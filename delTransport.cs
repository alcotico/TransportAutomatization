using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace TransportAutomatization
{
    public partial class delTransport : Form
    {
        DataTable table = new DataTable();
        public delTransport()
        {
            InitializeComponent();
        }

        private void delTransport_Load(object sender, EventArgs e)
        {
            DbProp db = new DbProp();
            MySqlConnection conn = db.getConnection();
            MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT id_transport, vin, model FROM transport", conn);
            adapter.Fill(table);
            delTransportBox.DataSource = table;
            delTransportBox.DisplayMember = "model";
            delTransportBox.ValueMember = "id_transport";
            delTransportBox.SelectedIndex = -1;
        }

        private void delTransportBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (delTransportBox.SelectedIndex != -1)
            {
                DataRow[] rows = table.Select("id_transport = " + delTransportBox.SelectedValue.ToString());
                idBox.Text = rows[0]["id_transport"].ToString();
                vinBox.Text = rows[0]["vin"].ToString();
            }
        }

        private void delBtn_Click(object sender, EventArgs e)
        {
            DbProp db = new DbProp();
            MySqlConnection conn = db.getConnection();
            MySqlCommand cmd = new MySqlCommand("DELETE FROM transport WHERE id_transport = @id", conn);
            cmd.Parameters.AddWithValue("@id", delTransportBox.SelectedValue);
            db.openConnection();

            if (cmd.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Запись удалена");
                this.Close();
            }
            else MessageBox.Show("Ошибка удаления");

            db.closeConnection();
        }
    }
}
