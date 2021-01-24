using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AirLines_S3
{
    public partial class SearchForm : Form
    {
        public String conString = @"Data Source=LAPTOP-GTKGDTGS\NIKITASERVER;Initial Catalog=Session3_10;Integrated Security=True";

        private SqlConnection connection;
        private DataSet dataSet;
        private SqlDataAdapter dataAdapter;
        public SearchForm()
        {
            InitializeComponent();

            connection = new SqlConnection(conString);
            try
            {
                connection.Open();
                dataAdapter = new SqlDataAdapter("SELECT * FROM dbo.Airports", connection);
                dataSet = new DataSet();
                DataTable dt = dataSet.Tables.Add("dbo.FromAirports");
                dataAdapter.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
            }

            connection = new SqlConnection(conString);
            try
            {
                connection.Open();
                dataAdapter = new SqlDataAdapter("SELECT * FROM dbo.Airports", connection);
                DataTable dt = dataSet.Tables.Add("dbo.ToAirports");

                dataAdapter.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
            }

            FromComboBox.DataSource = dataSet.Tables["dbo.FromAirports"];
            FromComboBox.DisplayMember = "IATACode";
            FromComboBox.ValueMember = "ID";
            ToComboBox.DataSource = dataSet.Tables["dbo.ToAirports"];
            ToComboBox.DisplayMember = "IATACode";
            ToComboBox.ValueMember = "ID";

            FontsInProject();
            ApplyFonts();
        }
        PrivateFontCollection font;
        private void FontsInProject()
        {
            this.font = new PrivateFontCollection();
            this.font.AddFontFile("Fonts/TeXGyreAdventor-Regular.ttf");
        }
        private void ApplyFonts()
        {
            OutboundsGridView.Font = new Font(font.Families[0], 8);
            label1.Font = new Font(font.Families[0], 8);
            label2.Font = new Font(font.Families[0], 8);
            label3.Font = new Font(font.Families[0], 8);
            label4.Font = new Font(font.Families[0], 8);
            label5.Font = new Font(font.Families[0], 8);
            FromComboBox.Font = new Font(font.Families[0], 8);
            ToComboBox.Font = new Font(font.Families[0], 8);
            ReturnRadio.Font = new Font(font.Families[0], 8);
            OneWayRadio.Font = new Font(font.Families[0], 8);
            ReturnDatePicker.Font = new Font(font.Families[0], 8);
            OutbondDatePicker.Font = new Font(font.Families[0], 8);
            SearchButton.Font = new Font(font.Families[0], 8);
            CheckDateBox.Font = new Font(font.Families[0], 8);
            label6.Font = new Font(font.Families[0], 8);
            ReturnGridView.Font = new Font(font.Families[0], 8);
            BookFlightButton.Font = new Font(font.Families[0], 8);
            ExitButton.Font = new Font(font.Families[0], 8);
        }


        private void GetTable()
        {
            connection = new SqlConnection(conString);
            try
            {
                connection.Open();
                dataAdapter = new SqlDataAdapter("SELECT dbo.Schedules.ID, Date, Time, (SELECT IATACode FROM dbo.Airports WHERE ID = dbo.Routes.DepartureAirportID) AS FromAirport, (SELECT IATACode FROM dbo.Airports WHERE ID = dbo.Routes.ArrivalAirportID) AS ToAirport, FlightNumber, dbo.Aircrafts.Name AS Aircraft, CAST(EconomyPrice as numeric(10,0)) AS Price FROM dbo.Schedules" +
                    " INNER JOIN dbo.Routes ON dbo.Schedules.RouteID = dbo.Routes.ID JOIN dbo.Airports ON dbo.Routes.DepartureAirportID = dbo.Airports.ID" +
                    " INNER JOIN dbo.Aircrafts ON dbo.Schedules.AircraftID = dbo.Aircrafts.ID", connection);
                dataSet = new DataSet();
                DataTable dt = dataSet.Tables.Add("dbo.Schedules");
                dataAdapter.Fill(dt);
                OutboundsGridView.DataSource = dataSet.Tables["dbo.Schedules"];

                for (int i = 0; i < OutboundsGridView.Rows.Count; i++)
                {
                    int id = Convert.ToInt32(OutboundsGridView.Rows[i].Cells[0].Value);
                    SqlCommand command = new SqlCommand($"SELECT Confirmed FROM dbo.Schedules WHERE ID LIKE '%{id}%'", connection);
                    int status = Convert.ToInt32(command.ExecuteScalar());
                    if (status == 0)
                    {
                        OutboundsGridView.Rows[i].DefaultCellStyle.BackColor = Color.Red;
                    }
                    else
                    {
                        OutboundsGridView.Rows[i].DefaultCellStyle.BackColor = Color.LawnGreen;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        private void ReturnRadio_CheckedChanged(object sender, EventArgs e)
        {
            label4.Visible = true;
            ReturnDatePicker.Visible = true;
            label6.Visible = true;
            ReturnGridView.Visible = true;
        }

        private void OneWayRadio_CheckedChanged(object sender, EventArgs e)
        {
            label4.Visible = false;
            ReturnDatePicker.Visible = false;
            label6.Visible = false;
            ReturnGridView.Visible = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            GetTable();
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(FromComboBox.Text) && string.IsNullOrEmpty(ToComboBox.Text))
            {
                GetTable();
            }
            else if (FromComboBox.Text == ToComboBox.Text)
            {
                MessageBox.Show("Invalid Filter", "Warning");
            }
            else
            {
                if (!string.IsNullOrEmpty(FromComboBox.Text))
                {
                    if (CheckDateBox.Checked == false)
                    {
                        (OutboundsGridView.DataSource as DataTable).DefaultView.RowFilter = string.Format("FromAirport = '{0}'", FromComboBox.Text);
                    }
                    else
                    {
                        (OutboundsGridView.DataSource as DataTable).DefaultView.RowFilter = string.Format("FromAirport = '{0}' AND Date = '{1}'", FromComboBox.Text, OutbondDatePicker.Value.ToString("dd.MM.yyyy"));
                    }
                }
                if (!string.IsNullOrEmpty(ToComboBox.Text))
                {
                    if (CheckDateBox.Checked == false)
                    {
                        (OutboundsGridView.DataSource as DataTable).DefaultView.RowFilter = string.Format("ToAirport = '{0}'", ToComboBox.Text);
                    }
                    else
                    {
                        (OutboundsGridView.DataSource as DataTable).DefaultView.RowFilter = string.Format("ToAirport = '{0}' AND Date = '{1}'", ToComboBox.Text, OutbondDatePicker.Value.ToString("dd.MM.yyyy"));
                    }
                }
                if (!string.IsNullOrEmpty(FromComboBox.Text) && !string.IsNullOrEmpty(ToComboBox.Text))
                {
                    if (CheckDateBox.Checked == false)
                    {
                        (OutboundsGridView.DataSource as DataTable).DefaultView.RowFilter = string.Format("FromAirport = '{0}' AND ToAirport = '{1}'", FromComboBox.Text, ToComboBox.Text);
                    }
                    else
                    {
                        (OutboundsGridView.DataSource as DataTable).DefaultView.RowFilter = string.Format("FromAirport = '{0}' AND ToAirport = '{1}' AND Date = '{2}'", FromComboBox.Text, ToComboBox.Text, OutbondDatePicker.Value.ToString("dd.MM.yyyy"));
                    }
                }

                connection = new SqlConnection(conString);
                try
                {
                    connection.Open();
                    for (int i = 0; i < OutboundsGridView.Rows.Count; i++)
                    {
                        int id = Convert.ToInt32(OutboundsGridView.Rows[i].Cells[0].Value);
                        SqlCommand command = new SqlCommand($"SELECT Confirmed FROM dbo.Schedules WHERE ID LIKE '%{id}%'", connection);
                        int status = Convert.ToInt32(command.ExecuteScalar());
                        if (status == 0)
                        {
                            OutboundsGridView.Rows[i].DefaultCellStyle.BackColor = Color.Red;
                        }
                        else
                        {
                            OutboundsGridView.Rows[i].DefaultCellStyle.BackColor = Color.LawnGreen;
                        }
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    connection.Close();
                }

                //////////////////////////////////////////////////////////////////////////////
                connection = new SqlConnection(conString);
                try
                {
                    connection.Open();
                    dataAdapter = new SqlDataAdapter("SELECT dbo.Schedules.ID, Date, Time, (SELECT IATACode FROM dbo.Airports WHERE ID = dbo.Routes.DepartureAirportID) AS FromAirport, (SELECT IATACode FROM dbo.Airports WHERE ID = dbo.Routes.ArrivalAirportID) AS ToAirport, FlightNumber, dbo.Aircrafts.Name AS Aircraft, CAST(EconomyPrice as numeric(10,0)) AS Price FROM dbo.Schedules" +
                        " INNER JOIN dbo.Routes ON dbo.Schedules.RouteID = dbo.Routes.ID JOIN dbo.Airports ON dbo.Routes.DepartureAirportID = dbo.Airports.ID" +
                        " INNER JOIN dbo.Aircrafts ON dbo.Schedules.AircraftID = dbo.Aircrafts.ID" +
                       string.Format(" WHERE (SELECT IATACode FROM dbo.Airports WHERE ID = dbo.Routes.DepartureAirportID) LIKE '%{0}%' AND (SELECT IATACode FROM dbo.Airports WHERE ID = dbo.Routes.ArrivalAirportID) LIKE '%{1}%'", ToComboBox.Text, FromComboBox.Text), connection);
                    dataSet = new DataSet();
                    DataTable dt = dataSet.Tables.Add("dbo.Schedules");
                    dataAdapter.Fill(dt);
                    ReturnGridView.DataSource = dataSet.Tables["dbo.Schedules"];

                    for (int i = 0; i < ReturnGridView.Rows.Count; i++)
                    {
                        int id = Convert.ToInt32(ReturnGridView.Rows[i].Cells[0].Value);
                        SqlCommand command = new SqlCommand($"SELECT Confirmed FROM dbo.Schedules WHERE ID LIKE '%{id}%'", connection);
                        int status = Convert.ToInt32(command.ExecuteScalar());
                        if (status == 0)
                        {
                            ReturnGridView.Rows[i].DefaultCellStyle.BackColor = Color.Red;
                        }
                        else
                        {
                            ReturnGridView.Rows[i].DefaultCellStyle.BackColor = Color.LawnGreen;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    connection.Close();
                }

                if (!string.IsNullOrEmpty(FromComboBox.Text) && !string.IsNullOrEmpty(ToComboBox.Text))
                {
                    if (CheckDateBox.Checked == false)
                    {
                        (ReturnGridView.DataSource as DataTable).DefaultView.RowFilter = string.Format("FromAirport = '{0}' AND ToAirport = '{1}'", ToComboBox.Text, FromComboBox.Text);
                    }
                    else
                    {
                        (ReturnGridView.DataSource as DataTable).DefaultView.RowFilter = string.Format("FromAirport = '{0}' AND ToAirport = '{1}' AND Date = '{2}'", ToComboBox.Text, FromComboBox.Text, ReturnDatePicker.Value.ToString("dd.MM.yyyy"));
                    }
                }

                connection = new SqlConnection(conString);
                try
                {
                    connection.Open();
                    for (int i = 0; i < ReturnGridView.Rows.Count; i++)
                    {
                        int id = Convert.ToInt32(ReturnGridView.Rows[i].Cells[0].Value);
                        SqlCommand command = new SqlCommand($"SELECT Confirmed FROM dbo.Schedules WHERE ID LIKE '%{id}%'", connection);
                        int status = Convert.ToInt32(command.ExecuteScalar());
                        if (status == 0)
                        {
                            ReturnGridView.Rows[i].DefaultCellStyle.BackColor = Color.Red;
                        }
                        else
                        {
                            ReturnGridView.Rows[i].DefaultCellStyle.BackColor = Color.LawnGreen;
                        }
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    connection.Close();
                }
            }
        }

        private void DeleteFromButton_Click(object sender, EventArgs e)
        {
            FromComboBox.Text = null;
        }

        private void DeleteToButton_Click(object sender, EventArgs e)
        {
            ToComboBox.Text = null;
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            FromComboBox.Text = null;
            ToComboBox.Text = null;
            OneWayRadio.Checked = true;
            CheckDateBox.Checked = false;
            GetTable();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
