class EtudiantView
{
    public static Etudiant SaisieEtudiant(ref int compteur)
    {
        Etudiant etudiant=new Etudiant(generateur.GenererMatricule(ref compteur), inputs.LireChaine("Nom : "), inputs.LireChaine("Prénom : "), []);
        return etudiant;
    }
    public static void AfficherEtudiants()
    {
        EtudiantService.afficherEtudiants().ForEach(e => Console.WriteLine($"Matricule : {e.getMatricule} ; Nom : {e.getNom} ; Prénom : {e.getPrenom}"));
    }

    public static Etudiant AfficherEtudiant(string matricule)
    {
        return EtudiantService.afficherEtudiantparUnMatricule(matricule);
    }
}
