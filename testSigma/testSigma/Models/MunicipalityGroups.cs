using System.Collections.Generic;
using Newtonsoft.Json.Linq;

namespace testSigma.Models
{
    public class MunicipalityGroups
    {
        public string Id { get; set; }
        public string Title { get; set; }
        public List<string> Member_id { get; set; }
        public List<string> Member_title { get; set; }

        public MunicipalityGroups(JToken item)
        {
            Member_id = new List<string>();
            Member_title = new List<string>();

            Id = item.Value<string>("id");
            Title = item.Value<string>("title");

            foreach (var m in item["members"])
            {
                Member_id.Add(m["member_id"].ToString());
            }

            foreach (var m in item["members"])
            { 
                Member_title.Add(m["member_title"].ToString());
            }
        }
    }
}