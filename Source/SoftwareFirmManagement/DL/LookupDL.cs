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
                allLookups.Clear();
                string query = "SELECT * FROM lookups;";
                var data = DatabaseHelper.Instance.GetData(query);
                while (data.Read())
                {
                    int lookupId = data.IsDBNull(0) ? 0 : data.GetInt32(0);
                    string keyGroup = data.GetString(1);
                    string value = data.GetString(2);
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
            int lookupId = LookupDL.allLookups
                           .Where(l => l.KeyGroup == keyGroup && l.Value == value)
                           .Select(l => l.LookupId)
                           .FirstOrDefault();
            //string query = $"CALL sp_get_lookup_id('{keyGroup}', '{value}');";
            //var data = DatabaseHelper.Instance.GetData(query);
            //int lookupId = data.GetInt32(0);
            return lookupId;
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
        public static List<Lookup> GetDesignations()
        {
            List<Lookup> designations = new List<Lookup>();
            return designations;
            // DL logic
        }


    }
}
