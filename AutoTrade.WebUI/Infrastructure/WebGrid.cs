using System;
using System.Collections.Generic;
using System.Web;
using System.Web.Helpers;

namespace AutoTrade.WebUI.Infrastructure
{
    public class WebGrid<T>: WebGrid
    {
        public WebGrid(IEnumerable<T> source = null,
                       IEnumerable<string> columnNames = null,
                       string defaultSort = null,
                       int rowsPerPage = 30, 
                       bool canPage = true, 
                       bool canSort = true, 
                       string ajaxUpdateContainerId = null, 
                       string ajaxUpdateCallback = null,
                       string fieldNamePrefix = null, 
                       string pageFieldName = null, 
                       string selectionFieldName = null,
                       string sortFieldName = null,     
                       string sortDirectionFieldName = null)
            : base(source.SafeCast<object>(),
                    columnNames,
                    defaultSort,
                    rowsPerPage, 
                    canPage,
                    canSort, 
                    ajaxUpdateContainerId,
                    ajaxUpdateCallback,
                    fieldNamePrefix, 
                    pageFieldName, 
                    selectionFieldName, 
                    sortFieldName, 
                    sortDirectionFieldName)
        {
        }

        public WebGridColumn Column(string columnName = null, 
                                    string header = null, 
                                    Func<T, object> format = null, 
                                    string style = null,
                                    bool canSort = true)
        {
            Func<dynamic, object> wrappedFormat = null;
            if (format != null)
            {
                wrappedFormat = o => format((T)o.Value);
            }
            WebGridColumn column = base.Column(columnName, header, wrappedFormat, style, canSort);
            return column;
        }

        public WebGrid<T> Bind(IEnumerable<T> source, IEnumerable<string> columnNames = null, bool autoSortAndPage = true, int rowCount = -1)
        {
            base.Bind(source.SafeCast<object>(), columnNames, autoSortAndPage, rowCount);
            return this;
        }
    }
}