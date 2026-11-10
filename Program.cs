class Program{
    public void Main(string[] args) {
            Etudiant etudiant= new  Etudiant("1", "Ba", "Amadou", [10, 12.5, 14]);
            EtudiantRepository.addEtudiant(etudiant);
            int compteur = 1;
            int choix;
            do
            {
                choix = view.Menu();
                switch (choix)
                {
                    case 0:
                        Console.WriteLine("Au revoir");
                        break;

                    case 1:
                        var etudiant2 = EtudiantView.SaisieEtudiant(ref compteur);
                        EtudiantRepository.addEtudiant(etudiant2);
                        break;

                    case 2:
                        EtudiantView.AfficherEtudiants();
                        break;

                    case 3:
                        string matricule = inputs.LireChaine("Saisir le matricule à rechercher : ");
                        double note = -1;
                        bool result = true;
                        do
                        {
                            note = inputs.LireDouble("Saisir une note entre 0 et 20 : ");
                            if (note < 0 || note > 20)
                            {
                                Console.WriteLine("Note invalide");
                                result = false;
                            }
                        } while (!result);
                        result = false;
                        do
                        {
                            result = EtudiantService.ajouterNoteEtudiant(note, matricule);
                        } while (!result);
                        break;

                    case 4:
                        matricule = inputs.LireChaine("Saisir le matricule : ");
                        Etudiant? etudiantNullable= EtudiantView.AfficherEtudiant(matricule);
                        if (etudiantNullable is null)
                        {
                            Console.WriteLine("Ce matricule ne correspond à aucun étudiant");
                        } else
                        {
                            var notes = etudiantNullable?.getNotes();
                            notes?.ForEach(n => Console.WriteLine(n));
                        }
                        break;
                    
                    default:
                        Console.WriteLine("Saisir un entier entre 0 et 4");
                        break;
                }
            } while (choix != 0);
            
    }

    
}

class generateur()
{
    public static string GenererMatricule(ref int compteur)
    {
        compteur++;
        // return "ism" + compteur;
        return $"ism{compteur}";
    }
}
class inputs
{
    public static string LireChaine(string msg)
    {
        string? chaine;
        do
        {
            Console.WriteLine(msg);
            chaine = Console.ReadLine();
        } while (chaine == null);
        return chaine;
    }

    public static double LireDouble(string msg)
    {
        bool result = false;
        double choix = 0;
        do
        {
            Console.WriteLine(msg);
            result = double.TryParse(Console.ReadLine(), out choix);
        } while (!result);
        return choix;
    }

    

}
class view{
    public static int Menu() {
        bool result = false;
        int choix = 0;
        do
        {
            Console.WriteLine("1. Ajouter un etudiant dans une liste");
            Console.WriteLine("2. Afficher la liste des étudiants");
            Console.WriteLine("3. Ajouter une note a un etudiant");
            Console.WriteLine("4. Lister les notes d'un etudiant");
            Console.WriteLine("0. Quitter");
            Console.WriteLine("Saisir votre choix : ");
            result = int.TryParse(Console.ReadLine(), out choix);
        } while (!result);
        return choix;
    }

}

class EtudiantView
{
    public static Etudiant SaisieEtudiant(ref int compteur)
    {
        Etudiant etudiant=new Etudiant(generateur.GenererMatricule(ref compteur), inputs.LireChaine("Nom : "), inputs.LireChaine("Prénom : "), []);
        return etudiant;
    }
    public static void AfficherEtudiants()
    {
        EtudiantService.afficherEtudiants().ForEach(e => Console.WriteLine($"Matricule : {e.getMatricule} ; Nom : {e.getNom} ; Prénom : {e.getPrenom}"));
    }

    public static Etudiant AfficherEtudiant(string matricule)
    {
        return EtudiantService.afficherEtudiantparUnMatricule(matricule);
    }
}
class EtudiantRepository{
    private static List<Etudiant> etudiants = new();

    public static void addEtudiant(Etudiant etudiant)
    {
        etudiants.Add(etudiant);
    }

    public static Etudiant? GetEtudiantByMatricule(string matricule)
    {
        return etudiants.FirstOrDefault(e => e.getMatricule() == matricule);
    }

    public static List<Etudiant>? GetEtudiants()
    {
        return etudiants;
    }
    public static bool AddNote(double note, string matricule)
    {
        Etudiant? etudiant = GetEtudiantByMatricule(matricule);
        if (etudiant is null)
        {
            Console.WriteLine("Le matricule ne correspond à aucun étudiant");
            return false;
        }
        etudiant?.getNotes().Add(note);
        return true;
    }
}

class EtudiantService
{
    public static void ajouterEtudiant(Etudiant etudiant)
    {
        EtudiantRepository.addEtudiant(etudiant);
    }

    public static List<Etudiant>? afficherEtudiants()
    {
        return EtudiantRepository.GetEtudiants();
    }

    public static bool ajouterNoteEtudiant(double note, string matricule)
    {
        return EtudiantRepository.AddNote(note, matricule);
    }

    public static Etudiant? afficherEtudiantparUnMatricule(string matricule)
    {
        return EtudiantRepository.GetEtudiantByMatricule(matricule);
    }
}

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