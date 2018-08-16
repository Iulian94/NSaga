using System.Collections.Generic;
using System.Linq;
using PetaPoco;

namespace NSaga
{
    /// <summary>
    /// Base wrapper to be able to delegate queries depending on the type of database.
    /// </summary>
    internal abstract class BaseQueryWrapper<TSagaData, TSagaHeaders>: IQueryWrapper
        where TSagaData : SagaData, new()
        where TSagaHeaders : SagaHeaders, new()
    {
        #region SagaData

        public SagaData SingleOrDefaultData(Database database, Sql sql)
        {
            var result = database.SingleOrDefault<TSagaData>(sql);
            return result;
        }

        public int DeleteData(Database database, string sql, params object[] args)
        {
            return database.Delete<TSagaData>(sql, args);
        }

        public int Update(Database database, SagaData poco)
        {
            var entity = SagaData.ConvertFromBase<TSagaData>(poco);
            return database.Update(entity);
        }

        public object Insert(Database database, SagaData poco)
        {
            var entity = SagaData.ConvertFromBase<TSagaData>(poco);
            return database.Insert(entity);
        }

        #endregion

        #region SagaHeaders

        public IEnumerable<SagaHeaders> QueryHeaders(Database database, Sql sql)
        {
            var result = database.Query<TSagaHeaders>(sql).Select(x => (SagaHeaders)x);
            return result;
        }

        public int DeleteHeader(Database database, string sql, params object[] args)
        {
            return database.Delete<TSagaHeaders>(sql, args);
        }

        public int Update(Database database, SagaHeaders poco)
        {
            var entity = SagaHeaders.ConvertFromBase<TSagaHeaders>(poco);
            return database.Update(entity);
        }
        
        public object Insert(Database database, SagaHeaders poco)
        {
            var entity = SagaHeaders.ConvertFromBase<TSagaHeaders>(poco);
            return database.Insert(entity);
        }

        #endregion
    }
}
