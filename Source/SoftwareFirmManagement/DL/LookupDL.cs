using SoftwareFirmManagement.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoftwareFirmManagement.DL
{
    public class LookupDL
    {
        public static List<Lookup> allLookups = new List<Lookup>();

        public static void LoadAllLookups()
        {
            try
            {
                string query = "SELECT * FROM lookups;";
                var data = DatabaseHelper.Instance.GetData(query);
                while (data.Read())
                {
                    int lookupId = data.IsDBNull(0) ? 0 : data.GetInt32(0);
                    string keyGroup = data[1].ToString();
                    string value = data[2].ToString();
                    allLookups.Add(new Lookup(lookupId, keyGroup, value));
                }
                
            }
            catch (MySql.Data.MySqlClient.MySqlException)
            {
                throw;
            }
        }
        public static int GetLookupId(string keyGroup, string value)
        {
            // dl logic please
            return 0;
        }
        public static string GetLookupValue(string keyGroup, int lookupId)
        {
            // dl logic please
            return "";
        }
        public static List<Lookup> GetLookupsByKeyGroup(string keyGroup)
        {
            List<Lookup> lookups = new List<Lookup>();
            foreach (var lookup in allLookups)
            {
                if (lookup.KeyGroup == keyGroup)
                {
                    lookups.Add(lookup);
                }
            }
            return lookups;
        }
        public static List<string> GetLookupValuesByKeyGroup(string keyGroup)
        {
            List<string> values = new List<string>();
            foreach (var lookup in allLookups)
            {
                if (lookup.KeyGroup == keyGroup)
                {
                    values.Add(lookup.Value);
                }
            }
            return values;
        }
        public static List<int> GetLookupIdsByKeyGroup(string keyGroup)
        {
            List<int> ids = new List<int>();
            foreach (var lookup in allLookups)
            {
                if (lookup.KeyGroup == keyGroup)
                {
                    ids.Add(lookup.LookupId);
                }
            }
            return ids;
        }
        public static List<Lookup> GetAllLookups()
        {
            return allLookups;
        }


    }
}
