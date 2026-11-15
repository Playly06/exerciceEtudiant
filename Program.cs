using ExoCS.view;
using ExoCS.view;
class Program{
    public static void Main(string[] args) {
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
                        EtudiantView.SaisieEtudiant();
                        break;

                    case 2:
                        EtudiantView.AfficherEtudiants();
                        break;

                    case 3:
                        break;

                    case 4:
                        EtudiantView.AfficherNotesDunEtudiant();
                    break;
                }
            } while (choix != 0);
            
    }

    
}