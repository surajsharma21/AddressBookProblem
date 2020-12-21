using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace AddressBookProblem
{
    class FileIOOperation
    {
        private string filePath = @"C:\Users\Lenovo PC\source\repos\AddressBookProblem\AddressBookProblem\Utility\AddressBookRecord.txt";
        public void WriteToFile(Dictionary<string, AddressBook> addressBookDictionary)
        {
            using StreamWriter writer = new StreamWriter(filePath, true);
            foreach (AddressBook addressBookobj in addressBookDictionary.Values)
            {
                foreach (Contact contact in addressBookobj.addressBook.Values)
                {
                    writer.WriteLine(contact.ToString());
                }
            }
            Console.WriteLine("\nSuccessfully added to Text file.");
            writer.Close();
        }
        public void ReadFromFile()
        {
            Console.WriteLine("Below are Contents of Text File");
            string lines = File.ReadAllText(filePath);
            Console.WriteLine(lines);
        }
    }
}
