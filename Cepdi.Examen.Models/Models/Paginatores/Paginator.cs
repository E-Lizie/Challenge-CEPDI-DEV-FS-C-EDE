using System;
using System.Collections.Generic;

namespace Cepdi.Models.Models.Paginatores
{
    public  class Paginator<T> where T : class
    {

        public int CurrentPage { get; set; }
        public int RecordsPage { get; set; }
        public int TotalRecords { get; set; }
        public IEnumerable<T> Records { get; set; }
        public int TotalPages { get { return (int)Math.Ceiling(TotalRecords / (double)RecordsPage); } }
        public bool HasCurrentPage { get { return (CurrentPage > 1); } }
        public bool HasNextPage { get { return (CurrentPage > TotalPages); } }
    }
}
