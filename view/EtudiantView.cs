namespace ExoCS.view;
using ExoCS.dto;
using ExoCS.service;
using ExoCS.entiy;
class EtudiantView
{
    public static void SaisieEtudiant()
    {
        EtudiantDto etudiantDto=new EtudiantDto(inputs.LireChaine("Nom : "), inputs.LireChaine("Prénom : "), []);
        EtudiantService.getInstance().ajouterEtudiant(etudiantDto);
    }
    public static void AfficherEtudiants()
    {
        EtudiantService.getInstance().afficherEtudiants().ForEach(e => Console.WriteLine($"Matricule : {e.getMatricule()} ; Nom : {e.getNom()} ; Prénom : {e.getPrenom()}"));
    }
    public static void AfficherNotesDunEtudiant()
    {
        NoteService.getInstance().afficherNotesDunEtudiant(inputs.LireInt("matricule : ")).ForEach(n => Console.WriteLine($"matiere : {n.getMatiere()} ; Resultat : {n.getResultat()} "));
    }
}
