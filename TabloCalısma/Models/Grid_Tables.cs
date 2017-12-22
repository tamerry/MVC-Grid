using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TabloCalısma.Models
{
    public class Grid_Tables
    {
        public int EmpNo { get; set; }
        public string EName { get; set; }
        public string Job { get; set; }
        public Nullable<int> Mgr { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public Nullable<System.DateTime> HireDate { get; set; }
        public Nullable<decimal> Sal { get; set; }
        public Nullable<decimal> Comm { get; set; }
        public Nullable<int> Dept { get; set; }
    }
}