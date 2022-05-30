using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using TicketBookingSystem;


namespace TicketBookingSystem
{
    public class Program
    {
        public void loginAs()
        {
        loginmenu:
            Console.WriteLine("-------------------------------------");
            Console.WriteLine(" Lonin As Customer Press 1");
            Console.WriteLine(" Login As Admin Press 2");

            Console.WriteLine(" Exit Press 3");

            Console.WriteLine("______________________________________");
            int user = Convert.ToInt32(Console.ReadLine());
            switch (user)
            {
                case 1:
                    {
                    mainmenu:
                        mainMenu();
                        BookingId Librarian = new BookingId();
                        Movies movie = new Movies();   
                        int input = Convert.ToInt32(Console.ReadLine());
                        switch (input)
                        {
                            case 1:
                                Console.Write("Enter Id: ");
                                Librarian.CustomerDetails(Convert.ToInt32(Console.ReadLine()));
                                goto mainmenu;
                            case 2:
                                movie.findMovie();
                                goto mainmenu;
                            case 3:
                                movie.Avlmovies();
                                goto mainmenu;
                            case 4:
                                movie.Bookmovie();
                                goto mainmenu;


                            case 5:
                                Environment.Exit(0);
                                break;

                            default:
                                Console.WriteLine("Invalid Choise ");
                                goto mainmenu;






                        }
                    }
                    break;
                case 2:
                customerMainMenu:
                    customerMainMenu();
                    BookingId id = new BookingId();
                    Movies movies = new Movies();
                    int choise = Convert.ToInt32(Console.ReadLine());
                    switch (choise)
                    {
                        case 1:
                            movies.Avlmovies();
                            goto customerMainMenu;
                        
                        case 2:
                            movies.moviebookingid();
                            goto customerMainMenu;
                        case 3:
                            movies.findMovie();
                            goto customerMainMenu;
                        case 4:
                            Environment.Exit(0);
                            break;
                        default:
                            Console.WriteLine("Invalid Choise ");
                            goto customerMainMenu; ;
                    }
                    break;
                case 3:
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine(" bad Input ");
                    Console.WriteLine("try Again");
                    goto loginmenu;


            }


        }


        private void mainMenu()
        {
            Console.WriteLine("----------------Main Menu ----------------");
            Console.WriteLine("Enter Id Press-    : 1");
            Console.WriteLine("Search Movie Press-: 2");
            Console.WriteLine("All Movie Press-   : 3");
            Console.WriteLine("Book Movie Press   : 4");
            Console.WriteLine("Exit Press         : 5");


        }
        private void customerMainMenu()
        {



            Console.WriteLine("----------------------------------------");
            Console.WriteLine("Show All Movie Press         :1");
            Console.WriteLine("Booking Id Press             :2");
            Console.WriteLine("Find Movie Press             :3");
            Console.WriteLine("Exit Press                   :4");
        }
    }

}