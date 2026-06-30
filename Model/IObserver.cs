using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AufgabeSai.Model
{
    public interface IObserver
    {
        void Update(decimal Kontostand);
    }
}
