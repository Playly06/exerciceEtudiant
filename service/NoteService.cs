namespace ExoCS.service;
using ExoCS.repository;
using ExoCS.entiy;
using ExoCS.dto;
using ExoCS.view;
class NoteService
{
    private static NoteService? instance;

    private NoteService(){}
    public static NoteService getInstance(){
        if(instance==null){
            instance=new NoteService();
        }
        return instance;
    }
    public List<NoteDto>? afficherNotesDunEtudiant(int matricule)
    {
        List<Note>? notes= NoteRepository.getInstance().GetNotesDunEtudiant(matricule);

        List<NoteDto>? notesDto=new();
        foreach(var note in notes)
        {
            NoteDto noteDto=new NoteDto(note.getMatiere(), note.getResultat());
            notesDto.Add(noteDto);
        }
        return notesDto;
    }
}
