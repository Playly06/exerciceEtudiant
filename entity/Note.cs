namespace ExoCS.entiy;
using static ExoCS.entiy.Etudiant;
class Note {
    private int id;
    private string matiere;
    private double resultat;
    private Etudiant etudiant;
    public Note(string matiere, double resultat)
    {
        this.matiere=matiere;
        this.resultat=resultat;
    }

    public string getMatiere()
    {
        return this.matiere;
    }
    public double getResultat()
    {
        return this.resultat;
    }
    public Etudiant getEtudiant(){
        return this.etudiant;
    }
}