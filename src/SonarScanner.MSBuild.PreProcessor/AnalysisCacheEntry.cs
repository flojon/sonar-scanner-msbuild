using System.Runtime.Serialization;

namespace SonarScanner.MSBuild.PreProcessor
{
    [DataContract]
    public class AnalysisCacheEntry
    {
        [DataMember]
        public bool HasChanged { get; set; }
    }
}
