using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Messages;
using Microsoft.Xrm.Sdk.Metadata.Query;

namespace Fic.XTB.FastRecordCounter.Helper
{
    public static class MetadataHelper
    {
        private static readonly string[] EntityProperties = { "ObjectTypeCode", "LogicalName", "DisplayName", "IsManaged", "IsCustomizable", "IsCustomEntity", "IsIntersect", "IsValidForAdvancedFind", "PrimaryIdAttribute" };

        public static RetrieveMetadataChangesResponse LoadEntities(IOrganizationService service)
        {
            var eqe = new EntityQueryExpression
            {
                Properties = new MetadataPropertiesExpression(EntityProperties)
            };
            var req = new RetrieveMetadataChangesRequest
            {
                Query = eqe,
                ClientVersionStamp = null
            };
            return (RetrieveMetadataChangesResponse) service.Execute(req);
        }
    }
}
