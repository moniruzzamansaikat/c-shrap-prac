using System.Reflection.Metadata;

public class Strings
{
  public void Main()
  {
    string name = "Saikat";
    string tame = (string)name.Clone(); // 

    tame = "Taikat";
    // Console.WriteLine("{0} and {1}", name, tame);

    string a = "Abc";
    string b = "abc";
    // Console.WriteLine(b.CompareTo(a));  -1

    // Console.WriteLine("def".CompareTo("abc")); // 1

    string sen = "I love coding & tech";
    // PrintLn(sen.Contains("love")); // True

    // PrintLn(sen.EndsWith("tech"));

    // PrintLn("abc".Equals("AbC", StringComparison.OrdinalIgnoreCase)); // true

    // PrintLn(sen.IndexOf("love")); // 2

    // PrintLn(string.Format("My name is {0}", "Saikat"));

    // PrintLn(sen.Insert(15, " books as well as"));

    // PrintLn(string.Join(", ", new string[]{"Apple", "Banana", "Mango"}));

    // PrintLn(sen.LastIndexOf("c"));

    // PrintLn(sen.Length);

    // PrintLn("938".PadLeft(10, '*')); // *******938

    // PrintLn("938".PadRight(10, '*')); // 938*******

    // PrintLn(sen.Remove(2)); // I

    // PrintLn(sen.Replace("I", "We")); // We love coding & tech

    // string[] words = "zuck, bug, code".Split(',');
    // PrintLn(words.Length); // 3

    // PrintLn("Hello World".Substring(6));  

    // char[] chars = "Hello".ToCharArray();
    // PrintLn(chars.Last()); // o

    // PrintLn("HELLO".ToLower());

    // PrintLn("hello".ToUpper());

    // PrintLn("            OK          ".Trim());

    // PrintLn("        OK                ".TrimStart());

    // PrintLn("        OK                ".TrimEnd());

    // PrintLn(string.IsNullOrEmpty("")); // True

    // PrintLn(string.IsNullOrEmpty("no")); // False

    // PrintLn(string.IsNullOrWhiteSpace("             ")); // True
  }

  public static void Print(object o)
  {
    Console.Write(o);
  }

  public static void PrintLn(object o)
  {
    Console.WriteLine(o);
  }
}