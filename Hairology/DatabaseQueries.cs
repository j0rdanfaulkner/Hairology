﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Hairology
{
    public class DatabaseQueries
    {
        // SELECT QUERIES

        public const string SELECT_FROM_USER_ACCOUNTS = "SELECT * FROM [User Accounts]";

        public const string SELECT_ACCOUNT_USING_USERNAME = "SELECT * FROM [User Accounts] WHERE username = '{0}'";

        public const string SELECT_ACCOUNT_USING_ID = "SELECT * FROM [User Accounts] WHERE account_id = '{0}'";

        public const string SELECT_EMPLOYEE_PERSONAL_DETAILS = "SELECT first_name, last_name, date_of_birth, sex, address_line_1, address_line_2, county, post_code FROM [Employee Details] WHERE employee_number = '{0}'";

        public const string SELECT_EMPLOYEE_WORK_DETAILS = "SELECT employee_number, department, completed_training, admin_rights FROM [Employees] WHERE employee_number = '{0}'";

        public const string SELECT_EMPLOYEE_NUMBER = "SELECT employee_number FROM [Employees] WHERE account_id = '{0}'";

        public const string SELECT_RANDOM_EMPLOYEE_NUMBER = "SELECT employee_number FROM [Employees] WHERE employee_number = '{0}'";

        public const string SELECT_RANDOM_TRANSACTION_ID = "SELECT transaction_id FROM [Transactions] WHERE transaction_id = '{0}'";

        public const string SELECT_ACCOUNT_ID = "SELECT account_id FROM [Employees] WHERE employee_number = '{0}'";

        public const string SELECT_USERNAME = "SELECT username FROM [User Accounts] WHERE username = '{0}'";

        public const string SELECT_USERNAME_USING_ID = "SELECT username FROM [User Accounts] WHERE account_id = '{0}'";

        public const string SELECT_PASSWORD = "SELECT password FROM [User Accounts] WHERE username = '{0}'";

        public const string SELECT_ALL_CUSTOMERS = "SELECT first_name, last_name, date_of_birth, sex, address_line_1, address_line_2, county, post_code, regular_customer FROM [Customers]";

        public const string SELECT_CUSTOMER_NAMES = "SELECT first_name, last_name, post_code FROM [Customers]";

        public const string SELECT_ALL_EMPLOYEES = "SELECT d.first_name, d.last_name, d.date_of_birth, d.sex, d.address_line_1, d.address_line_2, d.county, d.post_code, e.employee_number, e.department, e.completed_training, e.admin_rights FROM [Employee Details] AS d LEFT JOIN [Employees] AS e ON d.employee_number = e.employee_number";

        public const string SELECT_ALL_TRANSACTIONS = "SELECT transaction_id, card_number, security_code, expiration_date, amount_charged, transaction_completed FROM [Transactions]";

        public const string SELECT_ALL_PRODUCTS = "SELECT product_name, product_description, category, ean_number, case_size, current_quantity, reorder_regularly FROM [Inventory]";

        public const string SELECT_CUSTOMER_ID = "SELECT customer_id FROM [Customers] WHERE customer_id = '{0}'";

        public const string SELECT_CUSTOMER_ID_USING_POSTCODE = "SELECT customer_id FROM [Customers] WHERE post_code = '{0}'";

        public const string SELECT_USER_ACCOUNT_ID = "SELECT account_id FROM [User Accounts] WHERE account_id = '{0}'";

        public const string SELECT_EMPLOYEE_ID = "SELECT employee_id FROM [Employees] WHERE employee_id = '{0}'";

        public const string SELECT_EMPLOYEE_ID_USING_EMPLOYEE_NUMBER = "SELECT employee_id FROM [Employees] WHERE employee_number = '{0}'";

        public const string SELECT_USERNAME_USING_ACCOUNT_ID = "SELECT username FROM [User Accounts] WHERE account_id = '{0}'";

        public const string SELECT_RANDOM_PRODUCT_ID = "SELECT product_id FROM [Inventory] WHERE product_id = '{0}'";

        public const string SELECT_PRODUCT_USING_ID = "SELECT * FROM [Inventory] WHERE product_id = '{0}'";

        public const string SELECT_PRODUCT_USING_EAN_NUMBER = "SELECT * FROM [Inventory] WHERE ean_number = '{0}'";

        public const string SELECT_PRODUCT_ID_USING_EAN_NUMBER = "SELECT product_id FROM [Inventory] WHERE ean_number = '{0}'";

        // COUNT QUERIES

        public const string COUNT_EMPLOYEES = "SELECT COUNT(*) FROM [Employees]";

        public const string COUNT_ADMINS = "SELECT COUNT(*) FROM [Employees] WHERE admin_rights = 'True'";

        public const string COUNT_CUSTOMERS = "SELECT COUNT(*) FROM [Customers]";

        public const string COUNT_PRODUCTS = "SELECT COUNT(*) FROM [Inventory]";

        public const string COUNT_TRANSACTIONS = "SELECT COUNT(*) FROM [Transactions]";

        // INSERT QUERIES

        public const string INSERT_INTO_CUSTOMERS = "INSERT INTO [Customers] (customer_id, first_name, last_name, date_of_birth, sex, address_line_1, address_line_2, county, post_code, regular_customer) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}', '{9}')";

        public const string INSERT_INTO_ACCOUNTS = "INSERT INTO [User Accounts] (account_id, username, password) VALUES ('{0}', '{1}', '{2}')";

        public const string INSERT_INTO_EMPLOYEES = "INSERT INTO [Employees] (employee_id, account_id, employee_number, department, completed_training, admin_rights) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}')";

        public const string INSERT_INTO_EMPLOYEE_DETAILS = "INSERT INTO [Employee Details] (person_id, employee_number, first_name, last_name, date_of_birth, sex, address_line_1, address_line_2, county, post_code) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}', '{9}')";

        public const string INSERT_INTO_TRANSACTIONS = "INSERT INTO [Transactions] (transaction_id, employee_number, customer_id, card_number, security_code, expiration_date, amount_charged, transaction_completed) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}')";

        public const string INSERT_INTO_INVENTORY = "INSERT INTO [Inventory] (product_id, product_name, product_description, product_image, category, ean_number, case_size, current_quantity, reorder_regularly) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}')";

        // UPDATE QUERIES

        public const string UPDATE_CUSTOMER_DETAILS = "UPDATE [Customers] SET first_name = '{0}', last_name = '{1}', date_of_birth = '{2}', sex = '{3}', address_line_1 = '{4}', address_line_2 = '{5}', county = '{6}', post_code = '{7}', regular_customer = '{8}' WHERE customer_id = '{9}'";

        public const string UPDATE_EMPLOYEE_DETAILS = "UPDATE [Employee Details] SET first_name = '{0}', last_name = '{1}', date_of_birth = '{2}', sex = '{3}', address_line_1 = '{4}', address_line_2 = '{5}', county = '{6}', post_code = '{7}' WHERE employee_number = '{8}'";

        public const string UPDATE_EMPLOYEE_WORK_DETAILS = "UPDATE [Employees] SET department = '{0}', completed_training = '{1}', admin_rights = '{2}' WHERE employee_number = '{3}'";

        public const string UPDATE_ACCOUNT_DETAILS = "UPDATE [User Accounts] SET username = '{0}', password = '{1}' WHERE account_id = '{2}'";

        public const string UPDATE_PRODUCT_DETAILS = "UPDATE [Inventory] SET product_name = '{0}', product_description = '{1}', product_image = '{2}', category = '{3}', ean_number = '{4}', case_size = '{5}', current_quantity = '{6}', reorder_regularly = '{7}' WHERE product_id = '{8}'";

        public const string UPDATE_PASSWORD = "UPDATE [User Accounts] SET password = '{0}' WHERE username = '{1}'";

        // DELETE QUERIES

        public const string DELETE_CUSTOMER = "DELETE FROM [Customers] WHERE customer_id = '{0}'";

        public const string DELETE_EMPLOYEE = "DELETE FROM [Employees] WHERE employee_id = '{0}'";
        
        public const string DELETE_EMPLOYEE_DETAILS = "DELETE FROM [Employee Details] WHERE employee_number = '{0}'";

        public const string DELETE_ACCOUNT = "DELETE FROM [User Accounts] WHERE account_id = '{0}'";

        public const string DELETE_TRANSACTION_HISTORY = "DELETE FROM [Transactions] WHERE customer_id = '{0}'";

        public const string DELETE_PRODUCT = "DELETE FROM [Inventory] WHERE product_id = '{0}'";
    }
}