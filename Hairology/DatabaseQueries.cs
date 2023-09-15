using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hairology
{
    public class DatabaseQueries
    {
        // SELECT QUERIES

        public const string SELECT_ACCOUNT_USING_USERNAME = "SELECT * FROM [User Accounts] WHERE username = '{0}'";

        public const string SELECT_ACCOUNT_USING_ID = "SELECT * FROM [User Accounts] WHERE account_id = '{0}'";

        public const string SELECT_EMPLOYEE_PERSONAL_DETAILS = "SELECT first_name, last_name, age, sex, address_line_1, address_line_2, county, post_code FROM [Employee Details] WHERE employee_number = '{0}'";

        public const string SELECT_EMPLOYEE_WORK_DETAILS = "SELECT employee_number, department, completed_training, admin_rights FROM [Employees] WHERE employee_number = '{0}'";

        public const string SELECT_EMPLOYEE_NUMBER = "SELECT employee_number FROM [Employees] WHERE account_id = '{0}'";

        public const string SELECT_ACCOUNT_ID = "SELECT account_id FROM [Employees] WHERE employee_number = '{0}'";

        public const string SELECT_ALL_CUSTOMERS = "SELECT first_name, last_name, age, sex, address_line_1, address_line_2, county, post_code, regular_customer FROM [Customers]";

        public const string SELECT_ALL_EMPLOYEES = "SELECT d.first_name, d.last_name, d.age, d.sex, d.address_line_1, d.address_line_2, d.county, d.post_code, e.department, e.completed_training, e.admin_rights FROM [Employee Details] AS d LEFT JOIN [Employees] AS e ON d.employee_number = e.employee_number";

        public const string SELECT_ALL_TRANSACTIONS = "SELECT transaction_id, card_number, security_code, expiration_date, transaction_completed FROM [Transactions]";

        public const string SELECT_ALL_INVENTORY_RECORDS = "SELECT product_name, category, ean_number, case_size, current_quantity, reorder_regularly FROM [Inventory]";

        public const string SELECT_CUSTOMER_ID = "SELECT customer_id FROM [Customers] WHERE customer_id = '{0}'";

        // INSERT QUERIES

        public const string INSERT_INTO_CUSTOMERS = "INSERT INTO [Customers] (customer_id, first_name, last_name, age, sex, address_line_1, address_line_2, county, post_code, regular_customer) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}', '{9}')";
    }
}
