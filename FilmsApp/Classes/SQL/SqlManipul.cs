﻿using FilmsApp.Properties;
using System.Data;
using System.Data.SqlClient;

namespace FilmsApp.Classes.SQL
{
    class SqlManipul
    {
        public string ConnectionString { get; private set; }

        public int GenreFilterId { get; set; }
        public int CountryFilterId { get; set; }
        public int YearFilterVal { get; set; }
        public int DirectorFilterId { get; set; }
        public int LanguageFilterId { get; set; }
        public int RatedFilterId { get; set; }

        public int CurrentFilmId { get; set; }

        public MovieDBDataSet DataSetMovies;

        private static SqlManipul instance;
        private SqlManipul() {
            ConnectionString = Settings.Default.MovieDBConnectionString;
            FilterReset();
        }

        public static SqlManipul GetInstance()
        {
            if (instance == null)
                instance = new SqlManipul();
            return instance;
        }

        /// <summary>
        /// Получение списка ID фильмов удовлетворяющих условию фильтрации
        /// </summary>
        /// <returns></returns>
        public string GetFilterIdFilms()
        {
            SqlCommand command = new SqlCommand();
            //SELECT ID, Poster, Название, [Год выхода], Язык, [Длительность(мин)], Жанр, Страна, Режиссёр, [Рейтинг / 10]
            string commandText = "select ID FROM dbo.vMovies ";
            //если хоть один фильтр выбран
            if (GenreFilterId != -1 || CountryFilterId != -1 || YearFilterVal != -1 || DirectorFilterId != -1 || LanguageFilterId != -1 || RatedFilterId != -1)
            {

                string commandFilter = "where dbo.vMovies.ID in ( select dbo.Movie.MovieId from dbo.Movie ";
                //фильтрация по жанру
                if (GenreFilterId != -1)
                {
                    SqlParameter pGenre = new SqlParameter("@genre", System.Data.SqlDbType.Int)
                    {
                        Value = GenreFilterId
                    };
                    command.Parameters.Add(pGenre);
                    commandFilter += @"inner join dbo.MovieOnGenre on dbo.Movie.MovieId=dbo.MovieOnGenre.MovieId and dbo.MovieOnGenre.GenreId=@genre ";
                }
                //фильтрация по стране
                if (CountryFilterId != -1)
                {
                    SqlParameter pCountry = new SqlParameter("@country", System.Data.SqlDbType.Int)
                    {
                        Value = CountryFilterId
                    };
                    command.Parameters.Add(pCountry);
                    commandFilter += @"inner join dbo.MovieOnCountry on dbo.Movie.MovieId=dbo.MovieOnCountry.MovieId and dbo.MovieOnCountry.CountryId=@country ";
                }
                //фильтрация по языку
                if (LanguageFilterId != -1)
                {
                    SqlParameter pLanguage = new SqlParameter("@language", System.Data.SqlDbType.Int)
                    {
                        Value = LanguageFilterId
                    };
                    command.Parameters.Add(pLanguage);
                    commandFilter += @"inner join dbo.LanguageInMovie on dbo.Movie.MovieId=dbo.LanguageInMovie.MovieId and dbo.LanguageInMovie.LanguageId=@language ";
                }
                //фильтрация по режессёру
                if (DirectorFilterId != -1)
                {
                    SqlParameter pDirector = new SqlParameter("@director", System.Data.SqlDbType.Int)
                    {
                        Value = DirectorFilterId
                    };
                    command.Parameters.Add(pDirector);
                    commandFilter += @"inner join dbo.vDirectorsInMovieTable on dbo.vDirectorsInMovieTable.MovieId=dbo.Movie.MovieId and dbo.vDirectorsInMovieTable.PersonId=@director ";
                }
                //фильтры для where для рейтинга и года выхода
                if (YearFilterVal != -1 || RatedFilterId != -1)
                {
                    commandFilter += "where ";
                    bool flag = false;
                    if (RatedFilterId != -1)
                    {
                        SqlParameter pRated = new SqlParameter("@rated", System.Data.SqlDbType.Int)
                        {
                            Value = RatedFilterId
                        };
                        command.Parameters.Add(pRated);
                        commandFilter += @"dbo.Movie.RatedId=@rated";
                        flag = true;
                    }
                    if (YearFilterVal != -1)
                    {
                        if (flag)
                            commandFilter += " and ";
                        SqlParameter pYear = new SqlParameter("@year", System.Data.SqlDbType.Int)
                        {
                            Value = YearFilterVal
                        };
                        command.Parameters.Add(pYear);
                        commandFilter += @"year(dbo.Movie.Released)=@year";
                    }
                }
                commandFilter += " )";
                commandText += commandFilter;
            }
            command.CommandText = commandText;
            string result = "";
            using (SqlConnection connection = new SqlConnection(SqlManipul.GetInstance().ConnectionString))
            {
                connection.Open();
                command.Connection = connection;
                SqlDataReader reader = command.ExecuteReader();

                
                if (reader.HasRows)
                    while (reader.Read())
                        result += reader.GetInt32(0).ToString() + ",";
            }
            return result.Trim(',');
        }
        public void FilterReset()
        {
            GenreFilterId = -1;
            CountryFilterId = -1;
            YearFilterVal = -1;
            DirectorFilterId = -1;
            LanguageFilterId = -1;
            RatedFilterId = -1;
            CurrentFilmId = -1;
        }

        public bool ValidMovieTitle(string title)
        {
            bool result = false;
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("TitleMovieCheck", connection);
                command.CommandType = System.Data.CommandType.StoredProcedure;
                
                command.Parameters.Add(new SqlParameter("@title", SqlDbType.NVarChar, 50) { Value = title });
                command.Parameters.Add(new SqlParameter("@result", SqlDbType.Bit) { Value = result,Direction= ParameterDirection.Output });
                command.ExecuteNonQuery();
                result=(bool)command.Parameters["@result"].Value;
            }
            if (result)
                return true;
            else
                return false;
        }
    }
}