using System;
using System.Runtime.Serialization;

namespace Fic.XTB.FastRecordCounter.Model
{
    public class CountExtensionData : IExtensibleDataObject
    {
        public  Guid Id { get; set; }
        public ExtensionDataObject ExtensionData { get; set; }
    }
}
