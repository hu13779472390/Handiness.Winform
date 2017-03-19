using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleTestUnit
{
    public interface ITest<in T, out T1>
    {
        void Show(T info);
        T1 FetchInfo();
    }
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
