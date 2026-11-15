namespace ExoCS.entiy;
using static ExoCS.entiy.Note;

class Etudiant {
    private string matricule;
    private string nom;
    private string prenom;
    private System.Collections.Generic.List<Note> notes;
    public Etudiant(string nom, string prenom, System.Collections.Generic.List<Note> notes)
    {
        this.nom=nom;
        this.prenom=prenom;
        this.notes=notes;
    }

    public string getMatricule()
    {
        return this.matricule;
    }

    public void setMatricule(string matricule)
    {
        this.matricule=matricule;
    }

    public string getNom()
    {
        return this.nom;
    }
    
    public string getPrenom()
    {
        return this.prenom;
    }

    public System.Collections.Generic.List<Note> getNotes()
    {
        return this.notes;
    }
}