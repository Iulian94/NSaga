using System.Collections.Generic;
using PetaPoco;

namespace NSaga
{
    /// <summary>
    /// Wrapper to be able to delegate queries depending on the type of database.
    /// </summary>
    internal interface IQueryWrapper
    {
        SagaData SingleOrDefaultData(Database database, Sql sql);
        int DeleteData(Database database, string sql, params object[] args);
        int Update(Database database, SagaData poco);
        object Insert(Database database, SagaData poco);

        IEnumerable<SagaHeaders> QueryHeaders(Database database, Sql sql);
        int DeleteHeader(Database database, string sql, params object[] args);
        int Update(Database database, SagaHeaders poco);
        object Insert(Database database, SagaHeaders poco);
    }
}
