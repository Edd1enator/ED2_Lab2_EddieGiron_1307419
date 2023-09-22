using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Es_Arboles
{
    //abstract class puede ser heredada por otras clases y que es accesible desde cualquier parte del codigo
    public abstract class NoLinearB<T> where T : IComparable<T>
    {
        protected abstract NodeB<T> Insert(NodeB<T> nodo, T value);
        protected abstract void Delete(NodeB<T> nodo);
        protected abstract NodeB<T> Get(NodeB<T> nodo, T value);
    }
}
