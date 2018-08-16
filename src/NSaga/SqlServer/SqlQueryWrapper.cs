using System.Collections.Generic;
using System.Linq;
using PetaPoco;

namespace NSaga
{
    /// <summary>
    /// Default wrapper to be able to delegate queries depending on the type of database.
    /// </summary>
    internal sealed class SqlQueryWrapper : BaseQueryWrapper<SqlSagaData, SqlSagaHeaders>
    {

    }
}
