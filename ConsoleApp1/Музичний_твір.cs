using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Музичний_твір : Name
    {
        /*private string tonal;

        public string Tonal
        {
            get
            {
                return tonal;
            }
            set
            {
                tonal = value;

            }
        }*/

        public string tonal;

        public Музичний_твір()
        {

        }

        public Музичний_твір(string nameAuthur, string name, string date, string tonal)
        {            
            this.nameAuthur = nameAuthur;
            this.name = name;
            this.date = date;
            this.tonal = tonal;

        }


        public override String ToString()
        {
            return nameAuthur + " " + name + " " + date + " " + tonal;
        }

    }
}
