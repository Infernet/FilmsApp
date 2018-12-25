using FilmsApp.Classes.DAO;
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
            pictureBoxIcon.Image = new Bitmap(Application.StartupPath + @"\Resources\Icons\logo1.png");
            switch (UserDAO.GetInstance().Role)
            {
                case "Администратор":
                    {
                        buttonFilmAdd.Visible = true;
                        buttonFilmAdd.Enabled = true;
                        buttonModeratorFeedBack.Visible = true;
                        buttonModeratorFeedBack.Enabled = true;
                    }
                    break;
                case "Модератор":
                    {
                        buttonModeratorFeedBack.Visible = true;
                        buttonModeratorFeedBack.Enabled = true;
                    }
                    break;
                default:
                    break;
            }
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
            DialogResult result = ShowNextForm(new MovieFilterForm(), true);
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
            if (result != DialogResult.Abort)
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                    dataGridView1.Rows[i].Cells["PosterImage"].Value = new Bitmap(Application.StartupPath + @"\Resources\Images\" + (string)dataGridView1.Rows[i].Cells["posterData"].Value);
        }

        private void buttonShowSelectedFilm_Click(object sender, EventArgs e)
        {
            if (SqlManipul.GetInstance().CurrentFilmId != -1)
            {
                DialogResult result = ShowNextForm(new ShowFilmForm(), true);
                if (result == DialogResult.Abort)
                    DialogResult = DialogResult.Abort;
            }
            else
                MessageBox.Show("Для просмотра подробной информации о фильме, его следует выбрать.", "Фильм не выбран", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dataGridView1.DataSource != null)
                    SqlManipul.GetInstance().CurrentFilmId = (int)dataGridView1.CurrentRow.Cells[1].Value;
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void buttonModeratorFeedBack_Click(object sender, EventArgs e)
        {
            DialogResult result = ShowNextForm(new FeedBackModerationForm(), true);
            if (result == DialogResult.Abort)
                DialogResult = DialogResult.Abort;
        }

        private void buttonFilmAdd_Click(object sender, EventArgs e)
        {
            DialogResult result = ShowNextForm(new FilmAddForm(), true);
            if (result == DialogResult.Abort)
                DialogResult = DialogResult.Abort;
            SelectedFilmForm_Load_1(null, null);
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Abort;
        }
    }
}
