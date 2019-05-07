using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SYSA14_Biljettbokning
{
    class Controller
    {
        DAL dal = new DAL();


        //---------------------------------Controller Handeling of customer---------------------------------

        public DataTable CSearchAndConstructACustomerTable (int customerID)
        {
            DataTable resultOfMethod = new DataTable();
            resultOfMethod = dal.GenerateACustomerTable(customerID);

            return resultOfMethod; 
        }

        public DataTable CSearchAndConstructACustomerTable(String customerName)
        {
            DataTable resultOfMethod = new DataTable();
            resultOfMethod = dal.GenerateACustomerTable(customerName);

            return resultOfMethod;
        }

        public DataTable CConstructCustomerTableOverAllCustomers()
        {
            DataTable tempTable = new DataTable();
            tempTable = dal.GenerateCustomerTableOverAllCustomers();

            return tempTable; 

        }

        public int CAddingACustomer(int customerID, String customerName, String customerAddress, String customerEmail)
        {
            int resultOfMethod = 1; 

            bool resultOfSearchForCustomerID = dal.SearchForCustomerViaCustomerID(customerID); 

            if (resultOfSearchForCustomerID == false)
            {
                bool resultOfAddingACustomer = dal.AddingACustomer(customerID, customerName, customerAddress, customerEmail);

                if (resultOfAddingACustomer == true)
                {
                    resultOfMethod = 2;
                }
            }
            //Returns 1 if the customer exist in the DB, and 2 if the customer did not exist and where added correctly!
            return resultOfMethod; 
        }

        public int CDeleteACustomer (int customerID)
        {
            int resultOfMethod = 1;

            bool resultOfSearchForCustomerID = dal.SearchForCustomerViaCustomerID(customerID);

            if (resultOfSearchForCustomerID == true)
            {
                bool resultOfDeletingACustomer = dal.DeletingACustomer(customerID);

                if (resultOfDeletingACustomer == true)
                {
                    resultOfMethod = 2; 

                }

            }
            //Returns 1 if the customer do not exist in the DB, and 2 if the customer did not exist and where added correctly!
            return resultOfMethod; 
        }




        //---------------------------------Controller Handeling of movie---------------------------------




        //---------------------------------Controller Handeling of booking---------------------------------





    }
}
