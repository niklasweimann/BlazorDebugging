using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorDebugging
{
    public class SingeltonFoo
    {
        public static SingeltonFoo Instance { get; set; } = new SingeltonFoo();

        public delegate void MyEventHandler(string foo);

        public event MyEventHandler SomethingHappened;

        public void OnSomethingHappend(string foo)
        {
            SomethingHappened?.Invoke(foo);
        }
        private SingeltonFoo()
        {

        }
    }
}
