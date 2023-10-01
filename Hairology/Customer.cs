using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hairology
{
    public class Customer
    {
        // personal attributes
        private string _firstName = default!;
        private string _lastName = default!;
        private string _dateOfBirth = default!;
        private char _sex = default!;
        private string _addressLine1 = default!;
        private string _addressLine2 = default!;
        private string _county = default!;
        private string _postCode = default!;
        private bool _regularCustomer = default!;
        // constructor
        public Customer(object[] personalDetails)
        {
            // set personal details
            _firstName = personalDetails[0].ToString();
            _lastName = personalDetails[1].ToString();
            _dateOfBirth = personalDetails[2].ToString();
            _sex = char.Parse(personalDetails[3].ToString());
            _addressLine1 = personalDetails[4].ToString();
            _addressLine2 = personalDetails[5].ToString();
            _county = personalDetails[6].ToString();
            _postCode = personalDetails[7].ToString();
            _regularCustomer = Convert.ToBoolean(personalDetails[8].ToString());
        }
        public string GetFullName()
        {
            return _firstName + " " + _lastName;
        }
        public object GetAttribute(int index)
        {
            switch (index)
            {
                case 0:
                    return _firstName;
                case 1:
                    return _lastName;
                case 2:
                    return _dateOfBirth;
                case 3:
                    return _sex;
                case 4:
                    return _addressLine1;
                case 5:
                    return _addressLine2;
                case 6:
                    return _county;
                case 7:
                    return _postCode;
                case 8:
                    return _regularCustomer;
                default:
                    return null;
            }
        }
    }
}
