using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.CreationalPatterns
{
    public class Singleton
    {
        public static Singleton Instance()
        {
            if (_instance == null) _instance = new Singleton();
            return _instance;
        }

        private Singleton()
        { }

        private static Singleton _instance; 
    }

}
