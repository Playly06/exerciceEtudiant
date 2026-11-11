class Etudiant {

    private string matricule;
    private string nom;
    private string prenom;
    private System.Collections.Generic.List<double> notes;
    
    public Etudiant(string matricule, string nom, string prenom, System.Collections.Generic.List<double> notes)
    {
        this.matricule=matricule;
        this.nom=nom;
        this.prenom=prenom;
        this.notes=notes;

    }

    public string getMatricule()
    {
        return this.matricule;
    }

    public string getNom()
    {
        return this.nom;
    }
    
    public string getPrenom()
    {
        return this.prenom;
    }
    public System.Collections.Generic.List<double> getNotes()
    {
        return this.notes;
    }
}