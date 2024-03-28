namespace _02_Fakes;

public class DBKeyValueStore : IKeyValueStore
{
    public void SetValue(string key, string value)
    {
        // Consider this code to require an actual database
        throw new NotImplementedException();
    }

    public string GetValue(string key)
    {
        // Consider this code to require an actual database
        throw new NotImplementedException();
    }
}