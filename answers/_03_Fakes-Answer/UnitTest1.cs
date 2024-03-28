using Pose;

namespace _03_Fakes;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        var fileReadShim = Shim.Replace(() => System.IO.File.ReadAllLines(Is.A<string>())).With(
            delegate (string s)
            {
                return (string[])["line 1", "line 2", "line 3"]; 
            });

        string[]? result = null;

        PoseContext.Isolate(() =>
        {
            result = new HexFile("this_file_doesnt_exist.txt").Records;
        }, fileReadShim);
            
        Assert.Equal(3, result.Length);
    }
}