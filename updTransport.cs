using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace TransportAutomatization
{
    public partial class updTransport : Form
    {
        DataTable table = new DataTable();
        public updTransport()
        {
            InitializeComponent();
        }

        private void updTransport_Load(object sender, EventArgs e)
        {
            DbProp db = new DbProp();
            MySqlConnection conn = db.getConnection();
            MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT id_transport, vin, model FROM transport", conn);
            adapter.Fill(table);
            updTransportBox.DataSource = table;
            updTransportBox.DisplayMember = "model";
            updTransportBox.ValueMember = "id_transport";
            updTransportBox.SelectedIndex = -1;
        }

        private void updTransportBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (updTransportBox.SelectedIndex != -1)
            {
                DataRow[] rows = table.Select("id_transport = " + updTransportBox.SelectedValue.ToString());
                idBox.Text = rows[0]["id_transport"].ToString();
                vinBox.Text = rows[0]["vin"].ToString();
            }
        }

        private void delBtn_Click(object sender, EventArgs e)
        {
            if (Regex.IsMatch(runBox.Text, @"\d+"))
            {
                DbProp db = new DbProp();
                MySqlConnection conn = db.getConnection();
                MySqlCommand cmd = new MySqlCommand("SELECT updRun(@id, @run)", conn);
                cmd.Parameters.AddWithValue("@id", updTransportBox.SelectedValue);
                cmd.Parameters.AddWithValue("@run", runBox.Text);
                db.openConnection();

                if (cmd.ExecuteNonQuery() == -1)
                {
                    MessageBox.Show("Запись обновлена");
                    this.Close();
                }
                else MessageBox.Show("Ошибка обновления");

                db.closeConnection();
            }
            else
            {
                MessageBox.Show("Неправильное значение пробега");
            }
            
            
        }
    }
}
