﻿using FilmsApp.Classes.SQL;
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

        private bool cnt = false;

        private void SelectedFilmForm_Load_1(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "movieDBDataSet.vMovies". При необходимости она может быть перемещена или удалена.
            this.vMoviesTableAdapter.Fill(this.movieDBDataSet.vMovies);
            //adapter.Fill(this.movieDBDataSet.vMovies); использовать для перебора с учетом фильтра


            cnt = true;

            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                Image poster = new Bitmap(Application.StartupPath + @"\Resources\Images\" + (string)dataGridView1.Rows[i].Cells["posterData"].Value);
                dataGridView1.Rows[i].Cells["PosterImage"].Value = poster;

            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //MessageBox.Show(dataGridView1.SelectedRows[0].Cells["ID"].Value.ToString(), dataGridView1.SelectedRows[0].Cells["Название"].Value.ToString());
            //MessageBox.Show(dataGridView1.CurrentRow.Cells["ID"].Value.ToString(), dataGridView1.CurrentRow.Cells["Название"].Value.ToString());
            //MessageBox.Show(dataGridView1.CurrentRow.Cells[0].Value.ToString(), dataGridView1.CurrentRow.Cells[0].Value.ToString());
            try
            {
                MessageBox.Show(dataGridView1.CurrentRow.Cells[1].Value.ToString(), dataGridView1.CurrentRow.Cells[3].Value.ToString());
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
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
                        using (SqlConnection connection = new SqlConnection(SqlManipul.GetInstance().ConnectionString))
                        {
                            connection.Open();
                            SqlCommand command = SqlManipul.GetInstance().GetFilterCommand();
                            command.Connection = connection;
                            SqlDataAdapter adapter = new SqlDataAdapter(command);
                            this.movieDBDataSet.vMovies.Clear();
                            adapter.Fill(this.movieDBDataSet.vMovies);

                        }
                        dataGridView1.DataSource=movieDBDataSet.vMovies;
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

        private void dataGridView1_CurrentCellChanged(object sender, EventArgs e)
        {
            //try
            //{
            //    MessageBox.Show(dataGridView1.CurrentRow.Cells[1].Value.ToString(), dataGridView1.CurrentRow.Cells[3].Value.ToString());
            //}
            //catch (Exception error)
            //{
            //    MessageBox.Show(error.Message);
            //}
                
        }

        private void buttonShowSelectedFilm_Click(object sender, EventArgs e)
        {
            ShowNextForm(new ShowFilmForm(), false);
        }
    }
}
