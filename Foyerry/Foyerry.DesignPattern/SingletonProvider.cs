using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foyerry.DesignPattern
{
    public class SingletonProvider<T> where T : new()
    {
        private SingletonProvider()
        {
        }

        public static T Instance
        {
            get { return SingletonCreator.instance; }
        }

        private class SingletonCreator
        {
            static SingletonCreator() { }

            internal static readonly T instance = new T();
        }
    }
}
