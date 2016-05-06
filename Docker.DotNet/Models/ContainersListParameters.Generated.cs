using System.Runtime.Serialization;

namespace Docker.DotNet.Models
{
    [DataContract]
    public class ContainersListParameters // (main.ContainerListParameters)
    {
        [QueryStringParameter("size", false, typeof(BoolQueryStringConverter))]
        public bool? Size { get; set; }

        [QueryStringParameter("all", false, typeof(BoolQueryStringConverter))]
        public bool? All { get; set; }

        [QueryStringParameter("since", false)]
        public string Since { get; set; }

        [QueryStringParameter("before", false)]
        public string Before { get; set; }

        [QueryStringParameter("limit", false)]
        public long? Limit { get; set; }

        [QueryStringParameter("filter", false)]
        public Args Filter { get; set; }
    }
}
