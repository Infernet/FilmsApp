using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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

            
        }

        

        private void SelectedFilmForm_Load_1(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "movieDBDataSet.vMovies". При необходимости она может быть перемещена или удалена.
            this.vMoviesTableAdapter.Fill(this.movieDBDataSet.vMovies);
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                Image poster = new Bitmap(Application.StartupPath + @"\Resources\Images\" + (string)dataGridView1.Rows[i].Cells["posterData"].Value);
                dataGridView1.Rows[i].Cells["PosterImage"].Value = poster;

            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dataGridView1_Sorted(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                Image poster = new Bitmap(Application.StartupPath + @"\Resources\Images\" + (string)dataGridView1.Rows[i].Cells["posterData"].Value);
                dataGridView1.Rows[i].Cells["PosterImage"].Value = poster;

            }
        }
    }
}
