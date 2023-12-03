using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello! This is the event program.");
        Console.WriteLine();

        //Addresses
        Address address1 = new Address("455 lukeman street", "Adenta", "Greater Accra", "Ghana");
        Address address2 = new Address("477 Valley street", "Oyibi", "Greater Accra", "Ghana");
        Address address3 = new Address("567 west street", "Lapaz", "Greater Accra", "Ghana");

        //events

        Lecture lecture = new Lecture("Health talk", "Learn more about prevailing health issues", 
        "29th December 2023", "5:00 PM", address2, "Lecture", "Doctor Appiah", 150);

        OutDoorGathering outDoorGathering = new OutDoorGathering("Expect Partly cloudy weather", "Picnic at the Beach", "Family Picnic",
        "30th December 2023", "10:00 am", address1, "OutDoor Gathering");

        Reception reception = new Reception("(+233)59-543-3445","Wedding Reception", "To celebrate James and Mary", "1st January, 2023",
        "2:00 PM", address3, "Reception");


        //Generate various messages
        //Lecture
        Console.WriteLine("Lecture Event:\n");
        Console.WriteLine(lecture.GetStandardDetails());
        Console.WriteLine();

        Console.WriteLine($"Full Details:\n{lecture.GetFullDetails()}");
        Console.WriteLine();
        Console.WriteLine($"Short Description:\n{lecture.GetShortDescription()}\n");

        //Outdoor Gathering
        Console.WriteLine("Outdoor Gathering:\n");
        Console.WriteLine(outDoorGathering.GetStandardDetails());
        Console.WriteLine();

        Console.WriteLine($"Full Details:\n{outDoorGathering.GetFullDetails()}");
        Console.WriteLine();
        Console.WriteLine($"Short Description:\n{outDoorGathering.GetShortDescription()}\n");

        // reception
        Console.WriteLine("Reception:\n");
        Console.WriteLine(reception.GetStandardDetails());
        Console.WriteLine();

        Console.WriteLine($"Full Details:\n{reception.GetFullDetails()}");
        Console.WriteLine();
        Console.WriteLine($"Short Description:\n{reception.GetShortDescription()}\n");
    }
}