using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T.P6.Args
{
    class ArgsAbo<T> : EventArgs
    {
        private T t;

        public ArgsAbo(T t) : base()
        {
            this.t = t;
        }

        public T get()
        {
            return this.t;
        }
    }
}
