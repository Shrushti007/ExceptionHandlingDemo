
namespace ExceptionProjectLibrary

{
    public class Customer
    {
        int _custid;
        string _custName;
        string _city;
        public int Custid 
        {
            get
            { 
                return _custid;
            } 
            set
            {
                if (value > 0 && value<2000) 
                {
                    _custid = value;
                }
                else if (value > 2000)
                {
                    throw new CustomerNotFoundException("This is not valid number");
                }
                else
                {
                    throw new ArgumentNullException("Customer Id must be positive Number");
                }
                
            }
        }
        public string CustName
        { 
            get
            { 
                return _custName; 
            } 
            set 
            {
                if(string.IsNullOrEmpty(value) )
                   { 
                    throw new ArgumentNullException("Customer Name Cannot be Null Or Empty");
                   }
                else if(value.StartsWith(" "))
                {
                    throw new AccessViolationException("Name Cannot start with a space");
                }
                else
                {
                    _custName = value;

                }
            }
        }
        public string City 
        {
            get
            {
                return _city; 
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Customer city Cannot be Null Or Empty");
                }
                else
                {
                    _city = value;
                }
            }
        }
    }
}