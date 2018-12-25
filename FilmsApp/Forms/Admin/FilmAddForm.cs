using FilmsApp.Forms.Base;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;
using FilmsApp.Classes.SQL;

namespace FilmsApp.Forms.Admin
{
    public partial class FilmAddForm : BaseForm
    {
        //Обязательные данные
        private DataTable tableLanguage = new DataTable("Язык");
        private DataTable tableGenre = new DataTable("Жанр");
        private DataTable tableCountry = new DataTable("Страна");
        private DataTable tableDirector = new DataTable("Режиссёр");
        private string rated;
        private DateTime releasedDate=default(DateTime);
        private string poster="Default.jpg";
        //Опциональные параметры
        private DataTable tableActors = new DataTable("Актёры");
        private DataTable tableProduction = new DataTable("Производитель");
        private DataTable tableWriters = new DataTable("Сцераний");
        private DateTime dvd=default(DateTime);

        public FilmAddForm()
        {
            InitializeComponent();
            pictureBoxIcon.Image = new Bitmap(Application.StartupPath + @"\Resources\Icons\logo1.png");
            //обязательные поля
            tableLanguage.Columns.Add("Язык");
            tableGenre.Columns.Add("Название жанра");
            tableCountry.Columns.Add("Названиие страны");
            tableDirector.Columns.Add("ФИО режиссёра");

            dGVLanguage.DataSource = tableLanguage;
            dGVGenre.DataSource = tableGenre;
            dGVCountry.DataSource = tableCountry;
            dGVDirector.DataSource = tableDirector;
            //опциональные поля
            tableActors.Columns.Add("ФИО актёра");
            tableProduction.Columns.Add("Название студии");
            tableWriters.Columns.Add("ФИО");
            tableWriters.Columns.Add("Роль");

            dGVActors.DataSource = tableActors;
            dGVProduction.DataSource = tableProduction;
            dGVWriter.DataSource = tableWriters;

        }


        private void cBAdditionalParam_CheckedChanged(object sender, EventArgs e)
        {
            if (cBAdditionalParam.Checked)
                gBAdditionParam.Enabled = true;
            else
                gBAdditionParam.Enabled = false;
        }

        private void FilmAddForm_Load(object sender, EventArgs e)
        {
            //основные
            dGVLanguage.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dGVGenre.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dGVCountry.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dGVDirector.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            dGVLanguage.Columns[0].SortMode = DataGridViewColumnSortMode.NotSortable;
            dGVGenre.Columns[0].SortMode = DataGridViewColumnSortMode.NotSortable;
            dGVCountry.Columns[0].SortMode = DataGridViewColumnSortMode.NotSortable;
            dGVDirector.Columns[0].SortMode = DataGridViewColumnSortMode.NotSortable;
            //опциональные
            dGVActors.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dGVProduction.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dGVWriter.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dGVWriter.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            dGVActors.Columns[0].SortMode = DataGridViewColumnSortMode.NotSortable;
            dGVProduction.Columns[0].SortMode = DataGridViewColumnSortMode.NotSortable;
            dGVWriter.Columns[0].SortMode = DataGridViewColumnSortMode.NotSortable;
            dGVWriter.Columns[1].SortMode = DataGridViewColumnSortMode.NotSortable;
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            //проверка правильности ввода
            if (CheckDataFilm())
            {
                //проверка названия на дубликат
                if (SqlManipul.GetInstance().ValidMovieTitle(tbTitle.Text))
                {
                    //фиксация
                    rated = (String.IsNullOrWhiteSpace(tbRated.Text) ? "UNRATED" : tbRated.Text);
                    //исполнение
                    if (InsertFilm())
                        MessageBox.Show("Фильм - " + tbTitle.Text + " успешно добавлен.", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show("Не удалось добавить фильм - " + tbTitle.Text, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                    MessageBox.Show("Фильм с названием - " + tbTitle.Text + " уже существует в базе.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                MessageBox.Show("Заполните все необходимые поля.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private bool CheckDataFilm()
        {
            bool result = true;
            //валидация с подсветкой

            //название
            if (String.IsNullOrWhiteSpace(tbTitle.Text))
            {
                result = false;
                lTitle.BackColor = Color.Red;
            } 
            else
                lTitle.BackColor = Color.Green;
            //дата выхода
            if (dTPReleased.Value.ToShortDateString() == "01.01.1800")
            {
                result = false;
                lReleased.BackColor = Color.Red;
            }
            else
                lReleased.BackColor = Color.Green;
            //длительность
            if (numericRuntime.Value == 0)
            {
                result = false;
                lRuntime.BackColor = Color.Red;
            }
            else
                lRuntime.BackColor = Color.Green;
            //описание
            if (String.IsNullOrWhiteSpace(tbPlot.Text))
            {
                result = false;
                lPlot.BackColor = Color.Red;
            }
            else
                lPlot.BackColor = Color.Green;
            //язык
            if (tableLanguage.Rows.Count == 0)
            {
                result = false;
                lLanguage.BackColor = Color.Red;
            }
            else
                lLanguage.BackColor = Color.Green;
            //жанр
            if (tableGenre.Rows.Count == 0)
            {
                result = false;
                lGenre.BackColor = Color.Red;
            }
            else
                lGenre.BackColor = Color.Green;
            //страна
            if (tableCountry.Rows.Count == 0)
            {
                result = false;
                lCountry.BackColor = Color.Red;
            }
            else
                lCountry.BackColor = Color.Green;
            //режиссёр
            if (tableDirector.Rows.Count == 0)
            {
                result = false;
                lDirector.BackColor = Color.Red;
            }
            else
                lDirector.BackColor = Color.Green;

            return result;
        }

        private bool InsertFilm()
        {
            bool result = false;

            using (SqlConnection connection = new SqlConnection(SqlManipul.GetInstance().ConnectionString))
            {
                connection.Open();
                SqlTransaction transaction = connection.BeginTransaction();
                try
                {
                    //Добавление фильма с получением его primary key
                    int FilmId;
                    SqlCommand insertCommand = connection.CreateCommand();
                    insertCommand.CommandType = CommandType.StoredProcedure;
                    insertCommand.Transaction = transaction;
                    insertCommand.CommandText = "InsertMovie";

                    //добаление обязательных параметров

                    //возвращаемое значение
                    insertCommand.Parameters.Add(new SqlParameter("@result", SqlDbType.Int) { Direction = ParameterDirection.Output });
                    //заголовок
                    insertCommand.Parameters.Add(new SqlParameter("@Title", SqlDbType.NVarChar, 50) {Value=tbTitle.Text });
                    //имя рейтинга
                    insertCommand.Parameters.Add(new SqlParameter("@Rated", SqlDbType.NVarChar, 30) {Value=rated });
                    //дата релиза
                    insertCommand.Parameters.Add(new SqlParameter("@Released", SqlDbType.DateTime) {Value=releasedDate });
                    //длительность
                    insertCommand.Parameters.Add(new SqlParameter("@RunTime", SqlDbType.Int) {Value=(int)numericRuntime.Value });
                    //описание
                    insertCommand.Parameters.Add(new SqlParameter("@Plot", SqlDbType.NVarChar, 500) {Value=tbPlot.Text });
                    //постер
                    insertCommand.Parameters.Add(new SqlParameter("@Poster", SqlDbType.NVarChar, 50) {Value=poster });
                    //рейтинг
                    insertCommand.Parameters.Add(new SqlParameter("@Rating", SqlDbType.Float) {Value=5.0f });

                    //опциональные параметры
                    //проверка на установленный флаг
                    if (cBAdditionalParam.Checked)
                    {
                        //награды
                        if (!String.IsNullOrWhiteSpace(tBAwards.Text)) insertCommand.Parameters.Add(new SqlParameter("@Awards", SqlDbType.NVarChar, 100) { Value = tBAwards.Text });
                        //рейтинг imdb
                        if (numericImdbRated.Value != 0) insertCommand.Parameters.Add(new SqlParameter("@ImdbRating", SqlDbType.Float) { Value = (float)Math.Round(numericImdbRated.Value, 2) });
                        //метасумма
                        if (numericMetaScore.Value != 0) insertCommand.Parameters.Add(new SqlParameter("@MetaScore", SqlDbType.Int) { Value = (int)numericMetaScore.Value });
                        //голоса
                        if (numericImdbVotes.Value != 0) insertCommand.Parameters.Add(new SqlParameter("@Votes", SqlDbType.Int) { Value = (int)numericImdbVotes.Value });
                        //dvd
                        if (dvd != default(DateTime)) insertCommand.Parameters.Add(new SqlParameter("@DVD", SqlDbType.DateTime) { Value = dvd });
                        //сборы
                        if (numericBoxOffice.Value != 0) insertCommand.Parameters.Add(new SqlParameter("@BoxOffice", SqlDbType.Int) { Value = (int)numericBoxOffice.Value });
                        //сайт
                        if (!String.IsNullOrWhiteSpace(tbSite.Text)) insertCommand.Parameters.Add(new SqlParameter("@SiteURL", SqlDbType.NVarChar, 100) { Value = tbSite.Text });
                    }
                    insertCommand.ExecuteNonQuery();
                    FilmId = (int)insertCommand.Parameters["@result"].Value;

                    //добавление записей в обязательные таблицы
                    //параметр id фильма
                    SqlParameter paramFilmId = new SqlParameter("@FilmId", SqlDbType.Int) {Value=FilmId };


                    //жанр
                    insertCommand.Parameters.Clear();
                    insertCommand.CommandText = "InsertMovieOnGenre";
                    //аргумент названия
                    insertCommand.Parameters.Add(new SqlParameter("@GenreValue", SqlDbType.NVarChar, 30));
                    insertCommand.Parameters.Add(paramFilmId);
                    for (int index = 0; index < tableGenre.Rows.Count; index++)
                    {
                        insertCommand.Parameters["@GenreValue"].Value = (string)tableGenre.Rows[index][0];
                        insertCommand.ExecuteNonQuery();
                    }

                    //язык
                    insertCommand.Parameters.Clear();
                    insertCommand.CommandText = "InsertMovieOnLanguage";
                    insertCommand.Parameters.Add(new SqlParameter("@LanguageValue", SqlDbType.NVarChar, 30));
                    insertCommand.Parameters.Add(paramFilmId);
                    for (int index = 0; index < tableLanguage.Rows.Count; index++)
                    {
                        insertCommand.Parameters["@LanguageValue"].Value = (string)tableLanguage.Rows[index][0];
                        insertCommand.ExecuteNonQuery();
                    }

                    //страна
                    insertCommand.Parameters.Clear();
                    insertCommand.CommandText = "InsertMovieOnCountry";
                    insertCommand.Parameters.Add(new SqlParameter("@CountryValue", SqlDbType.NVarChar, 30));
                    insertCommand.Parameters.Add(paramFilmId);
                    for (int index = 0; index < tableCountry.Rows.Count; index++)
                    {
                        insertCommand.Parameters["@CountryValue"].Value = (string)tableCountry.Rows[index][0];
                        insertCommand.ExecuteNonQuery();
                    }

                    //режиссёр
                    insertCommand.Parameters.Clear();
                    insertCommand.CommandText = "InsertPersonInMovie";
                    insertCommand.Parameters.Add(new SqlParameter("@PersonName", SqlDbType.NVarChar, 60));
                    insertCommand.Parameters.Add(new SqlParameter("@RoleName", SqlDbType.NVarChar, 30) {Value="Director" });
                    insertCommand.Parameters.Add(paramFilmId);
                    for (int index = 0; index < tableDirector.Rows.Count; index++)
                    {
                        insertCommand.Parameters["@PersonName"].Value = (string)tableDirector.Rows[index][0];
                        insertCommand.ExecuteNonQuery();
                    }


                    //опциональные записи
                    //проверка установки галочки на доп параметры
                    if (cBAdditionalParam.Checked)
                    {
                        //актёры
                        if (tableActors.Rows.Count > 0)
                        {
                            insertCommand.Parameters.Clear();
                            insertCommand.CommandText = "InsertPersonInMovie";
                            insertCommand.Parameters.Add(new SqlParameter("@PersonName", SqlDbType.NVarChar, 60));
                            insertCommand.Parameters.Add(new SqlParameter("@RoleName", SqlDbType.NVarChar, 30) { Value = "Actors" });
                            insertCommand.Parameters.Add(paramFilmId);
                            for (int index = 0; index < tableActors.Rows.Count; index++)
                            {
                                insertCommand.Parameters["@PersonName"].Value = (string)tableActors.Rows[index][0];
                                insertCommand.ExecuteNonQuery();
                            }
                        }

                        //писатели
                        if (tableWriters.Rows.Count > 0)
                        {
                            insertCommand.Parameters.Clear();
                            insertCommand.CommandText = "InsertPersonInMovie";
                            insertCommand.Parameters.Add(new SqlParameter("@PersonName", SqlDbType.NVarChar, 60));
                            insertCommand.Parameters.Add(new SqlParameter("@RoleName", SqlDbType.NVarChar, 30));
                            insertCommand.Parameters.Add(paramFilmId);
                            for (int index = 0; index < tableWriters.Rows.Count; index++)
                            {
                                insertCommand.Parameters["@PersonName"].Value = (string)tableWriters.Rows[index][0];
                                insertCommand.Parameters["@RoleName"].Value = (String.IsNullOrWhiteSpace(tableWriters.Rows[index][1].ToString()) ? "Writer" : (string)tableWriters.Rows[index][1]);
                                insertCommand.ExecuteNonQuery();
                            }
                        }

                        //студия производитель
                        if (tableProduction.Rows.Count > 0)
                        {
                            insertCommand.Parameters.Clear();
                            insertCommand.CommandText = "InsertMovieOnProduction";
                            insertCommand.Parameters.Add(new SqlParameter("@ProductionValue", SqlDbType.NVarChar, 30));
                            insertCommand.Parameters.Add(paramFilmId);
                            for (int index = 0; index < tableProduction.Rows.Count; index++)
                            {
                                insertCommand.Parameters["@ProductionValue"].Value = (string)tableProduction.Rows[index][0];
                                insertCommand.ExecuteNonQuery();
                            }
                        }
                    }

                    transaction.Commit();
                    result = true;
                }
                catch (Exception error)
                {
                    transaction.Rollback();
                    MessageBox.Show(error.Message, "Ошибка при попытке добавить фильм", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    result = false;
                }

            }
            return result;
        }

        private void dTPDvd_ValueChanged(object sender, EventArgs e)
        {
            dvd = dTPDvd.Value;
        }

        private void dTPReleased_ValueChanged(object sender, EventArgs e)
        {
            releasedDate = dTPReleased.Value;
        }

        private void buttonSelectPoster_Click(object sender, EventArgs e)
        {
            openPosterDialog.Filter = "PNG|*.png |JPEG|*.jpg";
            openPosterDialog.FileName = "";
            if(openPosterDialog.ShowDialog()== DialogResult.OK)
            {
                MessageBox.Show(openPosterDialog.SafeFileName,openPosterDialog.FileName);
                poster = openPosterDialog.SafeFileName;
                File.Copy(openPosterDialog.FileName,Application.StartupPath+@"\Resources\Images\" + openPosterDialog.SafeFileName,true);
            }
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Abort;
        }

    }
}
