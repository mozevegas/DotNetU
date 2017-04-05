using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetU
{
    class CourseTable
    {
        public CourseTable (SqlDataReader reader)
        {
            this.Id = (int)reader["Id"];
            this.CourseTitle = reader["CourseTitle"].ToString();
            this.CourseNumber = (int)reader["CourseNumber"];
            this.InstructorID = (int)reader["InstructorID"];
            this.DepartmentID = (int)reader["DepartmentID"];
        }


        public int Id { get; set; }
        public string CourseTitle { get; set; }
        public int CourseNumber { get; set; }
        public int InstructorID { get; set; }
        public int DepartmentID { get; set; }
    }
}
