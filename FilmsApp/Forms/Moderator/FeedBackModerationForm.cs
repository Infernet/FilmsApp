using FilmsApp.Classes.SQL;
using FilmsApp.Forms.Base;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace FilmsApp.Forms.Moderator
{
    public partial class FeedBackModerationForm : BaseForm
    {
        private string cmd;

        public FeedBackModerationForm()
        {
            InitializeComponent();
            pictureBoxIcon.Image = new Bitmap(Application.StartupPath + @"\Resources\Icons\logo1.png");
        }

        private void FeedBackModerationForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "movieDBDataSet.UserFeedBack". При необходимости она может быть перемещена или удалена.
            this.userFeedBackTableAdapter.Fill(this.movieDBDataSet.UserFeedBack);
            comboBoxFeedBack.DataSource = movieDBDataSet.UserFeedBack.Select("Allowed=0");
            
        }

        private void comboBoxFeedBack_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmd = "FeedBackId=" + comboBoxFeedBack.SelectedValue.ToString();
            DateTime dateTime;
            DateTime.TryParse(movieDBDataSet.UserFeedBack.Select(cmd)[0]["SendDate"].ToString(), out dateTime);
            tbComment.Text = movieDBDataSet.UserFeedBack.Select(cmd)[0]["Comment"].ToString();
            dateTimePickerFeedBack.Value = dateTime;
            tbName.Text = movieDBDataSet.UserFeedBack.Select(cmd)[0]["UserName"].ToString();
        }

        private void checkChagneMode_CheckedChanged(object sender, EventArgs e)
        {
            if(checkChagneMode.Checked)
            {
                tbComment.Enabled = true;
                dateTimePickerFeedBack.Enabled = true;
                tbName.Enabled = true;
            }
            else
            {
                tbComment.Enabled = false;
                dateTimePickerFeedBack.Enabled = false;
                tbName.Enabled = false;
            }
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            if (checkChagneMode.Checked)
            {
                movieDBDataSet.UserFeedBack.Select(cmd)[0]["UserName"] = tbName.Text;
                movieDBDataSet.UserFeedBack.Select(cmd)[0]["SendDate"] = dateTimePickerFeedBack.Value;
                movieDBDataSet.UserFeedBack.Select(cmd)[0]["Comment"] = tbComment.Text;
            }
            movieDBDataSet.UserFeedBack.Select(cmd)[0]["Allowed"] = 1;
            userFeedBackTableAdapter.Update(movieDBDataSet.UserFeedBack);

            MessageBox.Show("Отзыв изменил статус на публичный.");
            this.userFeedBackTableAdapter.Fill(this.movieDBDataSet.UserFeedBack);
            comboBoxFeedBack.DataSource = movieDBDataSet.UserFeedBack.Select("Allowed=0");
        }

        private void buttonDeleteFeedBack_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Вы уверены, что хотите удалить отзыв пользователя: " +
                movieDBDataSet.UserFeedBack.Select(cmd)[0]["UserName"]+ " ?", "Внимание", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                try
                {
                    using (SqlConnection connection = new SqlConnection(SqlManipul.GetInstance().ConnectionString))
                    {
                        connection.Open();
                        userFeedBackTableAdapter.Adapter.DeleteCommand.Connection = connection;
                        userFeedBackTableAdapter.Adapter.DeleteCommand.CommandText = "delete from UserFeedBack where FeedBackId=@id";
                        userFeedBackTableAdapter.Adapter.DeleteCommand.Parameters.Clear();
                        userFeedBackTableAdapter.Adapter.DeleteCommand.Parameters.Add(new SqlParameter("@id", SqlDbType.Int) { Value = comboBoxFeedBack.SelectedValue });
                        userFeedBackTableAdapter.Adapter.DeleteCommand.ExecuteNonQuery();
                        MessageBox.Show("Отзыв удален из базы данных", "Успех");
                    }
                    this.userFeedBackTableAdapter.Fill(this.movieDBDataSet.UserFeedBack);
                    comboBoxFeedBack.DataSource = movieDBDataSet.UserFeedBack.Select("Allowed=0");
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message);
                }
            }
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Abort;
        }
    }
}
