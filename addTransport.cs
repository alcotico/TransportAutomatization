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
    public partial class addTransport : Form
    {
        public addTransport()
        {
            InitializeComponent();
        }

        void errorMes(String field)
        {
            transportExep.BackColor = Color.FromArgb(255, 128, 128);
            transportExep.Text = String.Format("ОШИБКА! Поле {0} заполнено некорректно", field);
        }

        

        private void addTransport_Load(object sender, EventArgs e)
        {

        }

        private void submit_Click(object sender, EventArgs e)
        {
            bool validateVin() => transportVIN.Text.Length == 17;
            bool validateNumber()
            {
                string pattern = @"^[АВЕКМНОРСТУХ]{1}\d{3}[АВЕКМНОРСТУХ]{2}\d{3}$";
                return Regex.IsMatch(transportRegNumber.Text, pattern, RegexOptions.IgnoreCase);
            }
            bool validateRun() => Regex.IsMatch(transportRun.Text, @"^\d+$");
            bool validateYear() => Regex.IsMatch(transportYear.Text, @"^\d{4}$");
            bool validatePlaces() => Regex.IsMatch(transportPlaces.Text, @"^\d+$");
            bool validateType() => transportType.SelectedIndex > -1;
            bool validateModel() => transportModel.Text != "";

            string exep = "";

            for (int i = 0; i <= 6; i++) 
            {
                if (exep != "") break; 
                switch (i)
                {
                    case 6:
                        if (!validateVin()) exep = "«VIN»";
                        break;
                    case 1:
                        if (!validateNumber()) exep = "«Гос. номер»";
                        break;
                    case 2:
                        if (!validateRun()) exep = "«Пробег»";
                        break;
                    case 3:
                        if (!validateModel()) exep = "«Модель»";
                        break;
                    case 4:
                        if (!validateYear()) exep = "«Год производства»";
                        break;
                    case 5:
                        if (!validatePlaces()) exep = "«Количество мест»";
                        break;
                    case 0:
                        if (!validateType()) exep = "«Назначение»";
                        break;
                }
            }

            if (exep == "")
            {
                try
                {
                    DbProp db = new DbProp();
                    MySqlConnection conn = db.getConnection();

                    MySqlCommand cmd = new MySqlCommand("INSERT INTO transport (vin, reg_number, model, type, build_year, run, places) "
                                                        + "VALUES (@vin, @reg_number, @model, @type, @build_year, @run, @places)", conn);
                    try
                    {
                        cmd.Parameters.Add("@vin", MySqlDbType.VarChar).Value = transportVIN.Text;
                        cmd.Parameters.Add("@reg_number", MySqlDbType.VarChar).Value = transportRegNumber.Text;
                        cmd.Parameters.Add("@model", MySqlDbType.VarChar).Value = transportModel.Text;
                        cmd.Parameters.Add("@type", MySqlDbType.VarChar).Value = transportType.Text;
                        cmd.Parameters.Add("@build_year", MySqlDbType.Year).Value = Int32.Parse(transportYear.Text);
                        cmd.Parameters.Add("@run", MySqlDbType.Int32).Value = Int32.Parse(transportRun.Text);
                        cmd.Parameters.Add("@places", MySqlDbType.Int32).Value = Int32.Parse(transportPlaces.Text);
                    }
                    catch
                    {
                        transportExep.BackColor = Color.FromArgb(255, 192, 128);
                        transportExep.Text = "Ошибка добавления параметров";
                    }


                    db.openConnection();

                    if (cmd.ExecuteNonQuery() == 1)
                    {
                        MessageBox.Show("Данные успешно добавлены");
                        this.Close();
                    }
                    else MessageBox.Show("Ошибка добавления");

                    db.closeConnection();

                }
                catch
                {
                   transportExep.BackColor = Color.FromArgb(255, 192, 128);
                   transportExep.Text = "Ошибка соединения с базой данных";
                }
            }
            else errorMes(exep);
        }
    }
}
