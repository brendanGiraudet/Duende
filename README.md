# Ce que fait ce `README.md` :

- **Caractéristiques** : Décrit ce que fait le microservice `application-recip`.
- **Prérequis** : Énumère les outils nécessaires pour construire et exécuter le service.
- **Installation** : Fournit des instructions pour cloner le dépôt et accéder au répertoire.
- **Configuration** : Explique comment est configué l'application.
- **Construire et Exécuter le Microservice** : Explique comment construire et exécuter le service localement et via Docker.
- **Utilisation** : Explique comment utiliser l'applicaton.
- **Contribuer** : Encouragement à contribuer au projet.
- **License** : Décrit la licence sous laquelle le projet est distribué.

## Caractéristiques
`application-crecip` est un microservice basé sur .NET 8, FLuxor et Radzen qui sert de front pour gérer les recettes dans une architecture orientée événements (Event-Driven Architecture).

- **Fluxor** : Fournit un pattern pour la gestion de la donnée basé sur des stores et des actions.
- **Radzen** : Fournisseur de composant de base blazor.
- **Containerisation** : Conteneurisé à l'aide de Docker pour un déploiement facile.

## Prérequis

- [.NET 8 SDK](https://dotnet.microsoft.com/download/dotnet/8.0)
- [Docker](https://www.docker.com/get-started)

## Installation

Clonez ce dépôt et accédez au répertoire du projet :

```bash
git clone https://github.com/brendanGiraudet/application-recip.git
cd application-recip
```

## Configuration
Configurer les variables d'environnement afin d'utiliser les bons ms dans le bon environnement

Construire et Exécuter le Microservice

1. Construire le Projet
Assurez-vous que vous avez le .NET 8 SDK installé, puis construisez le projet :

```bash
Copier le code
dotnet build
```

2. Exécuter le Projet Localement
Exécutez le microservice localement pour le tester :

```bash
Copier le code
dotnet run
```

Le microservice sera disponible à l'adresse http://localhost:5000 (port specifié dans le fichier appsettings).

3. Utiliser Docker
Construire l'Image Docker et/ou l'éxécuter
Pour construire l'image Docker du microservice, utilisez la commande suivante :

```bash
Copier le code
docker compose -f .\docker-compose-debug.yml up
```

Le service sera disponible à http://localhost:1919 (port specifié dans le fichier docker-compose-debug).

## Utilisation

# Creer une recette
La page /recips/add permet de fournir le formulaire pour la création d'une recette
La page /recips/id permet de fournir le formulaire pour la mise à jour d'une recette

## Contribuer
Les contributions sont les bienvenues ! Veuillez soumettre une issue ou une pull request pour toute amélioration ou problème.

## License
Aucune licence