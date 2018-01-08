namespace AGP2Application
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class AGPModel : DbContext
    {


        // Votre contexte a été configuré pour utiliser une chaîne de connexion « AGPModel » du fichier 
        // de configuration de votre application (App.config ou Web.config). Par défaut, cette chaîne de connexion cible 
        // la base de données « AGP2Application.AGPModel » sur votre instance LocalDb. 
        // 
        // Pour cibler une autre base de données et/ou un autre fournisseur de base de données, modifiez 
        // la chaîne de connexion « AGPModel » dans le fichier de configuration de l'application.
        public AGPModel()
            : base("name=AGPModel")
        {
        }



        // Ajoutez un DbSet pour chaque type d'entité à inclure dans votre modèle. Pour plus d'informations 
        // sur la configuration et l'utilisation du modèle Code First, consultez http://go.microsoft.com/fwlink/?LinkId=390109.

        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Project> Project { get; set; }
        public virtual DbSet<Budget> Budgets { get; set; }

       // public System.Data.Entity.DbSet<AGP2Application.Budget> Budgets { get; set; }
    }

    public class User
    {
        public int ID { get; set; }
        public string lastname { get; set; }
        public string firstname { get; set; }
        public string password { get; set; }
        public string email { get; set; }
        public string highschool { get; set; }
        public string institution { get; set; }
        public string domain { get; set; }
        public string filiere { get; set; }

    }

    public class Project
    {
        public int ID { get; set; }
        public string title { get; set; }
        public string acronym { get; set; }
        public string chef { get; set; }
        public string highschool { get; set; }
        public string institute { get; set; }

        public string domain { get; set; }
        public string sector { get; set; }
        public string typeofproject { get; set; }
        public string financial_instrument { get; set; }
        public string status { get; set; }
        public int provisionnal_cashbudget { get; set; }
        public string start { get; set; }
        public string end { get; set; }
        
    }

    public class Budget
    {
        public int ID { get; set; }
        public string Collaborator { get; set; }
        public string Role { get; set; }
        public float Rate { get; set; }
        public int Pourcentage { get; set; }
        public float NbrHour { get; set; }
        public float Total { get; set; }

    }
}