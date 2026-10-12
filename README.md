# TravelGuides — Test technique Fullstack

Application de consultation de guides de voyage, réalisée avec Blazor, ASP.NET Core Web API et Entity Framework Core.

## État du projet

Le rendu est partiel. La priorité a été donnée à un parcours fonctionnel complet : consulter la liste des guides, ouvrir un guide et afficher ses activités à partir des données stockées en base, via l'API.

### Fonctionnalités réalisées

- Frontend Blazor avec affichage des guides sous forme de cartes.
- Détail d'un guide : description, durée, mobilité, saison et public.
- Activités regroupées par jour et triées par ordre de visite.
- Affichage des informations pratiques des activités.
- États de chargement, messages d'erreur, bouton de nouvelle tentative et gestion d'un guide introuvable.
- API de consultation des guides avec séparation contrôleurs/services/ViewModels.
- Base SQL Server LocalDB et migrations EF Core.
- Données de démonstration : 32 guides et 366 activités après application des migrations sur une base neuve.
- ASP.NET Core Identity : utilisateurs, mots de passe hachés et rôles Admin/User.
- Endpoints de connexion JWT et de consultation du compte authentifié.

### Fonctionnalités non terminées

- Interface de connexion et utilisation du jeton dans Blazor.
- Invitations aux guides et restriction de leur consultation selon l'utilisateur.
- Opérations administrateur : création, modification et suppression des guides, gestion des activités et des utilisateurs.
- Recherche, pagination et autres bonus du sujet.
- Tests automatisés.

**Les endpoints de consultation des guides restent publics.** La présence des rôles et de la connexion JWT ne signifie pas que les permissions métier sont appliquées. Tous les guides sont visibles dans l'interface actuelle.

## Technologies et choix

- C# et .NET 10.
- Blazor Web App en mode interactif Serveur.
- ASP.NET Core Web API avec contrôleurs.
- Entity Framework Core 10 et SQL Server Express LocalDB.
- ASP.NET Core Identity et authentification JWT.
- Bootstrap pour la mise en page.

Cette stack reprend des technologies familières afin de concentrer le travail sur le parcours de consultation. LocalDB permet de consulter les données depuis Visual Studio. Les migrations reproduisent la structure et les données de démonstration. Les ViewModels définissent les réponses de l'API sans exposer directement les entités EF Core.

## Prérequis

- Windows.
- SDK .NET 10.
- Visual Studio 2026 avec la charge de travail « Développement ASP.NET et web ».
- SQL Server Express LocalDB, avec l'instance `(localdb)\MSSQLLocalDB`.
- Git pour récupérer le dépôt.

LocalDB rend cette procédure de lancement spécifique à Windows.

## Installation et configuration

### 1. Récupérer le projet

```powershell
git clone https://github.com/maximeringue/TravelGuides.git
Set-Location TravelGuides
```

Ouvrir **Test HWS.slnx** dans Visual Studio et laisser NuGet restaurer les packages. L'accès au dépôt est nécessaire s'il est privé.

### 2. Configurer la clé JWT

La configuration JWT est nécessaire au démarrage de l'API, même pour consulter les guides sans connexion.

Dans Visual Studio, faire clic droit sur **TravelGuides.Api → Gérer les secrets utilisateur**.

Générer une clé dans **PowerShell** :

```powershell
$jwtBytes = New-Object byte[] 32
$jwtGenerator = [System.Security.Cryptography.RandomNumberGenerator]::Create()
$jwtGenerator.GetBytes($jwtBytes)
$jwtGenerator.Dispose()
[Convert]::ToBase64String($jwtBytes)
```

Dans le fichier `secrets.json` ouvert par Visual Studio, renseigner :

```json
{
  "Jwt": {
    "Key": "REMPLACER_PAR_LA_CLE_GENEREE",
    "Issuer": "TravelGuides.Api",
    "Audience": "TravelGuides.Web"
  }
}
```

Remplacer la valeur de `Key` et enregistrer. Ce fichier reste en dehors du dépôt ; chaque personne doit configurer sa propre clé. Il est chargé en environnement Development.

### 3. Créer la base et charger les données

La connexion définie dans `TravelGuides.Api/appsettings.json` utilise l'authentification Windows :

```json
"ConnectionStrings": {
  "DefaultConnection": "Server=(localdb)\\MSSQLLocalDB;Database=TravelGuidesDb;Trusted_Connection=True;"
}
```

Dans Visual Studio, définir **TravelGuides.Api** comme projet de démarrage.

Ouvrir **Outils → Gestionnaire de package NuGet → Console du Gestionnaire de package**, puis exécuter :

```powershell
Update-Database -Project TravelGuides.Api -StartupProject TravelGuides.Api
```

Cette commande applique les migrations déjà présentes dans le dépôt :

1. `InitialCreate` : guides, activités et premiers exemples.
2. `AddIdentity` : tables des utilisateurs et rôles.
3. `AddDemoGuides` : 30 guides et 360 activités supplémentaires.

Il n'est pas nécessaire de générer une nouvelle migration ni d'exécuter un script SQL séparé. La base n'est pas créée automatiquement par le lancement de l'application : appliquer les migrations avant le premier démarrage.

Les comptes de démonstration sont créés au démarrage de l'API en environnement Development, après création de la base. L'initialisation vérifie leur existence afin de ne pas les dupliquer.

### 4. Configurer HTTPS

Si le certificat de développement n'est pas encore approuvé, exécuter :

```powershell
dotnet dev-certs https --trust
```

Accepter la demande de confiance pour le certificat local.

### 5. Lancer l'API et le frontend

Dans les propriétés de la solution, sélectionner **Plusieurs projets de démarrage**, puis mettre **TravelGuides.Api** et **Test HWS** sur **Démarrer**. Utiliser le profil **https** pour les deux projets.

Lancer avec F5, puis ouvrir :

- Frontend : https://localhost:7086
- API : https://localhost:7164/api/guides

Le navigateur ne s'ouvre pas automatiquement pour l'API. Sa racine `/` ne contient pas de page d'accueil.

Autre possibilité : depuis la racine du dépôt, lancer les commandes suivantes dans **deux terminaux distincts** :

```powershell
dotnet run --project "TravelGuides.Api/TravelGuides.Api.csproj" --launch-profile https
```

```powershell
dotnet run --project "Test HWS/Test HWS.csproj" --launch-profile https
```

Le frontend appelle `https://localhost:7164/`, adresse configurée dans son `Program.cs`. Si le port de l'API est modifié, adapter également cette adresse.

## Comptes de démonstration

| Email | Mot de passe | Rôle |
|---|---|---|
| admin@example.com | DemoAdmin123! | Admin |
| user@example.com | DemoUser123! | User |

Ces comptes servent uniquement aux essais locaux de l'API. Il n'existe pas encore de formulaire de connexion dans le frontend.

## Endpoints

| Méthode | Route | Comportement |
|---|---|---|
| GET | `/api/guides` | Liste des guides, accessible sans connexion |
| GET | `/api/guides/{id}` | Détail et activités ; 404 si le guide n'existe pas |
| POST | `/api/auth/login` | Vérification des identifiants et émission d'un jeton valable une heure |
| GET | `/api/auth/me` | Identité et rôles du compte ; nécessite un jeton valide |

Exemple de corps JSON pour la connexion :

```json
{
  "email": "admin@example.com",
  "password": "DemoAdmin123!"
}
```

Pour appeler `/api/auth/me`, transmettre le jeton reçu :

```http
Authorization: Bearer <accessToken>
```

Le fichier `TravelGuides.Api/TravelGuides.Api.http` permet d'effectuer les appels depuis Visual Studio. Retirer tout jeton réel du fichier avant de le commiter.

Le document OpenAPI est accessible en développement à `https://localhost:7164/openapi/v1.json`. Aucune interface Swagger UI n'est configurée.

## Vérifications manuelles

Le parcours de consultation et l'affichage des données de démonstration ont été vérifiés pendant le développement. Pour reproduire les contrôles :

1. Ouvrir le frontend et vérifier la liste des guides.
2. Ouvrir Paris puis un guide de démonstration ; vérifier les jours et l'ordre des activités.
3. Utiliser le lien de retour à la liste.
4. Ouvrir `https://localhost:7086/guides/999` : message « Ce guide est introuvable ».
5. Appeler `/api/guides/999` : réponse HTTP 404.
6. Pour contrôler les erreurs de chargement, arrêter uniquement l'API et actualiser la liste du frontend ; un message d'erreur doit apparaître. Redémarrer l'API, puis utiliser « Réessayer ».
7. Pour vérifier la connexion API, tester un compte de démonstration, un mauvais mot de passe, puis `/api/auth/me` avec et sans jeton. Résultats attendus : 200, 401, 200 et 401.

Aucune suite de tests automatisés n'est fournie. Les tests de connexion ci-dessus sont des vérifications à effectuer, distinctes du parcours de consultation déjà vérifié.

## Organisation

```text
Test HWS.slnx
Test HWS/                       # Frontend Blazor
  Components/Pages/             # Liste et détail des guides
  ViewModels/                   # Objets désérialisés depuis l'API
  Program.cs                    # Configuration du client HTTP
TravelGuides.Api/                # Backend
  Controllers/                  # Routes HTTP
  Services/                     # Lecture des données et connexion
  Models/                       # Entités EF Core et utilisateur Identity
  ViewModels/                   # Données reçues et renvoyées par l'API
  Data/                         # DbContext et initialisation des données
  Migrations/                   # Structure et données reproductibles
```

Les appels API sont effectués par le serveur Blazor. Le parcours est : navigateur → Blazor → API → EF Core → LocalDB.

## Données et interprétation du sujet

Le jeu de démonstration sert à présenter une liste fournie et des activités réparties sur plusieurs jours. Les lieux et informations pratiques ajoutés sont fictifs ; les champs non renseignés sont signalés dans l'interface.

Le frontend du sujet évoque des guides créés par les utilisateurs, alors que les règles backend réservent la création aux admins. L'interprétation retenue pour la suite est : les admins gèrent les guides ; les utilisateurs consultent uniquement les guides auxquels ils sont invités. Cette restriction reste à implémenter.

Une seule valeur de mobilité, de saison et de public est stockée par guide dans cette version.

## Prochaines étapes

1. Modéliser les invitations et appliquer les permissions dans l'API, sur la liste comme sur le détail.
2. Ajouter la connexion dans Blazor et transmettre le jeton lors des appels.
3. Compléter les opérations administrateur et leur validation.
4. Ajouter des tests des accès autorisés/interdits, puis la recherche et la pagination.
