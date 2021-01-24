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
    public partial class BookingForm : Form
    {
        public String conString = @"Data Source=LAPTOP-GTKGDTGS\NIKITASERVER;Initial Catalog=Session3_10;Integrated Security=True";

        private SqlConnection connection;
        private DataSet dataSet;
        private SqlDataAdapter dataAdapter;
        public BookingForm()
        {
            InitializeComponent();

            connection = new SqlConnection(conString);
            try
            {
                connection.Open();
                dataAdapter = new SqlDataAdapter("SELECT * FROM dbo.Countries", connection);
                dataSet = new DataSet();
                DataTable dt = dataSet.Tables.Add("dbo.Countries");
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

            CountryBox.DataSource = dataSet.Tables["dbo.Countries"];
            CountryBox.DisplayMember = "Name";
            CountryBox.ValueMember = "ID";

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
            label1.Font = new Font(font.Families[0], 8);
            label2.Font = new Font(font.Families[0], 8);
            label3.Font = new Font(font.Families[0], 8);
            label4.Font = new Font(font.Families[0], 8);
            label9.Font = new Font(font.Families[0], 8);
            OutboundFromLabel.Font = new Font(font.Families[0], 8, FontStyle.Bold);
            OutboundToLabel.Font = new Font(font.Families[0], 8, FontStyle.Bold);
            OutboundDateLabel.Font = new Font(font.Families[0], 8, FontStyle.Bold);
            OutboundFlightNumLabel.Font = new Font(font.Families[0], 8, FontStyle.Bold);
            label11.Font = new Font(font.Families[0], 8);
            label12.Font = new Font(font.Families[0], 8);
            label13.Font = new Font(font.Families[0], 8);
            label14.Font = new Font(font.Families[0], 8);
            label6.Font = new Font(font.Families[0], 8);
            ReturnFromLable.Font = new Font(font.Families[0], 8, FontStyle.Bold);
            ReturnToLabel.Font = new Font(font.Families[0], 8, FontStyle.Bold);
            ReturnDate.Font = new Font(font.Families[0], 8, FontStyle.Bold);
            ReturnFlightNum.Font = new Font(font.Families[0], 8, FontStyle.Bold);
            label7.Font = new Font(font.Families[0], 8);
            label8.Font = new Font(font.Families[0], 8);
            label5.Font = new Font(font.Families[0], 8);
            label10.Font = new Font(font.Families[0], 8);
            label15.Font = new Font(font.Families[0], 8);
            textBox1.Font = new Font(font.Families[0], 8);
            textBox2.Font = new Font(font.Families[0], 8);
            textBox3.Font = new Font(font.Families[0], 8);
            CountryBox.Font = new Font(font.Families[0], 8);
            BackButton.Font = new Font(font.Families[0], 8);
            ConfirmButton.Font = new Font(font.Families[0], 8);
        }

        private void BookingForm_Load(object sender, EventArgs e)
        {
            OutboundFromLabel.Text = SearchForm.OutboundFromAirport;
            OutboundToLabel.Text = SearchForm.OutboundToAirport;
            OutboundDateLabel.Text = SearchForm.OutboundDate;
            OutboundFlightNumLabel.Text = SearchForm.OutboundNum;
            if(SearchForm.isReturn == true)
            {
                label11.Visible = true;
                label12.Visible = true;
                label13.Visible = true;
                label14.Visible = true;
                label6.Visible = true;
                ReturnFromLable.Visible = true;
                ReturnToLabel.Visible = true;
                ReturnDate.Visible = true;
                ReturnFlightNum.Visible = true;

                ReturnFromLable.Text = SearchForm.ReturnFromAirport;
                ReturnToLabel.Text = SearchForm.ReturnToAirport;
                ReturnDate.Text = SearchForm.ReturnDate;
                ReturnFlightNum.Text = SearchForm.ReturnNum;
            }
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Close();
            SearchForm searchForm = new SearchForm();
            searchForm.Show();
        }
    }
}
