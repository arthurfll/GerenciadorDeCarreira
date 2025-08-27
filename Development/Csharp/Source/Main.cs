namespace Csharp.Main;

public class Main
{
  public static void HelloWorld()
  {

    var x = "abcdefgh";

    var y = x.ToList();

    y[0] = 'z';

    var z = new String(y.ToArray());

    Console.WriteLine(z);
  }
}


