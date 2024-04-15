Console.WriteLine("Does the site fall under the universal category? y or n");
string planning_type = Console.ReadLine();

if (planning_type == "y")
{
    Console.WriteLine("Planning permission needed");
}
// Check the conditions of other categories
if (planning_type == "n")
{
    Console.WriteLine("Is it adjacent to a highway? y or n");
    string highway = Console.ReadLine();
    // if it is next to the highway then is it above 1m tall
    if (highway == "y")
    {
        Console.WriteLine("Above 1m tall? y or n");
        string above1m = Console.ReadLine();
        if (above1m == "y")
        {
            Console.WriteLine("Planning permission needed");
        }
        else
        {
            Console.WriteLine("No planning needed");
        }
    }
    // if it is not next to the highway then is it above 1m tall
    else
    {
        Console.WriteLine("Above 2m tall? y or n");
        string above1m = Console.ReadLine();
        if (above1m == "y")
        {
            Console.WriteLine("Planning permission needed");
        }
        else
        {
            Console.WriteLine("No planning needed");
        }
    }
}