using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Collections;

namespace AutoTrade.WebUI.Infrastructure
{
    static public class EnumerableExtensions
    {
        public static IEnumerable<TTarget> SafeCast<TTarget>(this IEnumerable source)
        {
            return source == null ? null : source.Cast<TTarget>();
        }
    }
}