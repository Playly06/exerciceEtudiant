class inputs
{
    public static string LireChaine(string msg)
    {
        string? chaine;
        do
        {
            Console.WriteLine(msg);
            chaine = Console.ReadLine();
        } while (chaine == null);
        return chaine;
    }

    public static double LireDouble(string msg)
    {
        bool result = false;
        double choix = 0;
        do
        {
            Console.WriteLine(msg);
            result = double.TryParse(Console.ReadLine(), out choix);
        } while (!result);
        return choix;
    }

    

}