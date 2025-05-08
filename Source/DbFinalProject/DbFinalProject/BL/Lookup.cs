using DbFinalProject.DL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbFinalProject.BL
{
    public class Lookup
    {
        private int lookupId;
        private string keyGroup;
        private string value;

        public Lookup(int lookupId, string keyGroup, string value)
        {
            this.lookupId = lookupId;
            this.keyGroup = keyGroup;
            this.value = value;
        }

        public int LookupId
        {
            get { return lookupId; }
            set { lookupId = value; }
        }
        public string KeyGroup
        {
            get { return keyGroup; }
            set { keyGroup = value; }
        }
        public string Value
        {
            get { return value; }
            set { this.value = value; }
        }


        public static int GetLookupIdFromValue(string value)
        {
            return LookupDL.allLookups
                   .Where(l => l.value == value)
                   .Select(l => l.lookupId)
                   .FirstOrDefault();
        }


        public static List<string> GetValuesFromKeyGroup(string keyGroup)
        {
            List<string> values = new List<string>();
            foreach (var lookup in LookupDL.allLookups)
            {
                if (lookup.KeyGroup == keyGroup)
                {
                    values.Add(lookup.Value);
                }
            }
            return values;
        }


        public static string GetValueFromLookupId(int lookupId)
        {
            return LookupDL.allLookups
                   .Where(l => l.LookupId == lookupId)
                   .Select(l => l.Value)
                   .FirstOrDefault();
        }


    }
}
