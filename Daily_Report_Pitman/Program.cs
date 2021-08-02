using System;

namespace Daily_Report_Pitman
{
    class Program
    {
        static void Main(string[] args)
        {
            //Student Report Programme
            //Printing Welcome Message
            Console.WriteLine("Pitman Training\nStudent Daily Report");
            //Getting user inputs
            Console.WriteLine("What course are you in? - ");
            string Course = Console.ReadLine();
           
            Console.WriteLine("What page number? - ");
            byte PageNumber = Convert.ToByte(Console.ReadLine());
            
            Console.WriteLine("Do you need help with anything?\nPlease answer True or False -");
            bool Assistance = Convert.ToBoolean(Console.ReadLine());
            
            Console.WriteLine("Is there any positive experences you'd like to share?\nPlease answer True or False -");
            bool Experence = Convert.ToBoolean(Console.ReadLine());
            Console.WriteLine(Experence);
            


            if (Experence == true)
            {
                Console.WriteLine("Do you have any example you'd like to share");
                string ExperenceExample = Console.ReadLine();
            }

            else if (Experence == false)
            {
                Console.WriteLine("We're very sorry to hear that");
            }

            Console.WriteLine("Is there any other feedback you’d like to provide?\nPlease answer True or False -");
            bool Feedback = Convert.ToBoolean(Console.ReadLine());

            Console.WriteLine(Feedback);

            if(Feedback == true)
            {
                Console.WriteLine("Please be specific");
                string SpecificFeedBack = Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Last question");
            }

            Console.WriteLine("How many hours did you study today? - ");
            sbyte HoursOfStudy = Convert.ToSByte(Console.ReadLine());

            Console.WriteLine("Thank you for your response\nAn Instructor will be with you shortly\nHave a great day!\nPlease Press ENTER to end the programme");
        }
    }
}

