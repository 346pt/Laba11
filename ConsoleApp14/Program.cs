try
{
    StreamReader text = new StreamReader(@"C:\Users\Антисептик\Desktop\лаба11(10)");
    string[] massiv = text.ReadToEnd().Split('\n');
    foreach (var i in massiv)
    {
        Console.WriteLine(i);
    }
}
catch (OutOfMemoryException e)
{
    Console.WriteLine(e.Message);
}
catch (System.IO.IOException e)
{
    Console.WriteLine(e.Message);
}


