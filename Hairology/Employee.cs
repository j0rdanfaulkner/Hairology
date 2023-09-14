using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hairology
{
    public class Employee
    {
        public int employeeNumber = default!;
        private string _firstName = default!;
        private string _lastName = default!;
        private int _age = default!;
        private char _sex = default!;
        private string _addressLine1 = default!;
        private string _addressLine2 = default!;
        private string _county = default!;
        private string _postCode = default!;
        // constructor
        public Employee(object[] details)
        {
            _firstName = details[0].ToString();
            _lastName = details[1].ToString();
            _age = Convert.ToInt32(details[2]);
            _sex = char.Parse(details[3].ToString());
            _addressLine1 = details[4].ToString();
            _addressLine2 = details[5].ToString();
            _county = details[6].ToString();
            _postCode = details[7].ToString();
            employeeNumber = Convert.ToInt32(details[8].ToString());
        }
    }
}
