namespace _02_Fakes;

public interface IKeyValueStore
{
    void SetValue(string key, string value);
    string GetValue(string key);
}