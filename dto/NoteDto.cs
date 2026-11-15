namespace ExoCS.dto;
using static ExoCS.dto.EtudiantDto;
class NoteDto {
    private string matiere;
    private double resultat;
    private EtudiantDto etudiant;
    public NoteDto(string matiere, double resultat)
    {
        this.matiere=matiere;
        this.resultat=resultat;
        this.etudiant=etudiant;
    }

    public string getMatiere()
    {
        return this.matiere;
    }
    public double getResultat()
    {
        return this.resultat;
    }
    public EtudiantDto getEtudiant(){
        return this.etudiant;
    }
}