namespace types_of_linq
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Language Integrated Query (LINQ) in C# provides a consistent model for working with
            // data across various kinds of data sources and formats. There are several types of LINQ
            // based on the type of data source being queried. Here are the main types of LINQ:

            // 1. LINQ to Objects - Queries In-Memory Collections like arrays, lists and IEnumerable<T>
            /*
                    int[] numbers = { 1, 2, 3, 4, 5 };
                    var evenNumbers = from n in numbers
                                      where n % 2 == 0
                                      select n;
             */

            // 2. LINQ to SQL - It translates LINQ queries to SQL Queries.
            /*
                    DataContext db = new DataContext(connectionString);
                    Table<Customer> customers = db.GetTable<Customer>();
                    
                    var query = from c in customers
                                where c.City == "Seattle"
                                select c;
            */

            // 3. LINQ to XML (XLINQ) - Queries and manipulates XML data. Uses `XDocument`, `XElement`.
            /*
                     XDocument doc = XDocument.Load("data.xml");
                     var query = from e in doc.Descendants("Customer")
                                where (string)e.Element("City") == "Seattle"
                                select e;
            */

            // 4. LINQ to DataSet - Often used to filter, enumerate, and create projections of
            //                      DataTables.
            /*
                     DataSet ds = GetDataSet();
                     var query = from row in ds.Tables["Orders"].AsEnumerable()
                                 where row.Field<string>("City") == "Seattle"
                                 select row;
            */

            // 5. LINQ to Entities - Queries the EF object context, translate LINQ queries to db queries.
            /*
                     using (var context = new MyDbContext())
                     {
                            var query = from c in context.Customers
                                        where c.City == "Seattle"
                                        select c;
                     }   
            */

            // 6. Parallel LINQ (PLINQ) - Parallel implementation of LINQ to Objects that uses multiple
            //                            threads to perform queries.
            /*
                    int[] numbers = { 1, 2, 3, 4, 5 };
                    var evenNumbers = numbers.AsParallel()
                                             .Where(n => n % 2 == 0)
                                             .ToArray();
            */

            // 7. LINQ to JSON - Queries JSON data, often using libraries such as Json.NET.
            /*
                     string json = @"[{ 'Name': 'John', 'City': 'Seattle' }, { 'Name': 'Jane', 'City': 'New York' }]";
                     JArray jsonArray = JArray.Parse(json);
                     var query = from person in jsonArray
                                 where (string)person["City"] == "Seattle"
                                 select person;
            */
        }
    }
}
