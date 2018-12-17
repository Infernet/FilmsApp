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
    public partial class SelectedFilmForm : BaseForm
    {
        

        public SelectedFilmForm()
        {
            InitializeComponent();
            using (SqlConnection connection = new SqlConnection(SqlManipul.GetInstance().ConnectionString))
            {
                string command = @"select * from Movie";
                connection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(command, connection);
                adapter.Fill(movieDBDataSet);
            }
            dataGridView1.DataSource = movieDBDataSet.ViewPersonInMovie;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void SelectedFilmForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "movieDBDataSet.ViewGenre". При необходимости она может быть перемещена или удалена.
            this.viewGenreTableAdapter.Fill(this.movieDBDataSet.ViewGenre);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "movieDBDataSet.ViewPersonInMovie". При необходимости она может быть перемещена или удалена.
            this.viewPersonInMovieTableAdapter.Fill(this.movieDBDataSet.ViewPersonInMovie);

        }
    }
}
