namespace _02_Fakes;

public class BusinessLogic(IKeyValueStore keyValueStore)
{
    public string DoImportantStuff()
    {
        // Imagine all sorts of logic here that happens to be dependant on a IKeyValueStore
        return $"This a very important {keyValueStore.GetValue("Prime directive")}";
    }
}