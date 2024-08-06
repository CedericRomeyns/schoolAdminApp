using System.Data.SQLite;

namespace Ado.Data.SqlServer
{
    public static class SQLiteCommandExt
    {
        public static SQLiteCommand Where(this SQLiteCommand sqlCommand, string sql, params SQLiteParameter[] sqlParameters)
        {
            sqlCommand.CommandText = sqlCommand.CommandText.Replace(";", "");
            sqlCommand.CommandText += $" WHERE {sql}";
            foreach (var param in sqlParameters)
            {
                sqlCommand.Parameters.Add(param);
            }
            return sqlCommand;
        }

        public static SQLiteCommand And(this SQLiteCommand sqlCommand, string sql)
        {
            sqlCommand.CommandText = sqlCommand.CommandText.Replace(";", "");
            sqlCommand.CommandText += $" AND {sql}";
            return sqlCommand;
        }

        public static SQLiteCommand Or(this SQLiteCommand sqlCommand, string sql)
        {
            sqlCommand.CommandText = sqlCommand.CommandText.Replace(";", "");
            sqlCommand.CommandText += $" OR {sql}";
            return sqlCommand;
        }

        public static SQLiteCommand OrderBy(this SQLiteCommand sqlCommand, string columnName, string orderDirection = "ASC")
        {
            if (string.IsNullOrEmpty(columnName))
                throw new ArgumentException("Order by column name cannot be empty.");

            columnName = GetFirstWord(columnName);
            orderDirection = GetFirstWord(orderDirection);

            sqlCommand.CommandText = sqlCommand.CommandText.Replace(";", "");
            sqlCommand.CommandText += $" ORDER BY {columnName} {orderDirection}";
            sqlCommand.CommandText = sqlCommand.CommandText.Replace("--", "");
            return sqlCommand;
        }

        /// <summary>
        /// Securing sql injection. Example: If user define column name = 'Username', it's safe. if columnname is 'Username; Delete from User --', we are dead.
        /// </summary>
        /// <param name="columnName"></param>
        /// <returns></returns>
        private static string GetFirstWord(string columnName)
        {
            if (string.IsNullOrEmpty(columnName))
                return string.Empty;
            var arr = columnName.Split(' ');
            return arr[0].Replace(";", "");
        }
    }
}
