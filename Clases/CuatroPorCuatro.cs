using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiApp1.Clases
{
    internal class CuatroPorCuatro : VehiculoBase
    {
        public string turbo { get; set; }
        public string doble { get; set; }
        public int asientos { get; set; }

        public void terreno()
        {
            Console.WriteLine("Conduciendo en terrenos difíciles con la 4x4");
        }
    }
}
