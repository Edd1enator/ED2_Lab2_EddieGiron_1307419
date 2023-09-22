using Es_Arboles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Es_Arboles
{
    public class B <T> : NoLinearB<T> where T : IComparable<T>
    {
        protected override NodeB<T> Insert(NodeB<T> nodo, T value)
        {
            try
            {
                NodeB<T> nuevo = CrearNodoB(value);
                if (nodo == null)
                {
                    nodo = nuevo;
                }
                else
                {
                    nodo = InsertarB(nuevo, nodo);
                }
            }
            catch (Exception)
            {

                throw;
            }
            return nodo;
        }
        protected override void Delete(NodeB<T> nodo)
        {
            
        }
        protected override NodeB<T> Get(NodeB<T> nodo, T value)
        {
            return nodo;
        }
        private NodeB<T> CrearNodoB(T Value)
        {
            NodeB<T> nuevo = new NodeB<T>();
            nuevo.Valor = Value;
            nuevo.Derecho = new NodeB<T>();
            nuevo.Izquierdo = new NodeB<T>();
            return nuevo;
        }
        public NodeB<T> InsertarB(NodeB<T> nodo, NodeB<T> tempo) //Se inserta el valor en el arbol y se verifico si está ordenado
        {
            try
            {
                NodeB<T> nuevoNodo = tempo;

                if (nodo.Valor.CompareTo(tempo.Valor) == -1)
                {
                    if (tempo.Izquierdo.Valor == null)
                    {
                        tempo.Izquierdo = nodo;
                    }
                    else
                    {
                        tempo.Izquierdo = InsertarB(nodo, tempo.Izquierdo);
                    }
                }
                else if (nodo.Valor.CompareTo(tempo.Valor) == 1)
                {
                    if (tempo.Derecho.Valor == null)
                    {
                        tempo.Derecho = nodo;
                    }
                    else
                    {
                        tempo.Derecho = InsertarB(nodo, tempo.Derecho);
                    }
                }
                return nuevoNodo;
            }
            catch
            {
                throw;
            }
        }
    }
}
