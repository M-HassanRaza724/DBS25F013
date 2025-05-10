using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareFirmManagement.BL
{
    public class Lookup
    {
        private int lookupId;
        private string keyGroup;
        private string value;

        public override string ToString()
        {
            return value;
        }

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
    }
}
