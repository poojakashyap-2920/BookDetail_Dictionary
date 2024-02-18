using AddressBook_Dictionary;

namespace Book_Details_dictionary
{
   public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("wel-come to book details project \n");
            BookDetails ob = new BookDetails();
            while (true)
            {
                Console.WriteLine("1.AddBookDetail\n"+
                    "2.ShowBookDetail\n"+
                    "3.EditBookDetail\n"+
                    "4.SearchBookDetail\n"+
                    "5.DeleteBookDetail");
                Console.WriteLine("enter option");
                int option =  int.Parse(Console.ReadLine());
                switch(option)
                {
                    case 1:ob.AddBookDetail();
                        Console.WriteLine("record added successfully");
                        break;
                        case 2:ob.ShowBookDetails(); Console.WriteLine("book record show"); break;
                        case 3:ob.EditBookDetails(); Console.WriteLine("record edit successfully"); break;
                        case 4:ob.SearchBookDetail(); Console.WriteLine(); break;
                        case 5:ob.DeleteBookDetail(); Console.WriteLine("record deleted successfully"); break;
                }

            }
        }
    }
}
