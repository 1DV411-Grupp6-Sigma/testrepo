using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Newtonsoft.Json.Linq;

namespace testSigma.Models
{
    public class KpiGroups
    {
        public string Title { get; set; }
        public string Id { get; set; }
        public List<string> MemberTitle { get; set; }
        public List<string> MemberId { get; set; }

        public KpiGroups(JToken item)
        {
            MemberTitle = new List<string>();
            MemberId = new List<string>();

            Title = item.Value<string>("title");
            Id = item.Value<string>("id");

            foreach (var i in item["members"])
            {
                MemberTitle.Add(i["member_title"].ToString());
            }

            foreach (var i in item["members"])
            {
                MemberId.Add(i["member_id"].ToString());
            }
                        
        }
    }
}