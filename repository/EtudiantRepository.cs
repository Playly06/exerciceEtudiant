namespace ExoCS.repository;
using ExoCS.entiy;
using ExoCS.config;
using Microsoft.Data.SqlClient;

class EtudiantRepository{
    private static EtudiantRepository? instance;

    private EtudiantRepository(){}
    public static EtudiantRepository getInstance(){
        if(instance==null){
            instance=new EtudiantRepository();
        }
        return instance;
    }
    public void addEtudiant(Etudiant etudiant)
    {
        SqlConnection sqlc= ConnexionDatabase.getInstance().Connexion();
        string sql="insert into etudiant (nom, prenom) values (@nom, @prenom)";
        try
        {
            sqlc.Open();
            SqlCommand sqlcmd=new SqlCommand(sql,sqlc);
            sqlcmd.Parameters.AddWithValue("@nom",etudiant.getNom());
            sqlcmd.Parameters.AddWithValue("@prenom",etudiant.getPrenom());
            sqlcmd.ExecuteNonQuery();
            sqlcmd.Dispose();
            sqlc.Close();
        }
        catch (Exception ex)
        {
            Console.Write(ex.Message);
        }
    }

    //public static Etudiant? GetEtudiantByMatricule(string matricule)
    //{
    //}

    public List<Etudiant>? GetEtudiants()
    {
        List<Etudiant> etudiants = new();
        SqlConnection sqlc= ConnexionDatabase.getInstance().Connexion();
        string sql="select * from etudiant";
        SqlDataReader dreader;
        string output="";
        SqlCommand sqlcmd=new SqlCommand(sql,sqlc);
        try
        {
            sqlc.Open();
            dreader=sqlcmd.ExecuteReader();
            while (dreader.Read()) {
                Etudiant etudiant=new Etudiant(Convert.ToString(dreader.GetValue(0)),Convert.ToString(dreader.GetValue(1)),null);
                etudiant.setMatricule(Convert.ToString(dreader.GetValue(2)));
                etudiants.Add(etudiant);
            }
            Console.Write(output);
            sqlcmd.Dispose();
            sqlc.Close();
            
            
        }catch (Exception ex)
        {
            Console.Write(ex.Message);
        }

        return etudiants;
    }
}