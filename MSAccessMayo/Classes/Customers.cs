using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSAccessMayo
{
    public class Customers
    {
        dbcontrol s = new dbcontrol();
        public int ID { get; set; }
        public string Customer { get; set; }
        public string Address { get; set; }
        public string TIN { get; set; }
        public string BusinessStyle { get; set; }
        public string Terms { get; set; }

        public string Display { get { return $"{Customer}  |  {Convert.ToInt64(TIN):000-###-###-###}"; } }

        public Customers()
        {

        }

        public Customers(int ID, string Customer, string Address, string TIN, string BusinessStyle, string Terms)
        {
            this.ID = ID;
            this.Customer = Customer;
            this.Address = Address;
            this.TIN = TIN;
            this.BusinessStyle = BusinessStyle;
            this.Terms = Terms;
        }

        public Customers(string Customer, string Address, string TIN, string BusinessStyle, string Terms)
        {
            this.Customer = Customer;
            this.Address = Address;
            this.TIN = TIN;
            this.BusinessStyle = BusinessStyle;
            this.Terms = Terms;
        }

        public Customers(DataRow r)
        {
            ID = (int)r["CusNo"];
            Customer = r["Customer"].ToString();
            Address = r["Address"].ToString();
            TIN = r["TIN"].ToString();
            BusinessStyle = r["BusinessStyle"].ToString();
            Terms = r["Terms"].ToString();
        }

        public List<Customers> ListCustomer(string Search = "")
        {
            var list = new List<Customers>();
            s.Query("select * from tblCustomerList WHERE customer like @search", p => p.Add("@search", $"%{Search}%")).AsEnumerable().ToList().ForEach(r =>
            {
                list.Add(new Customers(r));
            });
            return list;
        }

        public Customers FindCustomer(string customer)
        {
            var cust = new Customers();
            s.Query("select * from tblCustomerList WHERE Customer = @customer", p => p.Add("@customer", customer)).AsEnumerable().ToList().ForEach(r =>
            {
                cust = new Customers(r);
            });
            return cust;
        }


    }
}
