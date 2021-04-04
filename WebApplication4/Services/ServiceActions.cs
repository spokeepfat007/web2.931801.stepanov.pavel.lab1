using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication4.Services
{
    public class ServiceActions : IServiceActions
    {
        public int val1 { get; set; }
        public int val2 { get; set; }
        public ServiceActions()
        {
            Random rnd = new Random();
            val1 = rnd.Next(11);
            val2 = rnd.Next(11);
        }
        public int div() { if (val2 != 0) return val1 / val2; else return -1; }
        public int sub() { return val1 - val2; }
        public int add() { return val1 + val2; }
        public int mult() { return val1 * val2; }
    }
    public interface IServiceActions
    {
        public int val1 { get; set; }
        public int val2 { get; set; }
        public int div();
        public int sub();
        public int add();
        public int mult();
    }
}
