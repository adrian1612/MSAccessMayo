using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSAccessMayo
{
    public class Employee
    {
        dbcontrol s = new dbcontrol();
        public int ID { get; set; }
        public string EmpID { get; set; }
        public string FullName { get; set; }
        public string Position { get; set; }

        public Employee()
        {

        }

        public Employee(int ID, string EmpID, string FullName, string Position)
        {
            this.ID = ID;
            this.EmpID = EmpID;
            this.FullName = FullName;
            this.Position = Position;
        }

        public Employee(string EmpID, string FullName, string Position)
        {
            this.EmpID = EmpID;
            this.FullName = FullName;
            this.Position = Position;
        }

        public Employee(DataRow r)
        {
            ID = (int)r["ID"];
            EmpID = r["EmpID"].ToString();
            FullName = r["FullName"].ToString();
            Position = r["Position"].ToString();
        }

        public List<Employee> ListEmployee(string Search = "")
        {
            var list = new List<Employee>();
            s.Query("select * from tbl_employee where FullName like @search", p => p.Add("@search", $"%{Search}%")).AsEnumerable().ToList().ForEach(r =>
            {
                list.Add(new Employee(r));
            });
            return list;
        }
    }
}
