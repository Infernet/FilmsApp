using FilmsApp.Classes.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FilmsApp.Forms.Base
{
    /// <summary>
    /// Форма авторизации пользователя, начальная форма программы
    /// </summary>
    public partial class SignInForm : BaseForm
    {
        private Regex loginRegex = new Regex(@"^(([A-Z]|[a-z])([\w\D][^а-яё][^А-Яё]){2,5})$");
        public SignInForm()
        {
            InitializeComponent();
        }
        /// <summary>
        /// отправка запроса к базе данных на вход
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            if (UserDAO.GetInstance().SignIn(textBoxLogin.Text, textBoxPassword.Text))
            {
                MessageBox.Show("Авторизация успешно пройдена, " + UserDAO.GetInstance().Role, "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //переход к главному окну
                ShowNextForm(new SelectedFilmForm());
            }
            else
                MessageBox.Show("Авторизация не удалась, проверьте правильность ввода логина и пароля", "Неудача", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        /// <summary>
        /// переход на форму регистрации
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonRegistration_Click(object sender, EventArgs e)
        {
            //открытие формы регистрации
            ShowNextForm(new SignUpForm(), true);
        }
        /// <summary>
        /// произвести вход как посетитель
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonSignInAsVisitor_Click(object sender, EventArgs e)
        {
            if (UserDAO.GetInstance().SignIn("user", "user"))
            {
                MessageBox.Show("Вы вошли, как посетитель", "Успешная авторизация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ShowNextForm(new SelectedFilmForm());
            }
            else
                MessageBox.Show("Ошибка, вход как посетитель заблокирован", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        /// <summary>
        /// проверка правильности ввода логина
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBoxLogin_TextChanged(object sender, EventArgs e)
        {
            //добавить валидацию
            //if (loginRegex.IsMatch(textBoxLogin.Text))
            //    textBoxLogin.BackColor = Color.Green;
            //else
            //    textBoxLogin.BackColor = Color.Red;
        }
        /// <summary>
        /// проверка правильности ввода пароля
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBoxPassword_TextChanged(object sender, EventArgs e)
        {
            //добавить валидацию
        }
    }
}
