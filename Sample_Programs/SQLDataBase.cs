using Amazon.DynamoDBv2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample_Programs
{
    internal class SQLDataBase
    {

        public static void SQLQueries()
        {

            //  Select DISTINCT column1, column2 FROM table_name;

/* INSERT INTO Customers (CustomerName, ContactName, Address, City, PostalCode, Country)
VALUES('Cardinal', 'Tom B. Erichsen', 'Skagen 21', 'Stavanger', '4006', 'Norway'); */

    

/* UPDATE Customers
SET ContactName = 'Alfred Schmidt', City= 'Frankfurt'
WHERE CustomerID = 1; */

/* SELECT Orders.OrderID, Customers.CustomerName
FROM Orders
INNER JOIN Customers ON Orders.CustomerID = Customers.CustomerID;
*/

}
}
}
