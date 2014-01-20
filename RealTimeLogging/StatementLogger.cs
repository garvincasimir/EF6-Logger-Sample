using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure.Interception;
using System.Linq;
using System.Web;

namespace RealTimeLogging
{
    public class StatementLogger : IDbCommandInterceptor
    {

        void IDbCommandInterceptor.NonQueryExecuted(System.Data.Common.DbCommand command, DbCommandInterceptionContext<int> interceptionContext)
        {
            SendToClient(command.CommandText);
        }

        void IDbCommandInterceptor.NonQueryExecuting(System.Data.Common.DbCommand command, DbCommandInterceptionContext<int> interceptionContext)
        {
            SendToClient(command.CommandText);
        }

        void IDbCommandInterceptor.ReaderExecuted(System.Data.Common.DbCommand command, DbCommandInterceptionContext<System.Data.Common.DbDataReader> interceptionContext)
        {
            SendToClient(command.CommandText);
        }

        void IDbCommandInterceptor.ReaderExecuting(System.Data.Common.DbCommand command, DbCommandInterceptionContext<System.Data.Common.DbDataReader> interceptionContext)
        {
            SendToClient(command.CommandText);
        }

        void IDbCommandInterceptor.ScalarExecuted(System.Data.Common.DbCommand command, DbCommandInterceptionContext<object> interceptionContext)
        {
            SendToClient(command.CommandText);
        }

        void IDbCommandInterceptor.ScalarExecuting(System.Data.Common.DbCommand command, DbCommandInterceptionContext<object> interceptionContext)
        {
            SendToClient(command.CommandText);
        }

        void SendToClient(string sql)
        {
            HubCaller.Invoke<LoggingHub>(_c => _c.Clients.All.onSql(sql));
        }
    }
}