using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IIS_Mover
{
    class IISMoverFunction
    {
        public int ID { get; set; }
        public int Type { get; set; }
        public String Name { get; set; }
        public Dictionary<string, string> dKVPs { get; set; } 

        public IISMoverFunction New()
        {
            this.dKVPs = new Dictionary<string, string>();
            this.ID = Program.oIISMoverList.lIISMoverFunctions.Count;
            return this;
        }

        public void MoveUp()
        {

        }

        public void MoveDown()
        {

        }

    }
}
