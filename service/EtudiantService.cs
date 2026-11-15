namespace ExoCS.service;
using ExoCS.repository;
using ExoCS.entiy;
using ExoCS.dto;
using ExoCS.view;

class EtudiantService
{

    private static EtudiantService? instance;

    private EtudiantService(){}
    public static EtudiantService getInstance(){
        if(instance==null){
            instance=new EtudiantService();
        }
        return instance;
    }
    public void ajouterEtudiant(EtudiantDto etudiantDto)
    {
        Etudiant etudiant=new Etudiant(etudiantDto.getNom(), etudiantDto.getPrenom(), null);
        EtudiantRepository.getInstance().addEtudiant(etudiant);
    }

    public List<EtudiantDto>? afficherEtudiants()
    {
        List<Etudiant>? etudiants =EtudiantRepository.getInstance().GetEtudiants();
        List<EtudiantDto>? etudiantsDto=new();
        foreach(var etudiant in etudiants)
        {
            EtudiantDto etudiantDto=new EtudiantDto(etudiant.getNom(), etudiant.getPrenom(),null);
            etudiantDto.setMatricule(etudiant.getMatricule());
            etudiantsDto.Add(etudiantDto);
        }
        return etudiantsDto;
    }

    //public static bool ajouterNoteEtudiant(double note, string matricule)
    //{
        //return EtudiantRepository.AddNote(note, matricule);
    //}

    
}