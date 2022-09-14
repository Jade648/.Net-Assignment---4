using System;
using System.IO;
using NLog.Web;

namespace TicketingSystem
{
	class Program
	{
		static void Main(string[] args)
		{
            string file = "movies.csv";
            
            string ratings = "ratings.csv";
            
            string tags = "tags.csv";
            
			string choice;
            
            do
            {
                
                Console.WriteLine("1) Read data from file.");

                Console.WriteLine("2) Check if file exists.");

                Console.WriteLine("3) Enter any other key to exit.");
                
                choice = Console.ReadLine();

                if (choice == "1")
                {
                    StreamWriter sw = new StreamWriter(file,append:true);
                    for(int i =0; i < 7; i++) {
                        
                        {
                            Console.WriteLine("Movie Title");

                          string movie = Console.ReadLine().ToUpper();

                          Console.WriteLine("Enter the movie's rating");

                          string rating = Console.ReadLine().ToUpper();

                          Console.WriteLine("Enter the movie's tags");

                          string genres = Console.ReadLine().ToUpper();
                           
                           sw.WriteLine (movie);

                           sw.WriteLine(ratings);

                           sw.WriteLine(genres);
                        }

                    } if (choice == "2"){

                         if (File.Exists(file)){
                         
                         StreamReader sr = new StreamReader(file);

                         while (!sr.EndOfStream){

                            string line = sr.ReadLine();

                            string [] arr = line.Split('|');

                            Console.WriteLine("choice: {0}, choice: {1},choice {2}", arr [0],arr [1],arr[2]);

                         }

                         sr.Close();   
                    }            

                    }else if (choice == "3")
                    {
                         Console.WriteLine("File does not exist");
                    }       
                   
                }     
                
            } while (choice == "1" || choice == "2");

        } 
    } 
}
 
     
        