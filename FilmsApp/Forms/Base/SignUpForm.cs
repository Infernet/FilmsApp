using FilmsApp.Classes.DAO;
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
    public partial class SignUpForm : BaseForm
    {
        private List<string> Roles = new List<string>();

        public SignUpForm()
        {
            InitializeComponent();
            using (SqlConnection connection = new SqlConnection(SqlManipul.GetInstance().ConnectionString))
            {
                connection.Open();
                try
                {
                    SqlCommand selectRole = new SqlCommand("Select * from UserRole", connection);
                    SqlDataReader reader = selectRole.ExecuteReader();
                    if (reader.HasRows)
                        while (reader.Read())
                            Roles.Add((string)reader.GetValue(1));

                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message, "Ошибка при определении ролей",MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Roles.Add("Администратор");
                }
            }
            comboRole.DataSource = Roles;
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            //добавить валидацию выбора
            if (UserDAO.GetInstance().RegistrationUser(textBoxLogin.Text, textBoxPassword.Text,(string)comboRole.SelectedItem))
            {
                MessageBox.Show("Пользователь успешно зарегистрирован", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //переход на другую форму
            }
            else
                MessageBox.Show("Регистрация не удалась, возможно данный пользватель уже существует", "Неудача", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
