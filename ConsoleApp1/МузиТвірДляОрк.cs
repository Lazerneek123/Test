using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class МузиТвірДляОрк : Музичний_твір
    {
        private int count;
        


        public int Count
        {
            get
            {
                return count;
            }
            set
            {
                if (value > 0)
                {
                    count = value;
                }

            }
        }

        public МузиТвірДляОрк()
        {

        }

        public МузиТвірДляОрк(string nameAuthur, string name, string date, string tonal, int count)
        {            
            this.nameAuthur = nameAuthur;
            this.name = name;
            this.date = date;
            this.tonal = tonal;
            this.count = count;

        }


        public override String ToString()
        {
            return nameAuthur + " " + name + " " + date + " " + tonal + " " + count;
        }

    }
}
