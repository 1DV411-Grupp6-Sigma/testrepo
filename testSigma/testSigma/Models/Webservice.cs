using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using Newtonsoft.Json.Schema;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace testSigma.Models
{


    public class Webservice : HTTPFetcher
    {

        /// <summary>
        /// Get municipalty id (kommunid) from municipalty name (kommunnamn) 
        /// </summary>
        /// <param name="municipalty name"></param>
        /// <returns>"municipalty name"</returns>
        public string GetMunicipalityId(string municipalty)
        {
            municipalty = HttpUtility.UrlEncode(municipalty.Trim());
            var query = "municipality?title=";
            //Using base class for doing a query
            var content = JsonFetcher(query + municipalty.ToLower());

            //Extract id from json
            var id = (string) (from c in content["values"]
                where ((string)c["title"]).ToLower() == municipalty
                select c["id"]).FirstOrDefault();

            return id;
        }

        public IEnumerable<KpiGroups> GetKpiGroups()
        {
            var query = "kpi_groups";

            var content = JsonFetcher(query);

            var kpiGroups = (from c in content["values"]
                select new KpiGroups(c)).ToList();

            return kpiGroups;
        }

        public IEnumerable<MunicipalityGroups> GetMunicipalityGroups()
        {
            var query = "municipality_groups";

            var content = JsonFetcher(query);

            var munGroups = (from c in content["values"]
                             select new MunicipalityGroups(c)).ToList();

            return munGroups;
        }

        public IEnumerable<Kpi> GetKpi()
        {
            var query = "kpi";

            var content = JsonFetcher(query);

            var kpi = (from c in content["values"]
                             select new Kpi(c)).ToList();

            return kpi;
        }

        public IEnumerable<Municipality> GetMunicipality()
        {
            var query = "municipality";

            var content = JsonFetcher(query);

            var muni = (from c in content["values"]
                       select new Municipality(c)).ToList();

            return muni;
        }

        public IEnumerable<OU> GetOu()
        {
            var query = "municipality";

            var content = JsonFetcher(query);

            var ou = (from c in content.Values()
                        select new OU(c)).ToList();

            return ou;
        }


    }
}