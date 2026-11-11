class EtudiantService
{
    public static void ajouterEtudiant(Etudiant etudiant)
    {
        EtudiantRepository.addEtudiant(etudiant);
    }

    public static List<Etudiant>? afficherEtudiants()
    {
        return EtudiantRepository.GetEtudiants();
    }

    public static bool ajouterNoteEtudiant(double note, string matricule)
    {
        return EtudiantRepository.AddNote(note, matricule);
    }

    public static Etudiant? afficherEtudiantparUnMatricule(string matricule)
    {
        return EtudiantRepository.GetEtudiantByMatricule(matricule);
    }
}
