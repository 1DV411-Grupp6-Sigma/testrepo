using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Newtonsoft.Json.Linq;

namespace testSigma.Models
{
    public class Kpi
    {
        public string Auspices { get; set; }
        public string Description { get; set; }
        public bool Has_ou_data { get; set; }
        public string Id { get; set; }
        public int Is_divided_by_gender { get; set; }
        public string Municipality_type { get; set; }
        public string Operating_area { get; set; }
        public DateTime? Ou_publication_date { get; set; }
        public string Perspective { get; set; }
        public DateTime? Prel_publication_date { get; set; }
        public DateTime? Publication_date { get; set; }
        public string Publ_period { get; set; }
        public string Title { get; set; }


        public Kpi(JToken item)
        {
            Auspices = item.Value<string>("auspices");
            Description = item.Value<string>("description");
            try
            {
                Has_ou_data = item.Value<bool>("has_ou_data");
            }
            catch (Exception)
            {

                Has_ou_data = false;
            }
            Id = item.Value<string>("id");
            Is_divided_by_gender = item.Value<int>("is_divided_by_gender");
            Municipality_type = item.Value<string>("municipality_type");
            Operating_area = item.Value<string>("operating_area");
            Ou_publication_date = item.Value<DateTime?>("ou_publication_date");
            Perspective = item.Value<string>("perspective");
            Prel_publication_date = item.Value<DateTime?>("prel_publication_date");
            Publication_date = item.Value<DateTime?>("publication_date");
            Publ_period = item.Value<string>("publ_period");
            Title = item.Value<string>("title");

        }
    }
}