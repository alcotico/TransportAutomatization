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
    public partial class MainForm : Form
    {
        private bool TestConnBtnClicked = false;
        
        String successMess = "Соединение установлено";
        String errorMess = "Ошибка соединения";
        System.Drawing.Color successBackColor = System.Drawing.Color.LightGreen;
        System.Drawing.Color errorBackColor = System.Drawing.Color.Red;
        System.Drawing.Color successForeColor = System.Drawing.Color.Black;
        System.Drawing.Color errorForeColor = System.Drawing.Color.White;
        System.Drawing.Color defaultBackColor = System.Drawing.Color.FromArgb(0, 255, 255, 255);

        void setConnMess(String mess, System.Drawing.Color backColor, System.Drawing.Color foreColor)
        {
            TestConnMess.Text = mess;
            TestConnMess.BackColor = backColor;
            TestConnMess.ForeColor = foreColor;
        }

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            TestConnBtn.PerformClick();
        }

        private void TestConnBtn_Click(object sender, EventArgs e)
        {
            

            if (TestConnBtnClicked)
            {
                TestConnBtnClicked = false;
                setConnMess("", defaultBackColor, successForeColor);
                TestConnBtn.Text = "Проверить соединение";

            }
            else
            {
                TestConnBtnClicked = true;
                DbProp db = new DbProp();
                try
                {
                    db.openConnection();
                }
                catch
                {
                    setConnMess(errorMess, errorBackColor, errorForeColor);
                }

                if (db.isConnectionOpen()) 
                { 
                    setConnMess(successMess, successBackColor, successForeColor);
                    db.closeConnection();
                }
                else setConnMess(errorMess, errorBackColor, errorForeColor);
                TestConnBtn.Text = "Скрыть сообщение";
            }
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            try
            {
                DbProp db = new DbProp();
                tableNames.Text = "Таблица транспорта в собственности предприятия";
                db.openConnection();
                setConnMess("", defaultBackColor, successForeColor);
                MySqlConnection conn = db.getConnection();
                MySqlDataAdapter adapter = new MySqlDataAdapter("CALL transportView", conn);
                DataTable table = new DataTable();
                adapter.Fill(table);
                transportView.DataSource = table;
                db.closeConnection();
            }
            catch { setConnMess(errorMess, errorBackColor, errorForeColor); }
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            try
            {
                DbProp db = new DbProp();
                tableNames.Text = "Таблица сотрудников предприятия";
                db.openConnection();
                setConnMess("", defaultBackColor, successForeColor);
                MySqlConnection conn = db.getConnection();
                MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT id_worker AS 'ID', passport AS 'Паспорт', name AS 'ФИО', position AS 'должность' FROM workers", conn);
                DataTable table = new DataTable();
                adapter.Fill(table);
                transportView.DataSource = table;
                db.closeConnection();
            }
            catch { setConnMess(errorMess, errorBackColor, errorForeColor); }
        }
    }
}
