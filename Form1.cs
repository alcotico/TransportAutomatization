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

        string successMess = "Соединение установлено";
        string errorMess = "Ошибка соединения";
        Color successBackColor =Color.LightGreen;
        Color errorBackColor = Color.Red;
        Color successForeColor = Color.Black;
        Color errorForeColor = Color.White;
        Color defaultBackColor = Color.FromArgb(0, 255, 255, 255);

        void setConnMess(string mess, Color backColor, Color foreColor)
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

        void showTable (String query, String labelText)
        {
            try
            {
                DbProp db = new DbProp();
                tableNames.Text = labelText;
                db.openConnection();
                setConnMess("", defaultBackColor, successForeColor);
                MySqlConnection conn = db.getConnection();
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                DataTable table = new DataTable();
                adapter.Fill(table);
                tablesView.DataSource = table;
                db.closeConnection();
            }
            catch { setConnMess(errorMess, errorBackColor, errorForeColor); }
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            try
            {
                showTable("CALL transportView", "Таблица транспорта в собственности предприятия");
            }
            catch { setConnMess(errorMess, errorBackColor, errorForeColor); }
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            try
            {
                showTable("SELECT id_worker AS 'ID', passport AS 'Паспорт', name AS 'ФИО', position AS 'должность' FROM workers",
                          "Таблица сотрудников предприятия");
            }
            catch { setConnMess(errorMess, errorBackColor, errorForeColor); }
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            try
            {
                showTable("SELECT id_company AS 'ID', itn AS 'ИНН', name AS 'Наименование', adress AS 'Адрес', phone AS 'Контактный телефон' FROM companies",
                          "Таблица компаний арендаторов");
            }
            catch { setConnMess(errorMess, errorBackColor, errorForeColor); }
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            try
            {
                showTable("CALL rentView",
                          "Таблица договоров аренды");
            }
            catch { setConnMess(errorMess, errorBackColor, errorForeColor); }
        }

        private void toolStripMenuItem8_Click(object sender, EventArgs e)
        {
            addTransport form = new addTransport();
            form.ShowDialog();
        }

        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {
            try
            {
                showTable("CALL TIView",
                          "Таблица документов тех. осмотра");
            }
            catch { setConnMess(errorMess, errorBackColor, errorForeColor); }
        }

        private void toolStripMenuItem7_Click(object sender, EventArgs e)
        {
            try
            {
                showTable("CALL repairView",
                          "Таблица документов ремонта");
            }
            catch { setConnMess(errorMess, errorBackColor, errorForeColor); }
        }

        private void toolStripMenuItem9_Click(object sender, EventArgs e)
        {
            delTransport delTransportForm = new delTransport();
            delTransportForm.ShowDialog();
        }

        private void toolStripMenuItem10_Click(object sender, EventArgs e)
        {
            updTransport updTransportForm = new updTransport();
            updTransportForm.ShowDialog();
        }
    }
}
