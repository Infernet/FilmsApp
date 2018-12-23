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
    public partial class ShowFilmForm : BaseForm
    {
        public ShowFilmForm()
        {
            InitializeComponent();
            LoadData();
            //adapter.Tables[0].Select(cmd)[0]["Рейтинг /10"] = "1";
            //tbRating.Text = adapter.Tables[0].Select(cmd)[0][2].ToString();
            
        }

        /// <summary>
        /// Метод отображающий информацию о фильме
        /// </summary>
        private void LoadData()
        {
            //ссылка на dataset и команда выбора данных по выбранному фильму
            MovieDBDataSet dataSet = SqlManipul.GetInstance().DataSetMovies;
            string cmd = "ID=" + SqlManipul.GetInstance().CurrentFilmId.ToString();
            //Заполнение базовыми данными
            picturePoster.Image = new Bitmap(Application.StartupPath + @"\Resources\Images\" + dataSet.Tables[0].Select(cmd)[0]["Poster"].ToString());
            lTitle.Text = dataSet.Tables[0].Select(cmd)[0]["Название"].ToString();
            DateTime dateTime;
            DateTime.TryParse(dataSet.Tables[0].Select(cmd)[0]["Дата выхода"].ToString(),out dateTime);
            tbReleased.Text = dateTime.ToString("dd  MMMM  yyyy");
            tbLanguage.Text = dataSet.Tables[0].Select(cmd)[0]["Язык"].ToString();
            tbRuntime.Text = dataSet.Tables[0].Select(cmd)[0]["Длительность (мин)"].ToString() + " мин.";
            tbGenre.Text = dataSet.Tables[0].Select(cmd)[0]["Жанр"].ToString();
            tbRated.Text = dataSet.Tables[0].Select(cmd)[0]["Возрастной рейтинг"].ToString();
            tbCountry.Text = dataSet.Tables[0].Select(cmd)[0]["Страна"].ToString();
            tbDirector.Text = dataSet.Tables[0].Select(cmd)[0]["Режиссёр"].ToString();
            tbPlot.Text = dataSet.Tables[0].Select(cmd)[0]["Описание"].ToString();
            //Заполнение опциональных данных
            if (dataSet.Tables[0].Select(cmd)[0]["Год"] != null)
            {
                lYear.Visible = true;
                tbYearReleased.Visible = true;
                tbYearReleased.Text = dataSet.Tables[0].Select(cmd)[0]["Год"].ToString();
            }
            if (dataSet.Tables[0].Select(cmd)[0]["IMDB rated"]!=null)
            {
                lImdbRating.Visible = true;
                tbImdbRated.Visible = true;
                tbImdbRated.Text = dataSet.Tables[0].Select(cmd)[0]["IMDB rated"].ToString()+"/10";
            }
            if (dataSet.Tables[0].Select(cmd)[0]["IMDB Votes"] != null)
            {
                lImdbVotes.Visible = true;
                tbImdbVotes.Visible = true;
                tbImdbVotes.Text = dataSet.Tables[0].Select(cmd)[0]["IMDB Votes"].ToString();
            }
            if (dataSet.Tables[0].Select(cmd)[0]["Дата выхода на DVD"] != null)
            {
                lDVD.Visible = true;
                tbDVD.Visible = true;
                DateTime.TryParse(dataSet.Tables[0].Select(cmd)[0]["Дата выхода на DVD"].ToString(), out dateTime);
                tbDVD.Text = dateTime.ToString("dd  MMMM  yyyy");
            }
            if (dataSet.Tables[0].Select(cmd)[0]["Сайт"] != null && !String.IsNullOrEmpty(dataSet.Tables[0].Select(cmd)[0]["Сайт"].ToString()))
            {
                lWebSite.Visible = true;
                tbWebSite.Visible = true;
                tbWebSite.Text = @dataSet.Tables[0].Select(cmd)[0]["Сайт"].ToString();
            }
            if (dataSet.Tables[0].Select(cmd)[0]["Награды"] != null)
            {
                lAwards.Visible = true;
                tbAwards.Visible = true;
                tbAwards.Text = dataSet.Tables[0].Select(cmd)[0]["Награды"].ToString();
            }
            if (dataSet.Tables[0].Select(cmd)[0]["Актёрский состав"] != null)
            {
                lActors.Visible = true;
                tbActors.Visible = true;
                tbActors.Text = dataSet.Tables[0].Select(cmd)[0]["Актёрский состав"].ToString();
            }
            if (dataSet.Tables[0].Select(cmd)[0]["Сценарий"] != null)
            {
                lWriters.Visible = true;
                tbWriters.Visible = true;
                tbWriters.Text = dataSet.Tables[0].Select(cmd)[0]["Сценарий"].ToString();
            }
            if (dataSet.Tables[0].Select(cmd)[0]["MetaScore"] != null)
            {
                lMetascore.Visible = true;
                tbMetaScore.Visible = true;
                tbMetaScore.Text = dataSet.Tables[0].Select(cmd)[0]["MetaScore"].ToString();
            }

            if (dataSet.Tables[0].Select(cmd)[0]["Кассовые сборы"] != null && !String.IsNullOrEmpty(dataSet.Tables[0].Select(cmd)[0]["Кассовые сборы"].ToString()))
            {
                lBoxOffice.Visible = true;
                tbBoxOffice.Visible = true;
                tbBoxOffice.Text ="$ "+ dataSet.Tables[0].Select(cmd)[0]["Кассовые сборы"].ToString();
            }
            if (dataSet.Tables[0].Select(cmd)[0]["Производство"] != null)
            {
                lProduction.Visible = true;
                tbProduction.Visible = true;
                tbProduction.Text = dataSet.Tables[0].Select(cmd)[0]["Производство"].ToString();
            }
        }
    }
}
