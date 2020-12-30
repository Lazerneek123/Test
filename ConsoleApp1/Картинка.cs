using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Картинка : Name
    {
        private int hight;
        private int weight;


        public int Hight
        {
            get
            {
                return hight;
            }
            set
            {
                if (value > 0)
                {
                    hight = value;
                }

            }
        }

        public int Weight
        {
            get
            {
                return weight;
            }
            set
            {
                if (value > 0)
                {
                    weight = value;
                }

            }
        }

        public Картинка()
        {

        }

        public Картинка(int hight, int weight, string nameAuthur, string name, string date)
        {
            this.hight = hight;
            this.weight = weight;
            this.nameAuthur = nameAuthur;
            this.name = name;
            this.date = date;
            
        }


        public override String ToString()
        {
            return nameAuthur + " " + name + " " + date + " " + hight + " " + weight;
        }

    }
}
