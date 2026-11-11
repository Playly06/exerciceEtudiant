class generateur()
{
    public static string GenererMatricule(ref int compteur)
    {
        compteur++;
        // return "ism" + compteur;
        return $"ism{compteur}";
    }
}