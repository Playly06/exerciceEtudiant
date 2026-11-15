namespace ExoCS.repository;
using ExoCS.entiy;
using ExoCS.config;
using Microsoft.Data.SqlClient;
class NoteRepository
{
     private static NoteRepository? instance;

    private NoteRepository(){}
    public static NoteRepository getInstance(){
        if(instance==null){
            instance=new NoteRepository();
        }
        return instance;
    }
    public List<Note>? GetNotesDunEtudiant(int matricule)
    {
        List<Note> notes = new();
        SqlConnection sqlc= ConnexionDatabase.getInstance().Connexion();
        string sql="select * from note where etudiantMatricule=@matricule";
        SqlDataReader dreader;
        try
        {
            sqlc.Open();
            SqlCommand sqlcmd=new SqlCommand(sql,sqlc);
            sqlcmd.Parameters.AddWithValue("@matricule", matricule);
            dreader=sqlcmd.ExecuteReader();
            while (dreader.Read()) {
                Note note=new Note(Convert.ToString(dreader.GetValue(0)),Convert.ToDouble(dreader.GetValue(1)));
                notes.Add(note);
            }
            sqlcmd.Dispose();
            sqlc.Close();

        }catch (Exception ex)
        {
            Console.Write(ex.Message);
        }
        return notes;
    }
}