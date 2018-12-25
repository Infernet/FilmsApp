using FilmsApp.Classes.DAO;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace FilmsApp.Forms.Base
{
    /// <summary>
    /// Форма авторизации пользователя, начальная форма программы
    /// </summary>
    public partial class SignInForm : BaseForm
    {
        public SignInForm()
        {
            InitializeComponent();
            pictureBoxIcon.Image = new Bitmap(Application.StartupPath + @"\Resources\Icons\logo1.png");
            
        }
        /// <summary>
        /// отправка запроса к базе данных на вход
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            if (textBoxLogin.BackColor == Color.Green && textBoxPassword.BackColor == Color.Green)
                if (UserDAO.GetInstance().SignIn(textBoxLogin.Text, textBoxPassword.Text))
                {
                    MessageBox.Show("Авторизация успешно пройдена, " + UserDAO.GetInstance().Role, "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //переход к главному окну
                    ShowNextForm(new SelectedFilmForm());
                }
                else
                    MessageBox.Show("Авторизация не удалась, проверьте правильность ввода логина и пароля", "Неудача", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
                MessageBox.Show("Введите имя пользователя и пароль.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        /// <summary>
        /// переход на форму регистрации
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonRegistration_Click(object sender, EventArgs e)
        {
            //открытие формы регистрации
            ShowNextForm(new SignUpForm());
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
            if (String.IsNullOrWhiteSpace(textBoxLogin.Text))
                textBoxLogin.BackColor = Color.Red;
            else
                textBoxLogin.BackColor = Color.Green;
        }
        /// <summary>
        /// проверка правильности ввода пароля
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBoxPassword_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(textBoxPassword.Text))
                textBoxPassword.BackColor = Color.Red;
            else
                textBoxPassword.BackColor = Color.Green;
        }
    }
}
