using FilmsApp.Classes.SQL;
using FilmsApp.Forms.Base;
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

namespace FilmsApp.Forms.SelectedFilmForms
{
    public partial class ShowFeedBackFirmForm : BaseForm
    {
        public ShowFeedBackFirmForm()
        {
            InitializeComponent();
        }

        private void comboBoxFeedBack_SelectedIndexChanged(object sender, EventArgs e)
        {
            string cmd = "FeedBackId=" + comboBoxFeedBack.SelectedValue.ToString();
            DateTime dateTime;
            tbComment.Text = movieDBDataSet.UserFeedBack.Select(cmd)[0]["Comment"].ToString();
            DateTime.TryParse(movieDBDataSet.UserFeedBack.Select(cmd)[0]["SendDate"].ToString(), out dateTime);
            textBoxDate.Text = "Дата написания: " + dateTime.ToString("dd MMMM yyy");
        }

        private void ShowFeedBackFirmForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "movieDBDataSet.UserFeedBack". При необходимости она может быть перемещена или удалена.
            this.userFeedBackTableAdapter.Fill(this.movieDBDataSet.UserFeedBack);
            comboBoxFeedBack.DataSource = movieDBDataSet.UserFeedBack.Select("MovieId=" + SqlManipul.GetInstance().CurrentFilmId);
        }

    }
}
