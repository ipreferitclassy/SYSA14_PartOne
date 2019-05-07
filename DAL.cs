using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SYSA14_Biljettbokning
{
    class DAL
    {

        //---------------------------------DAL Handeling of customer---------------------------------

        public DataTable GenerateACustomerTable (int customerID)
        {

            String connectionString = "Data Source=CS-LegionY720;Initial Catalog=SYSA14_Biljettbokning_DB;Integrated Security=True;Pooling=False";
            DataTable theTable = new DataTable();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand("SELECT * FROM Customer WHERE customerID = @value1 ", connection);
                connection.Open();
                command.Prepare();
                command.Parameters.AddWithValue("@value1", customerID);

                SqlDataReader dataReader = command.ExecuteReader();

                if (dataReader.HasRows)
                {
                    theTable.Columns.Add("Kundens idnummer", typeof(int));
                    theTable.Columns.Add("Kundens namn", typeof(String));
                    theTable.Columns.Add("Kundens adress", typeof(String));
                    theTable.Columns.Add("Kundens email", typeof(String));

                    while (dataReader.Read())
                    {

                        String tempOne = dataReader.GetInt32(0).ToString();
                        String tempTwo = dataReader.GetString(1);
                        String tempThree = dataReader.GetString(2);
                        String tempFour = dataReader.GetString(3);
                        theTable.Rows.Add(new string[] { tempOne, tempTwo, tempThree, tempFour });

                    }

                }

            }

            //Returns a empty table if no customer where found, else return a filled table!
            return theTable;
        }

        public DataTable GenerateACustomerTable(String customerName)
        {
            String tempCustomerName = customerName;
        

            String connectionString = "Data Source=CS-LegionY720;Initial Catalog=SYSA14_Biljettbokning_DB;Integrated Security=True;Pooling=False";
            DataTable theTable = new DataTable();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand("SELECT * FROM Customer WHERE customerName LIKE '%'+@value2+'%'", connection);
                connection.Open();
                command.Prepare();
                command.Parameters.AddWithValue("@value2", tempCustomerName);

                SqlDataReader dataReader = command.ExecuteReader();

                if (dataReader.HasRows)
                {
                    theTable.Columns.Add("Kundens idnummer", typeof(int));
                    theTable.Columns.Add("Kundens namn", typeof(String));
                    theTable.Columns.Add("Kundens adress", typeof(String));
                    theTable.Columns.Add("Kundens email", typeof(String));

                    while (dataReader.Read())
                    {

                        String tempOne = dataReader.GetInt32(0).ToString();
                        String tempTwo = dataReader.GetString(1);
                        String tempThree = dataReader.GetString(2);
                        String tempFour = dataReader.GetString(3);
                        theTable.Rows.Add(new string[] { tempOne, tempTwo, tempThree, tempFour });

                    }

                }

            }

            //Returns a empty table if no customer where found, else return a filled table!
            return theTable;
        }

        public DataTable GenerateCustomerTableOverAllCustomers()
        {
            DataTable tempTable = new DataTable();

            String connectionString = "Data Source=CS-LegionY720;Initial Catalog=SYSA14_Biljettbokning_DB;Integrated Security=True;Pooling=False";
            String queryString = "SELECT * FROM Customer";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(queryString, connection);
                connection.Open();

                SqlDataReader dataReader = command.ExecuteReader();

                if (dataReader.HasRows)
                {
                    tempTable.Columns.Add("Kundens idnummer", typeof(int));
                    tempTable.Columns.Add("Kundens namn", typeof(String));
                    tempTable.Columns.Add("Kundens adress", typeof(String));
                    tempTable.Columns.Add("Kundens email", typeof(String));

                    while (dataReader.Read())
                    {
                        String tempOne = dataReader.GetInt32(0).ToString();
                        String tempTwo = dataReader.GetString(1);
                        String tempThree = dataReader.GetString(2);
                        String tempFour = dataReader.GetString(3);

                        tempTable.Rows.Add( new String [] {tempOne, tempTwo, tempThree, tempFour });
                    }


                }



            }

                return tempTable;
        }

        public bool SearchForCustomerViaCustomerID(int customerID)
        {
            bool resultOfMethod = false; 
            String connectionString = "Data Source=CS-LegionY720;Initial Catalog=SYSA14_Biljettbokning_DB;Integrated Security=True;Pooling=False";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand("SELECT * FROM Customer WHERE customerID = @value1 ", connection);
                connection.Open();
                command.Prepare();
                command.Parameters.AddWithValue("@value1", customerID);
                SqlDataReader dataReader = command.ExecuteReader();

                if (dataReader.HasRows)
                {
                    resultOfMethod = true;
                }

            }

                //If a customer with the provided customerID is found the method returns true)
                return resultOfMethod;
        }

        public bool AddingACustomer(int customerID, String customerName, String customerAddress, String customerEmail)
        {
            // Will only be used after a check if customer exist in DB!

            bool resultOfMethod = false;

            String connectionString = "Data Source=CS-LegionY720;Initial Catalog=SYSA14_Biljettbokning_DB;Integrated Security=True;Pooling=False";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {

                SqlCommand command = new SqlCommand("INSERT INTO Customer(customerID, customerName, customerAddress, customerEmail) VALUES(@Value1, @Value2, @Value3, @Value4)", connection);
                connection.Open();
                command.Prepare();
                command.Parameters.AddWithValue("@Value1", customerID);
                command.Parameters.AddWithValue("@Value2", customerName);
                command.Parameters.AddWithValue("@Value3", customerAddress);
                command.Parameters.AddWithValue("@Value4", customerEmail);

                int resultOfQueryExecution = command.ExecuteNonQuery(); 

                if (resultOfQueryExecution>0)
                {
                    resultOfMethod = true; 

                }

            }
                //Returns true if the customer where added! 
                return resultOfMethod; 
        }

        public bool DeletingACustomer (int customerID)
        {
            bool resultofMethod = false;
            String connectionString = "Data Source=CS-LegionY720;Initial Catalog=SYSA14_Biljettbokning_DB;Integrated Security=True;Pooling=False";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand("DELETE FROM Customer WHERE customerID = @Value1", connection);
                connection.Open();
                command.Prepare();
                command.Parameters.AddWithValue("@Value1", customerID);

                int resultOfQuery = command.ExecuteNonQuery(); 

                if (resultOfQuery > 0)
                {
                    resultofMethod = true; 
                }

            }
                // Return true if the customer where deleted successfully! 
                return resultofMethod; 
        } 




        //---------------------------------DAL Handeling of movie---------------------------------




        //---------------------------------DAL Handeling of booking---------------------------------












    }
}
