using FilmsApp.Classes.SQL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FilmsApp.Forms.Base
{
    public partial class MovieFilterForm : BaseForm
    {
        private DataSet dataFilters = new DataSet("FilterDataSet");



        public MovieFilterForm()
        {
            InitializeComponent();
            //заполнение comboBox данными по фильтрам из БД
            using (SqlConnection connection = new SqlConnection(SqlManipul.GetInstance().ConnectionString))
            {
                connection.Open();
                List<DataTable> filterTables = new List<DataTable>();

                filterTables.Add(new DataTable("Genre"));
                filterTables.Add(new DataTable("Country"));
                filterTables.Add(new DataTable("Director"));
                filterTables.Add(new DataTable("Language"));
                filterTables.Add(new DataTable("Rated"));


                //устанока select на жанры и заполнение таблицы
                SqlDataAdapter adapter = new SqlDataAdapter("select * from Genre order by GenreName", connection);
                adapter.Fill(filterTables[0]);
                //заполнение списком стран
                adapter.SelectCommand.CommandText = "select * from Country order by CountryName";
                adapter.Fill(filterTables[1]);
                //заполнение списком режиссёров
                adapter.SelectCommand.CommandText = "select distinct PersonId,Name from vDirectorsInMovieTable order by Name";
                adapter.Fill(filterTables[2]);
                //заполнение списком языков
                adapter.SelectCommand.CommandText = "select * from Language order by LanguageName";
                adapter.Fill(filterTables[3]);
                //заполнение списком возрастного рейтинга
                adapter.SelectCommand.CommandText = "select * from Rated order by RatedName";
                adapter.Fill(filterTables[4]);

                foreach (DataTable table in filterTables)
                    dataFilters.Tables.Add(table);
            }
            //настройка данных для comboBox
            //жанр
            comboGenre.DataSource = dataFilters.Tables[0];
            comboGenre.DisplayMember = "GenreName";
            comboGenre.ValueMember = "GenreId";
            //страна
            comboCountry.DataSource = dataFilters.Tables[1];
            comboCountry.DisplayMember = "CountryName";
            comboCountry.ValueMember = "CountryId";
            //режиссёр
            comboDirector.DataSource = dataFilters.Tables[2];
            comboDirector.DisplayMember = "Name";
            comboDirector.ValueMember = "PersonId";
            //язык
            comboLanguage.DataSource = dataFilters.Tables[3];
            comboLanguage.DisplayMember = "LanguageName";
            comboLanguage.ValueMember = "LanguageId";
            //возрастной рейтинг
            comboRated.DataSource = dataFilters.Tables[4];
            comboRated.DisplayMember = "RatedName";
            comboRated.ValueMember = "RatedId";

            //восстановление фильтра по его текущему состоянию
            if (SqlManipul.GetInstance().GenreFilterId != -1)
            {
                checkEnableGenre.Checked = true;
                comboGenre.SelectedValue = SqlManipul.GetInstance().GenreFilterId;
            }
            if (SqlManipul.GetInstance().CountryFilterId != -1)
            {
                checkEnableCountry.Checked = true;
                comboCountry.SelectedValue = SqlManipul.GetInstance().CountryFilterId;
            }
            if (SqlManipul.GetInstance().DirectorFilterId != -1)
            {
                checkEnableDirector.Checked = true;
                comboDirector.SelectedValue = SqlManipul.GetInstance().DirectorFilterId;
            }
            if (SqlManipul.GetInstance().LanguageFilterId != -1)
            {
                checkEnableLanguage.Checked = true;
                comboLanguage.SelectedValue = SqlManipul.GetInstance().LanguageFilterId;
            }
            if (SqlManipul.GetInstance().RatedFilterId != -1)
            {
                checkEnableRated.Checked = true;
                comboRated.SelectedValue = SqlManipul.GetInstance().RatedFilterId;
            }
            if (SqlManipul.GetInstance().YearFilterVal != -1)
            {
                checkEnableYear.Checked = true;
                numericYear.Value = SqlManipul.GetInstance().YearFilterVal;
            }
        }


        private void checkEnableGenre_CheckedChanged(object sender, EventArgs e)
        {
            if (checkEnableGenre.Checked)
                comboGenre.Enabled = true;
            else
                comboGenre.Enabled = false;
        }

        private void checkEnableCountry_CheckedChanged(object sender, EventArgs e)
        {
            if (checkEnableCountry.Checked)
                comboCountry.Enabled = true;
            else
                comboCountry.Enabled = false;
        }

        private void checkEnableDirector_CheckedChanged(object sender, EventArgs e)
        {
            if (checkEnableDirector.Checked)
                comboDirector.Enabled = true;
            else
                comboDirector.Enabled = false;
        }

        private void checkEnableLanguage_CheckedChanged(object sender, EventArgs e)
        {
            if (checkEnableLanguage.Checked)
                comboLanguage.Enabled = true;
            else
                comboLanguage.Enabled = false;
        }

        private void checkEnableRated_CheckedChanged(object sender, EventArgs e)
        {
            if (checkEnableRated.Checked)
                comboRated.Enabled = true;
            else
                comboRated.Enabled = false;
        }

        private void checkEnableYear_CheckedChanged(object sender, EventArgs e)
        {
            if (checkEnableYear.Checked)
                numericYear.Enabled = true;
            else
                numericYear.Enabled = false;
        }
        
        private void buttonReset_Click(object sender, EventArgs e)
        {
            SqlManipul.GetInstance().FilterReset();
            this.DialogResult = DialogResult.No;
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            //проверка выбранных пунктов фильтров
            //жанр
            SqlManipul.GetInstance().GenreFilterId = (checkEnableGenre.Checked) ? (int)comboGenre.SelectedValue : -1;
            //страна
            SqlManipul.GetInstance().CountryFilterId = (checkEnableCountry.Checked) ? (int)comboCountry.SelectedValue : -1;
            //режиссёр
            SqlManipul.GetInstance().DirectorFilterId = (checkEnableDirector.Checked) ? (int)comboDirector.SelectedValue : -1;
            //язык
            SqlManipul.GetInstance().LanguageFilterId = (checkEnableLanguage.Checked) ? (int)comboLanguage.SelectedValue : -1;
            //возрастной рейтинг
            SqlManipul.GetInstance().RatedFilterId = (checkEnableRated.Checked) ? (int)comboRated.SelectedValue : -1;
            //год выхода
            SqlManipul.GetInstance().YearFilterVal = (checkEnableYear.Checked) ? (int)numericYear.Value : -1;
            this.DialogResult = DialogResult.Yes;
        }
    }
}
