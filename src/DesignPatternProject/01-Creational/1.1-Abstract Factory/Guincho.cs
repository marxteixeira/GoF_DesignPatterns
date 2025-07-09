using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternProject._01_Creational._1._1_Abstract_Factory
{
    // AbstractProduct   
    public abstract class Guincho
    {
        protected Guincho(Porte porte)
        {
            Porte = porte;
        }

        public abstract void Socorrer(Veiculo veiculo);
        public Porte Porte { get; set; }
    }
}
