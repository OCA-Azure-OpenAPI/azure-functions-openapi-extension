using System.Collections.Generic;

namespace Microsoft.Azure.WebJobs.Extensions.OpenApi.TestApp.Models
{
    public class DictionaryObjectModel
    {

        public Dictionary<int, int> IntValue { get; set; }
        public IDictionary<int, int> IIntValue { get; set; }
        public KeyValuePair<int, int> KeyValuePairIntValue { get; set; }

        //TO DO: public Dictionary<int, int[]> IntArrayValue { get; set; }
        public IDictionary<int, int[]> IIntArrayValue { get; set; }
        public KeyValuePair<int, int[]> KeyValuePairIntArrayValue { get; set; }

        public Dictionary<string, string> StringValue { get; set; }
        public IDictionary<string, string> IStringValue { get; set; }
        public KeyValuePair<string,string> KeyValuePairStringValue { get; set; }

        //TO DO: public Dictionary<string, string[]> StringArrayValue { get; set; }
        public IDictionary<string, string[]> IStringArrayValue { get; set; }
        public KeyValuePair<string, string[]> KeyValuePairStringArrayValue { get; set; }
    }
}
