using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    class OS
    {
        public string NameOS { get; private set; }

        private static OS instance;
        private static object syncRoot = new Object();

        public OS(string name)
        {
            NameOS = name;
        }

        public static OS getInstance(string name)
        {
            if (instance == null)
            {
                lock (syncRoot)
                {
                    if (instance == null)
                    {
                        instance = new OS(name);
                    }
                }
            }

            return instance;
        }
    }
}
