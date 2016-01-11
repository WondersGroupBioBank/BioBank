using WondersGroup.BioBank.Model.Models;

namespace WondersGroup.BioBank.Data.Infrastructure
{
public class DatabaseFactory : Disposable, IDatabaseFactory
{
    private BioBankContext dataContext;
    public BioBankContext Get()
    {
        return dataContext ?? (dataContext = new BioBankContext());
    }
    protected override void DisposeCore()
    {
        if (dataContext != null)
            dataContext.Dispose();
    }
}
}
