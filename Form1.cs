﻿using System;
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
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void TestConnBtn_Click(object sender, EventArgs e)
        {
            String successMess = "Соединение установлено";
            String errorMess = "Ошибка соединения";
            System.Drawing.Color successBackColor = System.Drawing.Color.LightGreen;
            System.Drawing.Color errorBackColor = System.Drawing.Color.Red;
            System.Drawing.Color successForeColor = System.Drawing.Color.Black;
            System.Drawing.Color errorForeColor = System.Drawing.Color.White;

            void setConnMess(String mess, System.Drawing.Color backColor, System.Drawing.Color foreColor)
            {
                TestConnMess.Text = mess;
                TestConnMess.BackColor = backColor;
                TestConnMess.ForeColor = foreColor;
            }
            
            DbProp db = new DbProp();
            try
            {
                db.openConnection();
            }
            catch
            {
                setConnMess(errorMess, errorBackColor, errorForeColor);
            }
            
            if (db.isConnectionOpen()) setConnMess(successMess, successBackColor, successForeColor);
                else setConnMess(errorMess, errorBackColor, errorForeColor);
        }
    }
}
