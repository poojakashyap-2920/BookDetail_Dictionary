using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace AddressBook_Dictionary
{
    public class BookDetails
    {
        Dictionary<string, (string, int publish_year, double prize)> Book_Details { get; set; }
        public BookDetails() {
            Book_Details = new Dictionary<string, (string, int publish_year, double prize)> ();
        }

        public void AddBookDetail()
        {
         
            string book_name = ValidateInputNumeric("enter book_name" , "message");

          
            string author_name = ValidateInputNumeric("enter author_name", "message");

          
            int year = int.Parse(InputValidInteger("enter published year", 4));

            
            double book_prize = double.Parse(InputValidInteger("enter book prize",  8));                              //double.Parse(Console.ReadLine());
           
            if (!Book_Details.ContainsKey(book_name)) {
                Book_Details.Add(book_name, (author_name, year, book_prize));
            }
            else
            {
                Console.WriteLine("duplicate key please enter unique key...");
            }

        }

        public void ShowBookDetails()
        { 
            foreach(var book in Book_Details)
            {
                Console.WriteLine($"{book.Key} : {book.Value}");
            }
        }

        public void EditBookDetails()
        {
           
            string book_name = ValidateInputNumeric("enter book_name", "message");


            if (Book_Details.ContainsKey(book_name))
                {
              
                string author_name = ValidateInputNumeric("enter author_name", "message");


              
                int year = int.Parse(InputValidInteger("enter published year", 4));

              
                double book_prize = double.Parse(InputValidInteger("enter book prize", 8));
                Book_Details[book_name] = (author_name,year, book_prize);
               }
              else
               {
                Console.WriteLine($"{book_name} not contains inside a dictionary");
               }
        }
        public void SearchBookDetail()
        {
          
        
            string book_name = ValidateInputNumeric("enter book_name", "message");
            if ( Book_Details.ContainsKey(book_name))
            {
           
                     var newvalue = Book_Details[book_name];
                    Console.WriteLine($"{book_name}  {newvalue} ");
               
            }
            else { Console.WriteLine($"{book_name} not contains in dictinory.."); }
           
        }
        public void DeleteBookDetail()
        {
           
            string book_name = ValidateInputNumeric("enter book_name", "message");



            if (Book_Details.ContainsKey(book_name))
            {
                foreach (var book in Book_Details)
                {
                    Book_Details.Remove(book_name);
                }
            }
        }

        public string ValidateInputNumeric(string prompt, string validationMessage)
        {
            string input;
            while (true)
            {
                Console.WriteLine(prompt);
                input = Console.ReadLine();
                try
                {
                    if (!Regex.IsMatch(input, @"^[A-Z][A-Za-z]{2,15}$"))
                    {
                        throw new Exception("string start with Upper case Minnimum 3 char Maximum 15 character");
                    }
                    break;
                }
                catch (Exception e)
                {
                    Console.WriteLine("Invalid input: " + e.Message);
                }
            }
            return input;
        }

        public string InputValidInteger(string prompt, int len)
        {
            string input;
            while (true)
            {
                Console.WriteLine(prompt);
                input = Console.ReadLine();
                if (input != null)
                {
                    try
                    {
                        if (!Regex.IsMatch(input, @"^[0-9]{3,8}$"))
                        {
                            throw new Exception("Enter only digits, minimum 3 and maximum 8 digits allowed.");
                        }
                        break;
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("Invalid input: " + e.Message);
                    }
                }
                else
                {
                    Console.WriteLine("Input value is null.");
                }
            }
            return input;
        }
    }
}
