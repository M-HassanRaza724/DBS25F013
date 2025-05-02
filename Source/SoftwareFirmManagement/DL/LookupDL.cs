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
            //int lookupId = LookupDL.allLookups
            //               .Where(l => l.KeyGroup == keyGroup && l.Value == value)
            //               .Select(l => l.LookupId)
            //               .FirstOrDefault();
            string query = $"CALL sp_get_lookup_id('{keyGroup}', '{value}');";
            var data = DatabaseHelper.Instance.GetData(query);
            int lookupId = data.GetInt32(0);
            return lookupId;
        }

    }
}
