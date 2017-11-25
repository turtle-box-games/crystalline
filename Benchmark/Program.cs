using System;
using System.Diagnostics;
using System.Linq;

namespace Benchmark
{
    public enum TypeEnum
    {
        Foo,

        Bar,
        
        Baz
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

    public class Baz : IType
    {
        public TypeEnum Type => TypeEnum.Baz;

        public string baz()
        {
            return "baz";
        }
    }

    internal class Program
    {
        private const int Iterations = 50_000_000;
        private const int Rounds = 3;
        
        private static string Test1(IType[] types)
        {
            string result = null;
            for (var i = 0; i < Iterations; ++i)
            {
                for (var j = 0; j < types.Length; ++j)
                {
                    var type = types[j];
                    switch (type.Type)
                    {
                        case TypeEnum.Foo:
                            result = ((Foo) type).foo();
                            break;
                        case TypeEnum.Bar:
                            result = ((Bar) type).bar();
                            break;
                        case TypeEnum.Baz:
                            result = ((Baz) type).baz();
                            break;
                        default:
                            throw new NotImplementedException();
                    }
                }
            }
            return result;
        }
        
        private static string Test2(IType[] types)
        {
            string result = null;
            for (var i = 0; i < Iterations; ++i)
            {
                for (var j = 0; j < types.Length; ++j)
                {
                    var type = types[j];
                    switch (type)
                    {
                        case Foo f:
                            result = f.foo();
                            break;
                        case Bar b:
                            result = b.bar();
                            break;
                        case Baz b:
                            result = b.baz();
                            break;
                        default:
                            throw new NotImplementedException();
                    }
                }
            }
            return result;
        }
        
        private static string Test3(IType[] types)
        {
            string result = null;
            for (var i = 0; i < Iterations; ++i)
            {
                for (var j = 0; j < types.Length; ++j)
                {
                    var type = types[j];
                    var fo = type as Foo;
                    if (fo != null)
                        result = fo.foo();
                    else
                    {
                        var ba = type as Bar;
                        if (ba != null)
                            result = ba.bar();
                        else
                        {
                            var bz = type as Baz;
                            if (bz != null)
                                result = bz.baz();
                        }
                    }
                }
            }
            return result;
        }
        
        private static string Test4(IType[] types)
        {
            string result = null;
            for (var i = 0; i < Iterations; ++i)
            {
                for (var j = 0; j < types.Length; ++j)
                {
                    var type = types[j];
                    if (type is Foo fo)
                        result = fo.foo();
                    else
                    {
                        if (type is Bar ba)
                            result = ba.bar();
                        else
                        {
                            if (type is Baz bz)
                                result = bz.baz();
                        }
                    }
                }
            }
            return result;
        }

        delegate string TestDelegate(IType[] types);
        
        public static void Main(string[] args)
        {
            var types = new IType[]
            {
                new Foo(), new Bar(), new Baz(), new Bar(), new Foo(), new Baz(),
                new Baz(), new Bar(), new Bar(), new Baz(), new Foo(), new Foo()
            };
            string result;
            var tests = new TestDelegate[] {Test1, Test2, Test3, Test4};
            var results = new[] {0d, 0d, 0d, 0d};
            for (var i = 0; i < Rounds; ++i)
            {
                for(var j = 0; j < tests.Length; ++j)
                {
                    var test = tests[j];
                    var stopwatch = new Stopwatch();
                    stopwatch.Start();
                    result = test(types);
                    stopwatch.Stop();
                    Console.WriteLine($"Round {i+1}, Test {j+1}: {stopwatch.Elapsed} - {result}");
                    results[j] += stopwatch.Elapsed.TotalMilliseconds;
                }
                Console.WriteLine();
            }
            var min = results.Min();
            for(var i = 0; i < tests.Length; ++i)
                Console.WriteLine($"Test {i+1} Avg: {results[i]/Rounds}, Ratio: {results[i]/min}");
        }
    }
}