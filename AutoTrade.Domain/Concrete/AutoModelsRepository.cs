using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AutoTrade.Domain.Abstract;

namespace AutoTrade.Domain.Concrete
{
    public class AutoModelsRepository:IAutoModelsRepository
    {
        private AutoTradeEntities context = new AutoTradeEntities();

        public IQueryable<AutoModel> AutoModels
        {
            get
            {
                return context.AutoModels;
            }
        }
    }
}
