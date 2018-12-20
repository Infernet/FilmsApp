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
            dataGridView1.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            
        }



        private void SelectedFilmForm_Load_1(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "movieDBDataSet.vMovies". При необходимости она может быть перемещена или удалена.
            //this.vMoviesTableAdapter.Fill(this.movieDBDataSet.vMovies);
            //adapter.Fill(this.movieDBDataSet.vMovies); использовать для перебора с учетом фильтра
            
         

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

        private void buttonSelectFilther_Click(object sender, EventArgs e)
        {
            // BaseForm filter = ;
            DialogResult result= new MovieFilterForm().ShowDialog();
            switch (result)
            {
                case DialogResult.Yes:
                    {
                        MessageBox.Show("Фильтрация");
                        //using (SqlConnection connection = new SqlConnection(SqlManipul.GetInstance().ConnectionString))
                        //{
                        //    connection.Open();
                        //    SqlCommand command = SqlManipul.GetInstance().GetFilterCommand();
                        //    command.Connection = connection;
                        //    SqlDataAdapter adapter = new SqlDataAdapter(command);
                        //    adapter.Fill(this.movieDBDataSet.vMovies);

                        //}
                        SqlCommand command = SqlManipul.GetInstance().GetFilterCommand();
                        vMoviesTableAdapter.Adapter.SelectCommand.CommandText = command.CommandText;
                        List<SqlParameter> paramList = new List<SqlParameter>();
                        foreach (SqlParameter item in command.Parameters)
                        {
                            paramList.Add(item);
                        }
                        command.Parameters.Clear();
                        foreach (SqlParameter param in paramList)
                            vMoviesTableAdapter.Adapter.SelectCommand.Parameters.Add(param); 
                        this.vMoviesTableAdapter.Fill(this.movieDBDataSet.vMovies);
                    }
                    break;
                case DialogResult.No:
                    {
                        MessageBox.Show("Сброс");
                        vMoviesTableAdapter.Fill(this.movieDBDataSet.vMovies);
                        dataGridView1.Update();
                    }
                    break;
                default:
                    break;
            }
        }

        
    }
}
