using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_15
{
    public class GeomProgression : ISeries
    {
        public int Start { get; private set; }
        public int Item { get; private set; }

        public void SetStart(int x)
        {
            Start = x;
            Item = Start;
        }
        public int GetNext()
        {
            //можно запросить шаг
            Item *= 2;
            return Item;
        }

        public void Reset()
        {
            Item = Start;
        }


    }
}
