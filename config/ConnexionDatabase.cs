namespace ExoCS.config;
using Microsoft.Data.SqlClient;

class ConnexionDatabase{
    static string db=@"Server=localhost;Database=ecole;Trusted_Connection=True;TrustServerCertificate=True;";

    private static ConnexionDatabase? instance;

    private ConnexionDatabase(){}
    public static ConnexionDatabase getInstance(){
        if(instance==null){
            instance=new ConnexionDatabase();
        }
        return instance;
    }
    public SqlConnection Connexion()
    {
        return new SqlConnection(db);
    }

}