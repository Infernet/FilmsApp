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
    public partial class FeedBackAddForm : BaseForm
    {
        public FeedBackAddForm()
        {
            InitializeComponent();
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(tbName.Text) && !String.IsNullOrEmpty(tbComment.Text))
                using (SqlConnection connection = new SqlConnection(SqlManipul.GetInstance().ConnectionString))
                {
                    try
                    {
                        connection.Open();
                        SqlCommand command = new SqlCommand("insert into UserFeedBack (UserName,Comment,MovieId) values (@name,@comment,@movieid)", connection);
                        command.Parameters.Add(new SqlParameter("@name", SqlDbType.NVarChar, 50) { Value = tbName.Text });
                        command.Parameters.Add(new SqlParameter("@comment", SqlDbType.NVarChar, 2000) { Value = tbComment.Text });
                        command.Parameters.Add(new SqlParameter("@movieid", SqlDbType.Int) { Value = SqlManipul.GetInstance().CurrentFilmId });
                        command.ExecuteNonQuery();
                        MessageBox.Show("Ваш отзыв успешно отправлен на модерацию.", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception err)
                    {
                        MessageBox.Show(err.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        
                    }
                }
            else
                MessageBox.Show("Нельзя оставлять поля пустыми", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }


    }
}
