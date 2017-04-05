using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetU
{
    class Instructor
    {
     
        public Instructor(SqlDataReader reader)
        {
            this.Id = (int)reader["Id"];
            this.Name = reader["InstructorName"].ToString();
            this.DeptId = (int)reader["DeptID"];
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int DeptId { get; set; }
    }
}
