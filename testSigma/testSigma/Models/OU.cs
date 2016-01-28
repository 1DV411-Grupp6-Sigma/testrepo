using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json.Linq;

namespace testSigma.Models
{
    public class ValueItems
    {
        public string Id { get; set; }
        public string Municipality { get; set; }
        public string Title { get; set; }

        public ValueItems(JToken item)
        {
            Id = item.Value<string>("id");
            Municipality = item.Value<string>("municipality");
            Title = item.Value<string>("title");
        }
    }

    public class OU
    {
        public int Count { get; set; }
        public string Next_page { get; set; }
        public List<ValueItems> Values { get; set; }


        public OU(JToken item)
        {
            Count = item.Root.Value<int>("count");
            Next_page = item.Value<string>("next_page");

            Values = new List<ValueItems>();
            foreach (var value in item.Root["values"])
            {
                Values.Add(new ValueItems(value));
            }
        }
    }
}