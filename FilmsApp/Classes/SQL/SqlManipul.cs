using FilmsApp.Properties;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        private static SqlManipul instance;
        private SqlManipul() { ConnectionString = Settings.Default.MovieDBConnectionString; }

        public static SqlManipul GetInstance()
        {
            if (instance == null)
                instance = new SqlManipul();
            return instance;
        }

        public SqlCommand GetFilterCommand()
        {
            SqlCommand command = new SqlCommand();
            //SELECT ID, Poster, Название, [Год выхода], Язык, [Длительность(мин)], Жанр, Страна, Режиссёр, [Рейтинг / 10]
            string commandText = "select * FROM dbo.vMovies ";
            //если хоть один фильтр выбран
            if(GenreFilterId!=-1 || CountryFilterId!=-1 || YearFilterVal != -1 ||DirectorFilterId!=-1 ||LanguageFilterId!=-1 ||RatedFilterId!=-1)
            {

                string commandFilter = "where dbo.vMovies.ID in ( select dbo.Movie.MovieId from dbo.Movie ";
                //фильтрация по жанру
                if (GenreFilterId!=-1)
                {
                    SqlParameter pGenre = new SqlParameter("@genre", System.Data.SqlDbType.Int);
                    pGenre.Value = GenreFilterId;
                    command.Parameters.Add(pGenre);
                    commandFilter += @"inner join dbo.MovieOnGenre on dbo.Movie.MovieId=dbo.MovieOnGenre.MovieId and dbo.MovieOnGenre.GenreId=@genre ";
                }
                //фильтрация по стране
                if (CountryFilterId != -1)
                {
                    SqlParameter pCountry = new SqlParameter("@country", System.Data.SqlDbType.Int);
                    pCountry.Value = CountryFilterId;
                    command.Parameters.Add(pCountry);
                    commandFilter += @"inner join dbo.MovieOnCountry on dbo.Movie.MovieId=dbo.MovieOnCountry.MovieId and dbo.MovieOnCountry.CountryId=@country ";
                }
                //фильтрация по языку
                if (LanguageFilterId != -1)
                {
                    SqlParameter pLanguage = new SqlParameter("@language", System.Data.SqlDbType.Int);
                    pLanguage.Value = LanguageFilterId;
                    command.Parameters.Add(pLanguage);
                    commandFilter += @"inner join dbo.LanguageInMovie on dbo.Movie.MovieId=dbo.LanguageInMovie.MovieId and dbo.LanguageInMovie.LanguageId=@language ";
                }
                //фильтрация по режессёру
                if (DirectorFilterId != -1)
                {
                    SqlParameter pDirector = new SqlParameter("@director", System.Data.SqlDbType.Int);
                    pDirector.Value = DirectorFilterId;
                    command.Parameters.Add(pDirector);
                    commandFilter += @"inner join dbo.vDirectorsInMovieTable on dbo.vDirectorsInMovieTable.MovieId=dbo.Movie.MovieId and dbo.vDirectorsInMovieTable.PersonId=@director ";
                }
                //фильтры для where для рейтинга и года выхода
                if(YearFilterVal!=-1 || RatedFilterId != -1)
                {
                    commandFilter += "where ";
                    bool flag = false;
                    if(RatedFilterId!=-1)
                    {
                        SqlParameter pRated = new SqlParameter("@rated", System.Data.SqlDbType.Int);
                        pRated.Value = RatedFilterId;
                        command.Parameters.Add(pRated);
                        commandFilter += @"dbo.Movie.RatedId=@rated";
                        flag = true;
                    }
                    if(YearFilterVal!=-1)
                    {
                        if (flag)
                            commandFilter += " and ";
                        SqlParameter pYear = new SqlParameter("@year", System.Data.SqlDbType.Int);
                        pYear.Value = YearFilterVal;
                        command.Parameters.Add(pYear);
                        commandFilter += @"year(dbo.Movie.Released)=@year";
                    }
                }
                commandFilter += " )";
                commandText += commandFilter;
            }
            command.CommandText = commandText;
            return command;
        }
        public void FilterReset()
        {
            GenreFilterId = -1;
            CountryFilterId = -1;
            YearFilterVal = -1;
            DirectorFilterId = -1;
            LanguageFilterId = -1;
            RatedFilterId = -1;
        }
    }
}


/*
 
            public SqlCommand GetFilterCommand()
        {
            SqlCommand command = new SqlCommand();
            string commandText = "SELECT ID, Poster, Название, [Год выхода], Язык, [Длительность(мин)], Жанр, Страна, Режиссёр, [Рейтинг / 10] FROM dbo.vMovies ";
            //если хоть один фильтр выбран
            if(GenreFilterId!=-1 || CountryFilterId!=-1 || YearFilterVal != -1 ||DirectorFilterId!=-1 ||LanguageFilterId!=-1 ||RatedFilterId!=-1)
            {

                string commandFilter = "where dbo.vMovies.ID in ( select dbo.Movie.MovieId from dbo.Movie ";
                //фильтрация по жанру
                if (GenreFilterId!=-1)
                {
                    SqlParameter pGenre = new SqlParameter("@genre", System.Data.SqlDbType.Int);
                    pGenre.Value = GenreFilterId;
                    command.Parameters.Add(pGenre);
                    commandFilter += @"inner join dbo.MovieOnGenre on dbo.Movie.MovieId=dbo.MovieOnGenre.MovieId and dbo.MovieOnGenre.GenreId=@genre ";
                }
                //фильтрация по стране
                if (CountryFilterId != -1)
                {
                    SqlParameter pCountry = new SqlParameter("@country", System.Data.SqlDbType.Int);
                    pCountry.Value = CountryFilterId;
                    command.Parameters.Add(pCountry);
                    commandFilter += @"inner join dbo.MovieOnCountry on dbo.Movie.MovieId=dbo.MovieOnCountry.MovieId and dbo.MovieOnCountry.CountryId=@country ";
                }
                //фильтрация по языку
                if (LanguageFilterId != -1)
                {
                    SqlParameter pLanguage = new SqlParameter("@language", System.Data.SqlDbType.Int);
                    pLanguage.Value = LanguageFilterId;
                    command.Parameters.Add(pLanguage);
                    commandFilter += @"inner join dbo.LanguageInMovie on dbo.Movie.MovieId=dbo.LanguageInMovie.MovieId and dbo.LanguageInMovie.LanguageId=@language ";
                }
                //фильтрация по режессёру
                if (DirectorFilterId != -1)
                {
                    SqlParameter pDirector = new SqlParameter("@director", System.Data.SqlDbType.Int);
                    pDirector.Value = DirectorFilterId;
                    command.Parameters.Add(pDirector);
                    commandFilter += @"inner join dbo.vDirectorsInMovieTable on dbo.vDirectorsInMovieTable.MovieId=dbo.Movie.MovieId and dbo.vDirectorsInMovieTable.PersonId=@director ";
                }
                //фильтры для where для рейтинга и года выхода
                if(YearFilterVal!=-1 || RatedFilterId != -1)
                {
                    commandFilter += "where ";
                    bool flag = false;
                    if(RatedFilterId!=-1)
                    {
                        SqlParameter pRated = new SqlParameter("@rated", System.Data.SqlDbType.Int);
                        pRated.Value = RatedFilterId;
                        command.Parameters.Add(pRated);
                        commandFilter += @"dbo.Movie.RatedId=@rated";
                        flag = true;
                    }
                    if(YearFilterVal!=-1)
                    {
                        if (flag)
                            commandFilter += " and ";
                        SqlParameter pYear = new SqlParameter("@year", System.Data.SqlDbType.Int);
                        pYear.Value = YearFilterVal;
                        command.Parameters.Add(pYear);
                        commandFilter += @"year(dbo.Movie.Released)=@year";
                    }
                }
                commandFilter += " )";
                commandText += commandFilter;
            }
            command.CommandText = commandText;
            return command;
        }

 */
