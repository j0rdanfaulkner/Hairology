﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hairology
{
    public class Employee
    {
        // personal attributes
        private string _firstName = default!;
        private string _lastName = default!;
        private int _age = default!;
        private char _sex = default!;
        private string _addressLine1 = default!;
        private string _addressLine2 = default!;
        private string _county = default!;
        private string _postCode = default!;
        // work attributes
        private int _employeeNumber = default!;
        private string _department = default!;
        private bool _completedTraining = default!;
        private bool _adminRights = default!;
        // constructor
        public Employee(object[] personalDetails, object[] workDetails)
        {
            // set personal details
            _firstName = personalDetails[0].ToString();
            _lastName = personalDetails[1].ToString();
            _age = Convert.ToInt32(personalDetails[2]);
            _sex = char.Parse(personalDetails[3].ToString());
            _addressLine1 = personalDetails[4].ToString();
            _addressLine2 = personalDetails[5].ToString();
            _county = personalDetails[6].ToString();
            _postCode = personalDetails[7].ToString();
            // set work details
            _employeeNumber = Convert.ToInt32(workDetails[0].ToString());
            _department = workDetails[1].ToString();
            _completedTraining = bool.Parse(workDetails[2].ToString());
            _adminRights = bool.Parse(workDetails[3].ToString());
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
                    break;
                case 1:
                    return _lastName;
                    break;
                case 2:
                    return _age;
                    break;
                case 3:
                    return _sex;
                    break;
                case 4:
                    return _addressLine1;
                    break;
                case 5:
                    return _addressLine2;
                    break;
                case 6:
                    return _county;
                    break;
                case 7:
                    return _postCode;
                    break;
                case 8:
                    return _employeeNumber;
                    break;
                case 9:
                    return _department;
                    break;
                case 10:
                    return _completedTraining;
                    break;
                case 11:
                    return _adminRights;
                    break;
                default:
                    return null;
                    break;
            }
            return null;
        }
    }
}
