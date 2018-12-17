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
        private Regex loginRegex = new Regex(@"^[^\D,\s](\w,[^А-ЯЁ] |[^а-яё]){2,19}$");
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

        }
        /// <summary>
        /// переход на форму регистрации
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonRegistration_Click(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// произвести вход как посетитель
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonSignInAsVisitor_Click(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// проверка правильности ввода логина
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBoxLogin_TextChanged(object sender, EventArgs e)
        {
            if (loginRegex.IsMatch(textBoxLogin.Text))
                textBoxLogin.BackColor = Color.Green;
            else
                textBoxLogin.BackColor = Color.Red;
        }
        /// <summary>
        /// проверка правильности ввода пароля
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBoxPassword_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
