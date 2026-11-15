namespace ExoCS.dto;
using static ExoCS.dto.NoteDto;

class EtudiantDto {
    private string matricule;
    private string nom;
    private string prenom;
    private System.Collections.Generic.List<NoteDto> notes;
    public EtudiantDto(string nom, string prenom, System.Collections.Generic.List<NoteDto> notes)
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

    public System.Collections.Generic.List<NoteDto> getNotes()
    {
        return this.notes;
    }
}