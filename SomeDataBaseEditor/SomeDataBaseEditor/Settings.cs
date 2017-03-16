using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SomeDataBaseEditor
{
    /// <summary>
    /// класс с настройками приложения
    /// </summary>
    public static class Settings
    {
        /// <summary>
        /// Имя базы данных по умолчанию
        /// </summary>
        const string DataBaseName = "UchPlan";

        /// <summary>
        /// Класс содержащий настройки подключения
        /// </summary>
        private static class connectionClass
        {
           public static System.Data.SqlClient.SqlConnection _connection=null;
        }

        /// <summary>
        /// Пробует подключиться к серверу используя строку подключения
        /// </summary>
        /// <param name="ServerName">адрес подключения</param>
        /// <param name="user">Имя пользователя, если он отличается от аутентификации пользователя Win</param>
        /// <param name="pass">пароль, если пользователь отличается от пользователя Win</param>
        /// <returns>Результат попытки подключения</returns>
        public static bool connectToServer(string ServerName,string user,string pass)
        {
            disconectServer();

            var con = new System.Data.SqlClient.SqlConnection();

            con.ConnectionString = 
                "Data Source=" + ServerName
             + ";Initial Catalog="+ DataBaseName 
             + ";Integrated Security=SSPI;"
             + "Pooling=False";

            try
            {
                con.Open();
                Settings.connectionClass._connection = con;
                return true;
            }
            catch(Exception)
            {
                con.Dispose();
                return false;
            }
        }

        public static void disconectServer()
        {
            if(connectionClass._connection!=null&&connectionClass._connection.State==System.Data.ConnectionState.Open)
            {
                connectionClass._connection.Close();
                connectionClass._connection = null;
            }
        }
    }
}
