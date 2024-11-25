using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoConcurrencia
{
    public sealed class Singleton
    {
        private static Singleton instancia = null;
        private static readonly object bloqueo = new object();

        public Singleton()
        {

        }

        public static Singleton Instance
        {
            get
            {
                lock (bloqueo)
                {
                    if (instancia == null)
                    {
                        instancia = new Singleton();
                    }

                    return instancia;
                }
            }
        }
    }
}