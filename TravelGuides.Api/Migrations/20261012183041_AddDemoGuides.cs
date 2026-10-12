using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TravelGuides.Api.Migrations
{
    /// <inheritdoc />
    public partial class AddDemoGuides : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Guides",
                columns: new[] { "Id", "Audience", "Description", "Mobility", "NumberOfDays", "Season", "Title" },
                values: new object[,]
                {
                    { 1001, "famille", "Guide de démonstration fictif : 3 jours à Bordeaux, avec visites, promenades et découvertes. Les lieux et informations pratiques de ce jeu ne constituent pas des recommandations réelles.", "à pied", 3, "printemps", "Escapade culturelle à Bordeaux" },
                    { 1002, "famille", "Guide de démonstration fictif : 4 jours à Toulouse, avec visites, promenades et découvertes. Les lieux et informations pratiques de ce jeu ne constituent pas des recommandations réelles.", "voiture", 4, "printemps", "Voyage en famille à Toulouse" },
                    { 1003, "famille", "Guide de démonstration fictif : 5 jours à Strasbourg, avec visites, promenades et découvertes. Les lieux et informations pratiques de ce jeu ne constituent pas des recommandations réelles.", "vélo", 5, "printemps", "Découverte à vélo à Strasbourg" },
                    { 1004, "seul", "Guide de démonstration fictif : 3 jours à Nantes, avec visites, promenades et découvertes. Les lieux et informations pratiques de ce jeu ne constituent pas des recommandations réelles.", "moto", 3, "printemps", "Balades et patrimoine à Nantes" },
                    { 1005, "seul", "Guide de démonstration fictif : 4 jours à Lille, avec visites, promenades et découvertes. Les lieux et informations pratiques de ce jeu ne constituent pas des recommandations réelles.", "à pied", 4, "été", "Séjour entre amis à Lille" },
                    { 1006, "seul", "Guide de démonstration fictif : 5 jours à Marseille, avec visites, promenades et découvertes. Les lieux et informations pratiques de ce jeu ne constituent pas des recommandations réelles.", "voiture", 5, "été", "Escapade culturelle à Marseille" },
                    { 1007, "en groupe", "Guide de démonstration fictif : 3 jours à Nice, avec visites, promenades et découvertes. Les lieux et informations pratiques de ce jeu ne constituent pas des recommandations réelles.", "vélo", 3, "été", "Voyage en famille à Nice" },
                    { 1008, "en groupe", "Guide de démonstration fictif : 4 jours à Annecy, avec visites, promenades et découvertes. Les lieux et informations pratiques de ce jeu ne constituent pas des recommandations réelles.", "moto", 4, "été", "Découverte à vélo à Annecy" },
                    { 1009, "en groupe", "Guide de démonstration fictif : 5 jours à Grenoble, avec visites, promenades et découvertes. Les lieux et informations pratiques de ce jeu ne constituent pas des recommandations réelles.", "à pied", 5, "automne", "Balades et patrimoine à Grenoble" },
                    { 1010, "entre amis", "Guide de démonstration fictif : 3 jours à Dijon, avec visites, promenades et découvertes. Les lieux et informations pratiques de ce jeu ne constituent pas des recommandations réelles.", "voiture", 3, "automne", "Séjour entre amis à Dijon" },
                    { 1011, "entre amis", "Guide de démonstration fictif : 4 jours à Rennes, avec visites, promenades et découvertes. Les lieux et informations pratiques de ce jeu ne constituent pas des recommandations réelles.", "vélo", 4, "automne", "Escapade culturelle à Rennes" },
                    { 1012, "entre amis", "Guide de démonstration fictif : 5 jours à Rouen, avec visites, promenades et découvertes. Les lieux et informations pratiques de ce jeu ne constituent pas des recommandations réelles.", "moto", 5, "automne", "Voyage en famille à Rouen" },
                    { 1013, "famille", "Guide de démonstration fictif : 3 jours à Reims, avec visites, promenades et découvertes. Les lieux et informations pratiques de ce jeu ne constituent pas des recommandations réelles.", "à pied", 3, "hiver", "Découverte à vélo à Reims" },
                    { 1014, "famille", "Guide de démonstration fictif : 4 jours à Avignon, avec visites, promenades et découvertes. Les lieux et informations pratiques de ce jeu ne constituent pas des recommandations réelles.", "voiture", 4, "hiver", "Balades et patrimoine à Avignon" },
                    { 1015, "famille", "Guide de démonstration fictif : 5 jours à Montpellier, avec visites, promenades et découvertes. Les lieux et informations pratiques de ce jeu ne constituent pas des recommandations réelles.", "vélo", 5, "hiver", "Séjour entre amis à Montpellier" },
                    { 1016, "seul", "Guide de démonstration fictif : 3 jours à La Rochelle, avec visites, promenades et découvertes. Les lieux et informations pratiques de ce jeu ne constituent pas des recommandations réelles.", "moto", 3, "hiver", "Escapade culturelle à La Rochelle" },
                    { 1017, "seul", "Guide de démonstration fictif : 4 jours à Tours, avec visites, promenades et découvertes. Les lieux et informations pratiques de ce jeu ne constituent pas des recommandations réelles.", "à pied", 4, "printemps", "Voyage en famille à Tours" },
                    { 1018, "seul", "Guide de démonstration fictif : 5 jours à Nancy, avec visites, promenades et découvertes. Les lieux et informations pratiques de ce jeu ne constituent pas des recommandations réelles.", "voiture", 5, "printemps", "Découverte à vélo à Nancy" },
                    { 1019, "en groupe", "Guide de démonstration fictif : 3 jours à Metz, avec visites, promenades et découvertes. Les lieux et informations pratiques de ce jeu ne constituent pas des recommandations réelles.", "vélo", 3, "printemps", "Balades et patrimoine à Metz" },
                    { 1020, "en groupe", "Guide de démonstration fictif : 4 jours à Besançon, avec visites, promenades et découvertes. Les lieux et informations pratiques de ce jeu ne constituent pas des recommandations réelles.", "moto", 4, "printemps", "Séjour entre amis à Besançon" },
                    { 1021, "en groupe", "Guide de démonstration fictif : 5 jours à Clermont-Ferrand, avec visites, promenades et découvertes. Les lieux et informations pratiques de ce jeu ne constituent pas des recommandations réelles.", "à pied", 5, "été", "Escapade culturelle à Clermont-Ferrand" },
                    { 1022, "entre amis", "Guide de démonstration fictif : 3 jours à Limoges, avec visites, promenades et découvertes. Les lieux et informations pratiques de ce jeu ne constituent pas des recommandations réelles.", "voiture", 3, "été", "Voyage en famille à Limoges" },
                    { 1023, "entre amis", "Guide de démonstration fictif : 4 jours à Poitiers, avec visites, promenades et découvertes. Les lieux et informations pratiques de ce jeu ne constituent pas des recommandations réelles.", "vélo", 4, "été", "Découverte à vélo à Poitiers" },
                    { 1024, "entre amis", "Guide de démonstration fictif : 5 jours à Caen, avec visites, promenades et découvertes. Les lieux et informations pratiques de ce jeu ne constituent pas des recommandations réelles.", "moto", 5, "été", "Balades et patrimoine à Caen" },
                    { 1025, "famille", "Guide de démonstration fictif : 3 jours à Brest, avec visites, promenades et découvertes. Les lieux et informations pratiques de ce jeu ne constituent pas des recommandations réelles.", "à pied", 3, "automne", "Séjour entre amis à Brest" },
                    { 1026, "famille", "Guide de démonstration fictif : 4 jours à Amiens, avec visites, promenades et découvertes. Les lieux et informations pratiques de ce jeu ne constituent pas des recommandations réelles.", "voiture", 4, "automne", "Escapade culturelle à Amiens" },
                    { 1027, "famille", "Guide de démonstration fictif : 5 jours à Orléans, avec visites, promenades et découvertes. Les lieux et informations pratiques de ce jeu ne constituent pas des recommandations réelles.", "vélo", 5, "automne", "Voyage en famille à Orléans" },
                    { 1028, "seul", "Guide de démonstration fictif : 3 jours à Angers, avec visites, promenades et découvertes. Les lieux et informations pratiques de ce jeu ne constituent pas des recommandations réelles.", "moto", 3, "automne", "Découverte à vélo à Angers" },
                    { 1029, "seul", "Guide de démonstration fictif : 4 jours à Saint-Malo, avec visites, promenades et découvertes. Les lieux et informations pratiques de ce jeu ne constituent pas des recommandations réelles.", "à pied", 4, "hiver", "Balades et patrimoine à Saint-Malo" },
                    { 1030, "seul", "Guide de démonstration fictif : 5 jours à Colmar, avec visites, promenades et découvertes. Les lieux et informations pratiques de ce jeu ne constituent pas des recommandations réelles.", "voiture", 5, "hiver", "Séjour entre amis à Colmar" }
                });

            migrationBuilder.InsertData(
                table: "Activities",
                columns: new[] { "Id", "Address", "Category", "Day", "Description", "OpeningHours", "Phone", "Title", "TravelGuideId", "VisitOrder", "Website" },
                values: new object[,]
                {
                    { 10001, "11, rue de Démonstration, Bordeaux (adresse fictive)", "activité", 1, "Activité fictive de démonstration à Bordeaux. Jour 1, visite 1. Prévoir un temps de découverte puis une pause. Aucune réservation réelle ne doit être effectuée à partir de ces informations.", "09:00–12:00 (démonstration)", "Non renseigné", "Atelier de découverte locale — étape 1.1", 1001, 1, "" },
                    { 10002, "12, rue de Démonstration, Bordeaux (adresse fictive)", "parc", 1, "Activité fictive de démonstration à Bordeaux. Jour 1, visite 2. Prévoir un temps de découverte puis une pause. Aucune réservation réelle ne doit être effectuée à partir de ces informations.", "14:00–17:00 (démonstration)", "Non renseigné", "Parc des horizons — étape 1.2", 1001, 2, "" },
                    { 10003, "13, rue de Démonstration, Bordeaux (adresse fictive)", "grotte", 1, "Activité fictive de démonstration à Bordeaux. Jour 1, visite 3. Prévoir un temps de découverte puis une pause. Aucune réservation réelle ne doit être effectuée à partir de ces informations.", "17:30–19:00 (démonstration)", "Non renseigné", "Grotte des lumières — étape 1.3", 1001, 3, "" },
                    { 10004, "21, rue de Démonstration, Bordeaux (adresse fictive)", "parc", 2, "Activité fictive de démonstration à Bordeaux. Jour 2, visite 1. Prévoir un temps de découverte puis une pause. Aucune réservation réelle ne doit être effectuée à partir de ces informations.", "09:00–12:00 (démonstration)", "Non renseigné", "Parc des horizons — étape 2.1", 1001, 1, "" },
                    { 10005, "22, rue de Démonstration, Bordeaux (adresse fictive)", "grotte", 2, "Activité fictive de démonstration à Bordeaux. Jour 2, visite 2. Prévoir un temps de découverte puis une pause. Aucune réservation réelle ne doit être effectuée à partir de ces informations.", "14:00–17:00 (démonstration)", "Non renseigné", "Grotte des lumières — étape 2.2", 1001, 2, "" },
                    { 10006, "23, rue de Démonstration, Bordeaux (adresse fictive)", "musée", 2, "Activité fictive de démonstration à Bordeaux. Jour 2, visite 3. Prévoir un temps de découverte puis une pause. Aucune réservation réelle ne doit être effectuée à partir de ces informations.", "17:30–19:00 (démonstration)", "Non renseigné", "Musée des découvertes — étape 2.3", 1001, 3, "" },
                    { 10007, "31, rue de Démonstration, Bordeaux (adresse fictive)", "grotte", 3, "Activité fictive de démonstration à Bordeaux. Jour 3, visite 1. Prévoir un temps de découverte puis une pause. Aucune réservation réelle ne doit être effectuée à partir de ces informations.", "09:00–12:00 (démonstration)", "Non renseigné", "Grotte des lumières — étape 3.1", 1001, 1, "" },
                    { 10008, "32, rue de Démonstration, Bordeaux (adresse fictive)", "musée", 3, "Activité fictive de démonstration à Bordeaux. Jour 3, visite 2. Prévoir un temps de découverte puis une pause. Aucune réservation réelle ne doit être effectuée à partir de ces informations.", "14:00–17:00 (démonstration)", "Non renseigné", "Musée des découvertes — étape 3.2", 1001, 2, "" },
                    { 10009, "33, rue de Démonstration, Bordeaux (adresse fictive)", "château", 3, "Activité fictive de démonstration à Bordeaux. Jour 3, visite 3. Prévoir un temps de découverte puis une pause. Aucune réservation réelle ne doit être effectuée à partir de ces informations.", "17:30–19:00 (démonstration)", "Non renseigné", "Château des voyageurs — étape 3.3", 1001, 3, "" },
                    { 10010, "11, rue de Démonstration, Toulouse (adresse fictive)", "parc", 1, "Activité fictive de démonstration à Toulouse. Jour 1, visite 1. Prévoir un temps de découverte puis une pause. Aucune réservation réelle ne doit être effectuée à partir de ces informations.", "09:00–12:00 (démonstration)", "Non renseigné", "Parc des horizons — étape 1.1", 1002, 1, "" },
                    { 10011, "12, rue de Démonstration, Toulouse (adresse fictive)", "grotte", 1, "Activité fictive de démonstration à Toulouse. Jour 1, visite 2. Prévoir un temps de découverte puis une pause. Aucune réservation réelle ne doit être effectuée à partir de ces informations.", "14:00–17:00 (démonstration)", "Non renseigné", "Grotte des lumières — étape 1.2", 1002, 2, "" },
                    { 10012, "13, rue de Démonstration, Toulouse (adresse fictive)", "musée", 1, "Activité fictive de démonstration à Toulouse. Jour 1, visite 3. Prévoir un temps de découverte puis une pause. Aucune réservation réelle ne doit être effectuée à partir de ces informations.", "17:30–19:00 (démonstration)", "Non renseigné", "Musée des découvertes — étape 1.3", 1002, 3, "" },
                    { 10013, "21, rue de Démonstration, Toulouse (adresse fictive)", "grotte", 2, "Activité fictive de démonstration à Toulouse. Jour 2, visite 1. Prévoir un temps de découverte puis une pause. Aucune réservation réelle ne doit être effectuée à partir de ces informations.", "09:00–12:00 (démonstration)", "Non renseigné", "Grotte des lumières — étape 2.1", 1002, 1, "" },
                    { 10014, "22, rue de Démonstration, Toulouse (adresse fictive)", "musée", 2, "Activité fictive de démonstration à Toulouse. Jour 2, visite 2. Prévoir un temps de découverte puis une pause. Aucune réservation réelle ne doit être effectuée à partir de ces informations.", "14:00–17:00 (démonstration)", "Non renseigné", "Musée des découvertes — étape 2.2", 1002, 2, "" },
                    { 10015, "23, rue de Démonstration, Toulouse (adresse fictive)", "château", 2, "Activité fictive de démonstration à Toulouse. Jour 2, visite 3. Prévoir un temps de découverte puis une pause. Aucune réservation réelle ne doit être effectuée à partir de ces informations.", "17:30–19:00 (démonstration)", "Non renseigné", "Château des voyageurs — étape 2.3", 1002, 3, "" },
                    { 10016, "31, rue de Démonstration, Toulouse (adresse fictive)", "musée", 3, "Activité fictive de démonstration à Toulouse. Jour 3, visite 1. Prévoir un temps de découverte puis une pause. Aucune réservation réelle ne doit être effectuée à partir de ces informations.", "09:00–12:00 (démonstration)", "Non renseigné", "Musée des découvertes — étape 3.1", 1002, 1, "" },
                    { 10017, "32, rue de Démonstration, Toulouse (adresse fictive)", "château", 3, "Activité fictive de démonstration à Toulouse. Jour 3, visite 2. Prévoir un temps de découverte puis une pause. Aucune réservation réelle ne doit être effectuée à partir de ces informations.", "14:00–17:00 (démonstration)", "Non renseigné", "Château des voyageurs — étape 3.2", 1002, 2, "" },
                    { 10018, "33, rue de Démonstration, Toulouse (adresse fictive)", "activité", 3, "Activité fictive de démonstration à Toulouse. Jour 3, visite 3. Prévoir un temps de découverte puis une pause. Aucune réservation réelle ne doit être effectuée à partir de ces informations.", "17:30–19:00 (démonstration)", "Non renseigné", "Atelier de découverte locale — étape 3.3", 1002, 3, "" },
                    { 10019, "41, rue de Démonstration, Toulouse (adresse fictive)", "château", 4, "Activité fictive de démonstration à Toulouse. Jour 4, visite 1. Prévoir un temps de découverte puis une pause. Aucune réservation réelle ne doit être effectuée à partir de ces informations.", "09:00–12:00 (démonstration)", "Non renseigné", "Château des voyageurs — étape 4.1", 1002, 1, "" },
                    { 10020, "42, rue de Démonstration, Toulouse (adresse fictive)", "activité", 4, "Activité fictive de démonstration à Toulouse. Jour 4, visite 2. Prévoir un temps de découverte puis une pause. Aucune réservation réelle ne doit être effectuée à partir de ces informations.", "14:00–17:00 (démonstration)", "Non renseigné", "Atelier de découverte locale — étape 4.2", 1002, 2, "" },
                    { 10021, "43, rue de Démonstration, Toulouse (adresse fictive)", "parc", 4, "Activité fictive de démonstration à Toulouse. Jour 4, visite 3. Prévoir un temps de découverte puis une pause. Aucune réservation réelle ne doit être effectuée à partir de ces informations.", "17:30–19:00 (démonstration)", "Non renseigné", "Parc des horizons — étape 4.3", 1002, 3, "" },
                    { 10022, "11, rue de Démonstration, Strasbourg (adresse fictive)", "grotte", 1, "Activité fictive de démonstration à Strasbourg. Jour 1, visite 1. Prévoir un temps de découverte puis une pause. Aucune réservation réelle ne doit être effectuée à partir de ces informations.", "09:00–12:00 (démonstration)", "Non renseigné", "Grotte des lumières — étape 1.1", 1003, 1, "" },
                    { 10023, "12, rue de Démonstration, Strasbourg (adresse fictive)", "musée", 1, "Activité fictive de démonstration à Strasbourg. Jour 1, visite 2. Prévoir un temps de découverte puis une pause. Aucune réservation réelle ne doit être effectuée à partir de ces informations.", "14:00–17:00 (démonstration)", "Non renseigné", "Musée des découvertes — étape 1.2", 1003, 2, "" },
                    { 10024, "13, rue de Démonstration, Strasbourg (adresse fictive)", "château", 1, "Activité fictive de démonstration à Strasbourg. Jour 1, visite 3. Prévoir un temps de découverte puis une pause. Aucune réservation réelle ne doit être effectuée à partir de ces informations.", "17:30–19:00 (démonstration)", "Non renseigné", "Château des voyageurs — étape 1.3", 1003, 3, "" },
                    { 10025, "21, rue de Démonstration, Strasbourg (adresse fictive)", "musée", 2, "Activité fictive de démonstration à Strasbourg. Jour 2, visite 1. Prévoir un temps de découverte puis une pause. Aucune réservation réelle ne doit être effectuée à partir de ces informations.", "09:00–12:00 (démonstration)", "Non renseigné", "Musée des découvertes — étape 2.1", 1003, 1, "" },
                    { 10026, "22, rue de Démonstration, Strasbourg (adresse fictive)", "château", 2, "Activité fictive de démonstration à Strasbourg. Jour 2, visite 2. Prévoir un temps de découverte puis une pause. Aucune réservation réelle ne doit être effectuée à partir de ces informations.", "14:00–17:00 (démonstration)", "Non renseigné", "Château des voyageurs — étape 2.2", 1003, 2, "" },
                    { 10027, "23, rue de Démonstration, Strasbourg (adresse fictive)", "activité", 2, "Activité fictive de démonstration à Strasbourg. Jour 2, visite 3. Prévoir un temps de découverte puis une pause. Aucune réservation réelle ne doit être effectuée à partir de ces informations.", "17:30–19:00 (démonstration)", "Non renseigné", "Atelier de découverte locale — étape 2.3", 1003, 3, "" },
                    { 10028, "31, rue de Démonstration, Strasbourg (adresse fictive)", "château", 3, "Activité fictive de démonstration à Strasbourg. Jour 3, visite 1. Prévoir un temps de découverte puis une pause. Aucune réservation réelle ne doit être effectuée à partir de ces informations.", "09:00–12:00 (démonstration)", "Non renseigné", "Château des voyageurs — étape 3.1", 1003, 1, "" },
                    { 10029, "32, rue de Démonstration, Strasbourg (adresse fictive)", "activité", 3, "Activité fictive de démonstration à Strasbourg. Jour 3, visite 2. Prévoir un temps de découverte puis une pause. Aucune réservation réelle ne doit être effectuée à partir de ces informations.", "14:00–17:00 (démonstration)", "Non renseigné", "Atelier de découverte locale — étape 3.2", 1003, 2, "" },
                    { 10030, "33, rue de Démonstration, Strasbourg (adresse fictive)", "parc", 3, "Activité fictive de démonstration à Strasbourg. Jour 3, visite 3. Prévoir un temps de découverte puis une pause. Aucune réservation réelle ne doit être effectuée à partir de ces informations.", "17:30–19:00 (démonstration)", "Non renseigné", "Parc des horizons — étape 3.3", 1003, 3, "" },
                    { 10031, "41, rue de Démonstration, Strasbourg (adresse fictive)", "activité", 4, "Activité fictive de démonstration à Strasbourg. Jour 4, visite 1. Prévoir un temps de découverte puis une pause. Aucune réservation réelle ne doit être effectuée à partir de ces informations.", "09:00–12:00 (démonstration)", "Non renseigné", "Atelier de découverte locale — étape 4.1", 1003, 1, "" },
                    { 10032, "42, rue de Démonstration, Strasbourg (adresse fictive)", "parc", 4, "Activité fictive de démonstration à Strasbourg. Jour 4, visite 2. Prévoir un temps de découverte puis une pause. Aucune réservation réelle ne doit être effectuée à partir de ces informations.", "14:00–17:00 (démonstration)", "Non renseigné", "Parc des horizons — étape 4.2", 1003, 2, "" },
                    { 10033, "43, rue de Démonstration, Strasbourg (adresse fictive)", "grotte", 4, "Activité fictive de démonstration à Strasbourg. Jour 4, visite 3. Prévoir un temps de découverte puis une pause. Aucune réservation réelle ne doit être effectuée à partir de ces informations.", "17:30–19:00 (démonstration)", "Non renseigné", "Grotte des lumières — étape 4.3", 1003, 3, "" },
                    { 10034, "51, rue de Démonstration, Strasbourg (adresse fictive)", "parc", 5, "Activité fictive de démonstration à Strasbourg. Jour 5, visite 1. Prévoir un temps de découverte puis une pause. Aucune réservation réelle ne doit être effectuée à partir de ces informations.", "09:00–12:00 (démonstration)", "Non renseigné", "Parc des horizons — étape 5.1", 1003, 1, "" },
                    { 10035, "52, rue de Démonstration, Strasbourg (adresse fictive)", "grotte", 5, "Activité fictive de démonstration à Strasbourg. Jour 5, visite 2. Prévoir un temps de découverte puis une pause. Aucune réservation réelle ne doit être effectuée à partir de ces informations.", "14:00–17:00 (démonstration)", "Non renseigné", "Grotte des lumières — étape 5.2", 1003, 2, "" },
                    { 10036, "53, rue de Démonstration, Strasbourg (adresse fictive)", "musée", 5, "Activité fictive de démonstration à Strasbourg. Jour 5, visite 3. Prévoir un temps de découverte puis une pause. Aucune réservation réelle ne doit être effectuée à partir de ces informations.", "17:30–19:00 (démonstration)", "Non renseigné", "Musée des découvertes — étape 5.3", 1003, 3, "" },
                    { 10037, "11, rue de Démonstration, Nantes (adresse fictive)", "musée", 1, "Activité fictive de démonstration à Nantes. Jour 1, visite 1. Prévoir un temps de découverte puis une pause. Aucune réservation réelle ne doit être effectuée à partir de ces informations.", "09:00–12:00 (démonstration)", "Non renseigné", "Musée des découvertes — étape 1.1", 1004, 1, "" },
                    { 10038, "12, rue de Démonstration, Nantes (adresse fictive)", "château", 1, "Activité fictive de démonstration à Nantes. Jour 1, visite 2. Prévoir un temps de découverte puis une pause. Aucune réservation réelle ne doit être effectuée à partir de ces informations.", "14:00–17:00 (démonstration)", "Non renseigné", "Château des voyageurs — étape 1.2", 1004, 2, "" },
                    { 10039, "13, rue de Démonstration, Nantes (adresse fictive)", "activité", 1, "Activité fictive de démonstration à Nantes. Jour 1, visite 3. Prévoir un temps de découverte puis une pause. Aucune réservation réelle ne doit être effectuée à partir de ces informations.", "17:30–19:00 (démonstration)", "Non renseigné", "Atelier de découverte locale — étape 1.3", 1004, 3, "" },
                    { 10040, "21, rue de Démonstration, Nantes (adresse fictive)", "château", 2, "Activité fictive de démonstration à Nantes. Jour 2, visite 1. Prévoir un temps de découverte puis une pause. Aucune réservation réelle ne doit être effectuée à partir de ces informations.", "09:00–12:00 (démonstration)", "Non renseigné", "Château des voyageurs — étape 2.1", 1004, 1, "" },
                    { 10041, "22, rue de Démonstration, Nantes (adresse fictive)", "activité", 2, "Activité fictive de démonstration à Nantes. Jour 2, visite 2. Prévoir un temps de découverte puis une pause. Aucune réservation réelle ne doit être effectuée à partir de ces informations.", "14:00–17:00 (démonstration)", "Non renseigné", "Atelier de découverte locale — étape 2.2", 1004, 2, "" },
                    { 10042, "23, rue de Démonstration, Nantes (adresse fictive)", "parc", 2, "Activité fictive de démonstration à Nantes. Jour 2, visite 3. Prévoir un temps de découverte puis une pause. Aucune réservation réelle ne doit être effectuée à partir de ces informations.", "17:30–19:00 (démonstration)", "Non renseigné", "Parc des horizons — étape 2.3", 1004, 3, "" },
                    { 10043, "31, rue de Démonstration, Nantes (adresse fictive)", "activité", 3, "Activité fictive de démonstration à Nantes. Jour 3, visite 1. Prévoir un temps de découverte puis une pause. Aucune réservation réelle ne doit être effectuée à partir de ces informations.", "09:00–12:00 (démonstration)", "Non renseigné", "Atelier de découverte locale — étape 3.1", 1004, 1, "" },
                    { 10044, "32, rue de Démonstration, Nantes (adresse fictive)", "parc", 3, "Activité fictive de démonstration à Nantes. Jour 3, visite 2. Prévoir un temps de découverte puis une pause. Aucune réservation réelle ne doit être effectuée à partir de ces informations.", "14:00–17:00 (démonstration)", "Non renseigné", "Parc des horizons — étape 3.2", 1004, 2, "" },
                    { 10045, "33, rue de Démonstration, Nantes (adresse fictive)", "grotte", 3, "Activité fictive de démonstration à Nantes. Jour 3, visite 3. Prévoir un temps de découverte puis une pause. Aucune réservation réelle ne doit être effectuée à partir de ces informations.", "17:30–19:00 (démonstration)", "Non renseigné", "Grotte des lumières — étape 3.3", 1004, 3, "" },
                    { 10046, "11, rue de Démonstration, Lille (adresse fictive)", "château", 1, "Activité fictive de démonstration à Lille. Jour 1, visite 1. Prévoir un temps de découverte puis une pause. Aucune réservation réelle ne doit être effectuée à partir de ces informations.", "09:00–12:00 (démonstration)", "Non renseigné", "Château des voyageurs — étape 1.1", 1005, 1, "" },
                    { 10047, "12, rue de Démonstration, Lille (adresse fictive)", "activité", 1, "Activité fictive de démonstration à Lille. Jour 1, visite 2. Prévoir un temps de découverte puis une pause. Aucune réservation réelle ne doit être effectuée à partir de ces informations.", "14:00–17:00 (démonstration)", "Non renseigné", "Atelier de découverte locale — étape 1.2", 1005, 2, "" },
                    { 10048, "13, rue de Démonstration, Lille (adresse fictive)", "parc", 1, "Activité fictive de démonstration à Lille. Jour 1, visite 3. Prévoir un temps de découverte puis une pause. Aucune réservation réelle ne doit être effectuée à partir de ces informations.", "17:30–19:00 (démonstration)", "Non renseigné", "Parc des horizons — étape 1.3", 1005, 3, "" },
                    { 10049, "21, rue de Démonstration, Lille (adresse fictive)", "activité", 2, "Activité fictive de démonstration à Lille. Jour 2, visite 1. Prévoir un temps de découverte puis une pause. Aucune réservation réelle ne doit être effectuée à partir de ces informations.", "09:00–12:00 (démonstration)", "Non renseigné", "Atelier de découverte locale — étape 2.1", 1005, 1, "" },
                    { 10050, "22, rue de Démonstration, Lille (adresse fictive)", "parc", 2, "Activité fictive de démonstration à Lille. Jour 2, visite 2. Prévoir un temps de découverte puis une pause. Aucune réservation réelle ne doit être effectuée à partir de ces informations.", "14:00–17:00 (démonstration)", "Non renseigné", "Parc des horizons — étape 2.2", 1005, 2, "" },
                    { 10051, "23, rue de Démonstration, Lille (adresse fictive)", "grotte", 2, "Activité fictive de démonstration à Lille. Jour 2, visite 3. Prévoir un temps de découverte puis une pause. Aucune réservation réelle ne doit être effectuée à partir de ces informations.", "17:30–19:00 (démonstration)", "Non renseigné", "Grotte des lumières — étape 2.3", 1005, 3, "" },
                    { 10052, "31, rue de Démonstration, Lille (adresse fictive)", "parc", 3, "Activité fictive de démonstration à Lille. Jour 3, visite 1. Prévoir un temps de découverte puis une pause. Aucune réservation réelle ne doit être effectuée à partir de ces informations.", "09:00–12:00 (démonstration)", "Non renseigné", "Parc des horizons — étape 3.1", 1005, 1, "" },
                    { 10053, "32, rue de Démonstration, Lille (adresse fictive)", "grotte", 3, "Activité fictive de démonstration à Lille. Jour 3, visite 2. Prévoir un temps de découverte puis une pause. Aucune réservation réelle ne doit être effectuée à partir de ces informations.", "14:00–17:00 (démonstration)", "Non renseigné", "Grotte des lumières — étape 3.2", 1005, 2, "" },
                    { 10054, "33, rue de Démonstration, Lille (adresse fictive)", "musée", 3, "Activité fictive de démonstration à Lille. Jour 3, visite 3. Prévoir un temps de découverte puis une pause. Aucune réservation réelle ne doit être effectuée à partir de ces informations.", "17:30–19:00 (démonstration)", "Non renseigné", "Musée des découvertes — étape 3.3", 1005, 3, "" },
                    { 10055, "41, rue de Démonstration, Lille (adresse fictive)", "grotte", 4, "Activité fictive de démonstration à Lille. Jour 4, visite 1. Prévoir un temps de découverte puis une pause. Aucune réservation réelle ne doit être effectuée à partir de ces informations.", "09:00–12:00 (démonstration)", "Non renseigné", "Grotte des lumières — étape 4.1", 1005, 1, "" },
                    { 10056, "42, rue de Démonstration, Lille (adresse fictive)", "musée", 4, "Activité fictive de démonstration à Lille. Jour 4, visite 2. Prévoir un temps de découverte puis une pause. Aucune réservation réelle ne doit être effectuée à partir de ces informations.", "14:00–17:00 (démonstration)", "Non renseigné", "Musée des découvertes — étape 4.2", 1005, 2, "" },
                    { 10057, "43, rue de Démonstration, Lille (adresse fictive)", "château", 4, "Activité fictive de démonstration à Lille. Jour 4, visite 3. Prévoir un temps de découverte puis une pause. Aucune réservation réelle ne doit être effectuée à partir de ces informations.", "17:30–19:00 (démonstration)", "Non renseigné", "Château des voyageurs — étape 4.3", 1005, 3, "" },
                    { 10058, "11, rue de Démonstration, Marseille (adresse fictive)", "activité", 1, "Activité fictive de démonstration à Marseille. Jour 1, visite 1. Prévoir un temps de découverte puis une pause. Aucune réservation réelle ne doit être effectuée à partir de ces informations.", "09:00–12:00 (démonstration)", "Non renseigné", "Atelier de découverte locale — étape 1.1", 1006, 1, "" },
                    { 10059, "12, rue de Démonstration, Marseille (adresse fictive)", "parc", 1, "Activité fictive de démonstration à Marseille. Jour 1, visite 2. Prévoir un temps de découverte puis une pause. Aucune réservation réelle ne doit être effectuée à partir de ces informations.", "14:00–17:00 (démonstration)", "Non renseigné", "Parc des horizons — étape 1.2", 1006, 2, "" },
                    { 10060, "13, rue de Démonstration, Marseille (adresse fictive)", "grotte", 1, "Activité fictive de démonstration à Marseille. Jour 1, visite 3. Prévoir un temps de découverte puis une pause. Aucune réservation réelle ne doit être effectuée à partir de ces informations.", "17:30–19:00 (démonstration)", "Non renseigné", "Grotte des lumières — étape 1.3", 1006, 3, "" },
                    { 10061, "21, rue de Démonstration, Marseille (adresse fictive)", "parc", 2, "Activité fictive de démonstration à Marseille. Jour 2, visite 1. Prévoir un temps de découverte puis une pause. Aucune réservation réelle ne doit être effectuée à partir de ces informations.", "09:00–12:00 (démonstration)", "Non renseigné", "Parc des horizons — étape 2.1", 1006, 1, "" },
                    { 10062, "22, rue de Démonstration, Marseille (adresse fictive)", "grotte", 2, "Activité fictive de démonstration à Marseille. Jour 2, visite 2. Prévoir un temps de découverte puis une pause. Aucune réservation réelle ne doit être effectuée à partir de ces informations.", "14:00–17:00 (démonstration)", "Non renseigné", "Grotte des lumières — étape 2.2", 1006, 2, "" },
                    { 10063, "23, rue de Démonstration, Marseille (adresse fictive)", "musée", 2, "Activité fictive de démonstration à Marseille. Jour 2, visite 3. Prévoir un temps de découverte puis une pause. Aucune réservation réelle ne doit être effectuée à partir de ces informations.", "17:30–19:00 (démonstration)", "Non renseigné", "Musée des découvertes — étape 2.3", 1006, 3, "" },
                    { 10064, "31, rue de Démonstration, Marseille (adresse fictive)", "grotte", 3, "Activité fictive de démonstration à Marseille. Jour 3, visite 1. Prévoir un temps de découverte puis une pause. Aucune réservation réelle ne doit être effectuée à partir de ces informations.", "09:00–12:00 (démonstration)", "Non renseigné", "Grotte des lumières — étape 3.1", 1006, 1, "" },
                    { 10065, "32, rue de Démonstration, Marseille (adresse fictive)", "musée", 3, "Activité fictive de démonstration à Marseille. Jour 3, visite 2. Prévoir un temps de découverte puis une pause. Aucune réservation réelle ne doit être effectuée à partir de ces informations.", "14:00–17:00 (démonstration)", "Non renseigné", "Musée des découvertes — étape 3.2", 1006, 2, "" },
                    { 10066, "33, rue de Démonstration, Marseille (adresse fictive)", "château", 3, "Activité fictive de démonstration à Marseille. Jour 3, visite 3. Prévoir un temps de découverte puis une pause. Aucune réservation réelle ne doit être effectuée à partir de ces informations.", "17:30–19:00 (démonstration)", "Non renseigné", "Château des voyageurs — étape 3.3", 1006, 3, "" },
                    { 10067, "41, rue de Démonstration, Marseille (adresse fictive)", "musée", 4, "Activité fictive de démonstration à Marseille. Jour 4, visite 1. Prévoir un temps de découverte puis une pause. Aucune réservation réelle ne doit être effectuée à partir de ces informations.", "09:00–12:00 (démonstration)", "Non renseigné", "Musée des découvertes — étape 4.1", 1006, 1, "" },
                    { 10068, "42, rue de Démonstration, Marseille (adresse fictive)", "château", 4, "Activité fictive de démonstration à Marseille. Jour 4, visite 2. Prévoir un temps de découverte puis une pause. Aucune réservation réelle ne doit être effectuée à partir de ces informations.", "14:00–17:00 (démonstration)", "Non renseigné", "Château des voyageurs — étape 4.2", 1006, 2, "" },
                    { 10069, "43, rue de Démonstration, Marseille (adresse fictive)", "activité", 4, "Activité fictive de démonstration à Marseille. Jour 4, visite 3. Prévoir un temps de découverte puis une pause. Aucune réservation réelle ne doit être effectuée à partir de ces informations.", "17:30–19:00 (démonstration)", "Non renseigné", "Atelier de découverte locale — étape 4.3", 1006, 3, "" },
                    { 10070, "51, rue de Démonstration, Marseille (adresse fictive)", "château", 5, "Activité fictive de démonstration à Marseille. Jour 5, visite 1. Prévoir un temps de découverte puis une pause. Aucune réservation réelle ne doit être effectuée à partir de ces informations.", "09:00–12:00 (démonstration)", "Non renseigné", "Château des voyageurs — étape 5.1", 1006, 1, "" },
                    { 10071, "52, rue de Démonstration, Marseille (adresse fictive)", "activité", 5, "Activité fictive de démonstration à Marseille. Jour 5, visite 2. Prévoir un temps de découverte puis une pause. Aucune réservation réelle ne doit être effectuée à partir de ces informations.", "14:00–17:00 (démonstration)", "Non renseigné", "Atelier de découverte locale — étape 5.2", 1006, 2, "" },
                    { 10072, "53, rue de Démonstration, Marseille (adresse fictive)", "parc", 5, "Activité fictive de démonstration à Marseille. Jour 5, visite 3. Prévoir un temps de découverte puis une pause. Aucune réservation réelle ne doit être effectuée à partir de ces informations.", "17:30–19:00 (démonstration)", "Non renseigné", "Parc des horizons — étape 5.3", 1006, 3, "" },
                    { 10073, "11, rue de Démonstration, Nice (adresse fictive)", "parc", 1, "Activité fictive de démonstration à Nice. Jour 1, visite 1. Prévoir un temps de découverte puis une pause. Aucune réservation réelle ne doit être effectuée à partir de ces informations.", "09:00–12:00 (démonstration)", "Non renseigné", "Parc des horizons — étape 1.1", 1007, 1, "" },
                    { 10074, "12, rue de Démonstration, Nice (adresse fictive)", "grotte", 1, "Activité fictive de démonstration à Nice. Jour 1, visite 2. Prévoir un temps de découverte puis une pause. Aucune réservation réelle ne doit être effectuée à partir de ces informations.", "14:00–17:00 (démonstration)", "Non renseigné", "Grotte des lumières — étape 1.2", 1007, 2, "" },
                    { 10075, "13, rue de Démonstration, Nice (adresse fictive)", "musée", 1, "Activité fictive de démonstration à Nice. Jour 1, visite 3. Prévoir un temps de découverte puis une pause. Aucune réservation réelle ne doit être effectuée à partir de ces informations.", "17:30–19:00 (démonstration)", "Non renseigné", "Musée des découvertes — étape 1.3", 1007, 3, "" },
                    { 10076, "21, rue de Démonstration, Nice (adresse fictive)", "grotte", 2, "Activité fictive de démonstration à Nice. Jour 2, visite 1. Prévoir un temps de découverte puis une pause. Aucune réservation réelle ne doit être effectuée à partir de ces informations.", "09:00–12:00 (démonstration)", "Non renseigné", "Grotte des lumières — étape 2.1", 1007, 1, "" },
                    { 10077, "22, rue de Démonstration, Nice (adresse fictive)", "musée", 2, "Activité fictive de démonstration à Nice. Jour 2, visite 2. Prévoir un temps de découverte puis une pause. Aucune réservation réelle ne doit être effectuée à partir de ces informations.", "14:00–17:00 (démonstration)", "Non renseigné", "Musée des découvertes — étape 2.2", 1007, 2, "" },
                    { 10078, "23, rue de Démonstration, Nice (adresse fictive)", "château", 2, "Activité fictive de démonstration à Nice. Jour 2, visite 3. Prévoir un temps de découverte puis une pause. Aucune réservation réelle ne doit être effectuée à partir de ces informations.", "17:30–19:00 (démonstration)", "Non renseigné", "Château des voyageurs — étape 2.3", 1007, 3, "" },
                    { 10079, "31, rue de Démonstration, Nice (adresse fictive)", "musée", 3, "Activité fictive de démonstration à Nice. Jour 3, visite 1. Prévoir un temps de découverte puis une pause. Aucune réservation réelle ne doit être effectuée à partir de ces informations.", "09:00–12:00 (démonstration)", "Non renseigné", "Musée des découvertes — étape 3.1", 1007, 1, "" },
                    { 10080, "32, rue de Démonstration, Nice (adresse fictive)", "château", 3, "Activité fictive de démonstration à Nice. Jour 3, visite 2. Prévoir un temps de découverte puis une pause. Aucune réservation réelle ne doit être effectuée à partir de ces informations.", "14:00–17:00 (démonstration)", "Non renseigné", "Château des voyageurs — étape 3.2", 1007, 2, "" },
                    { 10081, "33, rue de Démonstration, Nice (adresse fictive)", "activité", 3, "Activité fictive de démonstration à Nice. Jour 3, visite 3. Prévoir un temps de découverte puis une pause. Aucune réservation réelle ne doit être effectuée à partir de ces informations.", "17:30–19:00 (démonstration)", "Non renseigné", "Atelier de découverte locale — étape 3.3", 1007, 3, "" },
                    { 10082, "11, rue de Démonstration, Annecy (adresse fictive)", "grotte", 1, "Activité fictive de démonstration à Annecy. Jour 1, visite 1. Prévoir un temps de découverte puis une pause. Aucune réservation réelle ne doit être effectuée à partir de ces informations.", "09:00–12:00 (démonstration)", "Non renseigné", "Grotte des lumières — étape 1.1", 1008, 1, "" },
                    { 10083, "12, rue de Démonstration, Annecy (adresse fictive)", "musée", 1, "Activité fictive de démonstration à Annecy. Jour 1, visite 2. Prévoir un temps de découverte puis une pause. Aucune réservation réelle ne doit être effectuée à partir de ces informations.", "14:00–17:00 (démonstration)", "Non renseigné", "Musée des découvertes — étape 1.2", 1008, 2, "" },
                    { 10084, "13, rue de Démonstration, Annecy (adresse fictive)", "château", 1, "Activité fictive de démonstration à Annecy. Jour 1, visite 3. Prévoir un temps de découverte puis une pause. Aucune réservation réelle ne doit être effectuée à partir de ces informations.", "17:30–19:00 (démonstration)", "Non renseigné", "Château des voyageurs — étape 1.3", 1008, 3, "" },
                    { 10085, "21, rue de Démonstration, Annecy (adresse fictive)", "musée", 2, "Activité fictive de démonstration à Annecy. Jour 2, visite 1. Prévoir un temps de découverte puis une pause. Aucune réservation réelle ne doit être effectuée à partir de ces informations.", "09:00–12:00 (démonstration)", "Non renseigné", "Musée des découvertes — étape 2.1", 1008, 1, "" },
                    { 10086, "22, rue de Démonstration, Annecy (adresse fictive)", "château", 2, "Activité fictive de démonstration à Annecy. Jour 2, visite 2. Prévoir un temps de découverte puis une pause. Aucune réservation réelle ne doit être effectuée à partir de ces informations.", "14:00–17:00 (démonstration)", "Non renseigné", "Château des voyageurs — étape 2.2", 1008, 2, "" },
                    { 10087, "23, rue de Démonstration, Annecy (adresse fictive)", "activité", 2, "Activité fictive de démonstration à Annecy. Jour 2, visite 3. Prévoir un temps de découverte puis une pause. Aucune réservation réelle ne doit être effectuée à partir de ces informations.", "17:30–19:00 (démonstration)", "Non renseigné", "Atelier de découverte locale — étape 2.3", 1008, 3, "" },
                    { 10088, "31, rue de Démonstration, Annecy (adresse fictive)", "château", 3, "Activité fictive de démonstration à Annecy. Jour 3, visite 1. Prévoir un temps de découverte puis une pause. Aucune réservation réelle ne doit être effectuée à partir de ces informations.", "09:00–12:00 (démonstration)", "Non renseigné", "Château des voyageurs — étape 3.1", 1008, 1, "" },
                    { 10089, "32, rue de Démonstration, Annecy (adresse fictive)", "activité", 3, "Activité fictive de démonstration à Annecy. Jour 3, visite 2. Prévoir un temps de découverte puis une pause. Aucune réservation réelle ne doit être effectuée à partir de ces informations.", "14:00–17:00 (démonstration)", "Non renseigné", "Atelier de découverte locale — étape 3.2", 1008, 2, "" },
                    { 10090, "33, rue de Démonstration, Annecy (adresse fictive)", "parc", 3, "Activité fictive de démonstration à Annecy. Jour 3, visite 3. Prévoir un temps de découverte puis une pause. Aucune réservation réelle ne doit être effectuée à partir de ces informations.", "17:30–19:00 (démonstration)", "Non renseigné", "Parc des horizons — étape 3.3", 1008, 3, "" },
                    { 10091, "41, rue de Démonstration, Annecy (adresse fictive)", "activité", 4, "Activité fictive de démonstration à Annecy. Jour 4, visite 1. Prévoir un temps de découverte puis une pause. Aucune réservation réelle ne doit être effectuée à partir de ces informations.", "09:00–12:00 (démonstration)", "Non renseigné", "Atelier de découverte locale — étape 4.1", 1008, 1, "" },
                    { 10092, "42, rue de Démonstration, Annecy (adresse fictive)", "parc", 4, "Activité fictive de démonstration à Annecy. Jour 4, visite 2. Prévoir un temps de découverte puis une pause. Aucune réservation réelle ne doit être effectuée à partir de ces informations.", "14:00–17:00 (démonstration)", "Non renseigné", "Parc des horizons — étape 4.2", 1008, 2, "" },
                    { 10093, "43, rue de Démonstration, Annecy (adresse fictive)", "grotte", 4, "Activité fictive de démonstration à Annecy. Jour 4, visite 3. Prévoir un temps de découverte puis une pause. Aucune réservation réelle ne doit être effectuée à partir de ces informations.", "17:30–19:00 (démonstration)", "Non renseigné", "Grotte des lumières — étape 4.3", 1008, 3, "" },
                    { 10094, "11, rue de Démonstration, Grenoble (adresse fictive)", "musée", 1, "Activité fictive de démonstration à Grenoble. Jour 1, visite 1. Prévoir un temps de découverte puis une pause. Aucune réservation réelle ne doit être effectuée à partir de ces informations.", "09:00–12:00 (démonstration)", "Non renseigné", "Musée des découvertes — étape 1.1", 1009, 1, "" },
                    { 10095, "12, rue de Démonstration, Grenoble (adresse fictive)", "château", 1, "Activité fictive de démonstration à Grenoble. Jour 1, visite 2. Prévoir un temps de découverte puis une pause. Aucune réservation réelle ne doit être effectuée à partir de ces informations.", "14:00–17:00 (démonstration)", "Non renseigné", "Château des voyageurs — étape 1.2", 1009, 2, "" },
                    { 10096, "13, rue de Démonstration, Grenoble (adresse fictive)", "activité", 1, "Activité fictive de démonstration à Grenoble. Jour 1, visite 3. Prévoir un temps de découverte puis une pause. Aucune réservation réelle ne doit être effectuée à partir de ces informations.", "17:30–19:00 (démonstration)", "Non renseigné", "Atelier de découverte locale — étape 1.3", 1009, 3, "" },
                    { 10097, "21, rue de Démonstration, Grenoble (adresse fictive)", "château", 2, "Activité fictive de démonstration à Grenoble. Jour 2, visite 1. Prévoir un temps de découverte puis une pause. Aucune réservation réelle ne doit être effectuée à partir de ces informations.", "09:00–12:00 (démonstration)", "Non renseigné", "Château des voyageurs — étape 2.1", 1009, 1, "" },
                    { 10098, "22, rue de Démonstration, Grenoble (adresse fictive)", "activité", 2, "Activité fictive de démonstration à Grenoble. Jour 2, visite 2. Prévoir un temps de découverte puis une pause. Aucune réservation réelle ne doit être effectuée à partir de ces informations.", "14:00–17:00 (démonstration)", "Non renseigné", "Atelier de découverte locale — étape 2.2", 1009, 2, "" },
                    { 10099, "23, rue de Démonstration, Grenoble (adresse fictive)", "parc", 2, "Activité fictive de démonstration à Grenoble. Jour 2, visite 3. Prévoir un temps de découverte puis une pause. Aucune réservation réelle ne doit être effectuée à partir de ces informations.", "17:30–19:00 (démonstration)", "Non renseigné", "Parc des horizons — étape 2.3", 1009, 3, "" },
                    { 10100, "31, rue de Démonstration, Grenoble (adresse fictive)", "activité", 3, "Activité fictive de démonstration à Grenoble. Jour 3, visite 1. Prévoir un temps de découverte puis une pause. Aucune réservation réelle ne doit être effectuée à partir de ces informations.", "09:00–12:00 (démonstration)", "Non renseigné", "Atelier de découverte locale — étape 3.1", 1009, 1, "" },
                    { 10101, "32, rue de Démonstration, Grenoble (adresse fictive)", "parc", 3, "Activité fictive de démonstration à Grenoble. Jour 3, visite 2. Prévoir un temps de découverte puis une pause. Aucune réservation réelle ne doit être effectuée à partir de ces informations.", "14:00–17:00 (démonstration)", "Non renseigné", "Parc des horizons — étape 3.2", 1009, 2, "" },
                    { 10102, "33, rue de Démonstration, Grenoble (adresse fictive)", "grotte", 3, "Activité fictive de démonstration à Grenoble. Jour 3, visite 3. Prévoir un temps de découverte puis une pause. Aucune réservation réelle ne doit être effectuée à partir de ces informations.", "17:30–19:00 (démonstration)", "Non renseigné", "Grotte des lumières — étape 3.3", 1009, 3, "" },
                    { 10103, "41, rue de Démonstration, Grenoble (adresse fictive)", "parc", 4, "Activité fictive de démonstration à Grenoble. Jour 4, visite 1. Prévoir un temps de découverte puis une pause. Aucune réservation réelle ne doit être effectuée à partir de ces informations.", "09:00–12:00 (démonstration)", "Non renseigné", "Parc des horizons — étape 4.1", 1009, 1, "" },
                    { 10104, "42, rue de Démonstration, Grenoble (adresse fictive)", "grotte", 4, "Activité fictive de démonstration à Grenoble. Jour 4, visite 2. Prévoir un temps de découverte puis une pause. Aucune réservation réelle ne doit être effectuée à partir de ces informations.", "14:00–17:00 (démonstration)", "Non renseigné", "Grotte des lumières — étape 4.2", 1009, 2, "" },
                    { 10105, "43, rue de Démonstration, Grenoble (adresse fictive)", "musée", 4, "Activité fictive de démonstration à Grenoble. Jour 4, visite 3. Prévoir un temps de découverte puis une pause. Aucune réservation réelle ne doit être effectuée à partir de ces informations.", "17:30–19:00 (démonstration)", "Non renseigné", "Musée des découvertes — étape 4.3", 1009, 3, "" },
                    { 10106, "51, rue de Démonstration, Grenoble (adresse fictive)", "grotte", 5, "Activité fictive de démonstration à Grenoble. Jour 5, visite 1. Prévoir un temps de découverte puis une pause. Aucune réservation réelle ne doit être effectuée à partir de ces informations.", "09:00–12:00 (démonstration)", "Non renseigné", "Grotte des lumières — étape 5.1", 1009, 1, "" },
                    { 10107, "52, rue de Démonstration, Grenoble (adresse fictive)", "musée", 5, "Activité fictive de démonstration à Grenoble. Jour 5, visite 2. Prévoir un temps de découverte puis une pause. Aucune réservation réelle ne doit être effectuée à partir de ces informations.", "14:00–17:00 (démonstration)", "Non renseigné", "Musée des découvertes — étape 5.2", 1009, 2, "" },
                    { 10108, "53, rue de Démonstration, Grenoble (adresse fictive)", "château", 5, "Activité fictive de démonstration à Grenoble. Jour 5, visite 3. Prévoir un temps de découverte puis une pause. Aucune réservation réelle ne doit être effectuée à partir de ces informations.", "17:30–19:00 (démonstration)", "Non renseigné", "Château des voyageurs — étape 5.3", 1009, 3, "" },
                    { 10109, "11, rue de Démonstration, Dijon (adresse fictive)", "château", 1, "Activité fictive de démonstration à Dijon. Jour 1, visite 1. Prévoir un temps de découverte puis une pause. Aucune réservation réelle ne doit être effectuée à partir de ces informations.", "09:00–12:00 (démonstration)", "Non renseigné", "Château des voyageurs — étape 1.1", 1010, 1, "" },
                    { 10110, "12, rue de Démonstration, Dijon (adresse fictive)", "activité", 1, "Activité fictive de démonstration à Dijon. Jour 1, visite 2. Prévoir un temps de découverte puis une pause. Aucune réservation réelle ne doit être effectuée à partir de ces informations.", "14:00–17:00 (démonstration)", "Non renseigné", "Atelier de découverte locale — étape 1.2", 1010, 2, "" },
                    { 10111, "13, rue de Démonstration, Dijon (adresse fictive)", "parc", 1, "Activité fictive de démonstration à Dijon. Jour 1, visite 3. Prévoir un temps de découverte puis une pause. Aucune réservation réelle ne doit être effectuée à partir de ces informations.", "17:30–19:00 (démonstration)", "Non renseigné", "Parc des horizons — étape 1.3", 1010, 3, "" },
                    { 10112, "21, rue de Démonstration, Dijon (adresse fictive)", "activité", 2, "Activité fictive de démonstration à Dijon. Jour 2, visite 1. Prévoir un temps de découverte puis une pause. Aucune réservation réelle ne doit être effectuée à partir de ces informations.", "09:00–12:00 (démonstration)", "Non renseigné", "Atelier de découverte locale — étape 2.1", 1010, 1, "" },
                    { 10113, "22, rue de Démonstration, Dijon (adresse fictive)", "parc", 2, "Activité fictive de démonstration à Dijon. Jour 2, visite 2. Prévoir un temps de découverte puis une pause. Aucune réservation réelle ne doit être effectuée à partir de ces informations.", "14:00–17:00 (démonstration)", "Non renseigné", "Parc des horizons — étape 2.2", 1010, 2, "" },
                    { 10114, "23, rue de Démonstration, Dijon (adresse fictive)", "grotte", 2, "Activité fictive de démonstration à Dijon. Jour 2, visite 3. Prévoir un temps de découverte puis une pause. Aucune réservation réelle ne doit être effectuée à partir de ces informations.", "17:30–19:00 (démonstration)", "Non renseigné", "Grotte des lumières — étape 2.3", 1010, 3, "" },
                    { 10115, "31, rue de Démonstration, Dijon (adresse fictive)", "parc", 3, "Activité fictive de démonstration à Dijon. Jour 3, visite 1. Prévoir un temps de découverte puis une pause. Aucune réservation réelle ne doit être effectuée à partir de ces informations.", "09:00–12:00 (démonstration)", "Non renseigné", "Parc des horizons — étape 3.1", 1010, 1, "" },
                    { 10116, "32, rue de Démonstration, Dijon (adresse fictive)", "grotte", 3, "Activité fictive de démonstration à Dijon. Jour 3, visite 2. Prévoir un temps de découverte puis une pause. Aucune réservation réelle ne doit être effectuée à partir de ces informations.", "14:00–17:00 (démonstration)", "Non renseigné", "Grotte des lumières — étape 3.2", 1010, 2, "" },
                    { 10117, "33, rue de Démonstration, Dijon (adresse fictive)", "musée", 3, "Activité fictive de démonstration à Dijon. Jour 3, visite 3. Prévoir un temps de découverte puis une pause. Aucune réservation réelle ne doit être effectuée à partir de ces informations.", "17:30–19:00 (démonstration)", "Non renseigné", "Musée des découvertes — étape 3.3", 1010, 3, "" },
                    { 10118, "11, rue de Démonstration, Rennes (adresse fictive)", "activité", 1, "Activité fictive de démonstration à Rennes. Jour 1, visite 1. Prévoir un temps de découverte puis une pause. Aucune réservation réelle ne doit être effectuée à partir de ces informations.", "09:00–12:00 (démonstration)", "Non renseigné", "Atelier de découverte locale — étape 1.1", 1011, 1, "" },
                    { 10119, "12, rue de Démonstration, Rennes (adresse fictive)", "parc", 1, "Activité fictive de démonstration à Rennes. Jour 1, visite 2. Prévoir un temps de découverte puis une pause. Aucune réservation réelle ne doit être effectuée à partir de ces informations.", "14:00–17:00 (démonstration)", "Non renseigné", "Parc des horizons — étape 1.2", 1011, 2, "" },
                    { 10120, "13, rue de Démonstration, Rennes (adresse fictive)", "grotte", 1, "Activité fictive de démonstration à Rennes. Jour 1, visite 3. Prévoir un temps de découverte puis une pause. Aucune réservation réelle ne doit être effectuée à partir de ces informations.", "17:30–19:00 (démonstration)", "Non renseigné", "Grotte des lumières — étape 1.3", 1011, 3, "" },
                    { 10121, "21, rue de Démonstration, Rennes (adresse fictive)", "parc", 2, "Activité fictive de démonstration à Rennes. Jour 2, visite 1. Prévoir un temps de découverte puis une pause. Aucune réservation réelle ne doit être effectuée à partir de ces informations.", "09:00–12:00 (démonstration)", "Non renseigné", "Parc des horizons — étape 2.1", 1011, 1, "" },
                    { 10122, "22, rue de Démonstration, Rennes (adresse fictive)", "grotte", 2, "Activité fictive de démonstration à Rennes. Jour 2, visite 2. Prévoir un temps de découverte puis une pause. Aucune réservation réelle ne doit être effectuée à partir de ces informations.", "14:00–17:00 (démonstration)", "Non renseigné", "Grotte des lumières — étape 2.2", 1011, 2, "" },
                    { 10123, "23, rue de Démonstration, Rennes (adresse fictive)", "musée", 2, "Activité fictive de démonstration à Rennes. Jour 2, visite 3. Prévoir un temps de découverte puis une pause. Aucune réservation réelle ne doit être effectuée à partir de ces informations.", "17:30–19:00 (démonstration)", "Non renseigné", "Musée des découvertes — étape 2.3", 1011, 3, "" },
                    { 10124, "31, rue de Démonstration, Rennes (adresse fictive)", "grotte", 3, "Activité fictive de démonstration à Rennes. Jour 3, visite 1. Prévoir un temps de découverte puis une pause. Aucune réservation réelle ne doit être effectuée à partir de ces informations.", "09:00–12:00 (démonstration)", "Non renseigné", "Grotte des lumières — étape 3.1", 1011, 1, "" },
                    { 10125, "32, rue de Démonstration, Rennes (adresse fictive)", "musée", 3, "Activité fictive de démonstration à Rennes. Jour 3, visite 2. Prévoir un temps de découverte puis une pause. Aucune réservation réelle ne doit être effectuée à partir de ces informations.", "14:00–17:00 (démonstration)", "Non renseigné", "Musée des découvertes — étape 3.2", 1011, 2, "" },
                    { 10126, "33, rue de Démonstration, Rennes (adresse fictive)", "château", 3, "Activité fictive de démonstration à Rennes. Jour 3, visite 3. Prévoir un temps de découverte puis une pause. Aucune réservation réelle ne doit être effectuée à partir de ces informations.", "17:30–19:00 (démonstration)", "Non renseigné", "Château des voyageurs — étape 3.3", 1011, 3, "" },
                    { 10127, "41, rue de Démonstration, Rennes (adresse fictive)", "musée", 4, "Activité fictive de démonstration à Rennes. Jour 4, visite 1. Prévoir un temps de découverte puis une pause. Aucune réservation réelle ne doit être effectuée à partir de ces informations.", "09:00–12:00 (démonstration)", "Non renseigné", "Musée des découvertes — étape 4.1", 1011, 1, "" },
                    { 10128, "42, rue de Démonstration, Rennes (adresse fictive)", "château", 4, "Activité fictive de démonstration à Rennes. Jour 4, visite 2. Prévoir un temps de découverte puis une pause. Aucune réservation réelle ne doit être effectuée à partir de ces informations.", "14:00–17:00 (démonstration)", "Non renseigné", "Château des voyageurs — étape 4.2", 1011, 2, "" },
                    { 10129, "43, rue de Démonstration, Rennes (adresse fictive)", "activité", 4, "Activité fictive de démonstration à Rennes. Jour 4, visite 3. Prévoir un temps de découverte puis une pause. Aucune réservation réelle ne doit être effectuée à partir de ces informations.", "17:30–19:00 (démonstration)", "Non renseigné", "Atelier de découverte locale — étape 4.3", 1011, 3, "" },
                    { 10130, "11, rue de Démonstration, Rouen (adresse fictive)", "parc", 1, "Activité fictive de démonstration à Rouen. Jour 1, visite 1. Prévoir un temps de découverte puis une pause. Aucune réservation réelle ne doit être effectuée à partir de ces informations.", "09:00–12:00 (démonstration)", "Non renseigné", "Parc des horizons — étape 1.1", 1012, 1, "" },
                    { 10131, "12, rue de Démonstration, Rouen (adresse fictive)", "grotte", 1, "Activité fictive de démonstration à Rouen. Jour 1, visite 2. Prévoir un temps de découverte puis une pause. Aucune réservation réelle ne doit être effectuée à partir de ces informations.", "14:00–17:00 (démonstration)", "Non renseigné", "Grotte des lumières — étape 1.2", 1012, 2, "" },
                    { 10132, "13, rue de Démonstration, Rouen (adresse fictive)", "musée", 1, "Activité fictive de démonstration à Rouen. Jour 1, visite 3. Prévoir un temps de découverte puis une pause. Aucune réservation réelle ne doit être effectuée à partir de ces informations.", "17:30–19:00 (démonstration)", "Non renseigné", "Musée des découvertes — étape 1.3", 1012, 3, "" },
                    { 10133, "21, rue de Démonstration, Rouen (adresse fictive)", "grotte", 2, "Activité fictive de démonstration à Rouen. Jour 2, visite 1. Prévoir un temps de découverte puis une pause. Aucune réservation réelle ne doit être effectuée à partir de ces informations.", "09:00–12:00 (démonstration)", "Non renseigné", "Grotte des lumières — étape 2.1", 1012, 1, "" },
                    { 10134, "22, rue de Démonstration, Rouen (adresse fictive)", "musée", 2, "Activité fictive de démonstration à Rouen. Jour 2, visite 2. Prévoir un temps de découverte puis une pause. Aucune réservation réelle ne doit être effectuée à partir de ces informations.", "14:00–17:00 (démonstration)", "Non renseigné", "Musée des découvertes — étape 2.2", 1012, 2, "" },
                    { 10135, "23, rue de Démonstration, Rouen (adresse fictive)", "château", 2, "Activité fictive de démonstration à Rouen. Jour 2, visite 3. Prévoir un temps de découverte puis une pause. Aucune réservation réelle ne doit être effectuée à partir de ces informations.", "17:30–19:00 (démonstration)", "Non renseigné", "Château des voyageurs — étape 2.3", 1012, 3, "" },
                    { 10136, "31, rue de Démonstration, Rouen (adresse fictive)", "musée", 3, "Activité fictive de démonstration à Rouen. Jour 3, visite 1. Prévoir un temps de découverte puis une pause. Aucune réservation réelle ne doit être effectuée à partir de ces informations.", "09:00–12:00 (démonstration)", "Non renseigné", "Musée des découvertes — étape 3.1", 1012, 1, "" },
                    { 10137, "32, rue de Démonstration, Rouen (adresse fictive)", "château", 3, "Activité fictive de démonstration à Rouen. Jour 3, visite 2. Prévoir un temps de découverte puis une pause. Aucune réservation réelle ne doit être effectuée à partir de ces informations.", "14:00–17:00 (démonstration)", "Non renseigné", "Château des voyageurs — étape 3.2", 1012, 2, "" },
                    { 10138, "33, rue de Démonstration, Rouen (adresse fictive)", "activité", 3, "Activité fictive de démonstration à Rouen. Jour 3, visite 3. Prévoir un temps de découverte puis une pause. Aucune réservation réelle ne doit être effectuée à partir de ces informations.", "17:30–19:00 (démonstration)", "Non renseigné", "Atelier de découverte locale — étape 3.3", 1012, 3, "" },
                    { 10139, "41, rue de Démonstration, Rouen (adresse fictive)", "château", 4, "Activité fictive de démonstration à Rouen. Jour 4, visite 1. Prévoir un temps de découverte puis une pause. Aucune réservation réelle ne doit être effectuée à partir de ces informations.", "09:00–12:00 (démonstration)", "Non renseigné", "Château des voyageurs — étape 4.1", 1012, 1, "" },
                    { 10140, "42, rue de Démonstration, Rouen (adresse fictive)", "activité", 4, "Activité fictive de démonstration à Rouen. Jour 4, visite 2. Prévoir un temps de découverte puis une pause. Aucune réservation réelle ne doit être effectuée à partir de ces informations.", "14:00–17:00 (démonstration)", "Non renseigné", "Atelier de découverte locale — étape 4.2", 1012, 2, "" },
                    { 10141, "43, rue de Démonstration, Rouen (adresse fictive)", "parc", 4, "Activité fictive de démonstration à Rouen. Jour 4, visite 3. Prévoir un temps de découverte puis une pause. Aucune réservation réelle ne doit être effectuée à partir de ces informations.", "17:30–19:00 (démonstration)", "Non renseigné", "Parc des horizons — étape 4.3", 1012, 3, "" },
                    { 10142, "51, rue de Démonstration, Rouen (adresse fictive)", "activité", 5, "Activité fictive de démonstration à Rouen. Jour 5, visite 1. Prévoir un temps de découverte puis une pause. Aucune réservation réelle ne doit être effectuée à partir de ces informations.", "09:00–12:00 (démonstration)", "Non renseigné", "Atelier de découverte locale — étape 5.1", 1012, 1, "" },
                    { 10143, "52, rue de Démonstration, Rouen (adresse fictive)", "parc", 5, "Activité fictive de démonstration à Rouen. Jour 5, visite 2. Prévoir un temps de découverte puis une pause. Aucune réservation réelle ne doit être effectuée à partir de ces informations.", "14:00–17:00 (démonstration)", "Non renseigné", "Parc des horizons — étape 5.2", 1012, 2, "" },
                    { 10144, "53, rue de Démonstration, Rouen (adresse fictive)", "grotte", 5, "Activité fictive de démonstration à Rouen. Jour 5, visite 3. Prévoir un temps de découverte puis une pause. Aucune réservation réelle ne doit être effectuée à partir de ces informations.", "17:30–19:00 (démonstration)", "Non renseigné", "Grotte des lumières — étape 5.3", 1012, 3, "" },
                    { 10145, "11, rue de Démonstration, Reims (adresse fictive)", "grotte", 1, "Activité fictive de démonstration à Reims. Jour 1, visite 1. Prévoir un temps de découverte puis une pause. Aucune réservation réelle ne doit être effectuée à partir de ces informations.", "09:00–12:00 (démonstration)", "Non renseigné", "Grotte des lumières — étape 1.1", 1013, 1, "" },
                    { 10146, "12, rue de Démonstration, Reims (adresse fictive)", "musée", 1, "Activité fictive de démonstration à Reims. Jour 1, visite 2. Prévoir un temps de découverte puis une pause. Aucune réservation réelle ne doit être effectuée à partir de ces informations.", "14:00–17:00 (démonstration)", "Non renseigné", "Musée des découvertes — étape 1.2", 1013, 2, "" },
                    { 10147, "13, rue de Démonstration, Reims (adresse fictive)", "château", 1, "Activité fictive de démonstration à Reims. Jour 1, visite 3. Prévoir un temps de découverte puis une pause. Aucune réservation réelle ne doit être effectuée à partir de ces informations.", "17:30–19:00 (démonstration)", "Non renseigné", "Château des voyageurs — étape 1.3", 1013, 3, "" },
                    { 10148, "21, rue de Démonstration, Reims (adresse fictive)", "musée", 2, "Activité fictive de démonstration à Reims. Jour 2, visite 1. Prévoir un temps de découverte puis une pause. Aucune réservation réelle ne doit être effectuée à partir de ces informations.", "09:00–12:00 (démonstration)", "Non renseigné", "Musée des découvertes — étape 2.1", 1013, 1, "" },
                    { 10149, "22, rue de Démonstration, Reims (adresse fictive)", "château", 2, "Activité fictive de démonstration à Reims. Jour 2, visite 2. Prévoir un temps de découverte puis une pause. Aucune réservation réelle ne doit être effectuée à partir de ces informations.", "14:00–17:00 (démonstration)", "Non renseigné", "Château des voyageurs — étape 2.2", 1013, 2, "" },
                    { 10150, "23, rue de Démonstration, Reims (adresse fictive)", "activité", 2, "Activité fictive de démonstration à Reims. Jour 2, visite 3. Prévoir un temps de découverte puis une pause. Aucune réservation réelle ne doit être effectuée à partir de ces informations.", "17:30–19:00 (démonstration)", "Non renseigné", "Atelier de découverte locale — étape 2.3", 1013, 3, "" },
                    { 10151, "31, rue de Démonstration, Reims (adresse fictive)", "château", 3, "Activité fictive de démonstration à Reims. Jour 3, visite 1. Prévoir un temps de découverte puis une pause. Aucune réservation réelle ne doit être effectuée à partir de ces informations.", "09:00–12:00 (démonstration)", "Non renseigné", "Château des voyageurs — étape 3.1", 1013, 1, "" },
                    { 10152, "32, rue de Démonstration, Reims (adresse fictive)", "activité", 3, "Activité fictive de démonstration à Reims. Jour 3, visite 2. Prévoir un temps de découverte puis une pause. Aucune réservation réelle ne doit être effectuée à partir de ces informations.", "14:00–17:00 (démonstration)", "Non renseigné", "Atelier de découverte locale — étape 3.2", 1013, 2, "" },
                    { 10153, "33, rue de Démonstration, Reims (adresse fictive)", "parc", 3, "Activité fictive de démonstration à Reims. Jour 3, visite 3. Prévoir un temps de découverte puis une pause. Aucune réservation réelle ne doit être effectuée à partir de ces informations.", "17:30–19:00 (démonstration)", "Non renseigné", "Parc des horizons — étape 3.3", 1013, 3, "" },
                    { 10154, "11, rue de Démonstration, Avignon (adresse fictive)", "musée", 1, "Activité fictive de démonstration à Avignon. Jour 1, visite 1. Prévoir un temps de découverte puis une pause. Aucune réservation réelle ne doit être effectuée à partir de ces informations.", "09:00–12:00 (démonstration)", "Non renseigné", "Musée des découvertes — étape 1.1", 1014, 1, "" },
                    { 10155, "12, rue de Démonstration, Avignon (adresse fictive)", "château", 1, "Activité fictive de démonstration à Avignon. Jour 1, visite 2. Prévoir un temps de découverte puis une pause. Aucune réservation réelle ne doit être effectuée à partir de ces informations.", "14:00–17:00 (démonstration)", "Non renseigné", "Château des voyageurs — étape 1.2", 1014, 2, "" },
                    { 10156, "13, rue de Démonstration, Avignon (adresse fictive)", "activité", 1, "Activité fictive de démonstration à Avignon. Jour 1, visite 3. Prévoir un temps de découverte puis une pause. Aucune réservation réelle ne doit être effectuée à partir de ces informations.", "17:30–19:00 (démonstration)", "Non renseigné", "Atelier de découverte locale — étape 1.3", 1014, 3, "" },
                    { 10157, "21, rue de Démonstration, Avignon (adresse fictive)", "château", 2, "Activité fictive de démonstration à Avignon. Jour 2, visite 1. Prévoir un temps de découverte puis une pause. Aucune réservation réelle ne doit être effectuée à partir de ces informations.", "09:00–12:00 (démonstration)", "Non renseigné", "Château des voyageurs — étape 2.1", 1014, 1, "" },
                    { 10158, "22, rue de Démonstration, Avignon (adresse fictive)", "activité", 2, "Activité fictive de démonstration à Avignon. Jour 2, visite 2. Prévoir un temps de découverte puis une pause. Aucune réservation réelle ne doit être effectuée à partir de ces informations.", "14:00–17:00 (démonstration)", "Non renseigné", "Atelier de découverte locale — étape 2.2", 1014, 2, "" },
                    { 10159, "23, rue de Démonstration, Avignon (adresse fictive)", "parc", 2, "Activité fictive de démonstration à Avignon. Jour 2, visite 3. Prévoir un temps de découverte puis une pause. Aucune réservation réelle ne doit être effectuée à partir de ces informations.", "17:30–19:00 (démonstration)", "Non renseigné", "Parc des horizons — étape 2.3", 1014, 3, "" },
                    { 10160, "31, rue de Démonstration, Avignon (adresse fictive)", "activité", 3, "Activité fictive de démonstration à Avignon. Jour 3, visite 1. Prévoir un temps de découverte puis une pause. Aucune réservation réelle ne doit être effectuée à partir de ces informations.", "09:00–12:00 (démonstration)", "Non renseigné", "Atelier de découverte locale — étape 3.1", 1014, 1, "" },
                    { 10161, "32, rue de Démonstration, Avignon (adresse fictive)", "parc", 3, "Activité fictive de démonstration à Avignon. Jour 3, visite 2. Prévoir un temps de découverte puis une pause. Aucune réservation réelle ne doit être effectuée à partir de ces informations.", "14:00–17:00 (démonstration)", "Non renseigné", "Parc des horizons — étape 3.2", 1014, 2, "" },
                    { 10162, "33, rue de Démonstration, Avignon (adresse fictive)", "grotte", 3, "Activité fictive de démonstration à Avignon. Jour 3, visite 3. Prévoir un temps de découverte puis une pause. Aucune réservation réelle ne doit être effectuée à partir de ces informations.", "17:30–19:00 (démonstration)", "Non renseigné", "Grotte des lumières — étape 3.3", 1014, 3, "" },
                    { 10163, "41, rue de Démonstration, Avignon (adresse fictive)", "parc", 4, "Activité fictive de démonstration à Avignon. Jour 4, visite 1. Prévoir un temps de découverte puis une pause. Aucune réservation réelle ne doit être effectuée à partir de ces informations.", "09:00–12:00 (démonstration)", "Non renseigné", "Parc des horizons — étape 4.1", 1014, 1, "" },
                    { 10164, "42, rue de Démonstration, Avignon (adresse fictive)", "grotte", 4, "Activité fictive de démonstration à Avignon. Jour 4, visite 2. Prévoir un temps de découverte puis une pause. Aucune réservation réelle ne doit être effectuée à partir de ces informations.", "14:00–17:00 (démonstration)", "Non renseigné", "Grotte des lumières — étape 4.2", 1014, 2, "" },
                    { 10165, "43, rue de Démonstration, Avignon (adresse fictive)", "musée", 4, "Activité fictive de démonstration à Avignon. Jour 4, visite 3. Prévoir un temps de découverte puis une pause. Aucune réservation réelle ne doit être effectuée à partir de ces informations.", "17:30–19:00 (démonstration)", "Non renseigné", "Musée des découvertes — étape 4.3", 1014, 3, "" },
                    { 10166, "11, rue de Démonstration, Montpellier (adresse fictive)", "château", 1, "Activité fictive de démonstration à Montpellier. Jour 1, visite 1. Prévoir un temps de découverte puis une pause. Aucune réservation réelle ne doit être effectuée à partir de ces informations.", "09:00–12:00 (démonstration)", "Non renseigné", "Château des voyageurs — étape 1.1", 1015, 1, "" },
                    { 10167, "12, rue de Démonstration, Montpellier (adresse fictive)", "activité", 1, "Activité fictive de démonstration à Montpellier. Jour 1, visite 2. Prévoir un temps de découverte puis une pause. Aucune réservation réelle ne doit être effectuée à partir de ces informations.", "14:00–17:00 (démonstration)", "Non renseigné", "Atelier de découverte locale — étape 1.2", 1015, 2, "" },
                    { 10168, "13, rue de Démonstration, Montpellier (adresse fictive)", "parc", 1, "Activité fictive de démonstration à Montpellier. Jour 1, visite 3. Prévoir un temps de découverte puis une pause. Aucune réservation réelle ne doit être effectuée à partir de ces informations.", "17:30–19:00 (démonstration)", "Non renseigné", "Parc des horizons — étape 1.3", 1015, 3, "" },
                    { 10169, "21, rue de Démonstration, Montpellier (adresse fictive)", "activité", 2, "Activité fictive de démonstration à Montpellier. Jour 2, visite 1. Prévoir un temps de découverte puis une pause. Aucune réservation réelle ne doit être effectuée à partir de ces informations.", "09:00–12:00 (démonstration)", "Non renseigné", "Atelier de découverte locale — étape 2.1", 1015, 1, "" },
                    { 10170, "22, rue de Démonstration, Montpellier (adresse fictive)", "parc", 2, "Activité fictive de démonstration à Montpellier. Jour 2, visite 2. Prévoir un temps de découverte puis une pause. Aucune réservation réelle ne doit être effectuée à partir de ces informations.", "14:00–17:00 (démonstration)", "Non renseigné", "Parc des horizons — étape 2.2", 1015, 2, "" },
                    { 10171, "23, rue de Démonstration, Montpellier (adresse fictive)", "grotte", 2, "Activité fictive de démonstration à Montpellier. Jour 2, visite 3. Prévoir un temps de découverte puis une pause. Aucune réservation réelle ne doit être effectuée à partir de ces informations.", "17:30–19:00 (démonstration)", "Non renseigné", "Grotte des lumières — étape 2.3", 1015, 3, "" },
                    { 10172, "31, rue de Démonstration, Montpellier (adresse fictive)", "parc", 3, "Activité fictive de démonstration à Montpellier. Jour 3, visite 1. Prévoir un temps de découverte puis une pause. Aucune réservation réelle ne doit être effectuée à partir de ces informations.", "09:00–12:00 (démonstration)", "Non renseigné", "Parc des horizons — étape 3.1", 1015, 1, "" },
                    { 10173, "32, rue de Démonstration, Montpellier (adresse fictive)", "grotte", 3, "Activité fictive de démonstration à Montpellier. Jour 3, visite 2. Prévoir un temps de découverte puis une pause. Aucune réservation réelle ne doit être effectuée à partir de ces informations.", "14:00–17:00 (démonstration)", "Non renseigné", "Grotte des lumières — étape 3.2", 1015, 2, "" },
                    { 10174, "33, rue de Démonstration, Montpellier (adresse fictive)", "musée", 3, "Activité fictive de démonstration à Montpellier. Jour 3, visite 3. Prévoir un temps de découverte puis une pause. Aucune réservation réelle ne doit être effectuée à partir de ces informations.", "17:30–19:00 (démonstration)", "Non renseigné", "Musée des découvertes — étape 3.3", 1015, 3, "" },
                    { 10175, "41, rue de Démonstration, Montpellier (adresse fictive)", "grotte", 4, "Activité fictive de démonstration à Montpellier. Jour 4, visite 1. Prévoir un temps de découverte puis une pause. Aucune réservation réelle ne doit être effectuée à partir de ces informations.", "09:00–12:00 (démonstration)", "Non renseigné", "Grotte des lumières — étape 4.1", 1015, 1, "" },
                    { 10176, "42, rue de Démonstration, Montpellier (adresse fictive)", "musée", 4, "Activité fictive de démonstration à Montpellier. Jour 4, visite 2. Prévoir un temps de découverte puis une pause. Aucune réservation réelle ne doit être effectuée à partir de ces informations.", "14:00–17:00 (démonstration)", "Non renseigné", "Musée des découvertes — étape 4.2", 1015, 2, "" },
                    { 10177, "43, rue de Démonstration, Montpellier (adresse fictive)", "château", 4, "Activité fictive de démonstration à Montpellier. Jour 4, visite 3. Prévoir un temps de découverte puis une pause. Aucune réservation réelle ne doit être effectuée à partir de ces informations.", "17:30–19:00 (démonstration)", "Non renseigné", "Château des voyageurs — étape 4.3", 1015, 3, "" },
                    { 10178, "51, rue de Démonstration, Montpellier (adresse fictive)", "musée", 5, "Activité fictive de démonstration à Montpellier. Jour 5, visite 1. Prévoir un temps de découverte puis une pause. Aucune réservation réelle ne doit être effectuée à partir de ces informations.", "09:00–12:00 (démonstration)", "Non renseigné", "Musée des découvertes — étape 5.1", 1015, 1, "" },
                    { 10179, "52, rue de Démonstration, Montpellier (adresse fictive)", "château", 5, "Activité fictive de démonstration à Montpellier. Jour 5, visite 2. Prévoir un temps de découverte puis une pause. Aucune réservation réelle ne doit être effectuée à partir de ces informations.", "14:00–17:00 (démonstration)", "Non renseigné", "Château des voyageurs — étape 5.2", 1015, 2, "" },
                    { 10180, "53, rue de Démonstration, Montpellier (adresse fictive)", "activité", 5, "Activité fictive de démonstration à Montpellier. Jour 5, visite 3. Prévoir un temps de découverte puis une pause. Aucune réservation réelle ne doit être effectuée à partir de ces informations.", "17:30–19:00 (démonstration)", "Non renseigné", "Atelier de découverte locale — étape 5.3", 1015, 3, "" },
                    { 10181, "11, rue de Démonstration, La Rochelle (adresse fictive)", "activité", 1, "Activité fictive de démonstration à La Rochelle. Jour 1, visite 1. Prévoir un temps de découverte puis une pause. Aucune réservation réelle ne doit être effectuée à partir de ces informations.", "09:00–12:00 (démonstration)", "Non renseigné", "Atelier de découverte locale — étape 1.1", 1016, 1, "" },
                    { 10182, "12, rue de Démonstration, La Rochelle (adresse fictive)", "parc", 1, "Activité fictive de démonstration à La Rochelle. Jour 1, visite 2. Prévoir un temps de découverte puis une pause. Aucune réservation réelle ne doit être effectuée à partir de ces informations.", "14:00–17:00 (démonstration)", "Non renseigné", "Parc des horizons — étape 1.2", 1016, 2, "" },
                    { 10183, "13, rue de Démonstration, La Rochelle (adresse fictive)", "grotte", 1, "Activité fictive de démonstration à La Rochelle. Jour 1, visite 3. Prévoir un temps de découverte puis une pause. Aucune réservation réelle ne doit être effectuée à partir de ces informations.", "17:30–19:00 (démonstration)", "Non renseigné", "Grotte des lumières — étape 1.3", 1016, 3, "" },
                    { 10184, "21, rue de Démonstration, La Rochelle (adresse fictive)", "parc", 2, "Activité fictive de démonstration à La Rochelle. Jour 2, visite 1. Prévoir un temps de découverte puis une pause. Aucune réservation réelle ne doit être effectuée à partir de ces informations.", "09:00–12:00 (démonstration)", "Non renseigné", "Parc des horizons — étape 2.1", 1016, 1, "" },
                    { 10185, "22, rue de Démonstration, La Rochelle (adresse fictive)", "grotte", 2, "Activité fictive de démonstration à La Rochelle. Jour 2, visite 2. Prévoir un temps de découverte puis une pause. Aucune réservation réelle ne doit être effectuée à partir de ces informations.", "14:00–17:00 (démonstration)", "Non renseigné", "Grotte des lumières — étape 2.2", 1016, 2, "" },
                    { 10186, "23, rue de Démonstration, La Rochelle (adresse fictive)", "musée", 2, "Activité fictive de démonstration à La Rochelle. Jour 2, visite 3. Prévoir un temps de découverte puis une pause. Aucune réservation réelle ne doit être effectuée à partir de ces informations.", "17:30–19:00 (démonstration)", "Non renseigné", "Musée des découvertes — étape 2.3", 1016, 3, "" },
                    { 10187, "31, rue de Démonstration, La Rochelle (adresse fictive)", "grotte", 3, "Activité fictive de démonstration à La Rochelle. Jour 3, visite 1. Prévoir un temps de découverte puis une pause. Aucune réservation réelle ne doit être effectuée à partir de ces informations.", "09:00–12:00 (démonstration)", "Non renseigné", "Grotte des lumières — étape 3.1", 1016, 1, "" },
                    { 10188, "32, rue de Démonstration, La Rochelle (adresse fictive)", "musée", 3, "Activité fictive de démonstration à La Rochelle. Jour 3, visite 2. Prévoir un temps de découverte puis une pause. Aucune réservation réelle ne doit être effectuée à partir de ces informations.", "14:00–17:00 (démonstration)", "Non renseigné", "Musée des découvertes — étape 3.2", 1016, 2, "" },
                    { 10189, "33, rue de Démonstration, La Rochelle (adresse fictive)", "château", 3, "Activité fictive de démonstration à La Rochelle. Jour 3, visite 3. Prévoir un temps de découverte puis une pause. Aucune réservation réelle ne doit être effectuée à partir de ces informations.", "17:30–19:00 (démonstration)", "Non renseigné", "Château des voyageurs — étape 3.3", 1016, 3, "" },
                    { 10190, "11, rue de Démonstration, Tours (adresse fictive)", "parc", 1, "Activité fictive de démonstration à Tours. Jour 1, visite 1. Prévoir un temps de découverte puis une pause. Aucune réservation réelle ne doit être effectuée à partir de ces informations.", "09:00–12:00 (démonstration)", "Non renseigné", "Parc des horizons — étape 1.1", 1017, 1, "" },
                    { 10191, "12, rue de Démonstration, Tours (adresse fictive)", "grotte", 1, "Activité fictive de démonstration à Tours. Jour 1, visite 2. Prévoir un temps de découverte puis une pause. Aucune réservation réelle ne doit être effectuée à partir de ces informations.", "14:00–17:00 (démonstration)", "Non renseigné", "Grotte des lumières — étape 1.2", 1017, 2, "" },
                    { 10192, "13, rue de Démonstration, Tours (adresse fictive)", "musée", 1, "Activité fictive de démonstration à Tours. Jour 1, visite 3. Prévoir un temps de découverte puis une pause. Aucune réservation réelle ne doit être effectuée à partir de ces informations.", "17:30–19:00 (démonstration)", "Non renseigné", "Musée des découvertes — étape 1.3", 1017, 3, "" },
                    { 10193, "21, rue de Démonstration, Tours (adresse fictive)", "grotte", 2, "Activité fictive de démonstration à Tours. Jour 2, visite 1. Prévoir un temps de découverte puis une pause. Aucune réservation réelle ne doit être effectuée à partir de ces informations.", "09:00–12:00 (démonstration)", "Non renseigné", "Grotte des lumières — étape 2.1", 1017, 1, "" },
                    { 10194, "22, rue de Démonstration, Tours (adresse fictive)", "musée", 2, "Activité fictive de démonstration à Tours. Jour 2, visite 2. Prévoir un temps de découverte puis une pause. Aucune réservation réelle ne doit être effectuée à partir de ces informations.", "14:00–17:00 (démonstration)", "Non renseigné", "Musée des découvertes — étape 2.2", 1017, 2, "" },
                    { 10195, "23, rue de Démonstration, Tours (adresse fictive)", "château", 2, "Activité fictive de démonstration à Tours. Jour 2, visite 3. Prévoir un temps de découverte puis une pause. Aucune réservation réelle ne doit être effectuée à partir de ces informations.", "17:30–19:00 (démonstration)", "Non renseigné", "Château des voyageurs — étape 2.3", 1017, 3, "" },
                    { 10196, "31, rue de Démonstration, Tours (adresse fictive)", "musée", 3, "Activité fictive de démonstration à Tours. Jour 3, visite 1. Prévoir un temps de découverte puis une pause. Aucune réservation réelle ne doit être effectuée à partir de ces informations.", "09:00–12:00 (démonstration)", "Non renseigné", "Musée des découvertes — étape 3.1", 1017, 1, "" },
                    { 10197, "32, rue de Démonstration, Tours (adresse fictive)", "château", 3, "Activité fictive de démonstration à Tours. Jour 3, visite 2. Prévoir un temps de découverte puis une pause. Aucune réservation réelle ne doit être effectuée à partir de ces informations.", "14:00–17:00 (démonstration)", "Non renseigné", "Château des voyageurs — étape 3.2", 1017, 2, "" },
                    { 10198, "33, rue de Démonstration, Tours (adresse fictive)", "activité", 3, "Activité fictive de démonstration à Tours. Jour 3, visite 3. Prévoir un temps de découverte puis une pause. Aucune réservation réelle ne doit être effectuée à partir de ces informations.", "17:30–19:00 (démonstration)", "Non renseigné", "Atelier de découverte locale — étape 3.3", 1017, 3, "" },
                    { 10199, "41, rue de Démonstration, Tours (adresse fictive)", "château", 4, "Activité fictive de démonstration à Tours. Jour 4, visite 1. Prévoir un temps de découverte puis une pause. Aucune réservation réelle ne doit être effectuée à partir de ces informations.", "09:00–12:00 (démonstration)", "Non renseigné", "Château des voyageurs — étape 4.1", 1017, 1, "" },
                    { 10200, "42, rue de Démonstration, Tours (adresse fictive)", "activité", 4, "Activité fictive de démonstration à Tours. Jour 4, visite 2. Prévoir un temps de découverte puis une pause. Aucune réservation réelle ne doit être effectuée à partir de ces informations.", "14:00–17:00 (démonstration)", "Non renseigné", "Atelier de découverte locale — étape 4.2", 1017, 2, "" },
                    { 10201, "43, rue de Démonstration, Tours (adresse fictive)", "parc", 4, "Activité fictive de démonstration à Tours. Jour 4, visite 3. Prévoir un temps de découverte puis une pause. Aucune réservation réelle ne doit être effectuée à partir de ces informations.", "17:30–19:00 (démonstration)", "Non renseigné", "Parc des horizons — étape 4.3", 1017, 3, "" },
                    { 10202, "11, rue de Démonstration, Nancy (adresse fictive)", "grotte", 1, "Activité fictive de démonstration à Nancy. Jour 1, visite 1. Prévoir un temps de découverte puis une pause. Aucune réservation réelle ne doit être effectuée à partir de ces informations.", "09:00–12:00 (démonstration)", "Non renseigné", "Grotte des lumières — étape 1.1", 1018, 1, "" },
                    { 10203, "12, rue de Démonstration, Nancy (adresse fictive)", "musée", 1, "Activité fictive de démonstration à Nancy. Jour 1, visite 2. Prévoir un temps de découverte puis une pause. Aucune réservation réelle ne doit être effectuée à partir de ces informations.", "14:00–17:00 (démonstration)", "Non renseigné", "Musée des découvertes — étape 1.2", 1018, 2, "" },
                    { 10204, "13, rue de Démonstration, Nancy (adresse fictive)", "château", 1, "Activité fictive de démonstration à Nancy. Jour 1, visite 3. Prévoir un temps de découverte puis une pause. Aucune réservation réelle ne doit être effectuée à partir de ces informations.", "17:30–19:00 (démonstration)", "Non renseigné", "Château des voyageurs — étape 1.3", 1018, 3, "" },
                    { 10205, "21, rue de Démonstration, Nancy (adresse fictive)", "musée", 2, "Activité fictive de démonstration à Nancy. Jour 2, visite 1. Prévoir un temps de découverte puis une pause. Aucune réservation réelle ne doit être effectuée à partir de ces informations.", "09:00–12:00 (démonstration)", "Non renseigné", "Musée des découvertes — étape 2.1", 1018, 1, "" },
                    { 10206, "22, rue de Démonstration, Nancy (adresse fictive)", "château", 2, "Activité fictive de démonstration à Nancy. Jour 2, visite 2. Prévoir un temps de découverte puis une pause. Aucune réservation réelle ne doit être effectuée à partir de ces informations.", "14:00–17:00 (démonstration)", "Non renseigné", "Château des voyageurs — étape 2.2", 1018, 2, "" },
                    { 10207, "23, rue de Démonstration, Nancy (adresse fictive)", "activité", 2, "Activité fictive de démonstration à Nancy. Jour 2, visite 3. Prévoir un temps de découverte puis une pause. Aucune réservation réelle ne doit être effectuée à partir de ces informations.", "17:30–19:00 (démonstration)", "Non renseigné", "Atelier de découverte locale — étape 2.3", 1018, 3, "" },
                    { 10208, "31, rue de Démonstration, Nancy (adresse fictive)", "château", 3, "Activité fictive de démonstration à Nancy. Jour 3, visite 1. Prévoir un temps de découverte puis une pause. Aucune réservation réelle ne doit être effectuée à partir de ces informations.", "09:00–12:00 (démonstration)", "Non renseigné", "Château des voyageurs — étape 3.1", 1018, 1, "" },
                    { 10209, "32, rue de Démonstration, Nancy (adresse fictive)", "activité", 3, "Activité fictive de démonstration à Nancy. Jour 3, visite 2. Prévoir un temps de découverte puis une pause. Aucune réservation réelle ne doit être effectuée à partir de ces informations.", "14:00–17:00 (démonstration)", "Non renseigné", "Atelier de découverte locale — étape 3.2", 1018, 2, "" },
                    { 10210, "33, rue de Démonstration, Nancy (adresse fictive)", "parc", 3, "Activité fictive de démonstration à Nancy. Jour 3, visite 3. Prévoir un temps de découverte puis une pause. Aucune réservation réelle ne doit être effectuée à partir de ces informations.", "17:30–19:00 (démonstration)", "Non renseigné", "Parc des horizons — étape 3.3", 1018, 3, "" },
                    { 10211, "41, rue de Démonstration, Nancy (adresse fictive)", "activité", 4, "Activité fictive de démonstration à Nancy. Jour 4, visite 1. Prévoir un temps de découverte puis une pause. Aucune réservation réelle ne doit être effectuée à partir de ces informations.", "09:00–12:00 (démonstration)", "Non renseigné", "Atelier de découverte locale — étape 4.1", 1018, 1, "" },
                    { 10212, "42, rue de Démonstration, Nancy (adresse fictive)", "parc", 4, "Activité fictive de démonstration à Nancy. Jour 4, visite 2. Prévoir un temps de découverte puis une pause. Aucune réservation réelle ne doit être effectuée à partir de ces informations.", "14:00–17:00 (démonstration)", "Non renseigné", "Parc des horizons — étape 4.2", 1018, 2, "" },
                    { 10213, "43, rue de Démonstration, Nancy (adresse fictive)", "grotte", 4, "Activité fictive de démonstration à Nancy. Jour 4, visite 3. Prévoir un temps de découverte puis une pause. Aucune réservation réelle ne doit être effectuée à partir de ces informations.", "17:30–19:00 (démonstration)", "Non renseigné", "Grotte des lumières — étape 4.3", 1018, 3, "" },
                    { 10214, "51, rue de Démonstration, Nancy (adresse fictive)", "parc", 5, "Activité fictive de démonstration à Nancy. Jour 5, visite 1. Prévoir un temps de découverte puis une pause. Aucune réservation réelle ne doit être effectuée à partir de ces informations.", "09:00–12:00 (démonstration)", "Non renseigné", "Parc des horizons — étape 5.1", 1018, 1, "" },
                    { 10215, "52, rue de Démonstration, Nancy (adresse fictive)", "grotte", 5, "Activité fictive de démonstration à Nancy. Jour 5, visite 2. Prévoir un temps de découverte puis une pause. Aucune réservation réelle ne doit être effectuée à partir de ces informations.", "14:00–17:00 (démonstration)", "Non renseigné", "Grotte des lumières — étape 5.2", 1018, 2, "" },
                    { 10216, "53, rue de Démonstration, Nancy (adresse fictive)", "musée", 5, "Activité fictive de démonstration à Nancy. Jour 5, visite 3. Prévoir un temps de découverte puis une pause. Aucune réservation réelle ne doit être effectuée à partir de ces informations.", "17:30–19:00 (démonstration)", "Non renseigné", "Musée des découvertes — étape 5.3", 1018, 3, "" },
                    { 10217, "11, rue de Démonstration, Metz (adresse fictive)", "musée", 1, "Activité fictive de démonstration à Metz. Jour 1, visite 1. Prévoir un temps de découverte puis une pause. Aucune réservation réelle ne doit être effectuée à partir de ces informations.", "09:00–12:00 (démonstration)", "Non renseigné", "Musée des découvertes — étape 1.1", 1019, 1, "" },
                    { 10218, "12, rue de Démonstration, Metz (adresse fictive)", "château", 1, "Activité fictive de démonstration à Metz. Jour 1, visite 2. Prévoir un temps de découverte puis une pause. Aucune réservation réelle ne doit être effectuée à partir de ces informations.", "14:00–17:00 (démonstration)", "Non renseigné", "Château des voyageurs — étape 1.2", 1019, 2, "" },
                    { 10219, "13, rue de Démonstration, Metz (adresse fictive)", "activité", 1, "Activité fictive de démonstration à Metz. Jour 1, visite 3. Prévoir un temps de découverte puis une pause. Aucune réservation réelle ne doit être effectuée à partir de ces informations.", "17:30–19:00 (démonstration)", "Non renseigné", "Atelier de découverte locale — étape 1.3", 1019, 3, "" },
                    { 10220, "21, rue de Démonstration, Metz (adresse fictive)", "château", 2, "Activité fictive de démonstration à Metz. Jour 2, visite 1. Prévoir un temps de découverte puis une pause. Aucune réservation réelle ne doit être effectuée à partir de ces informations.", "09:00–12:00 (démonstration)", "Non renseigné", "Château des voyageurs — étape 2.1", 1019, 1, "" },
                    { 10221, "22, rue de Démonstration, Metz (adresse fictive)", "activité", 2, "Activité fictive de démonstration à Metz. Jour 2, visite 2. Prévoir un temps de découverte puis une pause. Aucune réservation réelle ne doit être effectuée à partir de ces informations.", "14:00–17:00 (démonstration)", "Non renseigné", "Atelier de découverte locale — étape 2.2", 1019, 2, "" },
                    { 10222, "23, rue de Démonstration, Metz (adresse fictive)", "parc", 2, "Activité fictive de démonstration à Metz. Jour 2, visite 3. Prévoir un temps de découverte puis une pause. Aucune réservation réelle ne doit être effectuée à partir de ces informations.", "17:30–19:00 (démonstration)", "Non renseigné", "Parc des horizons — étape 2.3", 1019, 3, "" },
                    { 10223, "31, rue de Démonstration, Metz (adresse fictive)", "activité", 3, "Activité fictive de démonstration à Metz. Jour 3, visite 1. Prévoir un temps de découverte puis une pause. Aucune réservation réelle ne doit être effectuée à partir de ces informations.", "09:00–12:00 (démonstration)", "Non renseigné", "Atelier de découverte locale — étape 3.1", 1019, 1, "" },
                    { 10224, "32, rue de Démonstration, Metz (adresse fictive)", "parc", 3, "Activité fictive de démonstration à Metz. Jour 3, visite 2. Prévoir un temps de découverte puis une pause. Aucune réservation réelle ne doit être effectuée à partir de ces informations.", "14:00–17:00 (démonstration)", "Non renseigné", "Parc des horizons — étape 3.2", 1019, 2, "" },
                    { 10225, "33, rue de Démonstration, Metz (adresse fictive)", "grotte", 3, "Activité fictive de démonstration à Metz. Jour 3, visite 3. Prévoir un temps de découverte puis une pause. Aucune réservation réelle ne doit être effectuée à partir de ces informations.", "17:30–19:00 (démonstration)", "Non renseigné", "Grotte des lumières — étape 3.3", 1019, 3, "" },
                    { 10226, "11, rue de Démonstration, Besançon (adresse fictive)", "château", 1, "Activité fictive de démonstration à Besançon. Jour 1, visite 1. Prévoir un temps de découverte puis une pause. Aucune réservation réelle ne doit être effectuée à partir de ces informations.", "09:00–12:00 (démonstration)", "Non renseigné", "Château des voyageurs — étape 1.1", 1020, 1, "" },
                    { 10227, "12, rue de Démonstration, Besançon (adresse fictive)", "activité", 1, "Activité fictive de démonstration à Besançon. Jour 1, visite 2. Prévoir un temps de découverte puis une pause. Aucune réservation réelle ne doit être effectuée à partir de ces informations.", "14:00–17:00 (démonstration)", "Non renseigné", "Atelier de découverte locale — étape 1.2", 1020, 2, "" },
                    { 10228, "13, rue de Démonstration, Besançon (adresse fictive)", "parc", 1, "Activité fictive de démonstration à Besançon. Jour 1, visite 3. Prévoir un temps de découverte puis une pause. Aucune réservation réelle ne doit être effectuée à partir de ces informations.", "17:30–19:00 (démonstration)", "Non renseigné", "Parc des horizons — étape 1.3", 1020, 3, "" },
                    { 10229, "21, rue de Démonstration, Besançon (adresse fictive)", "activité", 2, "Activité fictive de démonstration à Besançon. Jour 2, visite 1. Prévoir un temps de découverte puis une pause. Aucune réservation réelle ne doit être effectuée à partir de ces informations.", "09:00–12:00 (démonstration)", "Non renseigné", "Atelier de découverte locale — étape 2.1", 1020, 1, "" },
                    { 10230, "22, rue de Démonstration, Besançon (adresse fictive)", "parc", 2, "Activité fictive de démonstration à Besançon. Jour 2, visite 2. Prévoir un temps de découverte puis une pause. Aucune réservation réelle ne doit être effectuée à partir de ces informations.", "14:00–17:00 (démonstration)", "Non renseigné", "Parc des horizons — étape 2.2", 1020, 2, "" },
                    { 10231, "23, rue de Démonstration, Besançon (adresse fictive)", "grotte", 2, "Activité fictive de démonstration à Besançon. Jour 2, visite 3. Prévoir un temps de découverte puis une pause. Aucune réservation réelle ne doit être effectuée à partir de ces informations.", "17:30–19:00 (démonstration)", "Non renseigné", "Grotte des lumières — étape 2.3", 1020, 3, "" },
                    { 10232, "31, rue de Démonstration, Besançon (adresse fictive)", "parc", 3, "Activité fictive de démonstration à Besançon. Jour 3, visite 1. Prévoir un temps de découverte puis une pause. Aucune réservation réelle ne doit être effectuée à partir de ces informations.", "09:00–12:00 (démonstration)", "Non renseigné", "Parc des horizons — étape 3.1", 1020, 1, "" },
                    { 10233, "32, rue de Démonstration, Besançon (adresse fictive)", "grotte", 3, "Activité fictive de démonstration à Besançon. Jour 3, visite 2. Prévoir un temps de découverte puis une pause. Aucune réservation réelle ne doit être effectuée à partir de ces informations.", "14:00–17:00 (démonstration)", "Non renseigné", "Grotte des lumières — étape 3.2", 1020, 2, "" },
                    { 10234, "33, rue de Démonstration, Besançon (adresse fictive)", "musée", 3, "Activité fictive de démonstration à Besançon. Jour 3, visite 3. Prévoir un temps de découverte puis une pause. Aucune réservation réelle ne doit être effectuée à partir de ces informations.", "17:30–19:00 (démonstration)", "Non renseigné", "Musée des découvertes — étape 3.3", 1020, 3, "" },
                    { 10235, "41, rue de Démonstration, Besançon (adresse fictive)", "grotte", 4, "Activité fictive de démonstration à Besançon. Jour 4, visite 1. Prévoir un temps de découverte puis une pause. Aucune réservation réelle ne doit être effectuée à partir de ces informations.", "09:00–12:00 (démonstration)", "Non renseigné", "Grotte des lumières — étape 4.1", 1020, 1, "" },
                    { 10236, "42, rue de Démonstration, Besançon (adresse fictive)", "musée", 4, "Activité fictive de démonstration à Besançon. Jour 4, visite 2. Prévoir un temps de découverte puis une pause. Aucune réservation réelle ne doit être effectuée à partir de ces informations.", "14:00–17:00 (démonstration)", "Non renseigné", "Musée des découvertes — étape 4.2", 1020, 2, "" },
                    { 10237, "43, rue de Démonstration, Besançon (adresse fictive)", "château", 4, "Activité fictive de démonstration à Besançon. Jour 4, visite 3. Prévoir un temps de découverte puis une pause. Aucune réservation réelle ne doit être effectuée à partir de ces informations.", "17:30–19:00 (démonstration)", "Non renseigné", "Château des voyageurs — étape 4.3", 1020, 3, "" },
                    { 10238, "11, rue de Démonstration, Clermont-Ferrand (adresse fictive)", "activité", 1, "Activité fictive de démonstration à Clermont-Ferrand. Jour 1, visite 1. Prévoir un temps de découverte puis une pause. Aucune réservation réelle ne doit être effectuée à partir de ces informations.", "09:00–12:00 (démonstration)", "Non renseigné", "Atelier de découverte locale — étape 1.1", 1021, 1, "" },
                    { 10239, "12, rue de Démonstration, Clermont-Ferrand (adresse fictive)", "parc", 1, "Activité fictive de démonstration à Clermont-Ferrand. Jour 1, visite 2. Prévoir un temps de découverte puis une pause. Aucune réservation réelle ne doit être effectuée à partir de ces informations.", "14:00–17:00 (démonstration)", "Non renseigné", "Parc des horizons — étape 1.2", 1021, 2, "" },
                    { 10240, "13, rue de Démonstration, Clermont-Ferrand (adresse fictive)", "grotte", 1, "Activité fictive de démonstration à Clermont-Ferrand. Jour 1, visite 3. Prévoir un temps de découverte puis une pause. Aucune réservation réelle ne doit être effectuée à partir de ces informations.", "17:30–19:00 (démonstration)", "Non renseigné", "Grotte des lumières — étape 1.3", 1021, 3, "" },
                    { 10241, "21, rue de Démonstration, Clermont-Ferrand (adresse fictive)", "parc", 2, "Activité fictive de démonstration à Clermont-Ferrand. Jour 2, visite 1. Prévoir un temps de découverte puis une pause. Aucune réservation réelle ne doit être effectuée à partir de ces informations.", "09:00–12:00 (démonstration)", "Non renseigné", "Parc des horizons — étape 2.1", 1021, 1, "" },
                    { 10242, "22, rue de Démonstration, Clermont-Ferrand (adresse fictive)", "grotte", 2, "Activité fictive de démonstration à Clermont-Ferrand. Jour 2, visite 2. Prévoir un temps de découverte puis une pause. Aucune réservation réelle ne doit être effectuée à partir de ces informations.", "14:00–17:00 (démonstration)", "Non renseigné", "Grotte des lumières — étape 2.2", 1021, 2, "" },
                    { 10243, "23, rue de Démonstration, Clermont-Ferrand (adresse fictive)", "musée", 2, "Activité fictive de démonstration à Clermont-Ferrand. Jour 2, visite 3. Prévoir un temps de découverte puis une pause. Aucune réservation réelle ne doit être effectuée à partir de ces informations.", "17:30–19:00 (démonstration)", "Non renseigné", "Musée des découvertes — étape 2.3", 1021, 3, "" },
                    { 10244, "31, rue de Démonstration, Clermont-Ferrand (adresse fictive)", "grotte", 3, "Activité fictive de démonstration à Clermont-Ferrand. Jour 3, visite 1. Prévoir un temps de découverte puis une pause. Aucune réservation réelle ne doit être effectuée à partir de ces informations.", "09:00–12:00 (démonstration)", "Non renseigné", "Grotte des lumières — étape 3.1", 1021, 1, "" },
                    { 10245, "32, rue de Démonstration, Clermont-Ferrand (adresse fictive)", "musée", 3, "Activité fictive de démonstration à Clermont-Ferrand. Jour 3, visite 2. Prévoir un temps de découverte puis une pause. Aucune réservation réelle ne doit être effectuée à partir de ces informations.", "14:00–17:00 (démonstration)", "Non renseigné", "Musée des découvertes — étape 3.2", 1021, 2, "" },
                    { 10246, "33, rue de Démonstration, Clermont-Ferrand (adresse fictive)", "château", 3, "Activité fictive de démonstration à Clermont-Ferrand. Jour 3, visite 3. Prévoir un temps de découverte puis une pause. Aucune réservation réelle ne doit être effectuée à partir de ces informations.", "17:30–19:00 (démonstration)", "Non renseigné", "Château des voyageurs — étape 3.3", 1021, 3, "" },
                    { 10247, "41, rue de Démonstration, Clermont-Ferrand (adresse fictive)", "musée", 4, "Activité fictive de démonstration à Clermont-Ferrand. Jour 4, visite 1. Prévoir un temps de découverte puis une pause. Aucune réservation réelle ne doit être effectuée à partir de ces informations.", "09:00–12:00 (démonstration)", "Non renseigné", "Musée des découvertes — étape 4.1", 1021, 1, "" },
                    { 10248, "42, rue de Démonstration, Clermont-Ferrand (adresse fictive)", "château", 4, "Activité fictive de démonstration à Clermont-Ferrand. Jour 4, visite 2. Prévoir un temps de découverte puis une pause. Aucune réservation réelle ne doit être effectuée à partir de ces informations.", "14:00–17:00 (démonstration)", "Non renseigné", "Château des voyageurs — étape 4.2", 1021, 2, "" },
                    { 10249, "43, rue de Démonstration, Clermont-Ferrand (adresse fictive)", "activité", 4, "Activité fictive de démonstration à Clermont-Ferrand. Jour 4, visite 3. Prévoir un temps de découverte puis une pause. Aucune réservation réelle ne doit être effectuée à partir de ces informations.", "17:30–19:00 (démonstration)", "Non renseigné", "Atelier de découverte locale — étape 4.3", 1021, 3, "" },
                    { 10250, "51, rue de Démonstration, Clermont-Ferrand (adresse fictive)", "château", 5, "Activité fictive de démonstration à Clermont-Ferrand. Jour 5, visite 1. Prévoir un temps de découverte puis une pause. Aucune réservation réelle ne doit être effectuée à partir de ces informations.", "09:00–12:00 (démonstration)", "Non renseigné", "Château des voyageurs — étape 5.1", 1021, 1, "" },
                    { 10251, "52, rue de Démonstration, Clermont-Ferrand (adresse fictive)", "activité", 5, "Activité fictive de démonstration à Clermont-Ferrand. Jour 5, visite 2. Prévoir un temps de découverte puis une pause. Aucune réservation réelle ne doit être effectuée à partir de ces informations.", "14:00–17:00 (démonstration)", "Non renseigné", "Atelier de découverte locale — étape 5.2", 1021, 2, "" },
                    { 10252, "53, rue de Démonstration, Clermont-Ferrand (adresse fictive)", "parc", 5, "Activité fictive de démonstration à Clermont-Ferrand. Jour 5, visite 3. Prévoir un temps de découverte puis une pause. Aucune réservation réelle ne doit être effectuée à partir de ces informations.", "17:30–19:00 (démonstration)", "Non renseigné", "Parc des horizons — étape 5.3", 1021, 3, "" },
                    { 10253, "11, rue de Démonstration, Limoges (adresse fictive)", "parc", 1, "Activité fictive de démonstration à Limoges. Jour 1, visite 1. Prévoir un temps de découverte puis une pause. Aucune réservation réelle ne doit être effectuée à partir de ces informations.", "09:00–12:00 (démonstration)", "Non renseigné", "Parc des horizons — étape 1.1", 1022, 1, "" },
                    { 10254, "12, rue de Démonstration, Limoges (adresse fictive)", "grotte", 1, "Activité fictive de démonstration à Limoges. Jour 1, visite 2. Prévoir un temps de découverte puis une pause. Aucune réservation réelle ne doit être effectuée à partir de ces informations.", "14:00–17:00 (démonstration)", "Non renseigné", "Grotte des lumières — étape 1.2", 1022, 2, "" },
                    { 10255, "13, rue de Démonstration, Limoges (adresse fictive)", "musée", 1, "Activité fictive de démonstration à Limoges. Jour 1, visite 3. Prévoir un temps de découverte puis une pause. Aucune réservation réelle ne doit être effectuée à partir de ces informations.", "17:30–19:00 (démonstration)", "Non renseigné", "Musée des découvertes — étape 1.3", 1022, 3, "" },
                    { 10256, "21, rue de Démonstration, Limoges (adresse fictive)", "grotte", 2, "Activité fictive de démonstration à Limoges. Jour 2, visite 1. Prévoir un temps de découverte puis une pause. Aucune réservation réelle ne doit être effectuée à partir de ces informations.", "09:00–12:00 (démonstration)", "Non renseigné", "Grotte des lumières — étape 2.1", 1022, 1, "" },
                    { 10257, "22, rue de Démonstration, Limoges (adresse fictive)", "musée", 2, "Activité fictive de démonstration à Limoges. Jour 2, visite 2. Prévoir un temps de découverte puis une pause. Aucune réservation réelle ne doit être effectuée à partir de ces informations.", "14:00–17:00 (démonstration)", "Non renseigné", "Musée des découvertes — étape 2.2", 1022, 2, "" },
                    { 10258, "23, rue de Démonstration, Limoges (adresse fictive)", "château", 2, "Activité fictive de démonstration à Limoges. Jour 2, visite 3. Prévoir un temps de découverte puis une pause. Aucune réservation réelle ne doit être effectuée à partir de ces informations.", "17:30–19:00 (démonstration)", "Non renseigné", "Château des voyageurs — étape 2.3", 1022, 3, "" },
                    { 10259, "31, rue de Démonstration, Limoges (adresse fictive)", "musée", 3, "Activité fictive de démonstration à Limoges. Jour 3, visite 1. Prévoir un temps de découverte puis une pause. Aucune réservation réelle ne doit être effectuée à partir de ces informations.", "09:00–12:00 (démonstration)", "Non renseigné", "Musée des découvertes — étape 3.1", 1022, 1, "" },
                    { 10260, "32, rue de Démonstration, Limoges (adresse fictive)", "château", 3, "Activité fictive de démonstration à Limoges. Jour 3, visite 2. Prévoir un temps de découverte puis une pause. Aucune réservation réelle ne doit être effectuée à partir de ces informations.", "14:00–17:00 (démonstration)", "Non renseigné", "Château des voyageurs — étape 3.2", 1022, 2, "" },
                    { 10261, "33, rue de Démonstration, Limoges (adresse fictive)", "activité", 3, "Activité fictive de démonstration à Limoges. Jour 3, visite 3. Prévoir un temps de découverte puis une pause. Aucune réservation réelle ne doit être effectuée à partir de ces informations.", "17:30–19:00 (démonstration)", "Non renseigné", "Atelier de découverte locale — étape 3.3", 1022, 3, "" },
                    { 10262, "11, rue de Démonstration, Poitiers (adresse fictive)", "grotte", 1, "Activité fictive de démonstration à Poitiers. Jour 1, visite 1. Prévoir un temps de découverte puis une pause. Aucune réservation réelle ne doit être effectuée à partir de ces informations.", "09:00–12:00 (démonstration)", "Non renseigné", "Grotte des lumières — étape 1.1", 1023, 1, "" },
                    { 10263, "12, rue de Démonstration, Poitiers (adresse fictive)", "musée", 1, "Activité fictive de démonstration à Poitiers. Jour 1, visite 2. Prévoir un temps de découverte puis une pause. Aucune réservation réelle ne doit être effectuée à partir de ces informations.", "14:00–17:00 (démonstration)", "Non renseigné", "Musée des découvertes — étape 1.2", 1023, 2, "" },
                    { 10264, "13, rue de Démonstration, Poitiers (adresse fictive)", "château", 1, "Activité fictive de démonstration à Poitiers. Jour 1, visite 3. Prévoir un temps de découverte puis une pause. Aucune réservation réelle ne doit être effectuée à partir de ces informations.", "17:30–19:00 (démonstration)", "Non renseigné", "Château des voyageurs — étape 1.3", 1023, 3, "" },
                    { 10265, "21, rue de Démonstration, Poitiers (adresse fictive)", "musée", 2, "Activité fictive de démonstration à Poitiers. Jour 2, visite 1. Prévoir un temps de découverte puis une pause. Aucune réservation réelle ne doit être effectuée à partir de ces informations.", "09:00–12:00 (démonstration)", "Non renseigné", "Musée des découvertes — étape 2.1", 1023, 1, "" },
                    { 10266, "22, rue de Démonstration, Poitiers (adresse fictive)", "château", 2, "Activité fictive de démonstration à Poitiers. Jour 2, visite 2. Prévoir un temps de découverte puis une pause. Aucune réservation réelle ne doit être effectuée à partir de ces informations.", "14:00–17:00 (démonstration)", "Non renseigné", "Château des voyageurs — étape 2.2", 1023, 2, "" },
                    { 10267, "23, rue de Démonstration, Poitiers (adresse fictive)", "activité", 2, "Activité fictive de démonstration à Poitiers. Jour 2, visite 3. Prévoir un temps de découverte puis une pause. Aucune réservation réelle ne doit être effectuée à partir de ces informations.", "17:30–19:00 (démonstration)", "Non renseigné", "Atelier de découverte locale — étape 2.3", 1023, 3, "" },
                    { 10268, "31, rue de Démonstration, Poitiers (adresse fictive)", "château", 3, "Activité fictive de démonstration à Poitiers. Jour 3, visite 1. Prévoir un temps de découverte puis une pause. Aucune réservation réelle ne doit être effectuée à partir de ces informations.", "09:00–12:00 (démonstration)", "Non renseigné", "Château des voyageurs — étape 3.1", 1023, 1, "" },
                    { 10269, "32, rue de Démonstration, Poitiers (adresse fictive)", "activité", 3, "Activité fictive de démonstration à Poitiers. Jour 3, visite 2. Prévoir un temps de découverte puis une pause. Aucune réservation réelle ne doit être effectuée à partir de ces informations.", "14:00–17:00 (démonstration)", "Non renseigné", "Atelier de découverte locale — étape 3.2", 1023, 2, "" },
                    { 10270, "33, rue de Démonstration, Poitiers (adresse fictive)", "parc", 3, "Activité fictive de démonstration à Poitiers. Jour 3, visite 3. Prévoir un temps de découverte puis une pause. Aucune réservation réelle ne doit être effectuée à partir de ces informations.", "17:30–19:00 (démonstration)", "Non renseigné", "Parc des horizons — étape 3.3", 1023, 3, "" },
                    { 10271, "41, rue de Démonstration, Poitiers (adresse fictive)", "activité", 4, "Activité fictive de démonstration à Poitiers. Jour 4, visite 1. Prévoir un temps de découverte puis une pause. Aucune réservation réelle ne doit être effectuée à partir de ces informations.", "09:00–12:00 (démonstration)", "Non renseigné", "Atelier de découverte locale — étape 4.1", 1023, 1, "" },
                    { 10272, "42, rue de Démonstration, Poitiers (adresse fictive)", "parc", 4, "Activité fictive de démonstration à Poitiers. Jour 4, visite 2. Prévoir un temps de découverte puis une pause. Aucune réservation réelle ne doit être effectuée à partir de ces informations.", "14:00–17:00 (démonstration)", "Non renseigné", "Parc des horizons — étape 4.2", 1023, 2, "" },
                    { 10273, "43, rue de Démonstration, Poitiers (adresse fictive)", "grotte", 4, "Activité fictive de démonstration à Poitiers. Jour 4, visite 3. Prévoir un temps de découverte puis une pause. Aucune réservation réelle ne doit être effectuée à partir de ces informations.", "17:30–19:00 (démonstration)", "Non renseigné", "Grotte des lumières — étape 4.3", 1023, 3, "" },
                    { 10274, "11, rue de Démonstration, Caen (adresse fictive)", "musée", 1, "Activité fictive de démonstration à Caen. Jour 1, visite 1. Prévoir un temps de découverte puis une pause. Aucune réservation réelle ne doit être effectuée à partir de ces informations.", "09:00–12:00 (démonstration)", "Non renseigné", "Musée des découvertes — étape 1.1", 1024, 1, "" },
                    { 10275, "12, rue de Démonstration, Caen (adresse fictive)", "château", 1, "Activité fictive de démonstration à Caen. Jour 1, visite 2. Prévoir un temps de découverte puis une pause. Aucune réservation réelle ne doit être effectuée à partir de ces informations.", "14:00–17:00 (démonstration)", "Non renseigné", "Château des voyageurs — étape 1.2", 1024, 2, "" },
                    { 10276, "13, rue de Démonstration, Caen (adresse fictive)", "activité", 1, "Activité fictive de démonstration à Caen. Jour 1, visite 3. Prévoir un temps de découverte puis une pause. Aucune réservation réelle ne doit être effectuée à partir de ces informations.", "17:30–19:00 (démonstration)", "Non renseigné", "Atelier de découverte locale — étape 1.3", 1024, 3, "" },
                    { 10277, "21, rue de Démonstration, Caen (adresse fictive)", "château", 2, "Activité fictive de démonstration à Caen. Jour 2, visite 1. Prévoir un temps de découverte puis une pause. Aucune réservation réelle ne doit être effectuée à partir de ces informations.", "09:00–12:00 (démonstration)", "Non renseigné", "Château des voyageurs — étape 2.1", 1024, 1, "" },
                    { 10278, "22, rue de Démonstration, Caen (adresse fictive)", "activité", 2, "Activité fictive de démonstration à Caen. Jour 2, visite 2. Prévoir un temps de découverte puis une pause. Aucune réservation réelle ne doit être effectuée à partir de ces informations.", "14:00–17:00 (démonstration)", "Non renseigné", "Atelier de découverte locale — étape 2.2", 1024, 2, "" },
                    { 10279, "23, rue de Démonstration, Caen (adresse fictive)", "parc", 2, "Activité fictive de démonstration à Caen. Jour 2, visite 3. Prévoir un temps de découverte puis une pause. Aucune réservation réelle ne doit être effectuée à partir de ces informations.", "17:30–19:00 (démonstration)", "Non renseigné", "Parc des horizons — étape 2.3", 1024, 3, "" },
                    { 10280, "31, rue de Démonstration, Caen (adresse fictive)", "activité", 3, "Activité fictive de démonstration à Caen. Jour 3, visite 1. Prévoir un temps de découverte puis une pause. Aucune réservation réelle ne doit être effectuée à partir de ces informations.", "09:00–12:00 (démonstration)", "Non renseigné", "Atelier de découverte locale — étape 3.1", 1024, 1, "" },
                    { 10281, "32, rue de Démonstration, Caen (adresse fictive)", "parc", 3, "Activité fictive de démonstration à Caen. Jour 3, visite 2. Prévoir un temps de découverte puis une pause. Aucune réservation réelle ne doit être effectuée à partir de ces informations.", "14:00–17:00 (démonstration)", "Non renseigné", "Parc des horizons — étape 3.2", 1024, 2, "" },
                    { 10282, "33, rue de Démonstration, Caen (adresse fictive)", "grotte", 3, "Activité fictive de démonstration à Caen. Jour 3, visite 3. Prévoir un temps de découverte puis une pause. Aucune réservation réelle ne doit être effectuée à partir de ces informations.", "17:30–19:00 (démonstration)", "Non renseigné", "Grotte des lumières — étape 3.3", 1024, 3, "" },
                    { 10283, "41, rue de Démonstration, Caen (adresse fictive)", "parc", 4, "Activité fictive de démonstration à Caen. Jour 4, visite 1. Prévoir un temps de découverte puis une pause. Aucune réservation réelle ne doit être effectuée à partir de ces informations.", "09:00–12:00 (démonstration)", "Non renseigné", "Parc des horizons — étape 4.1", 1024, 1, "" },
                    { 10284, "42, rue de Démonstration, Caen (adresse fictive)", "grotte", 4, "Activité fictive de démonstration à Caen. Jour 4, visite 2. Prévoir un temps de découverte puis une pause. Aucune réservation réelle ne doit être effectuée à partir de ces informations.", "14:00–17:00 (démonstration)", "Non renseigné", "Grotte des lumières — étape 4.2", 1024, 2, "" },
                    { 10285, "43, rue de Démonstration, Caen (adresse fictive)", "musée", 4, "Activité fictive de démonstration à Caen. Jour 4, visite 3. Prévoir un temps de découverte puis une pause. Aucune réservation réelle ne doit être effectuée à partir de ces informations.", "17:30–19:00 (démonstration)", "Non renseigné", "Musée des découvertes — étape 4.3", 1024, 3, "" },
                    { 10286, "51, rue de Démonstration, Caen (adresse fictive)", "grotte", 5, "Activité fictive de démonstration à Caen. Jour 5, visite 1. Prévoir un temps de découverte puis une pause. Aucune réservation réelle ne doit être effectuée à partir de ces informations.", "09:00–12:00 (démonstration)", "Non renseigné", "Grotte des lumières — étape 5.1", 1024, 1, "" },
                    { 10287, "52, rue de Démonstration, Caen (adresse fictive)", "musée", 5, "Activité fictive de démonstration à Caen. Jour 5, visite 2. Prévoir un temps de découverte puis une pause. Aucune réservation réelle ne doit être effectuée à partir de ces informations.", "14:00–17:00 (démonstration)", "Non renseigné", "Musée des découvertes — étape 5.2", 1024, 2, "" },
                    { 10288, "53, rue de Démonstration, Caen (adresse fictive)", "château", 5, "Activité fictive de démonstration à Caen. Jour 5, visite 3. Prévoir un temps de découverte puis une pause. Aucune réservation réelle ne doit être effectuée à partir de ces informations.", "17:30–19:00 (démonstration)", "Non renseigné", "Château des voyageurs — étape 5.3", 1024, 3, "" },
                    { 10289, "11, rue de Démonstration, Brest (adresse fictive)", "château", 1, "Activité fictive de démonstration à Brest. Jour 1, visite 1. Prévoir un temps de découverte puis une pause. Aucune réservation réelle ne doit être effectuée à partir de ces informations.", "09:00–12:00 (démonstration)", "Non renseigné", "Château des voyageurs — étape 1.1", 1025, 1, "" },
                    { 10290, "12, rue de Démonstration, Brest (adresse fictive)", "activité", 1, "Activité fictive de démonstration à Brest. Jour 1, visite 2. Prévoir un temps de découverte puis une pause. Aucune réservation réelle ne doit être effectuée à partir de ces informations.", "14:00–17:00 (démonstration)", "Non renseigné", "Atelier de découverte locale — étape 1.2", 1025, 2, "" },
                    { 10291, "13, rue de Démonstration, Brest (adresse fictive)", "parc", 1, "Activité fictive de démonstration à Brest. Jour 1, visite 3. Prévoir un temps de découverte puis une pause. Aucune réservation réelle ne doit être effectuée à partir de ces informations.", "17:30–19:00 (démonstration)", "Non renseigné", "Parc des horizons — étape 1.3", 1025, 3, "" },
                    { 10292, "21, rue de Démonstration, Brest (adresse fictive)", "activité", 2, "Activité fictive de démonstration à Brest. Jour 2, visite 1. Prévoir un temps de découverte puis une pause. Aucune réservation réelle ne doit être effectuée à partir de ces informations.", "09:00–12:00 (démonstration)", "Non renseigné", "Atelier de découverte locale — étape 2.1", 1025, 1, "" },
                    { 10293, "22, rue de Démonstration, Brest (adresse fictive)", "parc", 2, "Activité fictive de démonstration à Brest. Jour 2, visite 2. Prévoir un temps de découverte puis une pause. Aucune réservation réelle ne doit être effectuée à partir de ces informations.", "14:00–17:00 (démonstration)", "Non renseigné", "Parc des horizons — étape 2.2", 1025, 2, "" },
                    { 10294, "23, rue de Démonstration, Brest (adresse fictive)", "grotte", 2, "Activité fictive de démonstration à Brest. Jour 2, visite 3. Prévoir un temps de découverte puis une pause. Aucune réservation réelle ne doit être effectuée à partir de ces informations.", "17:30–19:00 (démonstration)", "Non renseigné", "Grotte des lumières — étape 2.3", 1025, 3, "" },
                    { 10295, "31, rue de Démonstration, Brest (adresse fictive)", "parc", 3, "Activité fictive de démonstration à Brest. Jour 3, visite 1. Prévoir un temps de découverte puis une pause. Aucune réservation réelle ne doit être effectuée à partir de ces informations.", "09:00–12:00 (démonstration)", "Non renseigné", "Parc des horizons — étape 3.1", 1025, 1, "" },
                    { 10296, "32, rue de Démonstration, Brest (adresse fictive)", "grotte", 3, "Activité fictive de démonstration à Brest. Jour 3, visite 2. Prévoir un temps de découverte puis une pause. Aucune réservation réelle ne doit être effectuée à partir de ces informations.", "14:00–17:00 (démonstration)", "Non renseigné", "Grotte des lumières — étape 3.2", 1025, 2, "" },
                    { 10297, "33, rue de Démonstration, Brest (adresse fictive)", "musée", 3, "Activité fictive de démonstration à Brest. Jour 3, visite 3. Prévoir un temps de découverte puis une pause. Aucune réservation réelle ne doit être effectuée à partir de ces informations.", "17:30–19:00 (démonstration)", "Non renseigné", "Musée des découvertes — étape 3.3", 1025, 3, "" },
                    { 10298, "11, rue de Démonstration, Amiens (adresse fictive)", "activité", 1, "Activité fictive de démonstration à Amiens. Jour 1, visite 1. Prévoir un temps de découverte puis une pause. Aucune réservation réelle ne doit être effectuée à partir de ces informations.", "09:00–12:00 (démonstration)", "Non renseigné", "Atelier de découverte locale — étape 1.1", 1026, 1, "" },
                    { 10299, "12, rue de Démonstration, Amiens (adresse fictive)", "parc", 1, "Activité fictive de démonstration à Amiens. Jour 1, visite 2. Prévoir un temps de découverte puis une pause. Aucune réservation réelle ne doit être effectuée à partir de ces informations.", "14:00–17:00 (démonstration)", "Non renseigné", "Parc des horizons — étape 1.2", 1026, 2, "" },
                    { 10300, "13, rue de Démonstration, Amiens (adresse fictive)", "grotte", 1, "Activité fictive de démonstration à Amiens. Jour 1, visite 3. Prévoir un temps de découverte puis une pause. Aucune réservation réelle ne doit être effectuée à partir de ces informations.", "17:30–19:00 (démonstration)", "Non renseigné", "Grotte des lumières — étape 1.3", 1026, 3, "" },
                    { 10301, "21, rue de Démonstration, Amiens (adresse fictive)", "parc", 2, "Activité fictive de démonstration à Amiens. Jour 2, visite 1. Prévoir un temps de découverte puis une pause. Aucune réservation réelle ne doit être effectuée à partir de ces informations.", "09:00–12:00 (démonstration)", "Non renseigné", "Parc des horizons — étape 2.1", 1026, 1, "" },
                    { 10302, "22, rue de Démonstration, Amiens (adresse fictive)", "grotte", 2, "Activité fictive de démonstration à Amiens. Jour 2, visite 2. Prévoir un temps de découverte puis une pause. Aucune réservation réelle ne doit être effectuée à partir de ces informations.", "14:00–17:00 (démonstration)", "Non renseigné", "Grotte des lumières — étape 2.2", 1026, 2, "" },
                    { 10303, "23, rue de Démonstration, Amiens (adresse fictive)", "musée", 2, "Activité fictive de démonstration à Amiens. Jour 2, visite 3. Prévoir un temps de découverte puis une pause. Aucune réservation réelle ne doit être effectuée à partir de ces informations.", "17:30–19:00 (démonstration)", "Non renseigné", "Musée des découvertes — étape 2.3", 1026, 3, "" },
                    { 10304, "31, rue de Démonstration, Amiens (adresse fictive)", "grotte", 3, "Activité fictive de démonstration à Amiens. Jour 3, visite 1. Prévoir un temps de découverte puis une pause. Aucune réservation réelle ne doit être effectuée à partir de ces informations.", "09:00–12:00 (démonstration)", "Non renseigné", "Grotte des lumières — étape 3.1", 1026, 1, "" },
                    { 10305, "32, rue de Démonstration, Amiens (adresse fictive)", "musée", 3, "Activité fictive de démonstration à Amiens. Jour 3, visite 2. Prévoir un temps de découverte puis une pause. Aucune réservation réelle ne doit être effectuée à partir de ces informations.", "14:00–17:00 (démonstration)", "Non renseigné", "Musée des découvertes — étape 3.2", 1026, 2, "" },
                    { 10306, "33, rue de Démonstration, Amiens (adresse fictive)", "château", 3, "Activité fictive de démonstration à Amiens. Jour 3, visite 3. Prévoir un temps de découverte puis une pause. Aucune réservation réelle ne doit être effectuée à partir de ces informations.", "17:30–19:00 (démonstration)", "Non renseigné", "Château des voyageurs — étape 3.3", 1026, 3, "" },
                    { 10307, "41, rue de Démonstration, Amiens (adresse fictive)", "musée", 4, "Activité fictive de démonstration à Amiens. Jour 4, visite 1. Prévoir un temps de découverte puis une pause. Aucune réservation réelle ne doit être effectuée à partir de ces informations.", "09:00–12:00 (démonstration)", "Non renseigné", "Musée des découvertes — étape 4.1", 1026, 1, "" },
                    { 10308, "42, rue de Démonstration, Amiens (adresse fictive)", "château", 4, "Activité fictive de démonstration à Amiens. Jour 4, visite 2. Prévoir un temps de découverte puis une pause. Aucune réservation réelle ne doit être effectuée à partir de ces informations.", "14:00–17:00 (démonstration)", "Non renseigné", "Château des voyageurs — étape 4.2", 1026, 2, "" },
                    { 10309, "43, rue de Démonstration, Amiens (adresse fictive)", "activité", 4, "Activité fictive de démonstration à Amiens. Jour 4, visite 3. Prévoir un temps de découverte puis une pause. Aucune réservation réelle ne doit être effectuée à partir de ces informations.", "17:30–19:00 (démonstration)", "Non renseigné", "Atelier de découverte locale — étape 4.3", 1026, 3, "" },
                    { 10310, "11, rue de Démonstration, Orléans (adresse fictive)", "parc", 1, "Activité fictive de démonstration à Orléans. Jour 1, visite 1. Prévoir un temps de découverte puis une pause. Aucune réservation réelle ne doit être effectuée à partir de ces informations.", "09:00–12:00 (démonstration)", "Non renseigné", "Parc des horizons — étape 1.1", 1027, 1, "" },
                    { 10311, "12, rue de Démonstration, Orléans (adresse fictive)", "grotte", 1, "Activité fictive de démonstration à Orléans. Jour 1, visite 2. Prévoir un temps de découverte puis une pause. Aucune réservation réelle ne doit être effectuée à partir de ces informations.", "14:00–17:00 (démonstration)", "Non renseigné", "Grotte des lumières — étape 1.2", 1027, 2, "" },
                    { 10312, "13, rue de Démonstration, Orléans (adresse fictive)", "musée", 1, "Activité fictive de démonstration à Orléans. Jour 1, visite 3. Prévoir un temps de découverte puis une pause. Aucune réservation réelle ne doit être effectuée à partir de ces informations.", "17:30–19:00 (démonstration)", "Non renseigné", "Musée des découvertes — étape 1.3", 1027, 3, "" },
                    { 10313, "21, rue de Démonstration, Orléans (adresse fictive)", "grotte", 2, "Activité fictive de démonstration à Orléans. Jour 2, visite 1. Prévoir un temps de découverte puis une pause. Aucune réservation réelle ne doit être effectuée à partir de ces informations.", "09:00–12:00 (démonstration)", "Non renseigné", "Grotte des lumières — étape 2.1", 1027, 1, "" },
                    { 10314, "22, rue de Démonstration, Orléans (adresse fictive)", "musée", 2, "Activité fictive de démonstration à Orléans. Jour 2, visite 2. Prévoir un temps de découverte puis une pause. Aucune réservation réelle ne doit être effectuée à partir de ces informations.", "14:00–17:00 (démonstration)", "Non renseigné", "Musée des découvertes — étape 2.2", 1027, 2, "" },
                    { 10315, "23, rue de Démonstration, Orléans (adresse fictive)", "château", 2, "Activité fictive de démonstration à Orléans. Jour 2, visite 3. Prévoir un temps de découverte puis une pause. Aucune réservation réelle ne doit être effectuée à partir de ces informations.", "17:30–19:00 (démonstration)", "Non renseigné", "Château des voyageurs — étape 2.3", 1027, 3, "" },
                    { 10316, "31, rue de Démonstration, Orléans (adresse fictive)", "musée", 3, "Activité fictive de démonstration à Orléans. Jour 3, visite 1. Prévoir un temps de découverte puis une pause. Aucune réservation réelle ne doit être effectuée à partir de ces informations.", "09:00–12:00 (démonstration)", "Non renseigné", "Musée des découvertes — étape 3.1", 1027, 1, "" },
                    { 10317, "32, rue de Démonstration, Orléans (adresse fictive)", "château", 3, "Activité fictive de démonstration à Orléans. Jour 3, visite 2. Prévoir un temps de découverte puis une pause. Aucune réservation réelle ne doit être effectuée à partir de ces informations.", "14:00–17:00 (démonstration)", "Non renseigné", "Château des voyageurs — étape 3.2", 1027, 2, "" },
                    { 10318, "33, rue de Démonstration, Orléans (adresse fictive)", "activité", 3, "Activité fictive de démonstration à Orléans. Jour 3, visite 3. Prévoir un temps de découverte puis une pause. Aucune réservation réelle ne doit être effectuée à partir de ces informations.", "17:30–19:00 (démonstration)", "Non renseigné", "Atelier de découverte locale — étape 3.3", 1027, 3, "" },
                    { 10319, "41, rue de Démonstration, Orléans (adresse fictive)", "château", 4, "Activité fictive de démonstration à Orléans. Jour 4, visite 1. Prévoir un temps de découverte puis une pause. Aucune réservation réelle ne doit être effectuée à partir de ces informations.", "09:00–12:00 (démonstration)", "Non renseigné", "Château des voyageurs — étape 4.1", 1027, 1, "" },
                    { 10320, "42, rue de Démonstration, Orléans (adresse fictive)", "activité", 4, "Activité fictive de démonstration à Orléans. Jour 4, visite 2. Prévoir un temps de découverte puis une pause. Aucune réservation réelle ne doit être effectuée à partir de ces informations.", "14:00–17:00 (démonstration)", "Non renseigné", "Atelier de découverte locale — étape 4.2", 1027, 2, "" },
                    { 10321, "43, rue de Démonstration, Orléans (adresse fictive)", "parc", 4, "Activité fictive de démonstration à Orléans. Jour 4, visite 3. Prévoir un temps de découverte puis une pause. Aucune réservation réelle ne doit être effectuée à partir de ces informations.", "17:30–19:00 (démonstration)", "Non renseigné", "Parc des horizons — étape 4.3", 1027, 3, "" },
                    { 10322, "51, rue de Démonstration, Orléans (adresse fictive)", "activité", 5, "Activité fictive de démonstration à Orléans. Jour 5, visite 1. Prévoir un temps de découverte puis une pause. Aucune réservation réelle ne doit être effectuée à partir de ces informations.", "09:00–12:00 (démonstration)", "Non renseigné", "Atelier de découverte locale — étape 5.1", 1027, 1, "" },
                    { 10323, "52, rue de Démonstration, Orléans (adresse fictive)", "parc", 5, "Activité fictive de démonstration à Orléans. Jour 5, visite 2. Prévoir un temps de découverte puis une pause. Aucune réservation réelle ne doit être effectuée à partir de ces informations.", "14:00–17:00 (démonstration)", "Non renseigné", "Parc des horizons — étape 5.2", 1027, 2, "" },
                    { 10324, "53, rue de Démonstration, Orléans (adresse fictive)", "grotte", 5, "Activité fictive de démonstration à Orléans. Jour 5, visite 3. Prévoir un temps de découverte puis une pause. Aucune réservation réelle ne doit être effectuée à partir de ces informations.", "17:30–19:00 (démonstration)", "Non renseigné", "Grotte des lumières — étape 5.3", 1027, 3, "" },
                    { 10325, "11, rue de Démonstration, Angers (adresse fictive)", "grotte", 1, "Activité fictive de démonstration à Angers. Jour 1, visite 1. Prévoir un temps de découverte puis une pause. Aucune réservation réelle ne doit être effectuée à partir de ces informations.", "09:00–12:00 (démonstration)", "Non renseigné", "Grotte des lumières — étape 1.1", 1028, 1, "" },
                    { 10326, "12, rue de Démonstration, Angers (adresse fictive)", "musée", 1, "Activité fictive de démonstration à Angers. Jour 1, visite 2. Prévoir un temps de découverte puis une pause. Aucune réservation réelle ne doit être effectuée à partir de ces informations.", "14:00–17:00 (démonstration)", "Non renseigné", "Musée des découvertes — étape 1.2", 1028, 2, "" },
                    { 10327, "13, rue de Démonstration, Angers (adresse fictive)", "château", 1, "Activité fictive de démonstration à Angers. Jour 1, visite 3. Prévoir un temps de découverte puis une pause. Aucune réservation réelle ne doit être effectuée à partir de ces informations.", "17:30–19:00 (démonstration)", "Non renseigné", "Château des voyageurs — étape 1.3", 1028, 3, "" },
                    { 10328, "21, rue de Démonstration, Angers (adresse fictive)", "musée", 2, "Activité fictive de démonstration à Angers. Jour 2, visite 1. Prévoir un temps de découverte puis une pause. Aucune réservation réelle ne doit être effectuée à partir de ces informations.", "09:00–12:00 (démonstration)", "Non renseigné", "Musée des découvertes — étape 2.1", 1028, 1, "" },
                    { 10329, "22, rue de Démonstration, Angers (adresse fictive)", "château", 2, "Activité fictive de démonstration à Angers. Jour 2, visite 2. Prévoir un temps de découverte puis une pause. Aucune réservation réelle ne doit être effectuée à partir de ces informations.", "14:00–17:00 (démonstration)", "Non renseigné", "Château des voyageurs — étape 2.2", 1028, 2, "" },
                    { 10330, "23, rue de Démonstration, Angers (adresse fictive)", "activité", 2, "Activité fictive de démonstration à Angers. Jour 2, visite 3. Prévoir un temps de découverte puis une pause. Aucune réservation réelle ne doit être effectuée à partir de ces informations.", "17:30–19:00 (démonstration)", "Non renseigné", "Atelier de découverte locale — étape 2.3", 1028, 3, "" },
                    { 10331, "31, rue de Démonstration, Angers (adresse fictive)", "château", 3, "Activité fictive de démonstration à Angers. Jour 3, visite 1. Prévoir un temps de découverte puis une pause. Aucune réservation réelle ne doit être effectuée à partir de ces informations.", "09:00–12:00 (démonstration)", "Non renseigné", "Château des voyageurs — étape 3.1", 1028, 1, "" },
                    { 10332, "32, rue de Démonstration, Angers (adresse fictive)", "activité", 3, "Activité fictive de démonstration à Angers. Jour 3, visite 2. Prévoir un temps de découverte puis une pause. Aucune réservation réelle ne doit être effectuée à partir de ces informations.", "14:00–17:00 (démonstration)", "Non renseigné", "Atelier de découverte locale — étape 3.2", 1028, 2, "" },
                    { 10333, "33, rue de Démonstration, Angers (adresse fictive)", "parc", 3, "Activité fictive de démonstration à Angers. Jour 3, visite 3. Prévoir un temps de découverte puis une pause. Aucune réservation réelle ne doit être effectuée à partir de ces informations.", "17:30–19:00 (démonstration)", "Non renseigné", "Parc des horizons — étape 3.3", 1028, 3, "" },
                    { 10334, "11, rue de Démonstration, Saint-Malo (adresse fictive)", "musée", 1, "Activité fictive de démonstration à Saint-Malo. Jour 1, visite 1. Prévoir un temps de découverte puis une pause. Aucune réservation réelle ne doit être effectuée à partir de ces informations.", "09:00–12:00 (démonstration)", "Non renseigné", "Musée des découvertes — étape 1.1", 1029, 1, "" },
                    { 10335, "12, rue de Démonstration, Saint-Malo (adresse fictive)", "château", 1, "Activité fictive de démonstration à Saint-Malo. Jour 1, visite 2. Prévoir un temps de découverte puis une pause. Aucune réservation réelle ne doit être effectuée à partir de ces informations.", "14:00–17:00 (démonstration)", "Non renseigné", "Château des voyageurs — étape 1.2", 1029, 2, "" },
                    { 10336, "13, rue de Démonstration, Saint-Malo (adresse fictive)", "activité", 1, "Activité fictive de démonstration à Saint-Malo. Jour 1, visite 3. Prévoir un temps de découverte puis une pause. Aucune réservation réelle ne doit être effectuée à partir de ces informations.", "17:30–19:00 (démonstration)", "Non renseigné", "Atelier de découverte locale — étape 1.3", 1029, 3, "" },
                    { 10337, "21, rue de Démonstration, Saint-Malo (adresse fictive)", "château", 2, "Activité fictive de démonstration à Saint-Malo. Jour 2, visite 1. Prévoir un temps de découverte puis une pause. Aucune réservation réelle ne doit être effectuée à partir de ces informations.", "09:00–12:00 (démonstration)", "Non renseigné", "Château des voyageurs — étape 2.1", 1029, 1, "" },
                    { 10338, "22, rue de Démonstration, Saint-Malo (adresse fictive)", "activité", 2, "Activité fictive de démonstration à Saint-Malo. Jour 2, visite 2. Prévoir un temps de découverte puis une pause. Aucune réservation réelle ne doit être effectuée à partir de ces informations.", "14:00–17:00 (démonstration)", "Non renseigné", "Atelier de découverte locale — étape 2.2", 1029, 2, "" },
                    { 10339, "23, rue de Démonstration, Saint-Malo (adresse fictive)", "parc", 2, "Activité fictive de démonstration à Saint-Malo. Jour 2, visite 3. Prévoir un temps de découverte puis une pause. Aucune réservation réelle ne doit être effectuée à partir de ces informations.", "17:30–19:00 (démonstration)", "Non renseigné", "Parc des horizons — étape 2.3", 1029, 3, "" },
                    { 10340, "31, rue de Démonstration, Saint-Malo (adresse fictive)", "activité", 3, "Activité fictive de démonstration à Saint-Malo. Jour 3, visite 1. Prévoir un temps de découverte puis une pause. Aucune réservation réelle ne doit être effectuée à partir de ces informations.", "09:00–12:00 (démonstration)", "Non renseigné", "Atelier de découverte locale — étape 3.1", 1029, 1, "" },
                    { 10341, "32, rue de Démonstration, Saint-Malo (adresse fictive)", "parc", 3, "Activité fictive de démonstration à Saint-Malo. Jour 3, visite 2. Prévoir un temps de découverte puis une pause. Aucune réservation réelle ne doit être effectuée à partir de ces informations.", "14:00–17:00 (démonstration)", "Non renseigné", "Parc des horizons — étape 3.2", 1029, 2, "" },
                    { 10342, "33, rue de Démonstration, Saint-Malo (adresse fictive)", "grotte", 3, "Activité fictive de démonstration à Saint-Malo. Jour 3, visite 3. Prévoir un temps de découverte puis une pause. Aucune réservation réelle ne doit être effectuée à partir de ces informations.", "17:30–19:00 (démonstration)", "Non renseigné", "Grotte des lumières — étape 3.3", 1029, 3, "" },
                    { 10343, "41, rue de Démonstration, Saint-Malo (adresse fictive)", "parc", 4, "Activité fictive de démonstration à Saint-Malo. Jour 4, visite 1. Prévoir un temps de découverte puis une pause. Aucune réservation réelle ne doit être effectuée à partir de ces informations.", "09:00–12:00 (démonstration)", "Non renseigné", "Parc des horizons — étape 4.1", 1029, 1, "" },
                    { 10344, "42, rue de Démonstration, Saint-Malo (adresse fictive)", "grotte", 4, "Activité fictive de démonstration à Saint-Malo. Jour 4, visite 2. Prévoir un temps de découverte puis une pause. Aucune réservation réelle ne doit être effectuée à partir de ces informations.", "14:00–17:00 (démonstration)", "Non renseigné", "Grotte des lumières — étape 4.2", 1029, 2, "" },
                    { 10345, "43, rue de Démonstration, Saint-Malo (adresse fictive)", "musée", 4, "Activité fictive de démonstration à Saint-Malo. Jour 4, visite 3. Prévoir un temps de découverte puis une pause. Aucune réservation réelle ne doit être effectuée à partir de ces informations.", "17:30–19:00 (démonstration)", "Non renseigné", "Musée des découvertes — étape 4.3", 1029, 3, "" },
                    { 10346, "11, rue de Démonstration, Colmar (adresse fictive)", "château", 1, "Activité fictive de démonstration à Colmar. Jour 1, visite 1. Prévoir un temps de découverte puis une pause. Aucune réservation réelle ne doit être effectuée à partir de ces informations.", "09:00–12:00 (démonstration)", "Non renseigné", "Château des voyageurs — étape 1.1", 1030, 1, "" },
                    { 10347, "12, rue de Démonstration, Colmar (adresse fictive)", "activité", 1, "Activité fictive de démonstration à Colmar. Jour 1, visite 2. Prévoir un temps de découverte puis une pause. Aucune réservation réelle ne doit être effectuée à partir de ces informations.", "14:00–17:00 (démonstration)", "Non renseigné", "Atelier de découverte locale — étape 1.2", 1030, 2, "" },
                    { 10348, "13, rue de Démonstration, Colmar (adresse fictive)", "parc", 1, "Activité fictive de démonstration à Colmar. Jour 1, visite 3. Prévoir un temps de découverte puis une pause. Aucune réservation réelle ne doit être effectuée à partir de ces informations.", "17:30–19:00 (démonstration)", "Non renseigné", "Parc des horizons — étape 1.3", 1030, 3, "" },
                    { 10349, "21, rue de Démonstration, Colmar (adresse fictive)", "activité", 2, "Activité fictive de démonstration à Colmar. Jour 2, visite 1. Prévoir un temps de découverte puis une pause. Aucune réservation réelle ne doit être effectuée à partir de ces informations.", "09:00–12:00 (démonstration)", "Non renseigné", "Atelier de découverte locale — étape 2.1", 1030, 1, "" },
                    { 10350, "22, rue de Démonstration, Colmar (adresse fictive)", "parc", 2, "Activité fictive de démonstration à Colmar. Jour 2, visite 2. Prévoir un temps de découverte puis une pause. Aucune réservation réelle ne doit être effectuée à partir de ces informations.", "14:00–17:00 (démonstration)", "Non renseigné", "Parc des horizons — étape 2.2", 1030, 2, "" },
                    { 10351, "23, rue de Démonstration, Colmar (adresse fictive)", "grotte", 2, "Activité fictive de démonstration à Colmar. Jour 2, visite 3. Prévoir un temps de découverte puis une pause. Aucune réservation réelle ne doit être effectuée à partir de ces informations.", "17:30–19:00 (démonstration)", "Non renseigné", "Grotte des lumières — étape 2.3", 1030, 3, "" },
                    { 10352, "31, rue de Démonstration, Colmar (adresse fictive)", "parc", 3, "Activité fictive de démonstration à Colmar. Jour 3, visite 1. Prévoir un temps de découverte puis une pause. Aucune réservation réelle ne doit être effectuée à partir de ces informations.", "09:00–12:00 (démonstration)", "Non renseigné", "Parc des horizons — étape 3.1", 1030, 1, "" },
                    { 10353, "32, rue de Démonstration, Colmar (adresse fictive)", "grotte", 3, "Activité fictive de démonstration à Colmar. Jour 3, visite 2. Prévoir un temps de découverte puis une pause. Aucune réservation réelle ne doit être effectuée à partir de ces informations.", "14:00–17:00 (démonstration)", "Non renseigné", "Grotte des lumières — étape 3.2", 1030, 2, "" },
                    { 10354, "33, rue de Démonstration, Colmar (adresse fictive)", "musée", 3, "Activité fictive de démonstration à Colmar. Jour 3, visite 3. Prévoir un temps de découverte puis une pause. Aucune réservation réelle ne doit être effectuée à partir de ces informations.", "17:30–19:00 (démonstration)", "Non renseigné", "Musée des découvertes — étape 3.3", 1030, 3, "" },
                    { 10355, "41, rue de Démonstration, Colmar (adresse fictive)", "grotte", 4, "Activité fictive de démonstration à Colmar. Jour 4, visite 1. Prévoir un temps de découverte puis une pause. Aucune réservation réelle ne doit être effectuée à partir de ces informations.", "09:00–12:00 (démonstration)", "Non renseigné", "Grotte des lumières — étape 4.1", 1030, 1, "" },
                    { 10356, "42, rue de Démonstration, Colmar (adresse fictive)", "musée", 4, "Activité fictive de démonstration à Colmar. Jour 4, visite 2. Prévoir un temps de découverte puis une pause. Aucune réservation réelle ne doit être effectuée à partir de ces informations.", "14:00–17:00 (démonstration)", "Non renseigné", "Musée des découvertes — étape 4.2", 1030, 2, "" },
                    { 10357, "43, rue de Démonstration, Colmar (adresse fictive)", "château", 4, "Activité fictive de démonstration à Colmar. Jour 4, visite 3. Prévoir un temps de découverte puis une pause. Aucune réservation réelle ne doit être effectuée à partir de ces informations.", "17:30–19:00 (démonstration)", "Non renseigné", "Château des voyageurs — étape 4.3", 1030, 3, "" },
                    { 10358, "51, rue de Démonstration, Colmar (adresse fictive)", "musée", 5, "Activité fictive de démonstration à Colmar. Jour 5, visite 1. Prévoir un temps de découverte puis une pause. Aucune réservation réelle ne doit être effectuée à partir de ces informations.", "09:00–12:00 (démonstration)", "Non renseigné", "Musée des découvertes — étape 5.1", 1030, 1, "" },
                    { 10359, "52, rue de Démonstration, Colmar (adresse fictive)", "château", 5, "Activité fictive de démonstration à Colmar. Jour 5, visite 2. Prévoir un temps de découverte puis une pause. Aucune réservation réelle ne doit être effectuée à partir de ces informations.", "14:00–17:00 (démonstration)", "Non renseigné", "Château des voyageurs — étape 5.2", 1030, 2, "" },
                    { 10360, "53, rue de Démonstration, Colmar (adresse fictive)", "activité", 5, "Activité fictive de démonstration à Colmar. Jour 5, visite 3. Prévoir un temps de découverte puis une pause. Aucune réservation réelle ne doit être effectuée à partir de ces informations.", "17:30–19:00 (démonstration)", "Non renseigné", "Atelier de découverte locale — étape 5.3", 1030, 3, "" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 10001);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 10002);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 10003);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 10004);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 10005);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 10006);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 10007);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 10008);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 10009);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 10010);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 10011);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 10012);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 10013);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 10014);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 10015);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 10016);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 10017);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 10018);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 10019);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 10020);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 10021);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 10022);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 10023);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 10024);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 10025);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 10026);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 10027);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 10028);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 10029);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 10030);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 10031);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 10032);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 10033);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 10034);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 10035);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 10036);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 10037);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 10038);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 10039);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 10040);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 10041);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 10042);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 10043);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 10044);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 10045);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 10046);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 10047);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 10048);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 10049);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 10050);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 10051);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 10052);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 10053);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 10054);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 10055);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 10056);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 10057);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 10058);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 10059);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 10060);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 10061);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 10062);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 10063);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 10064);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 10065);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 10066);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 10067);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 10068);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 10069);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 10070);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 10071);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 10072);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 10073);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 10074);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 10075);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 10076);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 10077);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 10078);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 10079);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 10080);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 10081);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 10082);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 10083);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 10084);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 10085);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 10086);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 10087);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 10088);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 10089);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 10090);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 10091);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 10092);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 10093);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 10094);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 10095);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 10096);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 10097);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 10098);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 10099);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 10100);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 10101);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 10102);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 10103);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 10104);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 10105);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 10106);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 10107);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 10108);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 10109);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 10110);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 10111);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 10112);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 10113);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 10114);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 10115);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 10116);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 10117);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 10118);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 10119);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 10120);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 10121);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 10122);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 10123);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 10124);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 10125);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 10126);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 10127);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 10128);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 10129);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 10130);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 10131);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 10132);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 10133);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 10134);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 10135);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 10136);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 10137);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 10138);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 10139);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 10140);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 10141);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 10142);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 10143);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 10144);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 10145);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 10146);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 10147);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 10148);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 10149);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 10150);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 10151);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 10152);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 10153);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 10154);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 10155);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 10156);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 10157);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 10158);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 10159);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 10160);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 10161);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 10162);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 10163);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 10164);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 10165);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 10166);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 10167);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 10168);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 10169);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 10170);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 10171);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 10172);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 10173);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 10174);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 10175);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 10176);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 10177);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 10178);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 10179);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 10180);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 10181);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 10182);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 10183);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 10184);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 10185);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 10186);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 10187);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 10188);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 10189);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 10190);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 10191);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 10192);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 10193);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 10194);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 10195);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 10196);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 10197);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 10198);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 10199);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 10200);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 10201);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 10202);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 10203);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 10204);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 10205);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 10206);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 10207);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 10208);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 10209);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 10210);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 10211);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 10212);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 10213);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 10214);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 10215);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 10216);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 10217);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 10218);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 10219);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 10220);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 10221);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 10222);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 10223);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 10224);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 10225);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 10226);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 10227);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 10228);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 10229);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 10230);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 10231);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 10232);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 10233);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 10234);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 10235);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 10236);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 10237);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 10238);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 10239);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 10240);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 10241);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 10242);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 10243);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 10244);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 10245);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 10246);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 10247);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 10248);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 10249);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 10250);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 10251);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 10252);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 10253);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 10254);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 10255);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 10256);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 10257);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 10258);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 10259);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 10260);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 10261);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 10262);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 10263);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 10264);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 10265);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 10266);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 10267);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 10268);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 10269);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 10270);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 10271);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 10272);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 10273);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 10274);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 10275);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 10276);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 10277);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 10278);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 10279);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 10280);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 10281);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 10282);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 10283);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 10284);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 10285);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 10286);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 10287);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 10288);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 10289);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 10290);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 10291);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 10292);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 10293);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 10294);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 10295);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 10296);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 10297);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 10298);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 10299);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 10300);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 10301);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 10302);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 10303);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 10304);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 10305);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 10306);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 10307);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 10308);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 10309);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 10310);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 10311);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 10312);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 10313);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 10314);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 10315);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 10316);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 10317);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 10318);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 10319);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 10320);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 10321);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 10322);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 10323);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 10324);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 10325);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 10326);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 10327);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 10328);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 10329);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 10330);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 10331);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 10332);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 10333);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 10334);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 10335);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 10336);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 10337);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 10338);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 10339);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 10340);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 10341);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 10342);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 10343);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 10344);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 10345);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 10346);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 10347);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 10348);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 10349);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 10350);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 10351);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 10352);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 10353);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 10354);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 10355);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 10356);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 10357);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 10358);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 10359);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 10360);

            migrationBuilder.DeleteData(
                table: "Guides",
                keyColumn: "Id",
                keyValue: 1001);

            migrationBuilder.DeleteData(
                table: "Guides",
                keyColumn: "Id",
                keyValue: 1002);

            migrationBuilder.DeleteData(
                table: "Guides",
                keyColumn: "Id",
                keyValue: 1003);

            migrationBuilder.DeleteData(
                table: "Guides",
                keyColumn: "Id",
                keyValue: 1004);

            migrationBuilder.DeleteData(
                table: "Guides",
                keyColumn: "Id",
                keyValue: 1005);

            migrationBuilder.DeleteData(
                table: "Guides",
                keyColumn: "Id",
                keyValue: 1006);

            migrationBuilder.DeleteData(
                table: "Guides",
                keyColumn: "Id",
                keyValue: 1007);

            migrationBuilder.DeleteData(
                table: "Guides",
                keyColumn: "Id",
                keyValue: 1008);

            migrationBuilder.DeleteData(
                table: "Guides",
                keyColumn: "Id",
                keyValue: 1009);

            migrationBuilder.DeleteData(
                table: "Guides",
                keyColumn: "Id",
                keyValue: 1010);

            migrationBuilder.DeleteData(
                table: "Guides",
                keyColumn: "Id",
                keyValue: 1011);

            migrationBuilder.DeleteData(
                table: "Guides",
                keyColumn: "Id",
                keyValue: 1012);

            migrationBuilder.DeleteData(
                table: "Guides",
                keyColumn: "Id",
                keyValue: 1013);

            migrationBuilder.DeleteData(
                table: "Guides",
                keyColumn: "Id",
                keyValue: 1014);

            migrationBuilder.DeleteData(
                table: "Guides",
                keyColumn: "Id",
                keyValue: 1015);

            migrationBuilder.DeleteData(
                table: "Guides",
                keyColumn: "Id",
                keyValue: 1016);

            migrationBuilder.DeleteData(
                table: "Guides",
                keyColumn: "Id",
                keyValue: 1017);

            migrationBuilder.DeleteData(
                table: "Guides",
                keyColumn: "Id",
                keyValue: 1018);

            migrationBuilder.DeleteData(
                table: "Guides",
                keyColumn: "Id",
                keyValue: 1019);

            migrationBuilder.DeleteData(
                table: "Guides",
                keyColumn: "Id",
                keyValue: 1020);

            migrationBuilder.DeleteData(
                table: "Guides",
                keyColumn: "Id",
                keyValue: 1021);

            migrationBuilder.DeleteData(
                table: "Guides",
                keyColumn: "Id",
                keyValue: 1022);

            migrationBuilder.DeleteData(
                table: "Guides",
                keyColumn: "Id",
                keyValue: 1023);

            migrationBuilder.DeleteData(
                table: "Guides",
                keyColumn: "Id",
                keyValue: 1024);

            migrationBuilder.DeleteData(
                table: "Guides",
                keyColumn: "Id",
                keyValue: 1025);

            migrationBuilder.DeleteData(
                table: "Guides",
                keyColumn: "Id",
                keyValue: 1026);

            migrationBuilder.DeleteData(
                table: "Guides",
                keyColumn: "Id",
                keyValue: 1027);

            migrationBuilder.DeleteData(
                table: "Guides",
                keyColumn: "Id",
                keyValue: 1028);

            migrationBuilder.DeleteData(
                table: "Guides",
                keyColumn: "Id",
                keyValue: 1029);

            migrationBuilder.DeleteData(
                table: "Guides",
                keyColumn: "Id",
                keyValue: 1030);
        }
    }
}
