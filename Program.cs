
Movie[] movies = new Movie[5]
{
    new Movie("Inception", "2h 28m", 12.50),
    new Movie("Avatar: The Way of Water", "3h 12m", 15.00),
    new Movie("The Dark Knight", "2h 32m", 10.00),
    new Movie("Interstellar", "2h 49m", 11.50),
    new Movie("Spider-Man: Across the Spider-Verse", "2h 20m", 13.00)
};


Console.WriteLine("========================================");
Console.WriteLine("    WELCOME TO THE MOVIE BOOKING APP    ");
Console.WriteLine("========================================\n");

Console.Write("Enter Customer Name: ");
string customerName = Console.ReadLine()??"";

Console.Write("Enter Contact Number: ");
string contact = Console.ReadLine()??"";

Console.WriteLine("\n--- Available Movies ---");
for (int i = 0; i < movies.Length; i++)
{
    Console.WriteLine($"{i + 1}. {movies[i].Name} | Duration: {movies[i].Duration} | Price: ${movies[i].Price}");
}

int choice = 0;
while (choice < 1 || choice > movies.Length)
{
    Console.Write($"\nSelect a movie (1-{movies.Length}): ");
    if (!int.TryParse(Console.ReadLine(), out choice) || choice < 1 || choice > movies.Length)
    {
        Console.WriteLine("Invalid choice. Please select a valid movie number.");
    }
}

Movie chosenMovie = movies[choice - 1];

Console.Write("Enter Show Date (e.g., YYYY-MM-DD): ");
string date = Console.ReadLine()??"";

Console.Write("Enter Show Time (e.g., 06:30 PM): ");
string time = Console.ReadLine()??"";

Customer customer = new Customer(customerName, contact, chosenMovie, date, time);
customer.PrintTicket();






class Movie{
    public string Name;
    public string Duration;
    public double Price;

    public Movie(string name, string duration, double price)
    {
        Name = name;
        Duration = duration;
        Price = price;
    }
}

class Customer
{
    public string Name;
    public string Contact;
    public Movie SelectedMovie;
    public string ShowDate;
    public string ShowTime;

    public Customer(string name, string contact, Movie selectedMovie, string showDate, string showTime)
    {
        Name = name;
        Contact = contact;
        SelectedMovie = selectedMovie;
        ShowDate = showDate;
        ShowTime = showTime;
    }

    public void PrintTicket()
    {
        Console.WriteLine("\n========================================");
        Console.WriteLine("          BOOKING CONFIRMATION          ");
        Console.WriteLine("========================================");
        Console.WriteLine($"Customer Name  : {Name}");
        Console.WriteLine($"Contact Number : {Contact}");
        Console.WriteLine($"Movie Selected : {SelectedMovie.Name}");
        Console.WriteLine($"Movie Duration : {SelectedMovie.Duration}");
        Console.WriteLine($"Ticket Price   : ${SelectedMovie.Price}");
        Console.WriteLine($"Show Date      : {ShowDate}");
        Console.WriteLine($"Show Time      : {ShowTime}");
        Console.WriteLine("========================================");
        Console.WriteLine("   Thank you for booking with us!      ");
        Console.WriteLine("========================================");
    }
}
