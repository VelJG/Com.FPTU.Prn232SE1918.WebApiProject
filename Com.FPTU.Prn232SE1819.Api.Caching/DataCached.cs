namespace Com.FPTU.Prn232SE1819.Api.Caching;

public class DataCached : IDataCached
{
    public void Clear()
    {
        throw new NotImplementedException();
    }

    public T Get<T>(string key, Func<T> acquire, int? cacheTime = null)
    {
        throw new NotImplementedException();
    }

    public T Get<T>(string key)
    {
        throw new NotImplementedException();
    }

    public object Get(string key)
    {
        throw new NotImplementedException();
    }

    public IList<string> GetKeys()
    {
        throw new NotImplementedException();
    }

    public IList<T> GetValues<T>(string pattern)
    {
        throw new NotImplementedException();
    }

    public bool IsSet(string key)
    {
        throw new NotImplementedException();
    }

    public void Remove(string key)
    {
        throw new NotImplementedException();
    }

    public void Set<T>(string key, T? value, int cacheTime)
    {
        throw new NotImplementedException();
    }
}
