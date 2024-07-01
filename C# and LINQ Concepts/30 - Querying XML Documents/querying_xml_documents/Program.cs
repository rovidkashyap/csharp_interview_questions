using System;
using System.Linq;
using System.Xml.Linq;

namespace querying_xml_documents
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // LINQ (Language Integrated Query) in C# provides robust support for querying XML
            // documents through LINQ to XML. LINQ to XML allows developers to query, create, modify,
            // and manipulate XML data using LINQ syntax and operators, making it intuitive and
            // efficient to work with XML in C#.

            // XML string representing a bookstore
            string xmlString = @"
                    <bookstore>
                        <book category='fiction'>
                            <title>Great Expectations</title>
                            <author>Charles Dickens</author>
                        </book>
                        <book category='fiction'>
                            <title>War and Peace</title>
                            <author>Leo Tolstoy</author>
                        </book>
                        <book category='nonfiction'>
                            <title>The ELements of Style</title>
                            <author>William Strunk Jr.</author>
                        </book>
                    </bookstore>";

            // Parse the XML string into an XDocument
            XDocument doc = XDocument.Parse(xmlString);

            // LINQ query to find all fiction books
            var fictionBooks = from book in doc.Descendants("book")
                               where (string)book.Attribute("category") == "fiction"
                               select new
                               {
                                   Title = (string)book.Element("title"),
                                   Author = (string)book.Element("author")
                               };

            // OUtput the result
            foreach (var book in fictionBooks)
            {
                Console.WriteLine($"Title: {book.Title}, Author: {book.Author}");
            }
        }
    }
}
