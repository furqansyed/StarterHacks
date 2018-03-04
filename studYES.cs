using System;
using static System.Console;

namespace StarterHacks
{
    class Program
    {
        static void Main(string[] args)
        {
            string leave = "";
            while(leave.Length == 0)
            {
                //Clearing Console before program start
                Clear();
                
                //Array of Names
                string[] names = {"James", "Will", "McBarthy", "Adams", "Owen", "Cheetos", "Abigail", "Johnson", "Emelia", "Shaw", "Caleb", "Lays",
                                    "Jierra", "Cagan", "Camnik", "Rhudha", "Lalison", "Uo", "Kevan", "Aklamanos", "Surqan", "Fyed", "Matthew", "Willis",
                                    "Natasha", "Jordan", "Kyle", "Liam", "Agshan", "Alishba", "Ayesha", "Sean", "Satveer", "Ranveer", "Miguel", "Cameroon",
                                    "James", "Gordon", "Asnee", "Abel", "Nick", "Muhammad", "Hamza", "Rachel", "Charlie", "Garrett", "Willett", "Gorbet",
                                    "Jeff", "Jess", "Shannon", "Adele", "Megan", "Mabel", "Erin", "Holly", "Alexander", "Dana", "Tigger", "Krista", "Tessa", 
                                    "Scott", "Sebastian", "Rachel", "Farah", "Hanan", "Naushin", "Rajpreet", "Karmjot", "Salma", "Kajol", "Parvir", "Sasha", 
                                    "Ksenja", "Roger", "Gerald", "Pav", "Mickey", "Zack", "Laila", "Meena"};
                
                //Random Number Generator
                Random rnd = new Random();
                
                //Array of People
                Person[] person = new Person[100];
                for(int i = 0; i < person.Length; i++)
                    person[i] = new Person((names[rnd.Next(1, names.Length)] + " " + names[rnd.Next(1, names.Length)]), rnd.Next(18, 30), rnd.Next(0, 5), rnd.Next(0, 6), rnd.Next(0, 3), rnd.Next(0, 2), rnd.Next(0, 4));
                
                
                //Introduction
                WriteLine("");
                WriteLine("Welcome to studYES!");
                
                //Finding Name
                WriteLine("What is your name?");
                string name = ReadLine();
                
                //Finding Age only allowing range 10 - 99
                WriteLine("");
                WriteLine("How old are you?");
                string Age = ReadLine();
                while(Age.Length != 2 || ((int)Age[0] < 48 || (int)Age[0] >57 || (int)Age[1] < 48 || (int)Age[1] > 57 ) || (int.Parse(Age) < 10)) 
                {
                    Clear();
                    WriteLine("");
                    WriteLine("Invalid Answer. Please Try Again.");
                    WriteLine("");
                    WriteLine("How old are you?");
                    Age = ReadLine();
                }
                int age = int.Parse(Age);

                Clear();
                //Finding Faculty
                WriteLine("");
                WriteLine("What is your faculty?");
                WriteLine("0 - Engineering");
                WriteLine("1 - Science");
                WriteLine("2 - Applied Health Sciences");
                WriteLine("3 - Arts");
                WriteLine("4 - Math");
                string fac = ReadLine();
                while(fac.Length != 1 || ((int)fac[0] < 48 || (int)fac[0] > 52))
                {
                    Clear();
                    WriteLine("");
                    WriteLine("Invalid Answer. Please Try Again.");
                    WriteLine("");
                    WriteLine("What is your faculty?");
                    WriteLine("0 - Engineering");
                    WriteLine("1 - Science");
                    WriteLine("2 - Applied Health Sciences");
                    WriteLine("3 - Arts");
                    WriteLine("4 - Math");
                    fac = ReadLine();
                }
                int faculty = int.Parse(fac);
                
                //Finding Subject
                WriteLine("");
                WriteLine("What subject are you seeking a study buddy for?");
                WriteLine("0 - MATH 126");
                WriteLine("1 - MATH 136");
                WriteLine("2 - MATH 146");
                WriteLine("3 - BIOL 130");
                WriteLine("4 - BIOL 245");
                WriteLine("5 - BIOL 273");
                WriteLine("6 - CS 135");
                WriteLine("7 - CS 136");
                WriteLine("8 - CHEM 120");
                WriteLine("9 - CHEM 130");
                string sub = ReadLine();
                while(sub.Length != 1 || ((int)sub[0] < 48 || (int)sub[0] > 57))
                {
                    Clear();
                    WriteLine("");
                    WriteLine("Invalid Answer. Please Try Again.");
                    WriteLine("");
                    WriteLine("What subject are you seeking a study buddy for?");
                    WriteLine("0 - MATH 126");
                    WriteLine("1 - MATH 136");
                    WriteLine("2 - MATH 146");
                    WriteLine("3 - BIOL 130");
                    WriteLine("4 - BIOL 245");
                    WriteLine("5 - BIOL 273");
                    WriteLine("6 - CS 135");
                    WriteLine("7 - CS 136");
                    WriteLine("8 - CHEM 120");
                    WriteLine("9 - CHEM 130");
                    sub = ReadLine();
                }
                int subject = int.Parse(sub);
                
                Clear();
                //Finding Availability
                WriteLine("");
                WriteLine("When are you available?");
                WriteLine("0 - Morning");
                WriteLine("1 - Afternoon");
                WriteLine("2 - Evening");
                string avail = ReadLine();
                while(avail.Length != 1 || ((int)avail[0] < 48 || (int)avail[0] > 50))
                {
                    Clear();
                    WriteLine("");
                    WriteLine("Invalid Answer. Please Try Again.");
                    WriteLine("");
                    WriteLine("What is your favourite subject?");
                    WriteLine("When are you available?");
                    WriteLine("0 - Morning");
                    WriteLine("1 - Afternoon");
                    WriteLine("2 - Evening");
                    avail = ReadLine();
                }
                int availability = int.Parse(avail);
                
                //Finding Personality
                WriteLine("");
                WriteLine("Do you consider yourself quiet or loud?");
                WriteLine("0 - Quiet");
                WriteLine("1 - Loud");
                string loud = ReadLine();
                while(loud.Length != 1 || ((int)loud[0] < 48 || (int)loud[0] > 49))
                {
                    Clear();
                    WriteLine("");
                    WriteLine("Invalid Answer. Please Try Again.");
                    WriteLine("");
                    WriteLine("Do you consider yourself quiet or loud?");
                    WriteLine("0 - Quiet");
                    WriteLine("1 - Loud");
                    loud = ReadLine();
                }
                int loudness = int.Parse(loud);
                
                
                //Finding Residence
                WriteLine("");
                WriteLine("Which residence do you stay in?");
                WriteLine("0 - Ron Eydt Village");
                WriteLine("1 - Village 1");
                WriteLine("2 - University Colleges");
                WriteLine("3 - Univeristy of Waterloo Place");
                string res = ReadLine();
                while(res.Length != 1 || ((int)res[0] < 48 || (int)res[0] > 51))
                {
                    Clear();
                    WriteLine("");
                    WriteLine("Invalid Answer. Please Try Again.");
                    WriteLine("");
                    WriteLine("Which residence do you stay in?");
                    WriteLine("0 - Ron Eydt Village");
                    WriteLine("1 - Village 1");
                    WriteLine("2 - University Colleges");
                    WriteLine("3 - Univeristy of Waterloo Place");
                    res = ReadLine();
                }
                int residence = int.Parse(res);
                
                //Creating user with given values
                Person user = new Person(name, age, faculty, subject, availability, loudness, residence);
                
                //Final Display
                Clear();
                WriteLine($"Thanks for making your account, {name}!");
                WriteLine("");
                
                //Finding number of matches
                int count = 0;
                for(int i = 0; i < person.Length; i++)
                {
                    if(user.match(person[i]))
                        count++;
                }
                
                //If no matches
                if(count == 0)
                {
                    WriteLine("Unfortunately you have not matched with any users!");
                    WriteLine("Change your availability and try again!");
                }
                
                else
                {
                    WriteLine($"You have matched with {count} users:");
                    WriteLine("");
                    //Title Line
                    WriteLine("      NAME           AGE         FACULTY              SUBJECT      PERSONALITY         RESIDENCE");
                    for(int i = 0; i < person.Length; i++)
                    {
                        //Printing person information
                        if(user.match(person[i]))
                            person[i].toString();
                    }
                }
                 
                leave = ReadLine();
            }
        }
    }
        
    class Person
    {
        //Variables
        string name;
        int age;
        int faculty; //0 Engineering, 1 Science, 2 Applied Health Science, 3 Arts, 4 Mathematics
        int subject; //0 MATH 126, 1 MATH 136, 2 MATH 146, 3 BIOL 130, 4 BIOL 245, 5 BIOL 273, 6 CS 135, 7 CS 136, 8 CHEM 120, 9 CHEM 130
        int availability; //0 Morning, 1 Afternoon, 2 Evening
        int loudness; //0 Quiet, 1 Loud
        int residence; //0 Ron Eydt Village, 1 Village 1, 2 University Colleges, 3 University of Waterloo Place
        
        //Constructor
        public Person(string name, int age, int faculty, int subject, int availability, int loudness, int residence)
        {
            this.name = name;
            this.age = age;
            this.faculty = faculty;
            this.subject = subject;
            this.availability = availability;
            this.loudness = loudness;
            this.residence = residence;
        }
        
        //Method to see if they match another person
        public bool match(Person a)
        {
            return (age == a.age || faculty == a.faculty || subject == a.subject || loudness == a.loudness || residence == a.residence) && availability == a.availability;
        }
        
        //Printing Method
        public void toString()
        {          
            //Converting age to string
            string a = age.ToString();
            
            //Converting faculty to string
            string fac ="";
            if (faculty == 0)
                fac = "Engineering";
            else if(faculty == 1)
                fac = "Science";
            else if(faculty == 2)
                fac = "Applied Health Sciences";
            else if(faculty == 3)
                fac = "Arts";
            else 
                fac = "Mathematics";
            
            //Converting subject to string
            string sub ="";
            if (subject == 0)
                sub =("MATH 126");
            else if(subject == 1)
                sub =("MATH 136");
            else if(subject == 2)
                sub =("MATH 146");
            else if(subject == 3)
                sub =("BIOL 130");
            else if(subject == 4)
                sub =("BIOL 245");
            else if(subject == 5)
                sub =("BIOL 273");
            else if(subject == 6)
                sub =("CS 135");
            else if(subject == 7)
                sub =("CS 136");
            else if(subject == 8)
                sub =("CHEM 120");
            else
                sub =("CHEM 130");
            
            //Converting availability to string if required in future
            //~ string avail ="";
            //~ if (availability == 0)
                //~ avail = "Morning";
            //~ else if(availability == 1)
                //~ avail = "Afternoon";
            //~ else
                //~ avail = "Evening";

            //Converting loudness to string
            string loud ="";
            if (loudness == 0)
                loud = "Quiet";
            else
                loud = "Loud";

            //Converting residence to string
            string res ="";
            if (residence == 0)
                res = "Ron Eydt Village";
            else if(residence == 1)
                res = "Village 1";
            else if(residence == 2)
                res = "University Colleges";
            else
                res = "University of Waterloo Place";

            //Final Message
            WriteLine($"{name,-20} {age,-3}   {fac, -24}   {sub,-10}      {loud,-6}       {res}");
        }
    }
}
