namespace VariableGlobale
{
    static class VariableCreerCompteAdmin
    {
        public static DateTime DateMaximal { get; set; } = new DateTime(DateTime.Now.Year - 18, DateTime.Now.Month, DateTime.Now.Day);
        public static string AdminConnecter { get; set; }
        public static string NomAdmin { get; set; }
        public static string Nom { get; set; }
        public static string Prenoms { get; set; }
        public static DateTime Naissance { get; set; } = DateMaximal;
        public static string NouveauMdp { get; set; }
        public static string ConfirmerMdp { get; set; }
    }

    static class VariableModClient
    {
        public static string Nom { get; set; }
        public static string Prenoms { get; set; }
        public static string Adresse { get; set; }
        public static string Email { get; set; }
        public static string CarteDecodeur { get; set; }
    }

    static class VariableModChaine
    {
        public static int Numero { get; set; }
        public static string Nom { get; set; }
        public static string Categorie { get; set; }
    }

    static class VariableModOffre
    {
        public static string Nom { get; set; }
        public static string Tarif { get; set; }
        public static string Duree { get; set; }
        public static string Description { get; set; }
    }

    static class VariableAbonnement
    {
        public static string Nom { get; set; }
        public static int codeClient { get; set; }
        public static int codeCarteDecodeur { get; set; }
        public static string Adresse{ get; set; }
        public static string Email { get; set; }
        public static string Prenoms { get; set; }
        public static string NumeroDecodeur { get; set; }
        public static string offreActuel { get; set; }
        public static int jourRestant { get; set; }
        public static DateTime dateDebut { get; set; }
        public static DateTime dateFin { get; set; }
        public static int codeOffre { get; set; }
        public static int quantite { get; set; } = 1;
        public static decimal prixOffre { get; set; }
        public static int delaiOffre { get; set; }
        public static int nouveauDelaiOffre { get; set; }
        public static int codeNouveauOffre { get; set; }
        public static DateTime nouveauFinAbonnement { get; set; }
        public static string modeDePaiement { get; set; } = "";
        public static decimal montantEnEspece { get; set; } = -1;
        public static string numeroFacture { get; set; }
        public static string nomOffre{ get; set; }
        public static string prixUnitaireOffre { get; set; }

        //0
        public static int ligneClient { get; set; } = 0;

        //0
        public static int ligneOffre { get; set; } = 0;
        public static int codeAbonnement { get; set; }
        public static string mobileMoney { get; set; } = "";
    }

    static class VariableNouveauClient
    {
        public static string Menu { get; set; }
        public static string Nom { get; set; } = "";
        public static string Prenoms { get; set; } = "";
        public static string Adresse { get; set; } = "";
        public static string Email { get; set; } = "";
        public static string NumeroDecodeur { get; set; } = "";
        public static decimal Montant { get; set; } = 40000;

        //0
        public static int ligneDecodeur { get; set; } = 0;
        public static string ModeDePaiement { get; set; } = "";
        public static decimal MontantEnEspece { get; set; } = -1;
        public static string mobileMoney { get; set; } = "";

    }

    static class VariableDetailClient
    {
        public static string Nom { get; set; }
        public static string Prenoms { get; set; }
        public static string Adresse { get; set; }
        public static string Email { get; set; }
        public static string CarteDecodeur { get; set; }

    }
}






