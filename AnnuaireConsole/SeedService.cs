using AnnuaireModel.Context;
using AnnuaireModel.Dao;

namespace AnnuaireAPI
{
    public static class SeedService
    {
        public static void SeedDatabase()
        {
            var factory = new AnnuaireContextFactory();
            using (var context = factory.CreateDbContext([]))
            {


                if (context.Salaries.Any()) return;

                context.Sites.Add(new Site() { Id = 1, Ville = "Paris" });
                context.Sites.Add(new Site() { Id = 2, Ville = "Nantes" });
                context.Sites.Add(new Site() { Id = 3, Ville = "Toulouse" });
                context.Sites.Add(new Site() { Id = 4, Ville = "Lille" });
                context.Sites.Add(new Site() { Id = 5, Ville = "Nice" });

                context.Services.Add(new Service() { Id = 1, Nom = "Comptabilité" });
                context.Services.Add(new Service() { Id = 2, Nom = "Production" });
                context.Services.Add(new Service() { Id = 3, Nom = "Acceuil" });
                context.Services.Add(new Service() { Id = 4, Nom = "Informatique" });
                context.Services.Add(new Service() { Id = 5, Nom = "Commercial" });
                context.Services.Add(new Service() { Id = 6, Nom = "Relations Humaines" });

                context.Salaries.Add(new Salarie() { Id = 1, Email= "example@example.com", Nom ="Martin", Prenom="Alain", TelFixe="05 59 00 59 51", TelPort="06 01 44 52 13", ServiceId = 1, SiteId = 1 });
                context.Salaries.Add(new Salarie() { Id = 2, Email = "jean.dupont@example.com", Nom = "Dupont", Prenom = "Jean", TelFixe = "01 23 45 67 89", TelPort = "06 12 34 56 78", ServiceId = 1, SiteId = 1 });
                context.Salaries.Add(new Salarie() { Id = 3, Email = "marie.durand@example.com", Nom = "Durand", Prenom = "Marie", TelFixe = "02 98 76 54 32", TelPort = "06 87 65 43 21", ServiceId = 1, SiteId = 1 });
                context.Salaries.Add(new Salarie() { Id = 4, Email = "pierre.martin@example.com", Nom = "Martin", Prenom = "Pierre", TelFixe = "03 21 43 65 87", TelPort = "06 98 76 54 32", ServiceId = 2, SiteId = 1 });
                context.Salaries.Add(new Salarie() { Id = 5, Email = "julie.lefevre@example.com", Nom = "Lefevre", Prenom = "Julie", TelFixe = "04 56 78 90 12", TelPort = "06 34 56 78 90", ServiceId = 2, SiteId = 2 });
                context.Salaries.Add(new Salarie() { Id = 6, Email = "sophie.moreau@example.com", Nom = "Moreau", Prenom = "Sophie", TelFixe = "05 12 34 56 78", TelPort = "06 78 90 12 34", ServiceId = 2, SiteId = 2 });
                context.Salaries.Add(new Salarie() { Id = 7, Email = "pierre.durand@example.com", Nom = "Durand", Prenom = "Pierre", TelFixe = "03 12 34 56 78", TelPort = "06 21 43 65 87", ServiceId = 3, SiteId = 2 });
                context.Salaries.Add(new Salarie() { Id = 8, Email = "julie.martin@example.com", Nom = "Martin", Prenom = "Julie", TelFixe = "04 87 65 43 21", TelPort = "06 98 76 54 32", ServiceId = 3, SiteId = 2 });
                context.Salaries.Add(new Salarie() { Id = 9, Email = "jean.dupont@example.com", Nom = "Dupont", Prenom = "Jean", TelFixe = "05 23 45 67 89", TelPort = "06 12 34 56 78", ServiceId = 3, SiteId = 3 });
                context.Salaries.Add(new Salarie() { Id = 10, Email = "marie.durand@example.com", Nom = "Durand", Prenom = "Marie", TelFixe = "01 98 76 54 32", TelPort = "06 87 65 43 21", ServiceId = 4, SiteId = 3 });
                context.Salaries.Add(new Salarie() { Id = 11, Email = "paul.bernard@example.com", Nom = "Bernard", Prenom = "Paul", TelFixe = "02 12 34 56 78", TelPort = "06 21 43 65 87", ServiceId = 4, SiteId = 3 });
                context.Salaries.Add(new Salarie() { Id = 12, Email = "julie.lemoine@example.com", Nom = "Lemoine", Prenom = "Julie", TelFixe = "03 87 65 43 21", TelPort = "06 98 76 54 32", ServiceId = 4, SiteId = 3 });
                context.Salaries.Add(new Salarie() { Id = 13, Email = "jean.dupuis@example.com", Nom = "Dupuis", Prenom = "Jean", TelFixe = "04 23 45 67 89", TelPort = "06 12 34 56 78", ServiceId = 5, SiteId = 4 });
                context.Salaries.Add(new Salarie() { Id = 14, Email = "marie.michel@example.com", Nom = "Michel", Prenom = "Marie", TelFixe = "05 98 76 54 32", TelPort = "06 87 65 43 21", ServiceId = 5, SiteId = 4 });
                context.Salaries.Add(new Salarie() { Id = 15, Email = "pierre.dubois@example.com", Nom = "Dubois", Prenom = "Pierre", TelFixe = "01 23 45 67 89", TelPort = "06 98 76 54 32", ServiceId = 5, SiteId = 4 });
                context.Salaries.Add(new Salarie() { Id = 16, Email = "julie.bernard@example.com", Nom = "Bernard", Prenom = "Julie", TelFixe = "02 12 34 56 78", TelPort = "06 21 43 65 87", ServiceId = 6, SiteId = 4 });
                context.Salaries.Add(new Salarie() { Id = 17, Email = "jean.lemoine@example.com", Nom = "Lemoine", Prenom = "Jean", TelFixe = "03 87 65 43 21", TelPort = "06 98 76 54 32", ServiceId = 6, SiteId = 5 });
                context.Salaries.Add(new Salarie() { Id = 18, Email = "marie.dupuis@example.com", Nom = "Dupuis", Prenom = "Marie", TelFixe = "04 23 45 67 89", TelPort = "06 12 34 56 78", ServiceId = 6, SiteId = 5 });
                context.Salaries.Add(new Salarie() { Id = 19, Email = "pierre.michel@example.com", Nom = "Michel", Prenom = "Pierre", TelFixe = "05 98 76 54 32", TelPort = "06 87 65 43 21", ServiceId = 1, SiteId = 5 });
                context.Salaries.Add(new Salarie() { Id = 20, Email = "julie.dubois@example.com", Nom = "Dubois", Prenom = "Julie", TelFixe = "01 23 45 67 89", TelPort = "06 98 76 54 32", ServiceId = 1, SiteId = 5 });
                context.Salaries.Add(new Salarie() { Id = 21, Email = "juan.lopez@example.com", Nom = "Lopez", Prenom = "Juan", TelFixe = "01 11 22 33 44", TelPort = "06 55 66 77 88", ServiceId = 1, SiteId = 5 });
                context.Salaries.Add(new Salarie() { Id = 22, Email = "ana.rodriguez@example.com", Nom = "Rodriguez", Prenom = "Ana", TelFixe = "02 22 33 44 55", TelPort = "06 66 77 88 99", ServiceId = 2, SiteId = 5 });
                context.Salaries.Add(new Salarie() { Id = 23, Email = "carlos.garcia@example.com", Nom = "Garcia", Prenom = "Carlos", TelFixe = "03 33 44 55 66", TelPort = "06 77 88 99 00", ServiceId = 2, SiteId = 5 });
                context.Salaries.Add(new Salarie() { Id = 24, Email = "lucia.fernandez@example.com", Nom = "Fernandez", Prenom = "Lucia", TelFixe = "04 44 55 66 77", TelPort = "06 88 99 00 11", ServiceId = 3, SiteId = 5 });
                context.Salaries.Add(new Salarie() { Id = 25, Email = "manuel.perez@example.com", Nom = "Perez", Prenom = "Manuel", TelFixe = "05 55 66 77 88", TelPort = "06 99 00 11 22", ServiceId = 3, SiteId = 5 });
                context.Salaries.Add(new Salarie() { Id = 41, Email = "john.smith@example.com", Nom = "Smith", Prenom = "John", TelFixe = "01 23 45 67 89", TelPort = "06 98 76 54 32", ServiceId = 3, SiteId = 5 });
                context.Salaries.Add(new Salarie() { Id = 42, Email = "emma.johnson@example.com", Nom = "Johnson", Prenom = "Emma", TelFixe = "02 34 56 78 90", TelPort = "06 87 65 43 21", ServiceId = 3, SiteId = 5 });
                context.Salaries.Add(new Salarie() { Id = 43, Email = "michael.williams@example.com", Nom = "Williams", Prenom = "Michael", TelFixe = "03 45 67 89 01", TelPort = "06 76 54 32 10", ServiceId = 3, SiteId = 5 });
                context.Salaries.Add(new Salarie() { Id = 44, Email = "olivia.brown@example.com", Nom = "Brown", Prenom = "Olivia", TelFixe = "04 56 78 90 12", TelPort = "06 65 43 21 09", ServiceId = 3, SiteId = 5 });
                context.Salaries.Add(new Salarie() { Id = 45, Email = "james.taylor@example.com", Nom = "Taylor", Prenom = "James", TelFixe = "05 67 89 01 23", TelPort = "06 54 32 10 98", ServiceId = 3, SiteId = 5 });
                context.Salaries.Add(new Salarie() { Id = 46, Email = "charlotte.jones@example.com", Nom = "Jones", Prenom = "Charlotte", TelFixe = "06 78 90 12 34", TelPort = "06 43 21 09 87", ServiceId = 3, SiteId = 5 });
                context.Salaries.Add(new Salarie() { Id = 47, Email = "william.miller@example.com", Nom = "Miller", Prenom = "William", TelFixe = "07 89 01 23 45", TelPort = "06 32 10 98 76", ServiceId = 3, SiteId = 5 });
                context.Salaries.Add(new Salarie() { Id = 48, Email = "amelia.davis@example.com", Nom = "Davis", Prenom = "Amelia", TelFixe = "08 90 12 34 56", TelPort = "06 21 09 87 65", ServiceId = 3, SiteId = 5 });
                context.Salaries.Add(new Salarie() { Id = 49, Email = "alexander.anderson@example.com", Nom = "Anderson", Prenom = "Alexander", TelFixe = "09 01 23 45 67", TelPort = "06 10 98 76 54", ServiceId = 3, SiteId = 5 });
                context.Salaries.Add(new Salarie() { Id = 50, Email = "sophia.white@example.com", Nom = "White", Prenom = "Sophia", TelFixe = "01 12 34 56 78", TelPort = "06 09 87 65 43", ServiceId = 3, SiteId = 5 });
                context.Salaries.Add(new Salarie() { Id = 51, Email = "jacob.martin@example.com", Nom = "Martin", Prenom = "Jacob", TelFixe = "02 23 45 67 89", TelPort = "06 98 76 54 32", ServiceId = 3, SiteId = 5 });
                context.Salaries.Add(new Salarie() { Id = 52, Email = "emily.thompson@example.com", Nom = "Thompson", Prenom = "Emily", TelFixe = "03 34 56 78 90", TelPort = "06 87 65 43 21", ServiceId = 3, SiteId = 5 });
                context.Salaries.Add(new Salarie() { Id = 53, Email = "ethan.hall@example.com", Nom = "Hall", Prenom = "Ethan", TelFixe = "04 45 67 89 01", TelPort = "06 76 54 32 10", ServiceId = 3, SiteId = 5 });
                context.Salaries.Add(new Salarie() { Id = 54, Email = "ava.jenkins@example.com", Nom = "Jenkins", Prenom = "Ava", TelFixe = "05 56 78 90 12", TelPort = "06 65 43 21 09", ServiceId = 3, SiteId = 5 });
                context.Salaries.Add(new Salarie() { Id = 55, Email = "logan.roberts@example.com", Nom = "Roberts", Prenom = "Logan", TelFixe = "06 67 89 01 23", TelPort = "06 54 32 10 98", ServiceId = 3, SiteId = 5 });
                context.Salaries.Add(new Salarie() { Id = 56, Email = "mia.cook@example.com", Nom = "Cook", Prenom = "Mia", TelFixe = "07 78 90 12 34", TelPort = "06 43 21 09 87", ServiceId = 3, SiteId = 5 });
                context.Salaries.Add(new Salarie() { Id = 57, Email = "owen.kelly@example.com", Nom = "Kelly", Prenom = "Owen", TelFixe = "08 89 01 23 45", TelPort = "06 32 10 98 76", ServiceId = 3, SiteId = 5 });
                context.Salaries.Add(new Salarie() { Id = 58, Email = "isabella.phillips@example.com", Nom = "Phillips", Prenom = "Isabella", TelFixe = "09 90 12 34 56", TelPort = "06 21 09 87 65", ServiceId = 3, SiteId = 5 });
                context.Salaries.Add(new Salarie() { Id = 61, Email = "hans.schmidt@example.com", Nom = "Schmidt", Prenom = "Hans", TelFixe = "01 23 45 67 89", TelPort = "06 98 76 54 32", ServiceId = 3, SiteId = 5 });
                context.Salaries.Add(new Salarie() { Id = 62, Email = "sabine.mueller@example.com", Nom = "Müller", Prenom = "Sabine", TelFixe = "02 34 56 78 90", TelPort = "06 87 65 43 21", ServiceId = 3, SiteId = 5 });
                context.Salaries.Add(new Salarie() { Id = 63, Email = "thomas.schneider@example.com", Nom = "Schneider", Prenom = "Thomas", TelFixe = "03 45 67 89 01", TelPort = "06 76 54 32 10", ServiceId = 3, SiteId = 5 });
                context.Salaries.Add(new Salarie() { Id = 64, Email = "petra.fischer@example.com", Nom = "Fischer", Prenom = "Petra", TelFixe = "04 56 78 90 12", TelPort = "06 65 43 21 09", ServiceId = 3, SiteId = 5 });
                context.Salaries.Add(new Salarie() { Id = 65, Email = "michael.weber@example.com", Nom = "Weber", Prenom = "Michael", TelFixe = "05 67 89 01 23", TelPort = "06 54 32 10 98", ServiceId = 3, SiteId = 5 });
                context.Salaries.Add(new Salarie() { Id = 66, Email = "ursula.wagner@example.com", Nom = "Wagner", Prenom = "Ursula", TelFixe = "06 78 90 12 34", TelPort = "06 43 21 09 87", ServiceId = 3, SiteId = 5 });
                context.Salaries.Add(new Salarie() { Id = 67, Email = "christian.hoffmann@example.com", Nom = "Hoffmann", Prenom = "Christian", TelFixe = "07 89 01 23 45", TelPort = "06 32 10 98 76", ServiceId = 3, SiteId = 5 });
                context.Salaries.Add(new Salarie() { Id = 68, Email = "susanne.schulz@example.com", Nom = "Schulz", Prenom = "Susanne", TelFixe = "08 90 12 34 56", TelPort = "06 21 09 87 65", ServiceId = 3, SiteId = 5 });
                context.Salaries.Add(new Salarie() { Id = 69, Email = "andreas.koch@example.com", Nom = "Koch", Prenom = "Andreas", TelFixe = "09 01 23 45 67", TelPort = "06 10 98 76 54", ServiceId = 3, SiteId = 5 });
                context.Salaries.Add(new Salarie() { Id = 70, Email = "susanne.bauer@example.com", Nom = "Bauer", Prenom = "Susanne", TelFixe = "01 12 34 56 78", TelPort = "06 09 87 65 43", ServiceId = 3, SiteId = 5 });
                context.Salaries.Add(new Salarie() { Id = 71, Email = "martin.richter@example.com", Nom = "Richter", Prenom = "Martin", TelFixe = "02 23 45 67 89", TelPort = "06 98 76 54 32", ServiceId = 3, SiteId = 5 });
                context.Salaries.Add(new Salarie() { Id = 72, Email = "katrin.becker@example.com", Nom = "Becker", Prenom = "Katrin", TelFixe = "03 34 56 78 90", TelPort = "06 87 65 43 21", ServiceId = 3, SiteId = 5 });
                context.Salaries.Add(new Salarie() { Id = 73, Email = "matthias.huber@example.com", Nom = "Huber", Prenom = "Matthias", TelFixe = "04 45 67 89 01", TelPort = "06 76 54 32 10", ServiceId = 3, SiteId = 5 });
                context.Salaries.Add(new Salarie() { Id = 74, Email = "andrea.mayer@example.com", Nom = "Mayer", Prenom = "Andrea", TelFixe = "05 56 78 90 12", TelPort = "06 65 43 21 09", ServiceId = 3, SiteId = 5 });
                context.Salaries.Add(new Salarie() { Id = 75, Email = "peter.huber@example.com", Nom = "Huber", Prenom = "Peter", TelFixe = "06 67 89 01 23", TelPort = "06 54 32 10 98", ServiceId = 3, SiteId = 5 });
                context.Salaries.Add(new Salarie() { Id = 76, Email = "heike.roth@example.com", Nom = "Roth", Prenom = "Heike", TelFixe = "07 78 90 12 34", TelPort = "06 43 21 09 87", ServiceId = 3, SiteId = 5 });
                context.Salaries.Add(new Salarie() { Id = 77, Email = "markus.schwarz@example.com", Nom = "Schwarz", Prenom = "Markus", TelFixe = "08 89 01 23 45", TelPort = "06 32 10 98 76", ServiceId = 3, SiteId = 5 });
                context.Salaries.Add(new Salarie() { Id = 78, Email = "petra.klein@example.com", Nom = "Klein", Prenom = "Petra", TelFixe = "09 90 12 34 56", TelPort = "06 21 09 87 65", ServiceId = 3, SiteId = 5 });
                context.Salaries.Add(new Salarie() { Id = 79, Email = "daniel.clark@example.com", Nom = "Clark", Prenom = "Daniel", TelFixe = "01 23 45 67 89", TelPort = "06 98 76 54 32", ServiceId = 2, SiteId = 3 });
                context.Salaries.Add(new Salarie() { Id = 80, Email = "laura.evans@example.com", Nom = "Evans", Prenom = "Laura", TelFixe = "02 34 56 78 90", TelPort = "06 87 65 43 21", ServiceId = 1, SiteId = 5 });
                context.Salaries.Add(new Salarie() { Id = 81, Email = "stephen.harris@example.com", Nom = "Harris", Prenom = "Stephen", TelFixe = "03 45 67 89 01", TelPort = "06 76 54 32 10", ServiceId = 1, SiteId = 2 });
                context.Salaries.Add(new Salarie() { Id = 82, Email = "hannah.lewis@example.com", Nom = "Lewis", Prenom = "Hannah", TelFixe = "04 56 78 90 12", TelPort = "06 65 43 21 09", ServiceId = 3, SiteId = 4 });
                context.Salaries.Add(new Salarie() { Id = 83, Email = "joshua.walker@example.com", Nom = "Walker", Prenom = "Joshua", TelFixe = "05 67 89 01 23", TelPort = "06 54 32 10 98", ServiceId = 3, SiteId = 1 });
                context.Salaries.Add(new Salarie() { Id = 84, Email = "lucy.moore@example.com", Nom = "Moore", Prenom = "Lucy", TelFixe = "06 78 90 12 34", TelPort = "06 43 21 09 87", ServiceId = 1, SiteId = 2 });
                context.Salaries.Add(new Salarie() { Id = 85, Email = "ryan.jackson@example.com", Nom = "Jackson", Prenom = "Ryan", TelFixe = "07 89 01 23 45", TelPort = "06 32 10 98 76", ServiceId = 2, SiteId = 4 });
                context.Salaries.Add(new Salarie() { Id = 86, Email = "amelia.martin@example.com", Nom = "Martin", Prenom = "Amelia", TelFixe = "08 90 12 34 56", TelPort = "06 21 09 87 65", ServiceId = 2, SiteId = 5 });
                context.Salaries.Add(new Salarie() { Id = 87, Email = "james.lee@example.com", Nom = "Lee", Prenom = "James", TelFixe = "09 01 23 45 67", TelPort = "06 10 98 76 54", ServiceId = 1, SiteId = 3 });
                context.Salaries.Add(new Salarie() { Id = 88, Email = "sophie.king@example.com", Nom = "King", Prenom = "Sophie", TelFixe = "01 12 34 56 78", TelPort = "06 09 87 65 43", ServiceId = 3, SiteId = 1 });
                context.Salaries.Add(new Salarie() { Id = 89, Email = "benjamin.wright@example.com", Nom = "Wright", Prenom = "Benjamin", TelFixe = "02 23 45 67 89", TelPort = "06 98 76 54 32", ServiceId = 1, SiteId = 2 });
                context.Salaries.Add(new Salarie() { Id = 90, Email = "olivia.turner@example.com", Nom = "Turner", Prenom = "Olivia", TelFixe = "03 34 56 78 90", TelPort = "06 87 65 43 21", ServiceId = 2, SiteId = 1 });
                context.Salaries.Add(new Salarie() { Id = 91, Email = "samuel.wood@example.com", Nom = "Wood", Prenom = "Samuel", TelFixe = "04 45 67 89 01", TelPort = "06 76 54 32 10", ServiceId = 3, SiteId = 5 });
                context.Salaries.Add(new Salarie() { Id = 92, Email = "emma.thomson@example.com", Nom = "Thomson", Prenom = "Emma", TelFixe = "05 56 78 90 12", TelPort = "06 65 43 21 09", ServiceId = 2, SiteId = 3 });
                context.Salaries.Add(new Salarie() { Id = 93, Email = "liam.white@example.com", Nom = "White", Prenom = "Liam", TelFixe = "06 67 89 01 23", TelPort = "06 54 32 10 98", ServiceId = 1, SiteId = 4 });
                context.Salaries.Add(new Salarie() { Id = 94, Email = "ella.roberts@example.com", Nom = "Roberts", Prenom = "Ella", TelFixe = "07 78 90 12 34", TelPort = "06 43 21 09 87", ServiceId = 3, SiteId = 2 });
                context.Salaries.Add(new Salarie() { Id = 95, Email = "jack.hill@example.com", Nom = "Hill", Prenom = "Jack", TelFixe = "08 89 01 23 45", TelPort = "06 32 10 98 76", ServiceId = 2, SiteId = 3 });
                context.Salaries.Add(new Salarie() { Id = 96, Email = "isabella.green@example.com", Nom = "Green", Prenom = "Isabella", TelFixe = "09 90 12 34 56", TelPort = "06 21 09 87 65", ServiceId = 1, SiteId = 5 });
                context.Salaries.Add(new Salarie() { Id = 97, Email = "noah.scott@example.com", Nom = "Scott", Prenom = "Noah", TelFixe = "01 23 45 67 89", TelPort = "06 98 76 54 32", ServiceId = 2, SiteId = 1 });
                context.Salaries.Add(new Salarie() { Id = 98, Email = "mia.adams@example.com", Nom = "Adams", Prenom = "Mia", TelFixe = "02 34 56 78 90", TelPort = "06 87 65 43 21", ServiceId = 3, SiteId = 4 });
                context.Salaries.Add(new Salarie() { Id = 99, Email = "oliver.carter@example.com", Nom = "Carter", Prenom = "Oliver", TelFixe = "03 45 67 89 01", TelPort = "06 76 54 32 10", ServiceId = 1, SiteId = 3 });
                context.Salaries.Add(new Salarie() { Id = 100, Email = "ava.cooper@example.com", Nom = "Cooper", Prenom = "Ava", TelFixe = "04 56 78 90 12", TelPort = "06 65 43 21 09", ServiceId = 2, SiteId = 5 });

                context.SaveChanges();

            }

        }
    }
}
