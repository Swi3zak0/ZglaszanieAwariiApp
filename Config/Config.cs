using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZglaszanieAwariiApp.Config
{
    public class Config
    {
        private static Config _instance;
        public string SciezkaPliku { get; private set; }
        // Prywatny konstruktor – wymusza użycie singletona
        private Config()
        {
            SciezkaPliku = "awarie.json";
        }
        // Zwraca instancję singletona Config
        public static Config GetInstance()
        {
            return _instance ??= new Config();
        }
    }
}

