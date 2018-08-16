using PetaPoco;

namespace NSaga
{
    [TableName(SqlSagaRepository.MySqlSagaDataTableName)]
    [PrimaryKey("CorrelationId", AutoIncrement = false)]
    internal class MySqlSagaData : SagaData
    {
    }
    
    [TableName(SqlSagaRepository.MySqlHeadersTableName)]
    [PrimaryKey("CorrelationId", AutoIncrement = false)]
    internal class MySqlSagaHeaders : SagaHeaders
    {
    }
}
