class EtudiantRepository{
    private static List<Etudiant> etudiants = new();

    public static void addEtudiant(Etudiant etudiant)
    {
        etudiants.Add(etudiant);
    }

    public static Etudiant? GetEtudiantByMatricule(string matricule)
    {
        return etudiants.FirstOrDefault(e => e.getMatricule() == matricule);
    }

    public static List<Etudiant>? GetEtudiants()
    {
        return etudiants;
    }
    public static bool AddNote(double note, string matricule)
    {
        Etudiant? etudiant = GetEtudiantByMatricule(matricule);
        if (etudiant is null)
        {
            Console.WriteLine("Le matricule ne correspond à aucun étudiant");
            return false;
        }
        etudiant?.getNotes().Add(note);
        return true;
    }
}