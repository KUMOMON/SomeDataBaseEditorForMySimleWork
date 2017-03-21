using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace SomeDataBaseEditor
{
    static class helpers
    {
        /// <summary>
        /// Создает загатовку таблицы для извлекаемых данных
        /// </summary>
        /// <param name="s">Список имен создаваемых колонок</param>
        /// <returns>Пустая таблица с указанными калонками</returns>
        public static DataTable CreateDataTable(params string[] s)
        {
            var dt = new DataTable();
            foreach (var ColumnName in s)
                dt.Columns.Add(ColumnName);
            return dt;
        }

        /// <summary>
        /// Создает заготовку таблицы
        /// читая имена колонок из
        /// результата запроса
        /// </summary>
        /// <param name="sqlReader">результат запроса</param>
        /// <returns>Пустая заготовка таблицы с колонками</returns>
        public static DataTable CreateDataTable(SqlDataReader sqlReader)
        {
            if (sqlReader == null|| sqlReader.IsClosed)
                return null;

            var dt = new DataTable();

            for(var field =0; field< sqlReader.FieldCount;field++)
                dt.Columns.Add(sqlReader.GetName(field));

            return dt;
        }


        /// <summary>
        /// Возвращает результат запроса
        /// </summary>
        /// <param name="stringQuery">Строка запроса</param>
        /// <returns>Таблица с результатами запроса</returns>
        public static DataTable GetDataTable(string stringQuery)
        {
            DataTable dt =null; 
            using (SqlConnection cn = new SqlConnection())
            {
                try
                {
                    //подключаемся к базе данных
                    cn.ConnectionString = @"Data Source=.\SQLEXPRESS2014;Initial Catalog=UchPlan;" +
              "Integrated Security=SSPI;Pooling=False";
                    cn.Open();

                    using (var commandSQL = new SqlCommand(stringQuery, cn))
                    {

                        //выполняем текст запроса
                        var resultQueryReaderSQL = commandSQL.ExecuteReader();
                        //создаем таблицу с необходимыми колонками
                        dt = CreateDataTable(resultQueryReaderSQL);

                        //читаем построчно результат запроса
                        while (resultQueryReaderSQL.Read())
                        {
                            //считываем строку в массив
                            var newRows = new object[resultQueryReaderSQL.FieldCount];
                            for(var field=0;field<resultQueryReaderSQL.FieldCount;field++)
                                newRows[field] = resultQueryReaderSQL.GetSqlValue(field);
                            //вставляем массив как новую запись в таблице
                            dt.Rows.Add(newRows);
                        }
                    }


                }
                catch (SqlException sqlEx)
                {
                    System.Windows.Forms.MessageBox.Show(sqlEx.Message);
                }
                finally
                {
                    cn.Close();
                }

            }
            return dt;
        }

    }
}