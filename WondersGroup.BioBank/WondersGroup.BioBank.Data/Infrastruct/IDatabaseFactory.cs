using System;
using WondersGroup.BioBank.Model.Models;

namespace WondersGroup.BioBank.Data.Infrastructure
{
    public interface IDatabaseFactory : IDisposable
    {
        BioBankContext Get();
    }
}
