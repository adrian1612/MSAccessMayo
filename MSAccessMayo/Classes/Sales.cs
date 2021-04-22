using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSAccessMayo
{
    class Sales
    {

        dbcontrol s = new dbcontrol();

        public int ID { get; set; }
        public int SalesNo { get; set; }
        public string Category { get; set; }
        public string Customer { get; set; }
        public string Address { get; set; }
        public string TIN { get; set; }
        public string BusinessStyle { get; set; }
        public string SDate { get; set; }
        public string Terms { get; set; }
        public string PONo { get; set; }
        public string AmountInWord { get; set; }
        public string PayableTo { get; set; }
        public string PreparedBy { get; set; }
        public string CheckedBy { get; set; }
        public string ApprovedBy { get; set; }
        public List<SalesDetail> Details = new List<SalesDetail>();
        public decimal ParticularTotalAmount
        {
            get
            {
                decimal Total = 0;
                Details.ForEach(d => Total += d.Amount);
                return Total;
            }
        }


        public Sales()
        {

        }

        public Sales(int ID, int SalesNo, string Category, string Customer, string Address, string TIN, string BusinessStyle, string SDate, string Terms, string PONo, string AmountInWord, string PayableTo, string PreparedBy, string CheckedBy, string ApprovedBy)
        {
            this.ID = ID;
            this.SalesNo = SalesNo;
            this.Category = Category;
            this.Customer = Customer;
            this.Address = Address;
            this.TIN = TIN;
            this.BusinessStyle = BusinessStyle;
            this.SDate = SDate;
            this.Terms = Terms;
            this.PONo = PONo;
            this.AmountInWord = AmountInWord;
            this.PayableTo = PayableTo;
            this.PreparedBy = PreparedBy;
            this.CheckedBy = CheckedBy;
            this.ApprovedBy = ApprovedBy;
        }

        public Sales(int SalesNo, string Category, string Customer, string Address, string TIN, string BusinessStyle, string SDate, string Terms, string PONo, string AmountInWord, string PayableTo, string PreparedBy, string CheckedBy, string ApprovedBy)
        {
            this.SalesNo = SalesNo;
            this.Category = Category;
            this.Customer = Customer;
            this.Address = Address;
            this.TIN = TIN;
            this.BusinessStyle = BusinessStyle;
            this.SDate = SDate;
            this.Terms = Terms;
            this.PONo = PONo;
            this.AmountInWord = AmountInWord;
            this.PayableTo = PayableTo;
            this.PreparedBy = PreparedBy;
            this.CheckedBy = CheckedBy;
            this.ApprovedBy = ApprovedBy;
        }

        public Sales(DataRow r)
        {
            ID = (int)r["ID"];
            SalesNo = (int)r["SalesNo"];
            Category = r["Category"].ToString();
            Customer = r["Customer"].ToString();
            Address = r["Address"].ToString();
            TIN = r["TIN"].ToString();
            BusinessStyle = r["BusinessStyle"].ToString();
            SDate = r["SDate"].ToString();
            Terms = r["Terms"].ToString();
            PONo = r["PONo"].ToString();
            AmountInWord = r["AmountInWord"].ToString();
            PayableTo = r["PayableTo"].ToString();
            PreparedBy = r["PreparedBy"].ToString();
            CheckedBy = r["CheckedBy"].ToString();
            ApprovedBy = r["ApprovedBy"].ToString();
        }

        public void Insert(Sales sale)
        {
            var ID = s.Insert("tbl_sales", p =>
            {
                p.Add("SalesNo", sale.SalesNo);
                p.Add("Category", sale.Category);
                p.Add("Customer", sale.Customer);
                p.Add("Address", sale.Address);
                p.Add("TIN", sale.TIN);
                p.Add("BusinessStyle", sale.BusinessStyle);
                p.Add("SDate", sale.SDate);
                p.Add("Terms", sale.Terms);
                p.Add("PONo", sale.PONo);
                p.Add("AmountInWord", sale.AmountInWord);
                p.Add("PayableTo", sale.PayableTo);
                p.Add("PreparedBy", sale.PreparedBy);
                p.Add("CheckedBy", sale.CheckedBy);
                p.Add("ApprovedBy", sale.ApprovedBy);
            }, true);

            Details.ForEach(d =>
            {
                s.Insert("tbl_salesDetail", p =>
                {
                    p.Add("RecordID", ID);
                    p.Add("Particulars", d.Particular);
                    p.Add("Amount", d.Amount);
                });
            });
        }

        public String changeNumericToWords(double numb)
        {
            String num = numb.ToString();
            return changeToWords(num, false);
        }
        public String changeCurrencyToWords(String numb)
        {
            return changeToWords(numb, true);
        }
        public String changeNumericToWords(String numb)
        {
            return changeToWords(numb, false);
        }
        public String changeCurrencyToWords(double numb)
        {
            return changeToWords(numb.ToString(), true);
        }
        private String changeToWords(String numb, bool isCurrency)
        {
            String val = "", wholeNo = numb, points = "", andStr = "", pointStr = "";
            String endStr = (isCurrency) ? ("Only") : ("");
            try
            {
                int decimalPlace = numb.IndexOf(".");
                if (decimalPlace > 0)
                {
                    wholeNo = numb.Substring(0, decimalPlace);
                    points = numb.Substring(decimalPlace + 1);
                    if (Convert.ToInt32(points) > 0)
                    {
                        andStr = (isCurrency) ? ("and") : ("point");// just to separate whole numbers from points/cents
                        endStr = (isCurrency) ? ("Cents " + endStr) : ("");
                        pointStr = translateCents(points);
                    }
                }
                val = String.Format("{0} {1}{2} {3}", translateWholeNumber(wholeNo).Trim(), andStr, pointStr, endStr);
            }
            catch {; }
            return val;
        }
        private String translateWholeNumber(String number)
        {
            string word = "";
            try
            {
                bool beginsZero = false;//tests for 0XX
                bool isDone = false;//test if already translated
                double dblAmt = (Convert.ToDouble(number));
                //if ((dblAmt > 0) && number.StartsWith("0"))
                if (dblAmt > 0)
                {//test for zero or digit zero in a nuemric
                    beginsZero = number.StartsWith("0");
                    int numDigits = number.Length;
                    int pos = 0;//store digit grouping
                    String place = "";//digit grouping name:hundres,thousand,etc...
                    switch (numDigits)
                    {
                        case 1://ones' range
                            word = ones(number);
                            isDone = true;
                            break;
                        case 2://tens' range
                            word = tens(number);
                            isDone = true;
                            break;
                        case 3://hundreds' range
                            pos = (numDigits % 3) + 1;
                            place = " Hundred ";
                            break;
                        case 4://thousands' range
                        case 5:
                        case 6:
                            pos = (numDigits % 4) + 1;
                            place = " Thousand ";
                            break;
                        case 7://millions' range
                        case 8:
                        case 9:
                            pos = (numDigits % 7) + 1;
                            place = " Million ";
                            break;
                        case 10://Billions's range
                            pos = (numDigits % 10) + 1;
                            place = " Billion ";
                            break;
                        //add extra case options for anything above Billion...
                        default:
                            isDone = true;
                            break;
                    }
                    if (!isDone)
                    {//if transalation is not done, continue...(Recursion comes in now!!)
                        word = translateWholeNumber(number.Substring(0, pos)) + place + translateWholeNumber(number.Substring(pos));
                        //check for trailing zeros
                        if (beginsZero) word = " and " + word.Trim();
                    }
                    //ignore digit grouping names
                    if (word.Trim().Equals(place.Trim())) word = "";
                }
            }
            catch {; }
            return word.Trim();
        }
        private String tens(String digit)
        {
            int digt = Convert.ToInt32(digit);
            String name = null;
            switch (digt)
            {
                case 10:
                    name = "Ten";
                    break;
                case 11:
                    name = "Eleven";
                    break;
                case 12:
                    name = "Twelve";
                    break;
                case 13:
                    name = "Thirteen";
                    break;
                case 14:
                    name = "Fourteen";
                    break;
                case 15:
                    name = "Fifteen";
                    break;
                case 16:
                    name = "Sixteen";
                    break;
                case 17:
                    name = "Seventeen";
                    break;
                case 18:
                    name = "Eighteen";
                    break;
                case 19:
                    name = "Nineteen";
                    break;
                case 20:
                    name = "Twenty";
                    break;
                case 30:
                    name = "Thirty";
                    break;
                case 40:
                    name = "Fourty";
                    break;
                case 50:
                    name = "Fifty";
                    break;
                case 60:
                    name = "Sixty";
                    break;
                case 70:
                    name = "Seventy";
                    break;
                case 80:
                    name = "Eighty";
                    break;
                case 90:
                    name = "Ninety";
                    break;
                default:
                    if (digt > 0)
                    {
                        name = tens(digit.Substring(0, 1) + "0") + " " + ones(digit.Substring(1));
                    }
                    break;
            }
            return name;
        }
        private String tensCent(String digit)
        {
            int digt = Convert.ToInt32(digit);
            String name = null;
            switch (digt)
            {
                case 10:
                    name = "10";
                    break;
                case 11:
                    name = "11";
                    break;
                case 12:
                    name = "12";
                    break;
                case 13:
                    name = "13";
                    break;
                case 14:
                    name = "14";
                    break;
                case 15:
                    name = "15";
                    break;
                case 16:
                    name = "16";
                    break;
                case 17:
                    name = "17";
                    break;
                case 18:
                    name = "18";
                    break;
                case 19:
                    name = "19";
                    break;
                case 20:
                    name = "20";
                    break;
                case 30:
                    name = "30";
                    break;
                case 40:
                    name = "40";
                    break;
                case 50:
                    name = "50";
                    break;
                case 60:
                    name = "60";
                    break;
                case 70:
                    name = "70";
                    break;
                case 80:
                    name = "80";
                    break;
                case 90:
                    name = "90";
                    break;
                default:
                    if (digt > 0)
                    {
                        name = tensCent(digit.Substring(0, 1) + "0") + " " + onescent(digit.Substring(1));
                    }
                    break;
            }
            return name;
        }
        private String onescent(String digit)
        {
            int digt = Convert.ToInt32(digit);
            String name = "";
            switch (digt)
            {
                case 1:
                    name = "1";
                    break;
                case 2:
                    name = "2";
                    break;
                case 3:
                    name = "3";
                    break;
                case 4:
                    name = "4";
                    break;
                case 5:
                    name = "5";
                    break;
                case 6:
                    name = "6";
                    break;
                case 7:
                    name = "7";
                    break;
                case 8:
                    name = "8";
                    break;
                case 9:
                    name = "9";
                    break;
            }
            return name;
        }
        private String ones(String digit)
        {
            int digt = Convert.ToInt32(digit);
            String name = "";
            switch (digt)
            {
                case 1:
                    name = "One";
                    break;
                case 2:
                    name = "Two";
                    break;
                case 3:
                    name = "Three";
                    break;
                case 4:
                    name = "Four";
                    break;
                case 5:
                    name = "Five";
                    break;
                case 6:
                    name = "Six";
                    break;
                case 7:
                    name = "Seven";
                    break;
                case 8:
                    name = "Eight";
                    break;
                case 9:
                    name = "Nine";
                    break;
            }
            return name;
        }
        private String translateCents(String cents)
        {
            String cts = "", digit = "", engOne = "";
            int count = 0;
            for (int i = 0; i < cents.Length; i++)
            {
                count++;
            }
            if (count >= 2)
            {
                engOne = tens(cents);
                cts += $" {engOne}";
            }
            else
            {
                for (int i = 0; i < cents.Length; i++)
                {
                    digit = cents[i].ToString();
                    if (digit.Equals("0"))
                    {
                        engOne = "Zero";
                    }
                    else
                    {
                        engOne = ones(digit);
                    }
                    cts += " " + engOne;
                }
            }
            return cts;
        }


    }
}
