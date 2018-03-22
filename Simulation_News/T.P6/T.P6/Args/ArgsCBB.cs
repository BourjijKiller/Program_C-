using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T.P6.Args
{
    class ArgsCBB : EventArgs
    {
        private Object obj;

        public ArgsCBB(Object obj) : base()
        {
            this.obj = obj;
        }

        public object getObj
        {
            get
            {
                return this.obj;
            }
        }
    }
}
