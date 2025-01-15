using Dapper;
using DevExpress.XtraRichEdit.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.Linq;

namespace Commands_Runner
{
    /// <summary>
    /// Class principal de sql management
    /// </summary>
    public class SqlDataAccess : IDisposable
    {
        #region MAIN

        private IDbConnection _connection;
        private IDbTransaction _transaction;

        public SqlDataAccess(string stringConn, bool useLite = false)
        {
            if (_connection == null || _connection.State != ConnectionState.Open)
            {
                if (useLite)
                    _connection = new SQLiteConnection(stringConn);
                else
                    _connection = new SqlConnection(stringConn);

                _connection.Open();
            }
        }

        #endregion

        #region OPEN

        public IEnumerable<T> LoadDataOpen<T, U>(string sql, U parameters) => _connection.Query<T>(sql, parameters, transaction: _transaction, commandType: CommandType.Text);

        public IEnumerable<T> LoadDataOpen<T>(string sql) => _connection.Query<T>(sql, transaction: _transaction, commandType: CommandType.Text);

        public List<T> LoadDataListOpen<T, U>(string sql, U parameters) => _connection.Query<T>(sql, parameters, transaction: _transaction, commandType: CommandType.Text).ToList();

        public List<T> LoadDataListOpen<T>(string sql) => _connection.Query<T>(sql, transaction: _transaction, commandType: CommandType.Text).ToList();

        public int SaveDataOpen<T>(string sql, ref T parameters, int? commandTimeout = null) => _connection.Execute(sql, parameters, commandTimeout: commandTimeout);

        public int SaveDataOpen(string sql, int? commandTimeout = null) => _connection.Execute(sql, commandTimeout: commandTimeout);

        public T GetValueOpen<T, U>(string query, U parameters) => _connection.QueryFirstOrDefault<T>(query, parameters);

        public T GetValueOpen<T>(string query) => _connection.QueryFirstOrDefault<T>(query, transaction: _transaction);

        public T ExecuteScalarOpen<T, U>(string sql, U parameters) => _connection.ExecuteScalar<T>(sql, parameters);

        public T ExecuteScalarOpen<T>(string sql, ref T parameters) => _connection.ExecuteScalar<T>(sql, parameters);

        public T ExecuteScalarOpen<T>(string sql) => _connection.ExecuteScalar<T>(sql);

        public void ExecuteScalarOpen(string sql) => _connection.ExecuteScalar(sql);

        #endregion

        #region TRANSACTION

        public void StartTransactionOpen()
        {
            if (_connection.State != ConnectionState.Open)
                _connection.Open();

            _transaction = _connection.BeginTransaction();
        }

        public void ExecuteInTransaction(string sql) =>
            _connection.Execute(sql, transaction: _transaction);

        public void SaveDataInTransaction<T>(string sql, ref T parameters) =>
            _connection.Execute(sql, parameters, transaction: _transaction);

        public void SaveDataInTransaction(string sql) =>
            _connection.Execute(sql, transaction: _transaction);

        public void CommitTransaction()
        {
            _transaction.Commit();
            _transaction.Dispose();
            _transaction = null;
        }

        public bool IsInTransaction() =>
            _transaction?.Connection != null;

        public void RollbackTransaction()
        {
            _transaction.Rollback();
        }

        #endregion

        #region FUNCTION'S

        /// <summary>
        /// Inicia a conexao com a base de dados
        /// </summary>
        /// <param name="connectionStringName"></param>
        public bool IsOpen() => _connection != null && _connection.State == ConnectionState.Open;

        /// <summary>
        /// On dispose fechar a conexão com a base de dados!
        /// </summary>
        public void Dispose()
        {
            if (_connection != null)
            {
                _connection.Close();
                _connection.Dispose();
            }

            GC.SuppressFinalize(this);
        }

        #endregion
    }
}