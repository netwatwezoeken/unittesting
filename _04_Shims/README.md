# Shims

1. Take a look at `HexFile.cs`
1. The class uses `System.IO.File.ReadAllLines` is used and cannot be mocked easily
1. Add the NuGet package Pose
1. Then create the following testmethod:
```csharp
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
```

1. Notice how th unit under test is called in isolation to intercept the call to `ReadAllLines()`
1. 