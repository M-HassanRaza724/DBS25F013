using DbFinalProject.DL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbFinalProject.BL
{
    public class ServiceDGV
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }
        public string IncludedSubservice { get; set; }
        public string TechnologyUsed { get; set; }

        public ServiceDGV(string name, string description, string category, string includedSubservice, string technologyUsed)
        {
            Name = name;
            Description = description;
            Category = category;
            IncludedSubservice = includedSubservice;
            TechnologyUsed = technologyUsed;
        }


        public static List<ServiceDGV> GetServiceDGVList()
        {
            List<ServiceDGV> list = new List<ServiceDGV>();
            foreach (var service in ServiceDL.allServices)
            {
                string name = service.Name;
                string description = service.Description;
                string category = Lookup.GetValueFromLookupId(service.CategoryId);
                string includedSubservice = service.Subservice.Description;
                string technologyUsed = service.Technology.Description;
                list.Add(new ServiceDGV(name, description, category, includedSubservice, technologyUsed));
            }
            return list;
        }
    }
}
