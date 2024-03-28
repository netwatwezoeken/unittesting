namespace _03_Fakes;

public class HexFile(string path)
{
    public string[] Records { get; private set; } = System.IO.File.ReadAllLines(path);
}