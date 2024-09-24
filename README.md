# Ce que fait ce `README.md` :

- **Caract�ristiques** : D�crit ce que fait le microservice `application-recip`.
- **Pr�requis** : �num�re les outils n�cessaires pour construire et ex�cuter le service.
- **Installation** : Fournit des instructions pour cloner le d�p�t et acc�der au r�pertoire.
- **Configuration** : Explique comment est configu� l'application.
- **Construire et Ex�cuter le Microservice** : Explique comment construire et ex�cuter le service localement et via Docker.
- **Utilisation** : Explique comment utiliser l'applicaton.
- **Contribuer** : Encouragement � contribuer au projet.
- **License** : D�crit la licence sous laquelle le projet est distribu�.

## Caract�ristiques
`application-crecip` est un microservice bas� sur .NET 8, FLuxor et Radzen qui sert de front pour g�rer les recettes dans une architecture orient�e �v�nements (Event-Driven Architecture).

- **Fluxor** : Fournit un pattern pour la gestion de la donn�e bas� sur des stores et des actions.
- **Radzen** : Fournisseur de composant de base blazor.
- **Containerisation** : Conteneuris� � l'aide de Docker pour un d�ploiement facile.

## Pr�requis

- [.NET 8 SDK](https://dotnet.microsoft.com/download/dotnet/8.0)
- [Docker](https://www.docker.com/get-started)

## Installation

Clonez ce d�p�t et acc�dez au r�pertoire du projet :

```bash
git clone https://github.com/brendanGiraudet/application-recip.git
cd application-recip
```

## Configuration
Configurer les variables d'environnement afin d'utiliser les bons ms dans le bon environnement

Construire et Ex�cuter le Microservice

1. Construire le Projet
Assurez-vous que vous avez le .NET 8 SDK install�, puis construisez le projet :

```bash
Copier le code
dotnet build
```

2. Ex�cuter le Projet Localement
Ex�cutez le microservice localement pour le tester :

```bash
Copier le code
dotnet run
```

Le microservice sera disponible � l'adresse http://localhost:5000 (port specifi� dans le fichier appsettings).

3. Utiliser Docker
Construire l'Image Docker et/ou l'�x�cuter
Pour construire l'image Docker du microservice, utilisez la commande suivante :

```bash
Copier le code
docker compose -f .\docker-compose-debug.yml up
```

Le service sera disponible � http://localhost:1919 (port specifi� dans le fichier docker-compose-debug).

## Utilisation

# Creer une recette
La page /recips/add permet de fournir le formulaire pour la cr�ation d'une recette
La page /recips/id permet de fournir le formulaire pour la mise � jour d'une recette

## Contribuer
Les contributions sont les bienvenues ! Veuillez soumettre une issue ou une pull request pour toute am�lioration ou probl�me.

## License
Aucune licence