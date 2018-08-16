using System;
using PetaPoco;

namespace NSaga
{
    internal class SagaData
    {
        public Guid CorrelationId { get; set; }
        public String BlobData { get; set; }

        public static T ConvertFromBase<T>(SagaData baseObj)
            where T: SagaData, new()
        {
            var result = new T();

            result.CorrelationId = baseObj.CorrelationId;
            result.BlobData = baseObj.BlobData;

            return result;
        }
    }

    internal class SagaHeaders
    {
        public Guid CorrelationId { get; set; }
        public String Key { get; set; }
        public String Value { get; set; }

        public static T ConvertFromBase<T>(SagaHeaders baseObj)
            where T : SagaHeaders, new()
        {
            var result = new T();

            result.CorrelationId = baseObj.CorrelationId;
            result.Key = baseObj.Key;
            result.Value = baseObj.Value;

            return result;
        }
    }
}
