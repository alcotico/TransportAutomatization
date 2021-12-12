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
    public partial class reportTransport : Form
    {
        DataTable table = new DataTable();
        public reportTransport()
        {
            InitializeComponent();
        }

        private void reportTransport_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = table;
        }

        private void typeBox_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            for (int idx = 0; idx < typeBox.Items.Count; idx++)
            {
                if (idx != e.Index) typeBox.SetItemChecked(idx, false);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string runFilter = "";
            string typeFilter = "";
            string modelFilter = "";


            // проверка фильтра пробега
            if (minRunBox.Text != "" && maxRunBox.Text != "")
            {
                runFilter = string.Format("run >= {0} AND run <= {1}", minRunBox.Text, maxRunBox.Text);
            }
            else
            {
                if (!(minRunBox.Text == "" && maxRunBox.Text == "")){
                    if(minRunBox.Text != "")
                    {
                        runFilter = string.Format("run >= {0}", minRunBox.Text);
                    }
                    else
                    {
                        runFilter = string.Format("run <= {0}", maxRunBox.Text);
                    }
                }
            }

            //проверка модели
            if (modelBox.Text != "")
            {
                modelFilter = string.Format("model LIKE '%{0}%'", modelBox.Text);
            }

            //проверка назначения
            int checkedItem = -1;
            for (int idx = 0; idx < typeBox.Items.Count; idx++)
            {
                if (typeBox.GetItemChecked(idx))
                {
                    checkedItem = idx;
                    break;
                }
            }
            if (checkedItem != -1) typeFilter = string.Format("type = '{0}'", typeBox.Items[checkedItem].ToString());
                DbProp db = new DbProp();
            MySqlConnection conn = db.getConnection();
            if (runFilter == "" && typeFilter == "" && modelFilter == "")
            {
                string query = "SELECT id_transport AS 'ID', vin AS 'VIN', reg_number AS 'Гос. номер', model AS 'Модель', type AS 'Тип', " +
                                "build_year AS 'Год производства', run AS 'Пробег', places AS 'Количество мест' FROM transport";
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                table.Clear();
                adapter.Fill(table);
            }
            else
            {
                string[] arr = { runFilter, "" , typeFilter, "" , modelFilter };
                string query = "SELECT id_transport AS 'ID', vin AS 'VIN', reg_number AS 'Гос. номер', model AS 'Модель', type AS 'Тип', " +
                               "build_year AS 'Год производства', run AS 'Пробег', places AS 'Количество мест' FROM transport WHERE ";
                int idx = 0;
                for (int i = 0; i<arr.Length; i = i + 2)
                {
                    if (arr[i] != "")
                    {
                        idx = i;
                        break;
                    }
                }
                for (int i = idx; i < arr.Length - 2; i = i + 2)
                {
                    if (arr[i+2] != "")
                    {
                        arr[i + 1] = " AND ";
                    }
                }
                for (int i = idx; i < arr.Length; i++)
                {
                    query += arr[i];
                }

                MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                table.Clear();
                adapter.Fill(table);
            }
        }
    }
}
