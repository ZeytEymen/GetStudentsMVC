using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GetStudents.Models
{
    public class Students
    {
        public int StudentNo { get; set; }
        public string StudentFullName { get; set; }
        public string Class { get; set; }

        public Students(int sNo, string sFullName, string sClass)
        {
            this.StudentNo = sNo;
            this.StudentFullName = sFullName;
            this.Class = sClass;
        }
    }
}