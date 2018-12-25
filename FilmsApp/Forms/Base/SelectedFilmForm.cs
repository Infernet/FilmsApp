using FilmsApp.Classes.SQL;
using FilmsApp.Forms.Admin;
using FilmsApp.Forms.Moderator;
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
            dataGridView1.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            SqlManipul.GetInstance().DataSetMovies = movieDBDataSet;
        }

        private void SelectedFilmForm_Load_1(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "movieDBDataSet1.vMovies". При необходимости она может быть перемещена или удалена.
            this.vMoviesTableAdapter.Fill(this.movieDBDataSet.vMovies);


            for (int i = 0; i < dataGridView1.Rows.Count; i++)
                dataGridView1.Rows[i].Cells["PosterImage"].Value = new Bitmap(Application.StartupPath + @"\Resources\Images\" + (string)dataGridView1.Rows[i].Cells["posterData"].Value);
        }

        private void dataGridView1_Sorted(object sender, EventArgs e)
        {
            SqlManipul.GetInstance().CurrentFilmId = (int)dataGridView1.Rows[0].Cells[1].Value;
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
               dataGridView1.Rows[i].Cells["PosterImage"].Value = new Bitmap(Application.StartupPath + @"\Resources\Images\" + (string)dataGridView1.Rows[i].Cells["posterData"].Value);
        }

        private void buttonSelectFilther_Click(object sender, EventArgs e)
        {
            DialogResult result= new MovieFilterForm().ShowDialog();
            switch (result)
            {
                case DialogResult.Abort:
                        DialogResult = DialogResult.Abort;
                    break;
                case DialogResult.Yes:
                    {
                        MessageBox.Show("Фильтрация");
                        string filter = SqlManipul.GetInstance().GetFilterIdFilms();
                        if (!String.IsNullOrEmpty(filter))
                            dataGridView1.DataSource = movieDBDataSet.vMovies.Select("ID in (" + filter + ")").CopyToDataTable();
                        else
                            dataGridView1.DataSource = null;
                    }
                    break;
                case DialogResult.No:
                    {
                        MessageBox.Show("Сброс");
                        dataGridView1.DataSource = movieDBDataSet.vMovies;
                    }
                    break;
                default:
                    break;
            }
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
                dataGridView1.Rows[i].Cells["PosterImage"].Value = new Bitmap(Application.StartupPath + @"\Resources\Images\" + (string)dataGridView1.Rows[i].Cells["posterData"].Value);
        }

        private void buttonShowSelectedFilm_Click(object sender, EventArgs e)
        {
            if(SqlManipul.GetInstance().CurrentFilmId!=-1)
            ShowNextForm(new ShowFilmForm(), false);
            
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dataGridView1.DataSource != null)
                {
                    //MessageBox.Show(dataGridView1.CurrentRow.Cells[1].Value.ToString(), dataGridView1.CurrentRow.Cells[3].Value.ToString());
                    SqlManipul.GetInstance().CurrentFilmId = (int)dataGridView1.CurrentRow.Cells[1].Value;
                }
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void buttonModeratorFeedBack_Click(object sender, EventArgs e)
        {
            ShowNextForm(new FeedBackModerationForm());
        }

        private void buttonFilmAdd_Click(object sender, EventArgs e)
        {
            ShowNextForm(new FilmAddForm());
            

        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Abort;
        }
    }
}

//бекап метода фильтрации
/*
 
    private void buttonSelectFilther_Click(object sender, EventArgs e)
        {
            // BaseForm filter = ;
            DialogResult result= new MovieFilterForm().ShowDialog();
            switch (result)
            {
                case DialogResult.Yes:
                    {
                        MessageBox.Show("Фильтрация");
                        using (SqlConnection connection = new SqlConnection(SqlManipul.GetInstance().ConnectionString))
                        {
                            connection.Open();
                            SqlCommand command = SqlManipul.GetInstance().GetFilterCommand();
                            command.Connection = connection;
                            SqlDataAdapter adapter = new SqlDataAdapter(command);
                            this.movieDBDataSet.vMovies.Clear();
                            adapter.Fill(this.movieDBDataSet.vMovies);

                        }
                        dataGridView1.DataSource = movieDBDataSet.vMovies;
                        for (int i = 0; i < dataGridView1.Rows.Count; i++)
                        {
                            Image poster = new Bitmap(Application.StartupPath + @"\Resources\Images\" + (string)dataGridView1.Rows[i].Cells["posterData"].Value);
                            dataGridView1.Rows[i].Cells["PosterImage"].Value = poster;

                        }
                        //SqlCommand command = SqlManipul.GetInstance().GetFilterCommand();
                        //vMoviesTableAdapter.Adapter.SelectCommand.CommandText = command.CommandText;
                        //List<SqlParameter> paramList = new List<SqlParameter>();
                        //foreach (SqlParameter item in command.Parameters)
                        //{
                        //    paramList.Add(item);
                        //}
                        //command.Parameters.Clear();
                        //foreach (SqlParameter param in paramList)
                        //    vMoviesTableAdapter.Adapter.SelectCommand.Parameters.Add(param); 
                        //this.vMoviesTableAdapter.Fill(this.movieDBDataSet.vMovies);
                    }
                    break;
                case DialogResult.No:
                    {
                        MessageBox.Show("Сброс");
                        vMoviesTableAdapter.Fill(this.movieDBDataSet.vMovies);
                        dataGridView1.DataSource = movieDBDataSet.vMovies;
                        for (int i = 0; i < dataGridView1.Rows.Count; i++)
                        {
                            Image poster = new Bitmap(Application.StartupPath + @"\Resources\Images\" + (string)dataGridView1.Rows[i].Cells["posterData"].Value);
                            dataGridView1.Rows[i].Cells["PosterImage"].Value = poster;

                        }
                    }
                    break;
                default:
                    break;
            }
        }

 */
