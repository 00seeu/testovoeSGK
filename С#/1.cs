class Program
{
    static void Main(string[] args)
    {
        System.Func<string, char> f =
            s => { var c = s[0]; while (s.IndexOf(++c) >= 0) ; return c; }
            ;

        System.Console.WriteLine(f("abcdf"));  // e
        System.Console.WriteLine(f("OQRS"));   // P
        System.Console.WriteLine(f("xz"));     // y
    }
}