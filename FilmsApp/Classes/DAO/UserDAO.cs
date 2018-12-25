using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using FilmsApp.Classes.SQL;
using System.Data;
using System.Windows.Forms;

namespace FilmsApp.Classes.DAO
{
    class UserDAO
    {
        public string Role { get;set; }

        private static UserDAO instance;
        private UserDAO() { }

        public static UserDAO GetInstance()
        {
            if (instance == null)
                instance = new UserDAO();
            return instance;
        }
        /// <summary>
        /// Метод производящий авторизацию пользователя
        /// </summary>
        /// <param name="login"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public bool SignIn(string login,string password)
        {
            Role="";
            using (SqlConnection connection=new SqlConnection(SqlManipul.GetInstance().ConnectionString))
            {
                connection.Open();
                try
                {
                    SqlCommand signInCommand = new SqlCommand("SignInUser", connection);
                    signInCommand.CommandType = System.Data.CommandType.StoredProcedure;
                    SqlParameter parLogin = new SqlParameter("@Login", SqlDbType.NVarChar, 20);
                    parLogin.Value = login;
                    SqlParameter parPassword = new SqlParameter("Password", SqlDbType.NVarChar, 20);
                    parPassword.Value = password;
                    //возвращаемые значения
                    SqlParameter parRole = new SqlParameter("@Role", SqlDbType.NVarChar, 20);
                    parRole.Direction = ParameterDirection.Output;
                    SqlParameter parResult = new SqlParameter("@result", SqlDbType.Bit);
                    parResult.Direction = ParameterDirection.Output;
                    signInCommand.Parameters.Add(parLogin);
                    signInCommand.Parameters.Add(parPassword);
                    signInCommand.Parameters.Add(parRole);
                    signInCommand.Parameters.Add(parResult);

                    signInCommand.ExecuteNonQuery();
                    if((bool)signInCommand.Parameters["@result"].Value)
                        this.Role = (string)signInCommand.Parameters["@Role"].Value;
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message, "Ошибка при попытке авторизации", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
            }
            if (!String.IsNullOrEmpty(Role))
                return true;
            else
                return false;
        }
        /// <summary>
        /// Метод производящий регистрацию на сервере
        /// </summary>
        /// <param name="login"></param>
        /// <param name="password"></param>
        /// <param name="role"></param>
        /// <returns></returns>
        public bool RegistrationUser(string login, string password, string role)
        {
            bool result=false;
            using (SqlConnection connection = new SqlConnection(SqlManipul.GetInstance().ConnectionString))
            {
                connection.Open();
                SqlTransaction transaction = connection.BeginTransaction();
                try
                {
                    SqlCommand registrationCommand = new SqlCommand("RegistrationUser", connection);
                    registrationCommand.CommandType = CommandType.StoredProcedure;
                    registrationCommand.Transaction = transaction;
                    SqlParameter pLog = new SqlParameter("@Login", SqlDbType.NVarChar, 20);
                    pLog.Value = login;
                    SqlParameter pPas = new SqlParameter("@Password", SqlDbType.NVarChar, 20);
                    pPas.Value = password;
                    SqlParameter pRole = new SqlParameter("@Role", SqlDbType.NVarChar, 20);
                    pRole.Value = role;
                    SqlParameter pResult = new SqlParameter("@result", SqlDbType.Bit);
                    pResult.Direction = ParameterDirection.Output;

                    registrationCommand.Parameters.Add(pLog);
                    registrationCommand.Parameters.Add(pPas);
                    registrationCommand.Parameters.Add(pRole);
                    registrationCommand.Parameters.Add(pResult);

                    registrationCommand.ExecuteNonQuery();
                    result =(bool)registrationCommand.Parameters["@result"].Value;
                    if (result)
                        transaction.Commit();
                    else
                        transaction.Rollback();
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message, "Ошибка при попытке регистрации", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    transaction.Rollback();
                }
            }
            if (result)
                return true;
            else
                return false;
        }
    }
}
