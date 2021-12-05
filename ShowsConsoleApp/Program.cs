﻿using System;

namespace ShowsConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {

            Series[] ShowsToCompere = new Series[] {
                new Series("Friends", "Commedy", 100),
                new Series("How I Met Youre Mother", "commedy", 60),
                new Series("Rick An d Morty", "Commey", 50)};

            //Array.Sort(ShowsToCompere);

            //foreach (Series s in ShowsToCompere)
            //{
            //    Console.WriteLine(s.numberOfEps);
            //}

            //List  <T> ShowsList = new List<T>();

            int counter = 0;

            while (counter < 6)
            {
                ShowMenu();
                counter++;

            }




        }

        static void ShowMenu()
        {


            Console.WriteLine("Welcome To Show Menu , please select :");
            Console.WriteLine("1.Add Series ");
            Console.WriteLine("2.Show Series info");
            Console.WriteLine("3.Add an episode");
            Console.WriteLine("4.Show all Series existent");
            int userSelect = int.Parse(Console.ReadLine());


            switch (userSelect)
            {
                case 1:

                    Console.WriteLine("please enter detailes; name ,genre and numbers of  episode ");
                    string nameToAdd = Console.ReadLine();
                    string genreToAdd = Console.ReadLine();
                    int numberOfEpsToAdd = int.Parse(Console.ReadLine());
                    AddSeriesFunction(nameToAdd, genreToAdd, numberOfEpsToAdd);

                    break;

                case 2:
                    Console.WriteLine("Please enter Show name:");
                    string showName = Console.ReadLine();
                    ShowSeriesInfoAndAllInfo(showName);
                    break;

                case 3:


                    break;

                case 4:
                    ShowSeriesInfoAndAllInfo("SeriesThatAdd");
                    break;

                default:
                    Console.WriteLine("Something went wrong, enter a number between 1-4.");
                    ShowMenu();
                    break;
            }


        }




        static void AddSeriesFunction(string name, string genre, int numberOfEps)
        {
            try { 
            Series addEvent = new Series(name, genre, numberOfEps);
            FileStream fileStream = new FileStream(@$"C:\Users\edent\OneDrive\שולחן העבודה\טק קריירה\C#\02.12.2021\shows files\{name}", FileMode.Append);
            using (StreamWriter writer = new StreamWriter(fileStream))
            {
                writer.WriteLine($"•Name :{addEvent.name} , Genre :{addEvent.genre},  Number Of episode:{addEvent.numberOfEps}");
                Console.WriteLine($"•Name :{addEvent.name} , Genre :{addEvent.genre},  Number Of episode:{addEvent.numberOfEps}");
            }

            ShowInfo(addEvent);}
            catch(FormatException) {
                Console.WriteLine("ERRROROROOR");
            };
        }

        static void ShowInfo(Series addEvent)
        {
            FileStream fileStreamAll = new FileStream(@"C:\Users\edent\OneDrive\שולחן העבודה\טק קריירה\C#\02.12.2021\shows files\SeriesThatAdd", FileMode.Append);
            using (StreamWriter writer = new StreamWriter(fileStreamAll))
            {
                writer.WriteLine($"•Name :{addEvent.name} , Genre :{addEvent.genre},  Number Of episode:{addEvent.numberOfEps}");
            }
        }




        static void ShowSeriesInfoAndAllInfo(string ShowName)
        {
            FileStream fileStream = new FileStream(@$"C:\Users\edent\OneDrive\שולחן העבודה\טק קריירה\C#\02.12.2021\shows files\{ShowName}", FileMode.Open);
            using (StreamReader reader = new StreamReader(fileStream))
            {
                Console.WriteLine(reader.ReadToEnd());
            }
        }


        static void AddToEps(Series nameOfSer)
        {
            FileStream fileStream = new FileStream(@$"C:\Users\edent\OneDrive\שולחן העבודה\טק קריירה\C#\02.12.2021\shows files\{nameOfSer}", FileMode.Append);
            using (StreamWriter writer = new StreamWriter(fileStream))
            {
                writer.WriteLine(nameOfSer.numberOfEps + 1); ;
            }
        }





    }
}