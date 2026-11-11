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