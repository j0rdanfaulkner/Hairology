using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hairology
{
    public class DatabaseQueries
    {
        public const string SELECT_ACCOUNT_USING_USERNAME = "SELECT * FROM [User Accounts] WHERE username = '{0}'";

        public const string SELECT_ACCOUNT_USING_ID = "SELECT * FROM [User Accounts] WHERE account_id = '{0}'";

        public const string SELECT_EMPLOYEE_PERSONAL_DETAILS = "SELECT first_name, last_name, age, sex, address_line_1, address_line_2, county, post_code FROM [Employee Details] WHERE employee_number = '{0}'";

        public const string SELECT_EMPLOYEE_WORK_DETAILS = "SELECT employee_number, department, completed_training, admin_rights FROM [Employees] WHERE employee_number = '{0}'";

        public const string SELECT_EMPLOYEE_NUMBER = "SELECT employee_number FROM [Employees] WHERE account_id = '{0}'";

        public const string SELECT_ACCOUNT_ID = "SELECT account_id FROM [Employees] WHERE employee_number = '{0}'";
    }
}
