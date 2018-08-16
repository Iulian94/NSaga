using PetaPoco;

namespace NSaga
{
    [TableName(SqlSagaRepository.SagaDataTableName)]
    [PrimaryKey("CorrelationId", AutoIncrement = false)]
    internal class SqlSagaData : SagaData
    {

    }

    [TableName(SqlSagaRepository.HeadersTableName)]
    [PrimaryKey("CorrelationId", AutoIncrement = false)]
    internal class SqlSagaHeaders : SagaHeaders
    {

    }
}
