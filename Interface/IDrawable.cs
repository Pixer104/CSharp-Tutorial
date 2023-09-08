using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentals.Interface
{

    public interface IDrawable
    {
        void Paint();
    }

    public interface ISurface
    {
        void Paint();
    }

    public class SampleClass : IDrawable, ISurface
    {
        void IDrawable.Paint()
        {
            Console.WriteLine("Entered into IDrawable.Paint() method");
        }

        void ISurface.Paint()
        {
            Console.WriteLine("Enetered into ISurface.Paint() method");
        }

    }

    /*public class Circle : IDrawable
    {
        public void draw()
        {
            Console.WriteLine("Drawing Circle shape...");
        }
    }

    public class Rectangle : IDrawable
    {
        public void draw()
        {
            Console.WriteLine("Drawing Rectangle shape...");
        }

    }*/



}
