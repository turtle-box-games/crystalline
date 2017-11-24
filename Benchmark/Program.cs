using System;
using System.Diagnostics;

namespace Benchmark
{
    public enum TypeEnum
    {
        Foo,

        Bar
    }

    public interface IType
    {
        TypeEnum Type { get; }
    }

    public class Foo : IType
    {
        public TypeEnum Type => TypeEnum.Foo;

        public string foo()
        {
            return "foo";
        }
    }

    public class Bar : IType
    {
        public TypeEnum Type => TypeEnum.Bar;

        public string bar()
        {
            return "bar";
        }
    }

    internal class Program
    {
        public static void Main(string[] args)
        {
            var types = new IType[]
            {
                new Foo(), new Bar()
            };
            var stopwatch = new Stopwatch();
            stopwatch.Start();
            string result = null, result2 = null;
            for (var i = 0; i < 50_000_000; ++i)
            {
                var type = types[0];
                switch (type.Type)
                {
                    case TypeEnum.Foo:
                        result = ((Foo) type).foo();
                        break;
                    case TypeEnum.Bar:
                        result = ((Bar) type).bar();
                        break;
                    default:
                        throw new NotImplementedException();
                }
                type = types[1];
                switch (type.Type)
                {
                    case TypeEnum.Foo:
                        result2 = ((Foo) type).foo();
                        break;
                    case TypeEnum.Bar:
                        result2 = ((Bar) type).bar();
                        break;
                    default:
                        throw new NotImplementedException();
                }
            }
            stopwatch.Stop();
            Console.WriteLine(stopwatch.Elapsed);
            Console.WriteLine(result + result2);
            // ---------------------------
            stopwatch = new Stopwatch();
            stopwatch.Start();
            for (var i = 0; i < 50_000_000; ++i)
            {
                var type = types[0];
                switch (type)
                {
                    case Foo f:
                        result = f.foo();
                        break;
                    case Bar b:
                        result = b.bar();
                        break;
                    default:
                        throw new NotImplementedException();
                }
                type = types[1];
                switch (type)
                {
                    case Foo f:
                        result2 = f.foo();
                        break;
                    case Bar b:
                        result2 = b.bar();
                        break;
                    default:
                        throw new NotImplementedException();
                }
            }
            stopwatch.Stop();
            Console.WriteLine(stopwatch.Elapsed);
            Console.WriteLine(result + result2);
            // ---------------------------
            stopwatch = new Stopwatch();
            stopwatch.Start();
            for (var i = 0; i < 50_000_000; ++i)
            {
                var type = types[0];
                var fo = type as Foo;
                if (fo != null)
                    result = fo.foo();
                else
                {
                    var ba = type as Bar;
                    if (ba != null)
                        result = ba.bar();
                }
                type = types[1];
                fo = type as Foo;
                if (fo != null)
                    result2 = fo.foo();
                else
                {
                    var ba = type as Bar;
                    if (ba != null)
                        result2 = ba.bar();
                }
            }
            stopwatch.Stop();
            Console.WriteLine(stopwatch.Elapsed);
            Console.WriteLine(result + result2);
            // ---------------------------
            stopwatch = new Stopwatch();
            stopwatch.Start();
            for (var i = 0; i < 50_000_000; ++i)
            {
                var type = types[0];
                if (type is Foo fo)
                    result = fo.foo();
                else
                {
                    if (type is Bar ba)
                        result = ba.bar();
                }
                type = types[1];
                if (type is Foo fo2)
                    result2 = fo2.foo();
                else
                {
                    if (type is Bar ba)
                        result2 = ba.bar();
                }
            }
            stopwatch.Stop();
            Console.WriteLine(stopwatch.Elapsed);
            Console.WriteLine(result + result2);
        }
    }
}