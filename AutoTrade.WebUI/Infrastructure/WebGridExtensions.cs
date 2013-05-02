using System.Collections.Generic;
using System.Web.Mvc;

namespace AutoTrade.WebUI.Infrastructure
{
    static public class WebGridExtensions
    {
        public static WebGrid<T> Grid<T>(this HtmlHelper htmlHelper,
                                        IEnumerable<T> source,
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
        {
            return new WebGrid<T>(source,
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
                                sortDirectionFieldName);
        }


        public static WebGrid<T> ServerPagedGrid<T>(this HtmlHelper htmlHelper,
                                                    IEnumerable<T> source,
                                                    int totalRows,
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
        {
            var webGrid = new WebGrid<T>(null,
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
                                        sortDirectionFieldName);
            return webGrid.Bind(source, rowCount: totalRows, autoSortAndPage: false); ;
        }
    }
}