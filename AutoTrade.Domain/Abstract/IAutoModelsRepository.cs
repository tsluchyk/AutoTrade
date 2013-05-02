using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AutoTrade.Domain.Concrete;

namespace AutoTrade.Domain.Abstract
{
    public interface IAutoModelsRepository
    {
        IQueryable<AutoModel> AutoModels { get; }
    }
}
