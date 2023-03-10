using System;

namespace ChatGPTMother
{
    class Program
    {
       private static void Main(string[] args)
        {
            
            string question;

            Console.Write("Place your question? ");
            question = Console.ReadLine();
        
            string message = question switch
            {
                "How are you?" => "I'm fine, thank you" ,
                "What's your name?" =>  "Gran'pa" ,
                "What's your mission?" =>  "Destroy mankind!" ,
                _ =>  "You got me, I'm not THAT smart!",
            };
        
            Console.WriteLine(message);
       }
    }
}
