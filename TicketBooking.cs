using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketBookingSystem
{
    public class BookingId
    {
        int Id { get; set; }
        List<BookingId> obj = new List<BookingId>();

        public void CustomerList()
        {
            obj.Add(new BookingId
            {
                Id = 1,

            });
            obj.Add(new BookingId
            {
                Id = 2,

            });
            obj.Add(new BookingId
            {
                Id = 3,

            });
            obj.Add(new BookingId
            {
                Id = 4,

            });
            obj.Add(new BookingId
            {
                Id = 5,

            });
            obj.Add(new BookingId
            {
                Id = 6,

            });
            obj.Add(new BookingId
            {
                Id = 7,

            });
            obj.Add(new BookingId
            {
                Id = 8,

            });
        }
        public void CustomerDetails(int Id)
        {
            for (int i = 0; i < obj.Count; i++)
            {
                if (Id == obj[i].Id)
                {
                    Console.WriteLine("ID:" + obj[i].Id);
                }





            }

        }

        
        
    }
    public class CreateId
    {

        public void CustomerDetail()
        {
            FileStream fileStream = new FileStream(@"F:\\New folder\\bookID.txt", FileMode.Create, FileAccess.Write);
            StreamWriter writer = new StreamWriter(fileStream);

            Console.Write("Enter The id :");
            writer.Write(Console.ReadLine());

            writer.Dispose();
            writer.Close();
            fileStream.Close();

        }
    }
    public class Movies
    {
        public void Avlmovies()
        {
            FileStream fs = new FileStream(@"F:\New folder\movie.txt", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            Console.WriteLine("Available Movies:");
            while (sr.Peek() > 0)
            {
                string line = sr.ReadLine();
                if (line != null)
                    if (!line.StartsWith("AllMovie"))
                    {
                        string[] stg = line.Split(',');
                        Console.WriteLine(stg[0] + "\t" + stg[1]);
                    }
            }

        }
        public void findMovie()



        {
            String[] words = File.ReadAllText(@"F:\New folder\movie.txt").Split(',');
            Console.Write("Search Movie:\t");
            string st = Console.ReadLine();
            bool condition = false;
            for (int i = 0; i < words.Length; i++)
            {
                if (words[i].Contains(st) == true)
                {
                    condition = true;
                    Console.WriteLine("Movie Found", st);
                    break;
                }
                else
                {
                    Console.WriteLine("Movie Not Found", st);
                    condition = false;
                }
            }



        }
        public void cancellation()
        {
            string line = null;
            string line_to_delete = "the line i want to delete";
            using (StreamReader reader = new StreamReader("F:\\New folder\\movie.txt"))
            {
                using (StreamWriter writer = new StreamWriter("F:\\New folder\\dmovie.txt"))
                {
                    while ((line = reader.ReadLine()) != null)
                    {
                        if (String.Compare(line, line_to_delete) == 0)
                            continue;

                        writer.WriteLine(line);
                    }
                }
            }


        }
        public void moviebookingid()
        {

            FileStream Borrow = new FileStream(@"F:\New folder\dmovie.txt", FileMode.Open, FileAccess.Read);
            StreamReader BorrowD = new StreamReader(Borrow);
            Console.WriteLine("ID" + "\t" +"Movie Name");
            while (BorrowD.Peek() > 0)
            {
                string line = BorrowD.ReadLine(); 
                if (line != "")
                    if (!line.EndsWith("Name"))
                    {
                        string[] myStrs = line.Split(',');

                        Console.WriteLine(myStrs[0] + "\t" + myStrs[1]);
                    }
            }
        }
        public void Bookmovie()
        {
            {
                FileStream fd = new FileStream(@"F:\New folder\dmovie.txt", FileMode.Create, FileAccess.Write);
                StreamWriter sd = new StreamWriter(fd);
                Console.Write("Enter Id:");
                sd.Write(Console.ReadLine());
                Console.Write("Movie Name:");
                sd.Write(Console.ReadLine());

                sd.Close();
                fd.Close();
                Console.WriteLine("Completely Updated");
            }

        }

    }

}
    



